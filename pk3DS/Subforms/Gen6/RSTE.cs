using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using pk3DS.Core;
using pk3DS.Core.Randomizers;
using pk3DS.Core.Structures;
using pk3DS.Core.Structures.AXExports;
using pk3DS.Core.Structures.Gen6;
using pk3DS.Subforms.Gen6;

namespace pk3DS
{
    public partial class RSTE : Form
    {
        private readonly LearnsetRandomizer learn = new(Main.Config, Main.Config.Learnsets);

        public RSTE(byte[][] trd, byte[][] trp)
        {
            //trclass = trc;
            trdata = trd;
            trpoke = trp;
            Array.Resize(ref specieslist, Main.Config.MaxSpeciesID + 1);
            MegaDictionary = GiftEditor6.GetMegaDictionary(Main.Config);
            rModelRestricted = Main.Config.ORAS ? Legal.Model_AO : Legal.Model_XY;
            rFinalEvo = Legal.FinalEvolutions_6;

            InitializeComponent();
            // String Fetching
            #region Combo Box Arrays
            trpk_pkm = new[] { CB_Pokemon_1_Pokemon, CB_Pokemon_2_Pokemon, CB_Pokemon_3_Pokemon, CB_Pokemon_4_Pokemon, CB_Pokemon_5_Pokemon, CB_Pokemon_6_Pokemon, };
            trpk_lvl = new[] { CB_Pokemon_1_Level, CB_Pokemon_2_Level, CB_Pokemon_3_Level, CB_Pokemon_4_Level, CB_Pokemon_5_Level, CB_Pokemon_6_Level, };
            trpk_item = new[] { CB_Pokemon_1_Item, CB_Pokemon_2_Item, CB_Pokemon_3_Item, CB_Pokemon_4_Item, CB_Pokemon_5_Item, CB_Pokemon_6_Item, };
            trpk_abil = new[] { CB_Pokemon_1_Ability, CB_Pokemon_2_Ability, CB_Pokemon_3_Ability, CB_Pokemon_4_Ability, CB_Pokemon_5_Ability, CB_Pokemon_6_Ability, };
            trpk_m1 = new[] { CB_Pokemon_1_Move_1, CB_Pokemon_2_Move_1, CB_Pokemon_3_Move_1, CB_Pokemon_4_Move_1, CB_Pokemon_5_Move_1, CB_Pokemon_6_Move_1, };
            trpk_m2 = new[] { CB_Pokemon_1_Move_2, CB_Pokemon_2_Move_2, CB_Pokemon_3_Move_2, CB_Pokemon_4_Move_2, CB_Pokemon_5_Move_2, CB_Pokemon_6_Move_2, };
            trpk_m3 = new[] { CB_Pokemon_1_Move_3, CB_Pokemon_2_Move_3, CB_Pokemon_3_Move_3, CB_Pokemon_4_Move_3, CB_Pokemon_5_Move_3, CB_Pokemon_6_Move_3, };
            trpk_m4 = new[] { CB_Pokemon_1_Move_4, CB_Pokemon_2_Move_4, CB_Pokemon_3_Move_4, CB_Pokemon_4_Move_4, CB_Pokemon_5_Move_4, CB_Pokemon_6_Move_4, };
            trpk_IV = new[] { CB_Pokemon_1_IVs, CB_Pokemon_2_IVs, CB_Pokemon_3_IVs, CB_Pokemon_4_IVs, CB_Pokemon_5_IVs, CB_Pokemon_6_IVs, };
            trpk_form = new[] { CB_Pokemon_1_Form, CB_Pokemon_2_Form, CB_Pokemon_3_Form, CB_Pokemon_4_Form, CB_Pokemon_5_Form, CB_Pokemon_6_Form, };
            trpk_gender = new[] { CB_Pokemon_1_Gender, CB_Pokemon_2_Gender, CB_Pokemon_3_Gender, CB_Pokemon_4_Gender, CB_Pokemon_5_Gender, CB_Pokemon_6_Gender, };
            trpk_nature = new[] { TB_Pokemon_1_Nature, TB_Pokemon_2_Nature, TB_Pokemon_3_Nature, TB_Pokemon_4_Nature, TB_Pokemon_5_Nature, TB_Pokemon_6_Nature };
            #endregion
            string[] species = Main.Config.GetText(TextName.SpeciesNames);
            AltForms = Main.Config.Personal.GetFormList(species, Main.Config.MaxSpeciesID);
            Setup();
        }

        private readonly string[][] AltForms;
        internal static uint Rand() => Util.Random32();
        private bool start = true;
        private bool loading = true;
        private int index = -1;
        #region Global Variables
        private readonly ComboBox[] trpk_pkm;
        private readonly ComboBox[] trpk_lvl;
        private readonly ComboBox[] trpk_item;
        private readonly ComboBox[] trpk_abil;
        private readonly ComboBox[] trpk_m1, trpk_m2, trpk_m3, trpk_m4;
        private readonly ComboBox[] trpk_IV;
        private readonly ComboBox[] trpk_form;
        private readonly ComboBox[] trpk_gender;
        private readonly TextBox[] trpk_nature;

        private PictureBox[] pba;

        // Top Level Functions
        //private readonly byte[][] trclass;
        private readonly byte[][] trdata;
        private readonly byte[][] trpoke;
        private readonly string[] abilitylist = Main.Config.GetText(TextName.AbilityNames);
        private readonly string[] movelist = Main.Config.GetText(TextName.MoveNames);
        private readonly string[] itemlist = Main.Config.GetText(TextName.ItemNames);
        private readonly string[] specieslist = Main.Config.GetText(TextName.SpeciesNames);
        private readonly string[] types = Main.Config.GetText(TextName.Types);
        //private readonly string[] forms = Main.Config.GetText(TextName.Forms);
        private string[] trName = Main.Config.GetText(TextName.TrainerNames);
        private readonly string[] trClass = Main.Config.GetText(TextName.TrainerClasses);
        //private readonly string[] trText = Main.Config.GetText(TextName.TrainerText);
        #endregion

        // Ability Loading
        private void RefreshFormAbility(object sender, EventArgs e)
        {
            int i = Array.IndexOf(trpk_form, sender as ComboBox);
            RefreshPKMSlotAbility(i);
        }

        private void RefreshSpeciesAbility(object sender, EventArgs e)
        {
            int i = Array.IndexOf(trpk_pkm, sender as ComboBox);
            FormUtil.SetForms(trpk_pkm[i].SelectedIndex, trpk_form[i], AltForms);
            RefreshPKMSlotAbility(i);

            CalculateNature(sender, e);
        }

        private void RefreshPKMSlotAbility(int slot)
        {
            int previousAbility = trpk_abil[slot].SelectedIndex;

            int species = trpk_pkm[slot].SelectedIndex;
            int formnum = trpk_form[slot].SelectedIndex;

            int entry = Main.Config.Personal.GetFormIndex(species, formnum);

            trpk_abil[slot].Items.Clear();
            trpk_abil[slot].Items.Add("Any (1 or 2)");
            trpk_abil[slot].Items.Add(abilitylist[Main.SpeciesStat[entry].Abilities[0]] + " (1)");
            trpk_abil[slot].Items.Add(abilitylist[Main.SpeciesStat[entry].Abilities[1]] + " (2)");
            trpk_abil[slot].Items.Add(abilitylist[Main.SpeciesStat[entry].Abilities[2]] + " (H)");

            trpk_abil[slot].SelectedIndex = previousAbility;

            ShowTeams(slot);
        }
        // Set Loading
        private void ChangeTrainerType(object sender, EventArgs e)
        {
            if (start || loading) return;
            int pkm = CB_numPokemon.SelectedIndex;
            {
                for (int i = 0; i < 6; i++) // enable all if the pkm exists
                {
                    trpk_pkm[i].Enabled =
                    trpk_gender[i].Enabled =
                    trpk_abil[i].Enabled =
                    trpk_IV[i].Enabled =
                    trpk_lvl[i].Enabled = i < pkm;

                    trpk_item[i].Enabled = i < pkm && checkBox_Item.Checked;

                    trpk_m1[i].Enabled =
                    trpk_m2[i].Enabled =
                    trpk_m3[i].Enabled =
                    trpk_m4[i].Enabled = i < pkm && checkBox_Moves.Checked;

                    if (!trpk_pkm[i].Enabled)
                    {
                        trpk_pkm[i].SelectedIndex =
                        trpk_gender[i].SelectedIndex =
                        trpk_form[i].SelectedIndex =
                        trpk_abil[i].SelectedIndex =
                        trpk_lvl[i].SelectedIndex = 0;

                        trpk_IV[i].SelectedIndex = 31;
                    }
                    if (!trpk_item[i].Enabled)
                    {
                        trpk_item[i].SelectedIndex = 0;
                    }
                    if (!trpk_m1[i].Enabled)
                    {
                        trpk_m1[i].SelectedIndex =
                        trpk_m2[i].SelectedIndex =
                        trpk_m3[i].SelectedIndex =
                        trpk_m4[i].SelectedIndex = 0;
                    }
                }
                for (int i = pkm; i < 6; i++)
                    trpk_form[i].Enabled = false;
            }
        }

