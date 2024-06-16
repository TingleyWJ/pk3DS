using System;
using System.IO;
using System.Linq;
using pk3DS.Core.CTR;
using pk3DS.Core.Structures.PersonalInfo;
using pk3DS.Core.Structures;
using System.Collections.Generic;

namespace pk3DS.Core
{
    public class GameConfig
    {
        private const int FILECOUNT_XY = 271;
        private const int FILECOUNT_ORASDEMO = 301;
        private const int FILECOUNT_ORAS = 299;
        private const int FILECOUNT_SMDEMO = 239;
        private const int FILECOUNT_SM = 311;
        private const int FILECOUNT_USUM = 333;
        public readonly GameVersion Version = GameVersion.Invalid;

        public GARCReference[] Files { get; private set; }
        public TextVariableCode[] Variables { get; private set; }
        public TextReference[] GameText { get; private set; }
        public GameInfo Info { get; private set; }
        public int model_pointer_data_Length = 0x0;

        /// <summary>
        /// Whether or not to remap characters in text files to proper unicode. Defaults to false.
        /// </summary>
        /// <remarks>
        /// This will enable the display of ♂ and ♀, but may interfere with text editing. Set this to true if you're not going to change any text, otherwise set it to false.
        /// </remarks>
        public bool RemapCharacters { get; set; } = false;

        public GameConfig(int fileCount)
        {
            GameVersion game = GameVersion.Invalid;
            switch (fileCount)
            {
                case FILECOUNT_XY:
                    game = GameVersion.XY;
                    break;
                case FILECOUNT_ORASDEMO:
                    game = GameVersion.ORASDEMO;
                    break;
                case FILECOUNT_ORAS:
                    game = GameVersion.ORAS;
                    break;
                case FILECOUNT_SMDEMO:
                    game = GameVersion.SMDEMO;
                    break;
                case FILECOUNT_SM:
                    game = GameVersion.SM;
                    break;
                case FILECOUNT_USUM:
                    game = GameVersion.USUM;
                    break;
            }
            if (game == GameVersion.Invalid)
                return;

            Version = game;
        }

        public GameConfig(GameVersion game)
        {
            Version = game;
        }

        private void GetGameData(GameVersion game)
        {
            switch (game)
            {
                case GameVersion.XY:
                    Files = GARCReference.GARCReference_XY;
                    Variables = TextVariableCode.VariableCodes_XY;
                    GameText = TextReference.GameText_XY;
                    //set model pointer data length automatically
                    model_pointer_data_Length = 0xB48;
                    break;

                case GameVersion.ORASDEMO:
                case GameVersion.ORAS:
                    Files = GARCReference.GARCReference_AO;
                    Variables = TextVariableCode.VariableCodes_AO;
                    GameText = TextReference.GameText_AO;
                    //same for ORAS
                    model_pointer_data_Length = 0xB48;
                    break;

                case GameVersion.SMDEMO:
                    Files = GARCReference.GARCReference_SMDEMO;
                    Variables = TextVariableCode.VariableCodes_SM;
                    GameText = TextReference.GameText_SMDEMO;
                    break;
                case GameVersion.SN:
                case GameVersion.MN:
                case GameVersion.SM:
                    Files = GARCReference.GARCReference_SN;
                    if (new FileInfo(Path.Combine(RomFS, GetGARCFileName("encdata"))).Length == 0)
                        Files = GARCReference.GARCReference_MN;
                    Variables = TextVariableCode.VariableCodes_SM;
                    GameText = TextReference.GameText_SM;
                    break;
                case GameVersion.US:
                case GameVersion.UM:
                case GameVersion.USUM:
                    Files = GARCReference.GARCReference_US;
                    if (new FileInfo(Path.Combine(RomFS, GetGARCFileName("encdata"))).Length == 0)
                        Files = GARCReference.GARCReference_UM;
                    Variables = TextVariableCode.VariableCodes_SM;
                    GameText = TextReference.GameText_USUM;
                    //USUM different than SM because new Pokemon, not just new Formes
                    model_pointer_data_Length = 0xCA0;
                    break;
            }
        }

        public void Initialize(string romFSpath, string exeFSpath, int lang)
        {
            RomFS = romFSpath;
            ExeFS = exeFSpath;
            Language = lang;
            GetGameData(Version);
            InitializeAll();
        }

        public void InitializeAll()
        {
            InitializePersonal();
            InitializeLearnset();
            InitializeGameText();
            InitializeMoves();
            InitializeEvos();
            InitializeGameInfo();

            //initialize array to stick read index numbers in
            string[] new_model_base_forme_indices_text = Array.Empty<string>();
            int[] new_model_base_forme_indices = Array.Empty<int>();

            //text file names "changed_indices.txt" in the same directory as the built .exe
            var base_indices_path = Path.Combine(Directory.GetCurrentDirectory(), "changed_indices.txt");

            //to skip everything below if file not found or file empty
            bool no_indices = false;
            
            //checks if file with list of indices exists
            /*if (File.Exists(base_indices_path))
            {
                //try to read the file
                try
                {
                    //grabs each line as a string (so put each index you want to change on a different line)
                    new_model_base_forme_indices_text = File.ReadAllLines(base_indices_path);
                }
                catch
                {
                    no_indices = true;
                }
            }

            if (!no_indices)
            {
                //Convert strings read from file into integers
                new_model_base_forme_indices = Array.ConvertAll(new_model_base_forme_indices_text, int.Parse);

                //Do the edits for each index number. This implementation is MUCH less computation-efficient than doing loops inside EditModelMasterTable,
                //but it's not a lot and I don't understand what it's doing well enough to willingly much around with it.
                foreach (var item in new_model_base_forme_indices)
                {
                    EditModelMasterTable(item);
                }
            }*/
        }

        public void EditModelMasterTable(int pokemonIndex)
        {
            GARCFile ModelFile = GetGARCData("models");
            byte[] MasterTable = ModelFile.Files[0];


            byte[] LimitedMT = new byte[model_pointer_data_Length];
            Array.Copy(MasterTable, 0, LimitedMT, 0, model_pointer_data_Length);
            //Console.WriteLine($"{BitConverter.ToString(MasterTable)}");
            int size = 0x4;
            byte[][] splitTable = PersonalTable.SplitBytes(LimitedMT, size);

            /*for (int i = 0; i < splitTable.Length; i++)
            {
                Console.WriteLine($"Model[{i}]: {BitConverter.ToString(splitTable[i])}");
            }*/

            //edit pokemon's counts
            int modelIndex = -1;
            //form count, just do a plus-equal, for now just run Pokemon with more than 1 forme added through a second time. This avoids one set of accidental problems by substituting another (over-adding)
            splitTable[pokemonIndex - 1][2] += 0x1;
            //identifier, 0x1 = no extra forms, 0x3 = gender forms, 0x5 = non-gender forms, 0x7 = both gender and non-gender forms
            //If splitTable[pokemonIndex - 1][3] is at least 0x5, it is already where we want, so don't modify. Otherwise it is 0x1 or 0x3, and we want to add 0x4 to get to 0x5 or 0x7, respectively.
            if (splitTable[pokemonIndex - 1][3] < 0x5)
            {
                splitTable[pokemonIndex - 1][3] += 0x04;
            }

            int modelCount = 0;
            for (int i = 0; i < splitTable.Length; i++)
            {
                if (i == pokemonIndex - 1)
                {
                    modelIndex = modelCount;
                }
                splitTable[i][0] = (byte)modelCount;
                splitTable[i][1] = (byte)(modelCount >> 8);
                modelCount += splitTable[i][2];
            }

            /*for (int i = 0; i < splitTable.Length; i++)
            {
                Console.WriteLine($"Model[{i}]: {BitConverter.ToString(splitTable[i])}");
            }*/

            LimitedMT = splitTable.SelectMany(x => x).ToArray();
            Array.Copy(LimitedMT, 0, MasterTable, 0, model_pointer_data_Length);

            //Console.WriteLine($"modelcount: {modelCount}, mc * 2 - 2: {modelCount * 2 - 2}");
            byte[] backhalfMT = new byte[modelCount * 2 - 2];
            Array.Copy(MasterTable, model_pointer_data_Length, backhalfMT, 0, modelCount * 2 - 2);
            //int backSize = 0x2;
            //byte[][] splitBack = PersonalTable.SplitBytes(backhalfMT, backSize);

            byte[] rewriteBackMT = new byte[modelCount * 2];
            for (int i = 0, j = 0; i < modelCount * 2; i += 2, j += 2)
            {
                if (i / 2 == modelIndex)
                {
                    //this first byte would be 0x1 if its a female model
                    //this doesn't apply here because we're only adding 2 bytes for megas and they're just set as 00 00
                    //if you want to find the 2 bytes, use B48 + (2 * modelCount) at the index of your pokemon
                    rewriteBackMT[i] = 0x0;
                    rewriteBackMT[i + 1] = 0x0;
                    j -= 2;
                }
                else
                {
                    rewriteBackMT[i] = backhalfMT[j];
                    rewriteBackMT[i + 1] = backhalfMT[j + 1];
                }
            }
            //Console.WriteLine($"First: {BitConverter.ToString(backhalfMT)}");
            //Console.WriteLine($"Rewrt: {BitConverter.ToString(rewriteBackMT)}");

            Array.Resize(ref MasterTable, model_pointer_data_Length + modelCount * 2);
            Array.Copy(rewriteBackMT, 0, MasterTable, model_pointer_data_Length, modelCount * 2);

            //Console.WriteLine($"Full Table: {BitConverter.ToString(MasterTable)}");

            byte[][] modelReplace = ModelFile.Files;
            modelReplace[0] = MasterTable;
            ModelFile.Files = modelReplace;

            //Console.WriteLine($"Full Table Again: {BitConverter.ToString(ModelFile.Files[0])}");
            ModelFile.Save();
        }