        // Dumping
        private string GetTRSummary()
        {
            string toret = "======" + Environment.NewLine;

            toret += CB_TrainerID.SelectedIndex + " - " + CB_Trainer_Class.Text.Substring(0, CB_Trainer_Class.Text.Length - 6) + " " + CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6) + Environment.NewLine;
            toret += "======" + Environment.NewLine;
            int pkm = CB_numPokemon.SelectedIndex;
            toret += "Pokemon: " + pkm + Environment.NewLine;
            for (int i = 0; i < pkm; i++)
            {
                toret += trpk_pkm[i].Text + " (Lv. " + trpk_lvl[i].SelectedIndex + ") ";
                if (trpk_item[i].SelectedIndex > 0)
                    toret += "@" + trpk_item[i].Text;
                if (trpk_abil[i].SelectedIndex != 0)
                {
                    string abil = trpk_abil[i].Text;
                    abil = abil.Substring(0, abil.Length - 4);
                    toret += " (Ability: " + abil + ")";
                }
                if (checkBox_Moves.Checked)
                {
                    toret += " (Moves: ";
                    if (trpk_m1[i].SelectedIndex > 0) toret += trpk_m1[i].Text;
                    if (trpk_m2[i].SelectedIndex > 0) toret += " / " + trpk_m2[i].Text;
                    if (trpk_m3[i].SelectedIndex > 0) toret += " / " + trpk_m3[i].Text;
                    if (trpk_m4[i].SelectedIndex > 0) toret += " / " + trpk_m4[i].Text;
                    toret += ")";
                }
                toret += " IVs: All " + (Convert.ToInt32(trpk_IV[i].SelectedIndex) / 8);
                toret += Environment.NewLine;
            }
            toret += Environment.NewLine;
            return toret;
        }

        private bool dumping;