        public void InitializePersonal()
        {
            GARCPersonal = GetGARCData("personal");
            Personal = new PersonalTable(GARCPersonal.GetFile(GARCPersonal.FileCount - 1), Version);
        }

        public void InitializeLearnset()
        {
            GARCLearnsets = GetGARCData("levelup");
            switch (Generation)
            {
                case 6:
                    Learnsets = GARCLearnsets.Files.Select(file => new Learnset6(file)).ToArray();
                    break;
                case 7:
                    Learnsets = GARCLearnsets.Files.Select(file => new Learnset6(file)).ToArray();
                    break;
            }
        }

        public void InitializeGameText()
        {
            GARCGameText = GetGARCData("gametext");
            GameTextStrings = GARCGameText.Files.Select(file => new TextFile(this, file, RemapCharacters).Lines).ToArray();
        }

        public void InitializeMoves()
        {
            GARCMoves = GetGARCData("move");
            switch (Generation)
            {
                case 6:
                    if (XY)
                        Moves = GARCMoves.Files.Select(file => new Move6(file)).ToArray();
                    if (ORAS)
                        Moves = Mini.UnpackMini(GARCMoves.GetFile(0), "WD").Select(file => new Move6(file)).ToArray();
                    break;
                case 7:
                    Moves = Mini.UnpackMini(GARCMoves.GetFile(0), "WD").Select(file => new Move7(file)).ToArray();
                    break;
            }
        }
        public void InitializeEvos()
        {
            var g = GetGARCData("evolution");
            byte[][] d = g.Files;
            switch (Generation)
            {
                case 6:
                    Evolutions = d.Select(z => new EvolutionSet6(z)).ToArray();
                    break;
                case 7:
                    Evolutions = d.Select(z => new EvolutionSet7(z)).ToArray();
                    break;
            }
        }

        private void InitializeGameInfo()
        {
            Info = new GameInfo(this);
        }

        public LazyGARCFile GetlzGARCData(string file)
        {
            var gr = GetGARCReference(file);
            gr = gr.LanguageVariant ? gr.GetRelativeGARC(Language, gr.Name) : gr;
            return new LazyGARCFile(GetlzGARC(file), gr, GetGARCPath(file));
        }