        private void B_Dump_Click(object sender, EventArgs e)
        {
            string toret = ""; dumping = true;
            for (int i = 1; i < CB_TrainerID.Items.Count; i++)
            {
                CB_TrainerID.SelectedIndex = i;
                string tdata = GetTRSummary();
                toret += tdata;
            }
            SaveFileDialog sfd = new SaveFileDialog { FileName = "Battles.txt", Filter = "Text File|*.txt" };

            SystemSounds.Asterisk.Play();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                File.WriteAllText(path, toret, Encoding.Unicode);
            }
            dumping = false;
        }

        // Change Read/Write
        private TrainerData6 tr;

        private void ChangeTrainerIndex(object sender, EventArgs e)
        {
            if (!dumping && index > -1) WriteFile();
            ReadFile(); // Load the new file.
        }

        private void ReadFile()
        {
            if (start) return;
            index = CB_TrainerID.SelectedIndex;
            loading = true;

            if (index == 0) return;

            TabControl.Enabled = true;
            byte[] trd = trdata[index];
            byte[] trp = trpoke[index];
            tr = new TrainerData6(trd, trp, Main.Config.ORAS);

            // Load Trainer Data
            CB_Trainer_Class.SelectedIndex = tr.Class;
            checkBox_Item.Checked = tr.Item;
            checkBox_Moves.Checked = tr.Moves;
            CB_Battle_Type.SelectedIndex = tr.BattleType;
            CB_numPokemon.SelectedIndex = tr.NumPokemon;
            CB_Item_1.SelectedIndex = tr.Items[0];
            CB_Item_2.SelectedIndex = tr.Items[1];
            CB_Item_3.SelectedIndex = tr.Items[2];
            CB_Item_4.SelectedIndex = tr.Items[3];
            CB_AI.SelectedIndex = tr.AI;
            checkBox_Healer.Checked = tr.Healer;
            CB_Money.SelectedIndex = tr.Money;
            CB_Prize.SelectedIndex = tr.Prize;

            // Load Pokemon Data
            for (int i = 0; i < tr.NumPokemon; i++)
            {
                trpk_IV[i].SelectedIndex = tr.Team[i].IVs;
                trpk_lvl[i].SelectedIndex = tr.Team[i].Level;
                trpk_pkm[i].SelectedIndex = tr.Team[i].Species;
                FormUtil.SetForms(tr.Team[i].Species, trpk_form[i], AltForms);
                trpk_form[i].SelectedIndex = tr.Team[i].Form % trpk_form[i].Items.Count; // stupid X/Y buggy edge cases (220 / 222)
                RefreshPKMSlotAbility(i); // Repopulate Abilities

                trpk_abil[i].SelectedIndex = tr.Team[i].Ability;
                trpk_gender[i].SelectedIndex = tr.Team[i].Gender;

                trpk_item[i].SelectedIndex = tr.Team[i].Item;
                trpk_m1[i].SelectedIndex = tr.Team[i].Moves[0];
                trpk_m2[i].SelectedIndex = tr.Team[i].Moves[1];
                trpk_m3[i].SelectedIndex = tr.Team[i].Moves[2];
                trpk_m4[i].SelectedIndex = tr.Team[i].Moves[3];
            }
            loading = false;
            ChangeTrainerType(null, null); // Prompt cleaning update of PKM fields

            // Refresh Team View
            if (!loading)
            {
                for (int i = 0; i < 6; i++) ShowTeams(i);
                // showText(); // Commented out for now, have to figure out how text is assigned.
            }

            CalculateNature(CB_Trainer_Class, EventArgs.Empty);
            ReloadNatureMap(TabControl, EventArgs.Empty);
        }

        private void WriteFile()
        {
            // Set Trainer Data
            tr.Moves = checkBox_Moves.Checked;
            tr.Item = checkBox_Item.Checked;
            tr.Class = CB_Trainer_Class.SelectedIndex;
            tr.BattleType = (byte)CB_Battle_Type.SelectedIndex;
            tr.NumPokemon = (byte)CB_numPokemon.SelectedIndex;
            if (tr.NumPokemon == 0)
                tr.NumPokemon = 1; // No empty teams!
            tr.Items[0] = (ushort)CB_Item_1.SelectedIndex;
            tr.Items[1] = (ushort)CB_Item_2.SelectedIndex;
            tr.Items[2] = (ushort)CB_Item_3.SelectedIndex;
            tr.Items[3] = (ushort)CB_Item_4.SelectedIndex;
            tr.AI = (byte)CB_AI.SelectedIndex;
            tr.Healer = checkBox_Healer.Checked;
            tr.Money = (byte)CB_Money.SelectedIndex;
            tr.Prize = (ushort)CB_Prize.SelectedIndex;

            // Set Pokemon Data
            Array.Resize(ref tr.Team, tr.NumPokemon);
            for (int i = 0; i < tr.NumPokemon; i++)
            {
                tr.Team[i] ??= new TrainerData6.Pokemon(new byte[100], false, false);
                tr.Team[i].IVs = (byte)trpk_IV[i].SelectedIndex;
                tr.Team[i].Ability = trpk_abil[i].SelectedIndex;
                tr.Team[i].Gender = trpk_gender[i].SelectedIndex;
                tr.Team[i].Level = (ushort)trpk_lvl[i].SelectedIndex;
                tr.Team[i].Species = (ushort)trpk_pkm[i].SelectedIndex;
                tr.Team[i].Form = (ushort)trpk_form[i].SelectedIndex;
                tr.Team[i].Item = (ushort)trpk_item[i].SelectedIndex;

                tr.Team[i].Moves[0] = (ushort)trpk_m1[i].SelectedIndex;
                tr.Team[i].Moves[1] = (ushort)trpk_m2[i].SelectedIndex;
                tr.Team[i].Moves[2] = (ushort)trpk_m3[i].SelectedIndex;
                tr.Team[i].Moves[3] = (ushort)trpk_m4[i].SelectedIndex;
            }
            trdata[index] = tr.Write();
            trpoke[index] = tr.WriteTeam();
        }

        // Image Displays
        private void ChangeTeam(object sender, EventArgs e)
        {
            if (loading) return;

            int gendSlot = Array.IndexOf(trpk_gender, sender as ComboBox);
            int itemSlot = Array.IndexOf(trpk_item, sender as ComboBox);
            ShowTeams(gendSlot < 0 ? itemSlot : gendSlot);
        }

        private void ShowTeams(int i)
        {
            if (tr == null) return;
            if (i >= tr.Team.Length) { pba[i].Image = null; return; }
            Bitmap rawImg = WinFormsUtil.GetSprite(trpk_pkm[i].SelectedIndex, trpk_form[i].SelectedIndex, trpk_gender[i].SelectedIndex, trpk_item[i].SelectedIndex, Main.Config);
            pba[i].Image = WinFormsUtil.ScaleImage(rawImg, 2);
        }

        private void Setup()
        {
            start = true;

            Array.Resize(ref trName, trdata.Length);
            CB_TrainerID.Items.Clear();
            for (int i = 0; i < trdata.Length; i++)
                CB_TrainerID.Items.Add($"{trName[i] ?? "UNKNOWN"} - {i:000}");

            CB_Trainer_Class.Items.Clear();
            for (int i = 0; i < trClass.Length; i++)
                CB_Trainer_Class.Items.Add($"{trClass[i]} - {i:000}");

            specieslist[0] = "---";
            abilitylist[0] = itemlist[0] = movelist[0] = "";
            pba = new[] { PB_Team1, PB_Team2, PB_Team3, PB_Team4, PB_Team5, PB_Team6 };

            for (int i = 0; i < 6; i++)
            {
                trpk_pkm[i].Items.Clear();
                foreach (string s in specieslist)
                    trpk_pkm[i].Items.Add(s);

                trpk_m1[i].Items.Clear();
                trpk_m2[i].Items.Clear();
                trpk_m3[i].Items.Clear();
                trpk_m4[i].Items.Clear();
                foreach (string s in movelist)
                {
                    trpk_m1[i].Items.Add(s);
                    trpk_m2[i].Items.Add(s);
                    trpk_m3[i].Items.Add(s);
                    trpk_m4[i].Items.Add(s);
                }

                trpk_item[i].Items.Clear();
                foreach (string s in itemlist)
                    trpk_item[i].Items.Add(s);

                trpk_lvl[i].Items.Clear();
                for (int z = 0; z <= 100; z++)
                    trpk_lvl[i].Items.Add(z.ToString());

                trpk_IV[i].Items.Clear();
                for (int z = 0; z < 256; z++)
                    trpk_IV[i].Items.Add(z.ToString());

                trpk_gender[i].Items.Clear();
                trpk_gender[i].Items.Add("- / Genderless/Random");
                trpk_gender[i].Items.Add("♂ / Male");
                trpk_gender[i].Items.Add("♀ / Female");

                trpk_form[i].Items.Add("");

                trpk_pkm[i].SelectedIndex = 0;
            }
            CB_Item_1.Items.Clear();
            CB_Item_2.Items.Clear();
            CB_Item_3.Items.Clear();
            CB_Item_4.Items.Clear();
            CB_Prize.Items.Clear();
            foreach (string s in itemlist)
            {
                CB_Item_1.Items.Add(s);
                CB_Item_2.Items.Add(s);
                CB_Item_3.Items.Add(s);
                CB_Item_4.Items.Add(s);
                CB_Prize.Items.Add(s);
            }

            CB_AI.Items.Clear(); CB_Money.Items.Clear();
            for (int i = 0; i < 256; i++)
            { CB_AI.Items.Add(i.ToString()); CB_Money.Items.Add(i.ToString()); }

            CB_Battle_Type.Items.Clear();
            CB_Battle_Type.Items.Add("Single");
            CB_Battle_Type.Items.Add("Double");
            CB_Battle_Type.Items.Add("Triple");
            CB_Battle_Type.Items.Add("Rotation");
            if (Main.Config.ORAS) CB_Battle_Type.Items.Add("Horde");
            megaEvos = Main.Config.ORAS
                ? new[] { 15, 18, 80, 208, 254, 260, 302, 319, 323, 334, 362, 373, 376, 380, 381, 428, 475, 531, 719, 3, 6, 9, 65, 94, 115, 127, 130, 142, 150, 181, 212, 214, 229, 248, 257, 282, 303, 306, 308, 310, 354, 359, 445, 448, 460 }
                : new[] { 3, 6, 9, 65, 94, 115, 127, 130, 142, 150, 181, 212, 214, 229, 248, 257, 282, 303, 306, 308, 310, 354, 359, 445, 448, 460 };

            CB_TrainerID.SelectedIndex = 37; //Youngster Austin, for testing conveniency
            start = false;
            ReadFile();
        }

        public static bool rPKM, rSmart, rLevel, rMove, rMetronome, rNoMove, rForceHighPower, rAbility, rDiffAI,
            rDiffIV, rClass, rGift, rItem, rDoRand, rRandomMegas, rGymE4Only,
            rTypeTheme, rTypeGymTrainers, rOnlySingles, rDMG, rSTAB, r6PKM, rForceFullyEvolved;

        public static bool rNoFixedDamage;
        internal static bool[] rThemedClasses = Array.Empty<bool>();
        private static string[] rTags;
        private static int[] megaEvos;
        public static int[] rIgnoreClass, rEnsureMEvo;
        public static int rDMGCount, rSTABCount;
        private int[] mEvoTypes;
        private static int[] rModelRestricted;
        public static int[] rFinalEvo;
        private string[] rImportant;
        private readonly List<string> Tags = new();
        private readonly Dictionary<string, int> TagTypes = new();
        public static int[] sL; // Random Species List
        public static decimal rGiftPercent, rLevelMultiplier, rMinPKM, rMaxPKM, rForceFullyEvolvedLevel, rForceHighPowerLevel;

        private void B_Randomize_Click(object sender, EventArgs e)
        {
            rPKM = rMove = rMetronome = rAbility = rDiffAI = rDiffIV = rClass = rGift = rItem = rDoRand = false; // init to false
            rGiftPercent = 0;
            rForceFullyEvolvedLevel = 0;
            new TrainerRand().ShowDialog(); // Open Randomizer Config to get config vals
            if (rDoRand)
                Randomize();
        }

        private void Randomize()
        {
            List<int> banned = new List<int> { 165, 621 }; // Struggle, Hyperspace Fury
            if (rNoFixedDamage)
                banned.AddRange(MoveRandomizer.FixedDamageMoves);
            var move = new MoveRandomizer(Main.Config)
            {
                rDMG = rDMG,
                rSTAB = rSTAB,
                rSTABCount = rSTABCount,
                rDMGCount = rDMGCount,
                BannedMoves = banned,
            };

            rImportant = new string[CB_TrainerID.Items.Count];
            rTags = Main.Config.ORAS ? GetTagsORAS() : GetTagsXY();
            mEvoTypes = GetMegaEvolvableTypes();
            List<int> GymE4Types = new List<int>();

            // Fetch Move Stats for more difficult randomization

            if (rEnsureMEvo.Length > 0)
            {
                if (mEvoTypes.Length < 13 && rTypeTheme)
                {
                    WinFormsUtil.Alert("There are insufficient Types with at least one mega evolution to Guarantee story Mega Evos while keeping Type theming.",
                    "Re-Randomize Personal or don't choose both options."); return;
                }
                GymE4Types.AddRange(mEvoTypes);
            }
            else
            {
                GymE4Types.AddRange(Enumerable.Range(0, types.Length).ToArray());
            }

            foreach (int t1 in rEnsureMEvo.Where(t1 => rTags[t1].Length != 0 && !TagTypes.Keys.Contains(rTags[t1])))
            {
                int t;
                if (rTags[t1].Contains("GYM") || rTags[t1].Contains("ELITE") || rTags[t1].Contains("CHAMPION"))
                {
                    t = GymE4Types[(int)(Rand() % GymE4Types.Count)];
                    GymE4Types.Remove(t);
                }
                else
                {
                    t = mEvoTypes[Rand() % mEvoTypes.Length];
                }

                TagTypes[rTags[t1]] = t;
            }
            foreach (string t1 in Tags)
            {
                if (!TagTypes.Keys.Contains(t1) && t1.Length != 0)
                {
                    int t;
                    if (t1.Contains("GYM") || t1.Contains("ELITE") || t1.Contains("CHAMPION"))
                    {
                        t = GymE4Types[(int)(Rand() % GymE4Types.Count)];
                        GymE4Types.Remove(t);
                    }
                    else
                    {
                        t = (int)(Rand() % types.Length);
                    }

                    TagTypes[t1] = t;
                }
                Console.WriteLine(t1 + ": " + types[TagTypes[t1]]);
            }

            CB_TrainerID.SelectedIndex = 0; // fake a writeback
            ushort[] itemvals = Main.Config.ORAS ? Legal.Pouch_Items_AO : Legal.Pouch_Items_XY;
            itemvals = itemvals.Concat(Legal.Pouch_Berry_XY).ToArray();

            string[] ImportantClasses = { "GYM", "ELITE", "CHAMPION" };
            for (int i = 1; i < CB_TrainerID.Items.Count; i++)
            {
                // Trainer Type/Mega Evo
                int type = GetRandomType(i);
                bool mevo = rEnsureMEvo.Contains(i);
                bool isImportantClass = rImportant[i] != null && (rImportant[i].Contains("GYM") || rImportant[i].Contains("ELITE") || rImportant[i].Contains("CHAMPION"));
                bool typerand = (rTypeTheme && !rGymE4Only) || (rTypeTheme && isImportantClass);

                rSpeciesRand.rType = typerand;

                byte[] trd = trdata[i];
                byte[] trp = trpoke[i];
                var t = new TrainerData6(trd, trp, Main.Config.ORAS)
                {
                    Moves = rMove || (!rNoMove && checkBox_Moves.Checked),
                    Item = rItem || checkBox_Item.Checked
                };

                SetMinMaxPKM(t);
                SetFullParties(t, rImportant[i] == null);
                RandomizeTrainerAIClass(t, trClass);
                RandomizeTrainerPrizeItem(t);
                RandomizeTeam(t, move, learn, itemvals, type, mevo, typerand);

                trdata[i] = t.Write();
                trpoke[i] = t.WriteTeam();
            }
            CB_TrainerID.SelectedIndex = 1;
            WinFormsUtil.Alert("Randomized all Trainers according to specification!", "Press the Dump to .TXT button to view the new Trainer information!");
        }

        private static void RandomizeTeam(TrainerData6 t, MoveRandomizer move, LearnsetRandomizer learn, ushort[] itemvals, int type, bool mevo, bool typerand)
        {
            int last = t.Team.Length - 1;
            for (int p = 0; p < t.Team.Length; p++)
            {
                var pk = t.Team[p];
                int[] stones = null;
                if (rPKM)
                {
                    // randomize pokemon
                    int species;
                    if (typerand)
                    {
                        species = rSpeciesRand.GetRandomSpeciesType(pk.Species, type);
                        if (p == last && mevo)
                        {
                            int tries = 0;
                            do { stones = GetRandomMega(out species); }
                            while (Main.Config.Personal[species].Types.All(z => z != type) && tries++ < 100);
                        }
                    }
                    else if (p == last && mevo)
                    {
                        stones = GetRandomMega(out species);
                    }
                    else
                    {
                        species = rSpeciesRand.GetRandomSpecies(pk.Species);
                    }

                    pk.Species = (ushort)species;
                    pk.Gender = 0; // Set Gender to Random
                    bool mega = rRandomMegas && !(mevo && p == last); // except if mega evolution is forced for the last slot
                    pk.Form = (ushort)Randomizer.GetRandomForme(pk.Species, mega, true, Main.SpeciesStat);
                }
                if (rLevel)
                    pk.Level = (ushort)Randomizer.GetModifiedLevel(pk.Level, rLevelMultiplier);
                if (rAbility)
                    pk.Ability = (int)(1 + (Rand() % 3));
                if (rDiffIV)
                    pk.IVs = 255;

                if (mevo && p == last && stones != null)
                    pk.Item = (ushort)stones[Rand() % stones.Length];
                else if (rItem)
                    pk.Item = itemvals[Rand() % itemvals.Length];

                if (rForceFullyEvolved && pk.Level >= rForceFullyEvolvedLevel && !rFinalEvo.Contains(pk.Species))
                {
                    static int randFinalEvo() => (int)(Util.Random32() % rFinalEvo.Length);
                    pk.Species = (ushort)rFinalEvo[randFinalEvo()];
                    pk.Form = (ushort)Randomizer.GetRandomForme(pk.Species, rRandomMegas, true, Main.SpeciesStat);
                }

                // random
                if (rMove)
                {
                    var pkMoves = move.GetRandomMoveset(pk.Species, 4);
                    for (int m = 0; m < 4; m++)
                        pk.Moves[m] = (ushort)pkMoves[m];
                }

                // levelup
                if (rNoMove)
                {
                    t.Moves = true;
                    var pkMoves = learn.GetCurrentMoves(pk.Species, pk.Form, pk.Level, 4);
                    for (int m = 0; m < 4; m++)
                        pk.Moves[m] = (ushort)pkMoves[m];
                }

                if (rMetronome)
                {
                    t.Moves = true;
                    var pkMoves = new[] { 118, 0, 0, 0 };
                    for (int m = 0; m < 4; m++)
                        pk.Moves[m] = (ushort)pkMoves[m];
                }

                // high-power attacks
                if (rForceHighPower && pk.Level >= rForceHighPowerLevel)
                {
                    var pkMoves = learn.GetHighPoweredMoves(pk.Species, pk.Form, 4);
                    for (int m = 0; m < 4; m++)
                        pk.Moves[m] = (ushort)pkMoves[m];
                }
            }
        }

        private static void SetMinMaxPKM(TrainerData6 t)
        {
            int lastPKM = Math.Max(t.NumPokemon - 1, 0); // 0,1-6 => 0-5 (never is 0)
            var avgBST = (int)t.Team.Average(pk => Main.SpeciesStat[pk.Species].BST);
            int avgLevel = (int)t.Team.Average(pk => pk.Level);
            var pinfo = Main.SpeciesStat.OrderBy(pk => Math.Abs(avgBST - pk.BST)).First();
            int avgSpec = Array.IndexOf(Main.SpeciesStat, pinfo);

            // set minimum pkm, don't modify hordes
            if (t.NumPokemon < rMinPKM && t.BattleType != 4)
            {
                t.NumPokemon = (byte)rMinPKM;
                for (int f = lastPKM + 1; f < t.NumPokemon; f++)
                {
                    Array.Resize(ref t.Team, (int)rMinPKM);
                    t.Team[f] = // clone last pkm, keeping an average level for all new pkm
                        new TrainerData6.Pokemon(t.Team[lastPKM].Write(t.Item, t.Moves), t.Item, t.Moves)
                        {
                            Species = (ushort)rSpeciesRand.GetRandomSpecies(avgSpec),
                            Level = (ushort)avgLevel,
                        };
                }
            }

            // set maximum pkm, don't modify hordes
            if (t.NumPokemon > rMaxPKM && t.BattleType != 4)
            {
                Array.Resize(ref t.Team, (int)rMaxPKM);
                t.NumPokemon = (byte)rMaxPKM;
            }
        }

        private static void SetFullParties(TrainerData6 t, bool important)
        {
            int lastPKM = Math.Max(t.NumPokemon - 1, 0); // 0,1-6 => 0-5 (never is 0)
            var avgBST = (int)t.Team.Average(pk => Main.SpeciesStat[pk.Species].BST);
            int avgLevel = (int)t.Team.Average(pk => pk.Level);
            var pinfo = Main.SpeciesStat.OrderBy(pk => Math.Abs(avgBST - pk.BST)).First();
            int avgSpec = Array.IndexOf(Main.SpeciesStat, pinfo);

            // 6 pkm for important trainers, skip the first rival battles
            if (!r6PKM || important)
                return;

            t.NumPokemon = 6;
            for (int f = lastPKM + 1; f < t.NumPokemon; f++)
            {
                Array.Resize(ref t.Team, t.NumPokemon);
                t.Team[f] = // clone last pkm, keeping an average level for all new pkm
                    new TrainerData6.Pokemon(t.Team[lastPKM].Write(t.Item, t.Moves), t.Item, t.Moves)
                    {
                        Species = (ushort)rSpeciesRand.GetRandomSpecies(avgSpec),
                        Level = (ushort)avgLevel,
                    };
            }
        }

        private static void RandomizeTrainerAIClass(TrainerData6 t, string[] trClass)
        {
            if (rDiffAI)
                t.AI |= 7; // Set first 3 bits, keep any other flag if present

            if (rClass && rModelRestricted.Contains(t.Class) && !rIgnoreClass.Contains(t.Class)) // shuffle classes with 3D models
            {
                int randClass() => (int)(Rand() % rModelRestricted.Length);
                t.Class = rModelRestricted[randClass()];
            }
            else
            if (
                rClass // Classes selected to be randomized
                && (!rOnlySingles || t.BattleType == 0) //  Nonsingles only get changed if rOnlySingles
                && !rIgnoreClass.Contains(t.Class) // Current class isn't a special class
                )
            {
                int randClass() => (int)(Rand() % trClass.Length);
                int rv; do { rv = randClass(); }
                while (rIgnoreClass.Contains(rv) || trClass[rv].StartsWith("[~") || (Main.Config.ORAS && (rv >= 0 && rv <= 63)) || (rv >= 68 && rv <= 126)); // don't allow disallowed classes
                t.Class = rv;
            }
        }

        private static void RandomizeTrainerPrizeItem(TrainerData6 t)
        {
            if (rGift && Rand() % 100 < rGiftPercent)
            {
                ushort[] items;
                uint rnd = Rand() % 10;
                if (rnd < 2) // held item
                    items = Main.Config.ORAS ? Legal.Pouch_Items_AO : Legal.Pouch_Items_XY;
                else if (rnd < 5) // medicine
                    items = Main.Config.ORAS ? Legal.Pouch_Medicine_AO : Legal.Pouch_Medicine_XY;
                else // berry
                    items = Legal.Pouch_Berry_XY;
                t.Prize = items[Rand() % items.Length];
            }
            else if (rGift)
            {
                t.Prize = 0;
            }
        }

        private string[] GetTagsORAS()
        {
            string[] tags = Enumerable.Repeat("", trdata.Length).ToArray();
            ImportantTrainers = true;

            // Rival Battles
            TagTrainer(tags, "RIVAL1", 289, 292, 295, 298, 527, 530, 674, 677, 699, 906); // Rival w/ Grass Starter
            TagTrainer(tags, "RIVAL2", 290, 293, 296, 299, 528, 531, 675, 678, 700, 907); // Rival w/ Fire Starter
            TagTrainer(tags, "RIVAL3", 291, 294, 297, 300, 529, 532, 676, 679, 701, 908); // Rival w/ Water Starter

            // Aqua Admins
            TagTrainer(tags, "AQUA1", 178, 231, 266);           // Archie
            TagTrainer(tags, "AQUA2", 683, 684, 685, 686, 687); // Matt
            TagTrainer(tags, "AQUA3", 688, 689, 690);           // Shelly

            // Magma Admins
            TagTrainer(tags, "MAGMA1", 235, 236, 271);           // Maxie
            TagTrainer(tags, "MAGMA2", 694, 695, 696, 697, 698); // Courtney
            TagTrainer(tags, "MAGMA3", 691, 692, 693);           // Tabitha

            // Gym Leaders
            TagTrainer(tags, "GYM1", 561);      // Roxanne
            TagTrainer(tags, "GYM2", 563);      // Brawly
            TagTrainer(tags, "GYM3", 567);      // Wattson
            TagTrainer(tags, "GYM4", 569);      // Flannery
            TagTrainer(tags, "GYM5", 570);      // Norman
            TagTrainer(tags, "GYM6", 571);      // Winona
            TagTrainer(tags, "GYM7", 552);      // Liza & Tate
            TagTrainer(tags, "GYM8", 572, 943); // Wallace

            // Elite Four
            TagTrainer(tags, "ELITE1", 553, 909);             // Sidney
            TagTrainer(tags, "ELITE2", 554, 910);             // Phoebe
            TagTrainer(tags, "ELITE3", 555, 911);             // Glacia
            TagTrainer(tags, "ELITE4", 556, 912);             // Drake
            TagTrainer(tags, "CHAMPION", 557, 680, 913, 942); // Champion Steven

            // Wally
            TagTrainer(tags, "WALLY", 518, 583, 944, 945, 946, 947);

            // Zinnia
            TagTrainer(tags, "LOREKEEPER", 713, 898);

            // Aarune
            TagTrainer(tags, "EXPERT", 856, 857);

            ImportantTrainers = false;
            TagTrainer(tags, "RIVAL1", 1, 4); // Rival w/ Grass Starter
            TagTrainer(tags, "RIVAL2", 2, 5); // Rival w/ Fire Starter
            TagTrainer(tags, "RIVAL3", 3, 6); // Rival w/ Water Starter

            // Gym Trainers (Tagged in order of appearance on Bulbapedia's lists)
            if (rTypeGymTrainers)
            {
                TagTrainer(tags, "GYM1", 562, 22, 667);
                TagTrainer(tags, "GYM2", 60, 56, 59);
                TagTrainer(tags, "GYM3", 34, 568, 614, 35);
                TagTrainer(tags, "GYM4", 81, 824, 83, 615, 823, 613, 85);
                TagTrainer(tags, "GYM5", 63, 67, 64, 68, 65, 69, 66);
                TagTrainer(tags, "GYM6", 115, 517, 516, 118, 730);
                TagTrainer(tags, "GYM7", 157, 226, 320, 159, 225, 158);
                TagTrainer(tags, "GYM8", 647, 342, 594, 646, 338, 339, 340, 341);
            }
            return tags;
        }

        private string[] GetTagsXY()
        {
            string[] tags = Enumerable.Repeat("", trdata.Length).ToArray();
            ImportantTrainers = true;

            // Rival Battles
            TagTrainer(tags, "RIVAL1", 130, 184, 329, 332, 335, 338, 341, 435, 519, 604, 575, 578, 581, 584, 587, 590, 593, 596, 599, 607); // Rival w/ Fire Starter
            TagTrainer(tags, "RIVAL2", 131, 185, 330, 333, 336, 339, 342, 436, 520, 605, 576, 579, 582, 585, 588, 591, 594, 597, 600, 608); // Rival w/ Water Starter
            TagTrainer(tags, "RIVAL3", 132, 186, 331, 334, 337, 340, 343, 437, 521, 606, 577, 580, 583, 586, 589, 592, 595, 598, 601, 609); // Rival w/ Grass Starter

            // Team Flare Admins
            TagTrainer(tags, "FLAREBOSS", 303, 525, 526); // Lysandre
            TagTrainer(tags, "FLARE1", 175, 344);         // Aliana
            TagTrainer(tags, "FLARE2", 350, 351);         // Bryony
            TagTrainer(tags, "FLARE3", 348, 349);         // Celosia
            TagTrainer(tags, "FLARE4", 346, 347);         // Mable
            TagTrainer(tags, "FLARE5", 345);              // Xerosic

            // Gym Leaders
            TagTrainer(tags, "GYM1", 6, 254, 262);       // Viola
            TagTrainer(tags, "GYM2", 76, 261, 279);      // Grant
            TagTrainer(tags, "GYM3", 21, 255, 263, 613); // Korrina
            TagTrainer(tags, "GYM4", 22, 256, 264);      // Ramos
            TagTrainer(tags, "GYM5", 23, 257, 265);      // Clemont
            TagTrainer(tags, "GYM6", 24, 258, 266);      // Valerie
            TagTrainer(tags, "GYM7", 25, 259, 267);      // Olympia
            TagTrainer(tags, "GYM8", 26, 260, 268);      // Wulfric

            // Elite Four
            TagTrainer(tags, "ELITE1", 269, 273, 507); // Malva
            TagTrainer(tags, "ELITE2", 271, 275);      // Siebold
            TagTrainer(tags, "ELITE3", 187, 272);      // Wikstrom
            TagTrainer(tags, "ELITE4", 270, 274);      // Drasna
            TagTrainer(tags, "CHAMPION", 276, 277);    // Champion Diantha

            // Friends
            TagTrainer(tags, "SHAUNA", 321, 322, 323);
            TagTrainer(tags, "TREVOR", 325, 439);
            TagTrainer(tags, "TIERNO", 324, 438, 573);

            // Professor
            TagTrainer(tags, "PROFESSOR", 327, 328);

            // Suspicious Trainer ???
            TagTrainer(tags, "ESSENTIA", 503, 504, 505, 511, 512, 513, 514, 515); // Emma

            // AZ
            TagTrainer(tags, "AZ", 602);

            // Battle Chatelaines
            TagTrainer(tags, "CHATELAINE1", 559); // Nita
            TagTrainer(tags, "CHATELAINE2", 560); // Evelyn
            TagTrainer(tags, "CHATELAINE3", 561); // Dana
            TagTrainer(tags, "CHATELAINE4", 562); // Morgan

            ImportantTrainers = false;
            TagTrainer(tags, "SHAUNA", 137, 138, 139);
            TagTrainer(tags, "GYM3", 188);

            // Gym Trainers (Tagged in order of appearance on Bulbapedia's lists)
            if (rTypeGymTrainers)
            {
                TagTrainer(tags, "GYM1", 39, 40, 48);
                TagTrainer(tags, "GYM2", 64, 63, 106, 105);
                TagTrainer(tags, "GYM3", 83, 147, 84, 146);
                TagTrainer(tags, "GYM4", 123, 121, 124, 122);
                TagTrainer(tags, "GYM5", 461, 462, 463, 464, 465, 466, 28, 29, 30, 467, 468, 469);
                TagTrainer(tags, "GYM6", 245, 250, 248, 243);
                TagTrainer(tags, "GYM7", 170, 171, 172, 365, 366);
                TagTrainer(tags, "GYM8", 169, 32, 168, 31);
            }
            return tags;
        }

        private bool ImportantTrainers;
        public static SpeciesRandomizer rSpeciesRand;

        // Theme Methods
        private void TagTrainer(string[] trTags, string tag, params int[] ids)
        {
            foreach (int id in ids.Where(id => id < trTags.Length))
                trTags[id] = tag;

            if (!Tags.Contains(tag))
                Tags.Add(tag);

            if (!ImportantTrainers) return;
            foreach (int id in ids)
                rImportant[id] = tag;
        }

        private static Dictionary<int, int[]> MegaDictionary;

        private static int[] GetRandomMega(out int species)
        {
            int rnd = Util.Rand.Next(0, MegaDictionary.Count - 1);
            species = MegaDictionary.Keys.ElementAt(rnd);
            return MegaDictionary.Values.ElementAt(rnd);
        }

        private int GetRandomType(int trainer)
        {
            if (rTags[trainer].Length != 0)
                return TagTypes[rTags[trainer]];
            if (!rEnsureMEvo.Contains(trainer))
                return (int)(Rand() % types.Length);
            return mEvoTypes[Rand() % mEvoTypes.Length];
        }

        private static int[] GetMegaEvolvableTypes()
        {
            List<int> MEvoTypes = new List<int>();
            foreach (int spec in megaEvos)
            {
                if (!MEvoTypes.Contains(Main.SpeciesStat[spec].Types[0]))
                    MEvoTypes.Add(Main.SpeciesStat[spec].Types[0]);
                if (!MEvoTypes.Contains(Main.SpeciesStat[spec].Types[1]))
                    MEvoTypes.Add(Main.SpeciesStat[spec].Types[1]);
            }
            MEvoTypes.Sort();
            Console.WriteLine("There are " + MEvoTypes.Count + " Types capable of Mega Evolution.");
            return MEvoTypes.ToArray();
        }

        private void IsFormClosing(object sender, FormClosingEventArgs e)
        {
            WriteFile();
        }

        private void GotoParty(object sender, EventArgs e)
        {
            // When sprite is clicked, jump to that Pokémon.
            TabControl.SelectedIndex = 1 + Array.IndexOf(new[] { PB_Team1, PB_Team2, PB_Team3, PB_Team4, PB_Team5, PB_Team6, }, sender as PictureBox);
        }

        private void B_Export_Calc(object sender, EventArgs e)
        {
            if (DialogResult.Yes != WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "Export Trainers in Showdown Calc format?"))
                return;

            ExportFormattedSetsTxt sets = new();

            Dictionary<string, int> trainerAppearanceIndexes = new();
            int rivalIdx = 0;

            for (int i = 0; i < AXHelpers.AXTrainerIndexes.Length; i++)
            {
                CB_TrainerID.SelectedIndex = AXHelpers.AXTrainerIndexes[i];
                //CB_AI.SelectedIndex = 1;

                ExportTrainerDataTxt[] exportData = new ExportTrainerDataTxt[CB_numPokemon.SelectedIndex];

                string trShortenedName = CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6);

                bool foundTag = false;
                string trainerName1 = "", trainerName2 = "";
                for (int j = 0; j < AXHelpers.AXTagTrainerIndexes.Length; j++)
                {
                    Tuple<int, int, int> tagIndices = AXHelpers.AXTagTrainerIndexes[j];

                    if (CB_TrainerID.SelectedIndex == tagIndices.Item1)
                    {
                        foundTag = true;
                        trainerName1 = trShortenedName;
                        int originalIndex = CB_TrainerID.SelectedIndex;
                        CB_TrainerID.SelectedIndex = tagIndices.Item2;
                        trainerName2 = CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6);
                        CB_TrainerID.SelectedIndex = originalIndex;
                    }
                    else if (CB_TrainerID.SelectedIndex == tagIndices.Item2)
                    {
                        foundTag = true;
                        trainerName2 = trShortenedName;
                        int originalIndex = CB_TrainerID.SelectedIndex;
                        CB_TrainerID.SelectedIndex = tagIndices.Item1;
                        trainerName1 = CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6);
                        CB_TrainerID.SelectedIndex = originalIndex;
                    }

                    if (foundTag)
                    {
                        trShortenedName = $"{trainerName1} & {trainerName2} {tagIndices.Item3}";
                        break;
                    }
                }

                if (!trainerAppearanceIndexes.ContainsKey(trShortenedName))
                {
                    trainerAppearanceIndexes.Add(trShortenedName, 0);

                    if (trShortenedName == "Serena" ||
                        trShortenedName == "Calem")
                    {
                        trShortenedName += $" {trainerAppearanceIndexes[trShortenedName]}-{rivalIdx + 1}";
                        rivalIdx++;
                    }
                }
                else if (trShortenedName == "Serena" ||
                            trShortenedName == "Calem")
                {
                    string oldShortName = trShortenedName;
                    trShortenedName += $" {trainerAppearanceIndexes[trShortenedName]}-{rivalIdx + 1}";

                    rivalIdx++;
                    if (rivalIdx == 3)
                        trainerAppearanceIndexes[oldShortName]++;
                    rivalIdx %= 3;
                }
                else if (!foundTag)
                {
                    trShortenedName += $" {++trainerAppearanceIndexes[trShortenedName]}";
                }

                for (int j = 0; j < exportData.Length; j++)
                {
                    exportData[j] = new()
                    {
                        TrainerID = CB_TrainerID.SelectedIndex,
                        AI = CB_AI.SelectedIndex,
                        BattleType = CB_Battle_Type.Text + "s",
                        RewardItem = "-",
                        //Sprite = "-", // Deprecated, was planning on mapping in AXHelpers

                        PartyPosition = j,
                        Level = trpk_lvl[j].SelectedIndex,
                        Form = trpk_form[j].SelectedIndex,
                        Gender = trpk_gender[j].SelectedIndex == 0 ? "" : (trpk_gender[j].SelectedIndex == 1 ? "M" : "F"),
                        HeldItem = (trpk_item[j].Text != "" ? trpk_item[j].Text : "-").Replace("’", "'"),
                        Nature = trpk_nature[j].Text.Substring(0, trpk_nature[j].Text.IndexOf("(") - 1),
                        Ability = trpk_abil[j].Text.Substring(0, trpk_abil[j].Text.IndexOf("(") - 1)
                    };

                    exportData[j].Moves[0] = trpk_m1[j].Text.Replace("’", "'");
                    exportData[j].Moves[1] = trpk_m2[j].Text.Replace("’", "'");
                    exportData[j].Moves[2] = trpk_m3[j].Text.Replace("’", "'");
                    exportData[j].Moves[3] = trpk_m4[j].Text.Replace("’", "'");

                    int calculatedIV = trpk_IV[j].SelectedIndex & 0x1F;
                    exportData[j].IVs.Add("hp", calculatedIV);
                    exportData[j].IVs.Add("at", calculatedIV);
                    exportData[j].IVs.Add("df", calculatedIV);
                    exportData[j].IVs.Add("sa", calculatedIV);
                    exportData[j].IVs.Add("sd", calculatedIV);
                    exportData[j].IVs.Add("sp", calculatedIV);

                    string pkmName = trpk_pkm[j].Text;

                    if (pkmName == "Aegislash")
                    {
                        pkmName = "Aegislash-Shield";
                    }
                    else if (exportData[j].Form > 0)
                    {
                        string pkmFormName = $"{pkmName} {exportData[j].Form}";
                        if (AXHelpers.AXPokemonFormNamesSite.TryGetValue(pkmFormName, out string value))
                            pkmName = value;
                    }
                    else if (exportData[j].HeldItem == "Megite X")
                    {
                        if (pkmName == "Charizard" || pkmName == "Mewtwo")
                            pkmName += "-Mega-X";
                        else
                            pkmName += "-Mega";

                        int entry = Main.Config.Personal.GetFormIndex(trpk_pkm[j].SelectedIndex, trpk_form[j].SelectedIndex + 1);
                        exportData[j].Ability = abilitylist[Main.SpeciesStat[entry].Abilities[0]];
                    }
                    else if (exportData[j].HeldItem == "Megite Y")
                    {
                        if (pkmName == "Charizard" || pkmName == "Mewtwo")
                            pkmName += "-Mega-Y";
                        else
                            pkmName += "-Mega";

                        int entry = Main.Config.Personal.GetFormIndex(trpk_pkm[j].SelectedIndex, trpk_form[j].SelectedIndex + 2);
                        exportData[j].Ability = abilitylist[Main.SpeciesStat[entry].Abilities[0]];
                    }
                    else if (exportData[j].HeldItem == "Fire Stone")
                    {
                        pkmName += "-Sunny";

                        int entry = Main.Config.Personal.GetFormIndex(trpk_pkm[j].SelectedIndex, trpk_form[j].SelectedIndex + 1);
                        exportData[j].Ability = abilitylist[Main.SpeciesStat[entry].Abilities[0]];
                    }
                    else if (exportData[j].HeldItem == "Water Stone")
                    {
                        pkmName += "-Rainy";

                        int entry = Main.Config.Personal.GetFormIndex(trpk_pkm[j].SelectedIndex, trpk_form[j].SelectedIndex + 2);
                        exportData[j].Ability = abilitylist[Main.SpeciesStat[entry].Abilities[0]];
                    }
                    else if (exportData[j].HeldItem == "Shiny Stone")
                    {
                        pkmName += "-Snowy";

                        int entry = Main.Config.Personal.GetFormIndex(trpk_pkm[j].SelectedIndex, trpk_form[j].SelectedIndex + 3);
                        exportData[j].Ability = abilitylist[Main.SpeciesStat[entry].Abilities[0]];
                    }

                    if (!sets.TrPokemonList.ContainsKey(pkmName))
                        sets.TrPokemonList.Add(pkmName, new());

                    string levelName = $"Lvl {trpk_lvl[j].SelectedIndex} {trShortenedName} ";

                    try
                    {
                        sets.TrPokemonList[pkmName].Add(levelName, exportData[j]);
                    }
                    // Duplicate Key Error - This hack will only work for 2 duplicate mons, not 3+
                    catch (ArgumentException)
                    {
                        ExportTrainerDataTxt tempETD = sets.TrPokemonList[pkmName][levelName];
                        sets.TrPokemonList[pkmName].Remove(levelName);

                        sets.TrPokemonList[pkmName].Add($"{tempETD.Gender} {levelName}", tempETD);
                        sets.TrPokemonList[pkmName].Add($"{exportData[j].Gender} {levelName}", exportData[j]);
                    }
                }
            }

            SaveFileDialog sfd = new() { FileName = "Trainers - Showdown Calc.json", Filter = "JSON|*.json" };
            SystemSounds.Asterisk.Play();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                string json = JsonSerializer.Serialize(sets);
                File.WriteAllText(path, json);
            }
        }

        private void B_Export_Site(object sender, EventArgs e)
        {
            if (DialogResult.Yes != WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "Export Trainers for Site?"))
                return;

			Dictionary<string, ExportRouteSite> routeDict = new();

            for (int i = 0; i < AXHelpers.AXTrainerIndexes.Length; i++)
            {
                CB_TrainerID.SelectedIndex = AXHelpers.AXTrainerIndexes[i];

				if (AXHelpers.TrainerIDSkips.Contains(CB_TrainerID.SelectedIndex))
					continue;

				string routeName = AXHelpers.TrainerIDToRoute[CB_TrainerID.SelectedIndex].Route;

				string trShortenedName = CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6);
                string trClass = Regex.Replace(CB_Trainer_Class.Text.Substring(0, CB_Trainer_Class.Text.IndexOf(" - ")), "[^a-zA-Z0-9çé& ]+", "").Trim();
                int trClassIndex = int.Parse(CB_Trainer_Class.Text.Substring(CB_Trainer_Class.Text.IndexOf(" - ") + 3));

                bool foundTag = false, skipTrainer = false;
                string trainerName1 = "", trainerName2 = "";
				List<ExportTrPkmSite> tagPkm = new();
                for (int j = 0; j < AXHelpers.AXTagTrainerIndexes.Length; j++)
                {
                    Tuple<int, int, int> tagIndices = AXHelpers.AXTagTrainerIndexes[j];

					if (routeDict.TryGetValue(routeName, out ExportRouteSite outRoute))
					{
						if ((CB_TrainerID.SelectedIndex == tagIndices.Item1 || CB_TrainerID.SelectedIndex == tagIndices.Item2) &&
							outRoute.Trainers.FindIndex(t => t.TrainerID == tagIndices.Item1 || t.TrainerID == tagIndices.Item2) > -1)
						{
							skipTrainer = true;
							break;
						}
					}

					if (CB_TrainerID.SelectedIndex == tagIndices.Item1)
                    {
                        foundTag = true;
                        trainerName1 = trShortenedName;
                        int originalIndex = CB_TrainerID.SelectedIndex;
                        CB_TrainerID.SelectedIndex = tagIndices.Item2;
                        trainerName2 = CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6);

						for (int k = 0; k < CB_numPokemon.SelectedIndex; k++)
						{
							ExportTrPkmSite trPkm = new()
							{
								Name = trpk_pkm[k].Text.Replace("’", "'"),
								Gender = trpk_gender[k].Text == "- / Genderless/Random" ? "" : trpk_gender[k].Text,
								Level = trpk_lvl[k].SelectedIndex,
								Ability = trpk_abil[k].Text.Substring(0, trpk_abil[k].Text.IndexOf("(") - 1),
								HeldItem = trpk_item[k].Text.Replace("’", "'"),
								Nature = trpk_nature[k].Text,
								IVs = trpk_IV[k].SelectedIndex & 0x1F
							};

							if (trPkm.HeldItem == "Megite X" ||
								trPkm.HeldItem == "Lucarionite" ||
								trPkm.HeldItem == "Fire Stone")
								trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[k].Text} 1", trpk_pkm[k].SelectedIndex);
							else if (trPkm.HeldItem == "Megite Y" ||
									 trPkm.HeldItem == "Water Stone")
								trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[k].Text} 2", trpk_pkm[k].SelectedIndex);
							else if (trPkm.HeldItem == "Shiny Stone")
								trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[k].Text} 3", trpk_pkm[k].SelectedIndex);
							else
								trPkm.Form = AXHelpers.GetJSONPkmName(trpk_form[k]);

							trPkm.Moves[0] = trpk_m1[k].Text.Replace("’", "'");
							trPkm.Moves[1] = trpk_m2[k].Text.Replace("’", "'");
							trPkm.Moves[2] = trpk_m3[k].Text.Replace("’", "'");
							trPkm.Moves[3] = trpk_m4[k].Text.Replace("’", "'");

							tagPkm.Add(trPkm);
						}

                        CB_TrainerID.SelectedIndex = originalIndex;
                    }
                    else if (CB_TrainerID.SelectedIndex == tagIndices.Item2)
                    {
                        foundTag = true;
                        trainerName2 = trShortenedName;
                        int originalIndex = CB_TrainerID.SelectedIndex;
                        CB_TrainerID.SelectedIndex = tagIndices.Item1;
                        trainerName1 = CB_TrainerID.Text.Substring(0, CB_TrainerID.Text.Length - 6);

						for (int k = 0; k < CB_numPokemon.SelectedIndex; k++)
						{
							ExportTrPkmSite trPkm = new()
							{
								Name = trpk_pkm[k].Text.Replace("’", "'"),
								Gender = trpk_gender[k].Text == "- / Genderless/Random" ? "" : trpk_gender[k].Text,
								Level = trpk_lvl[k].SelectedIndex,
								Ability = trpk_abil[k].Text.Substring(0, trpk_abil[k].Text.IndexOf("(") - 1),
								HeldItem = trpk_item[k].Text.Replace("’", "'"),
								Nature = trpk_nature[k].Text,
								IVs = trpk_IV[k].SelectedIndex & 0x1F
							};

							if (trPkm.HeldItem == "Megite X" ||
								trPkm.HeldItem == "Lucarionite" ||
								trPkm.HeldItem == "Fire Stone")
								trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[k].Text} 1", trpk_pkm[k].SelectedIndex);
							else if (trPkm.HeldItem == "Megite Y" ||
									 trPkm.HeldItem == "Water Stone")
								trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[k].Text} 2", trpk_pkm[k].SelectedIndex);
							else if (trPkm.HeldItem == "Shiny Stone")
								trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[k].Text} 3", trpk_pkm[k].SelectedIndex);
							else
								trPkm.Form = AXHelpers.GetJSONPkmName(trpk_form[k]);

							trPkm.Moves[0] = trpk_m1[k].Text.Replace("’", "'");
							trPkm.Moves[1] = trpk_m2[k].Text.Replace("’", "'");
							trPkm.Moves[2] = trpk_m3[k].Text.Replace("’", "'");
							trPkm.Moves[3] = trpk_m4[k].Text.Replace("’", "'");

							tagPkm.Add(trPkm);
						}

						CB_TrainerID.SelectedIndex = originalIndex;
                    }

                    if (foundTag)
                    {
                        trShortenedName = $"{trainerName1} & {trainerName2}";
                        break;
                    }
                }

				if (skipTrainer)
					continue;

				for (int j = 0; j < AXHelpers.TrainerIDRenames.Length; j++)
				{
					if (AXHelpers.TrainerIDRenames[j].Item1 == CB_TrainerID.SelectedIndex)
					{
						trShortenedName = AXHelpers.TrainerIDRenames[j].Item2;
						break;
					}
				}

                /*if (!trainerAppearanceIndexes.ContainsKey(trShortenedName))
                {
                    trainerAppearanceIndexes.Add(trShortenedName, 0);

                    if (trShortenedName == "Serena" ||
                        trShortenedName == "Calem")
                    {
                        trShortenedName += " " + trainerAppearanceIndexes[trShortenedName] + "-" + (rivalIdx + 1);
                        rivalIdx++;
                    }
                }
                else if (trShortenedName == "Serena" ||
                         trShortenedName == "Calem")
                {
                    string oldShortName = trShortenedName;
                    trShortenedName += " " + trainerAppearanceIndexes[trShortenedName] + "-" + (rivalIdx + 1);

                    rivalIdx++;
                    if (rivalIdx == 3)
                        trainerAppearanceIndexes[oldShortName]++;
                    rivalIdx %= 3;
                }
                else if (!foundTag)
				{
                    trShortenedName += " " + ++trainerAppearanceIndexes[trShortenedName];
                }*/

                ExportTrSite tr = new()
                {
					TrainerName = trShortenedName,
                    TrainerID = CB_TrainerID.SelectedIndex,
                    TrainerClass = trClass,
                    TrainerClassIndex = trClassIndex,
					BattleType = foundTag || AXHelpers.TrainerIDToRoute[CB_TrainerID.SelectedIndex].Required == "DoublesPartner" ? "Double" : CB_Battle_Type.SelectedItem.ToString(),
					Route = routeName,
                    EncounterIndex = AXHelpers.TrainerIDToRoute[CB_TrainerID.SelectedIndex].EncounterIndex,
                    Required = AXHelpers.TrainerIDToRoute[CB_TrainerID.SelectedIndex].Required,
					Notes = AXHelpers.TrainerIDToRoute[CB_TrainerID.SelectedIndex].Notes,
					IsTagBattle = AXHelpers.TrainerIDToRoute[CB_TrainerID.SelectedIndex].IsTagBattle
                };

                for (int j = 0; j < CB_numPokemon.SelectedIndex; j++)
                {
                    ExportTrPkmSite trPkm = new()
                    {
                        Name = trpk_pkm[j].Text.Replace("’", "'"),
                        Gender = trpk_gender[j].Text == "- / Genderless/Random" ? "" : trpk_gender[j].Text,
                        Level = trpk_lvl[j].SelectedIndex,
                        Ability = trpk_abil[j].Text.Substring(0, trpk_abil[j].Text.IndexOf("(") - 1),
                        HeldItem = trpk_item[j].Text.Replace("’", "'"),
                        Nature = trpk_nature[j].Text,
                        IVs = trpk_IV[j].SelectedIndex & 0x1F
                    };

					if (trPkm.HeldItem == "Megite X" ||
						trPkm.HeldItem == "Lucarionite" ||
						trPkm.HeldItem == "Fire Stone")
						trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[j].Text} 1", trpk_pkm[j].SelectedIndex);
					else if (trPkm.HeldItem == "Megite Y" ||
							 trPkm.HeldItem == "Water Stone")
						trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[j].Text} 2", trpk_pkm[j].SelectedIndex);
					else if (trPkm.HeldItem == "Shiny Stone")
						trPkm.Form = AXHelpers.GetJSONPkmName($"{trpk_form[j].Text} 3", trpk_pkm[j].SelectedIndex);
					else
						trPkm.Form = AXHelpers.GetJSONPkmName(trpk_form[j]);

					trPkm.Moves[0] = trpk_m1[j].Text.Replace("’", "'");
                    trPkm.Moves[1] = trpk_m2[j].Text.Replace("’", "'");
                    trPkm.Moves[2] = trpk_m3[j].Text.Replace("’", "'");
                    trPkm.Moves[3] = trpk_m4[j].Text.Replace("’", "'");

                    tr.Pokemon.Add(trPkm);
                }

				tr.Pokemon.AddRange(tagPkm);

				ExportRouteSite route = new()
				{
					RouteIndex	= AXHelpers.RouteMappings[tr.Route].RouteIndex,
					Required =	AXHelpers.RouteMappings[tr.Route].Required,
					Notes =		AXHelpers.RouteMappings[tr.Route].Notes,
				};

				route.Trainers.Add(tr);

                if (!routeDict.TryAdd(tr.Route, route))
				{
					routeDict[tr.Route].Trainers.Add(tr);
					routeDict[tr.Route].Trainers.Sort((x, y) => x.EncounterIndex.CompareTo(y.EncounterIndex));
				}
            }

            SaveFileDialog sfd = new() { FileName = "trainers.json", Filter = "JSON|*.json" };
            SystemSounds.Asterisk.Play();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                string json = JsonSerializer.Serialize(routeDict);
                File.WriteAllText(path, json);
            }
        }

		private void AddPkm()
		{

		}

		//---------------------------
		// NATURE FUNCS
		//---------------------------

        private NatureViewer NatureViewer;

        private void CalculateNature(object sender, EventArgs e)
        {
            if (loading)
                return;

            ComboBox source = sender as ComboBox;

            if (source == CB_Trainer_Class)
            {
                for (int i = 0; i < 6; i++)
                    SetNatureString(i);
            }
            else
            {
                int index = new[] { Array.IndexOf(trpk_pkm, source), Array.IndexOf(trpk_IV, source), Array.IndexOf(trpk_lvl, source) }.Max();

                SetNatureString(index);

                if (NatureViewer != null)
                {
                    int species = trpk_pkm[index].SelectedIndex;
                    int level = trpk_lvl[index].SelectedIndex;
                    int tr_class = CB_Trainer_Class.SelectedIndex;

                    NatureViewer.Invoke((MethodInvoker)delegate
                    {
                        NatureViewer.Reload(species, level, tr_class);
                    });
                }
            }
        }

        private void SetNatureString(int pkmIndex)
        {
            int species = trpk_pkm[pkmIndex].SelectedIndex;
            int level = trpk_lvl[pkmIndex].SelectedIndex;
            int IVs = trpk_IV[pkmIndex].SelectedIndex;
            int tr_class = CB_Trainer_Class.SelectedIndex;

            uint nature = NatureCalculation.GetNature(species, level, IVs, tr_class);
            trpk_nature[pkmIndex].Text = NatureCalculation.GetNatureString(nature);
            trpk_nature[pkmIndex].BackColor = NatureCalculation.GetNatureColor(nature);
        }

        private void B_NatureMap_Click(object sender, EventArgs e)
        {
            bool parsed = int.TryParse(TabControl.SelectedTab.Name[^1..], out int tabIndex);
            if (!parsed)
            {
                MessageBox.Show("Must select one of the Pokemon Tabs.", "Error");
                return;
            }

            int pkmSlot = tabIndex - 1;

            int species = trpk_pkm[pkmSlot].SelectedIndex;
            int level = trpk_lvl[pkmSlot].SelectedIndex;
            int tr_class = CB_Trainer_Class.SelectedIndex;

            new Thread(() => OpenNatureMap(species, level, tr_class)).Start();
        }

        private void OpenNatureMap(int species, int level, int tr_class)
        {
            NatureViewer = new NatureViewer(4, species, level, tr_class);
            NatureViewer.ShowDialog();
            NatureViewer = null;
        }

        private void ReloadNatureMap(object sender, EventArgs e)
        {
            bool parsed = int.TryParse(TabControl.SelectedTab.Name[^1..], out int tabIndex);

            if (NatureViewer == null || !parsed || tabIndex > tr.NumPokemon)
                return;

            int pkmSlot = tabIndex - 1;

            int species = trpk_pkm[pkmSlot].SelectedIndex;
            int level = trpk_lvl[pkmSlot].SelectedIndex;
            int tr_class = CB_Trainer_Class.SelectedIndex;

            NatureViewer.Invoke((MethodInvoker)delegate
            {
                NatureViewer.Reload(species, level, tr_class);
            });
        }
    }
}