        public GARCFile GetGARCData(string file, bool skipRelative = false)
        {
            var gr = GetGARCReference(file);
            if (gr.LanguageVariant && !skipRelative)
                gr = gr.GetRelativeGARC(Language, gr.Name);
            return GetGARCByReference(gr);
        }

        public GARCFile GetGARCByReference(GARCReference gr)
        {
            try
            {
                return new(GetMemGARC(gr.Name), gr, GetGARCPath(gr.Name));
            }
            catch (FormatException f)
            {
                var message = $"{gr.Name} - ({gr.Reference}) is apparently corrupt. Please restore the backup for this file." + f.Message;
                throw new FormatException(message, f);
            }
        }

        private string GetGARCPath(string file)
        {
            var gr = GetGARCReference(file);
            gr = gr.LanguageVariant ? gr.GetRelativeGARC(Language, gr.Name) : gr;
            string subloc = gr.Reference;
            return Path.Combine(RomFS, subloc);
        }

        private GARC.MemGARC GetMemGARC(string file)
        {
            return new(File.ReadAllBytes(GetGARCPath(file)));
        }

        private GARC.LazyGARC GetlzGARC(string file)
        {
            return new(File.ReadAllBytes(GetGARCPath(file)));
        }

        public string RomFS, ExeFS;

        public GARCReference GetGARCReference(string name) { return Files?.FirstOrDefault(f => f.Name == name); }
        public TextVariableCode GetVariableCode(string name) { return Variables?.FirstOrDefault(v => v.Name == name); }
        public TextVariableCode GetVariableName(int value) { return Variables?.FirstOrDefault(v => v.Code == value); }

        private TextReference GetGameText(TextName name) { return GameText?.FirstOrDefault(f => f.Name == name); }
        public TextData GetTextData(TextName file) => new(GetText(file));

        public string[] GetText(TextName file)
        {
            return (string[])GameTextStrings[GetGameText(file).Index].Clone();
        }

        public bool SetText(TextName file, string[] strings)
        {
            GameTextStrings[GetGameText(file).Index] = strings;
            return true;
        }

        public string GetGARCFileName(string requestedGARC)
        {
            var garc = GetGARCReference(requestedGARC);
            if (garc.LanguageVariant)
                garc = garc.GetRelativeGARC(Language);

            return garc.Reference;
        }

        public int Language { get; set; }

        public GARCFile GARCPersonal, GARCLearnsets, GARCMoves, GARCGameText;
        public PersonalTable Personal { get; private set; }
        public Learnset[] Learnsets { get; private set; }
        public string[][] GameTextStrings { get; private set; }
        public Move[] Moves { get; private set; }
        public EvolutionSet[] Evolutions { get; private set; }

        public bool XY => Version == GameVersion.XY;
        public bool ORAS => Version == GameVersion.ORAS || Version == GameVersion.ORASDEMO;
        public bool SM => Version == GameVersion.SM || Version == GameVersion.SMDEMO;
        public bool USUM => Version == GameVersion.USUM;
        public int MaxSpeciesID => XY || ORAS ? Legal.MaxSpeciesID_6 : SM ? Legal.MaxSpeciesID_7_SM : Legal.MaxSpeciesID_7_USUM;
        public int GARCVersion => XY || ORAS ? GARC.VER_4 : GARC.VER_6;

        public int Generation
        {
            get
            {
                if (XY || ORAS)
                    return 6;
                if (SM || USUM)
                    return 7;
                return -1;
            }
        }

        public bool IsRebuildable(int fileCount)
        {
            return fileCount switch
            {
                FILECOUNT_XY => Version == GameVersion.XY,
                FILECOUNT_ORAS => Version == GameVersion.ORAS,
                FILECOUNT_ORASDEMO => Version == GameVersion.ORASDEMO,
                FILECOUNT_SMDEMO => Version == GameVersion.SMDEMO,
                FILECOUNT_SM => Version == GameVersion.SM,
                FILECOUNT_USUM => Version == GameVersion.USUM,
                _ => false
            };
        }
    }
}
