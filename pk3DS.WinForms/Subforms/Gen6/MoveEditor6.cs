using pk3DS.Core;
using pk3DS.Core.Structures;
using pk3DS.Core.Structures.AXExports;
using pk3DS.Core.MathHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.Json;
using System.Windows.Forms;

namespace pk3DS.WinForms;

public partial class MoveEditor6 : Form
{
    public MoveEditor6(byte[][] infiles)
    {
        files = infiles;
        movelist[0] = "";

        InitializeComponent();
        Setup();
        RandSettings.GetFormSettings(this, groupBox1.Controls);

		/*System.Collections.Generic.Dictionary<string, int> moveSort = new();
            for (int i = 0; i < files.Length; i++)
            {
                byte[] data = files[i];
                moveSort.Add(movelist[i], data[3]); // Power
                //moveSort.Add(movelist[i], BitConverter.ToUInt16(data, 16)); // Effect Code
                //System.Diagnostics.Debug.WriteLine($"Move: {movelist[i], 15}\tEffect Code: {BitConverter.ToUInt16(data, 0x10)}");
            }
            var mSortlist = moveSort.ToList();
            mSortlist.Sort((kv1, kv2) => kv1.Value.CompareTo(kv2.Value));

            for (int i = 1; i < mSortlist.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"Move: {mSortlist[i].Key, 15}\tPow: {mSortlist[i].Value}");
                //System.Diagnostics.Debug.WriteLine($"Move: {mSortlist[i].Key, 15}\tEC: {mSortlist[i].Value}");
            }*/
	}

	private readonly byte[][] files;
    private readonly string[] types = Main.Config.GetText(TextName.Types);
    private readonly string[] moveflavor = Main.Config.GetText(TextName.MoveFlavor);
    private readonly string[] movelist = Main.Config.GetText(TextName.MoveNames);
    private readonly string[] MoveCategories = ["Status", "Physical", "Special"];
    private readonly string[] StatCategories = ["None", "Attack", "Defense", "Special Attack", "Special Defense", "Speed", "Accuracy", "Evasion", "All",
    ];

    private readonly string[] TargetingTypes =
    [
        "Single Adjacent Ally/Foe",
        "Any Ally", "Any Adjacent Ally", "Single Adjacent Foe", "Everyone but User", "All Foes",
        "All Allies", "Self", "All Pokémon on Field", "Single Adjacent Foe (2)", "Entire Field",
        "Opponent's Field", "User's Field", "Self",
    ];

    private readonly string[] InflictionTypes =
    [
        "None",
        "Paralyze", "Sleep", "Freeze", "Burn", "Poison",
        "Confusion", "Attract", "Capture", "Nightmare", "Curse",
        "Taunt", "Torment", "Disable", "Yawn", "Heal Block",
        "?", "Detect", "Leech Seed", "Embargo", "Perish Song",
        "Ingrain",
    ];

    private readonly string[] MoveQualities =
    [
        "Only DMG",
        "No DMG -> Inflict Status", "No DMG -> -Target/+User Stat", "No DMG | Heal User", "DMG | Inflict Status", "No DMG | STATUS | +Target Stat",
        "DMG | -Target Stat", "DMG | +User Stat", "DMG | Absorbs DMG", "One-Hit KO", "Affects Whole Field",
        "Affect One Side of the Field", "Forces Target to Switch", "Unique Effect",
    ];

    private void Setup()
    {
        CB_Move.Items.AddRange(movelist);
        CB_Type.Items.AddRange(types);
        CB_Category.Items.AddRange(MoveCategories);
        CB_Stat1.Items.AddRange(StatCategories);
        CB_Stat2.Items.AddRange(StatCategories);
        CB_Stat3.Items.AddRange(StatCategories);
        CB_Targeting.Items.AddRange(TargetingTypes);
        CB_Quality.Items.AddRange(MoveQualities);
        CB_Inflict.Items.AddRange(InflictionTypes);
        foreach (var s in Enum.GetNames(typeof(MoveFlag6)).Skip(1)) CLB_Flags.Items.Add(s);
        CB_Inflict.Items.Add("Special");

        CB_Move.Items.RemoveAt(0);
        CB_Move.SelectedIndex = 0;
    }

    private int entry = -1;

    private void ChangeEntry(object sender, EventArgs e)
    {
        SetEntry();
        entry = Array.IndexOf(movelist, CB_Move.Text);
        GetEntry();
    }

    private void GetEntry()
    {
        if (entry < 1) return;
        byte[] data = files[entry];
        {
            RTB.Text = moveflavor[entry].Replace("\\n", Environment.NewLine);

            CB_Type.SelectedIndex = data[0x00];
            CB_Quality.SelectedIndex = data[0x01];
            CB_Category.SelectedIndex = data[0x02];
            NUD_Power.Value = data[0x3];
            NUD_Accuracy.Value = data[0x4];
            NUD_PP.Value = data[0x05];
            NUD_Priority.Value = (sbyte)data[0x06];
            NUD_HitMin.Value = data[0x7] & 0xF;
            NUD_HitMax.Value = data[0x7] >> 4;
            short inflictVal = BitConverter.ToInt16(data, 0x08);
            CB_Inflict.SelectedIndex = inflictVal < 0 ? CB_Inflict.Items.Count - 1 : inflictVal;
            NUD_Inflict.Value = data[0xA];
            NUD_0xB.Value = data[0xB]; // 0xB ~ Something to deal with skipImmunity
            NUD_TurnMin.Value = data[0xC];
            NUD_TurnMax.Value = data[0xD];
            NUD_CritStage.Value = data[0xE];
            NUD_Flinch.Value = data[0xF];
            NUD_Effect.Value = BitConverter.ToUInt16(data, 0x10);
            NUD_Recoil.Value = (sbyte)data[0x12];
            NUD_Heal.Value = data[0x13];

            CB_Targeting.SelectedIndex = data[0x14];
            CB_Stat1.SelectedIndex = data[0x15];
            CB_Stat2.SelectedIndex = data[0x16];
            CB_Stat3.SelectedIndex = data[0x17];
            NUD_Stat1.Value = (sbyte)data[0x18];
            NUD_Stat2.Value = (sbyte)data[0x19];
            NUD_Stat3.Value = (sbyte)data[0x1A];
            NUD_StatP1.Value = data[0x1B];
            NUD_StatP2.Value = data[0x1C];
            NUD_StatP3.Value = data[0x1D];

            var move = new Move6(data);
            var flags = (uint)move.Flags;
            for (int i = 0; i < CLB_Flags.Items.Count; i++)
                CLB_Flags.SetItemChecked(i, ((flags >> i) & 1) == 1);
        }
    }

    private void SetEntry()
    {
        if (entry < 1) return;
        byte[] data = files[entry];
        {
            data[0x00] = (byte)CB_Type.SelectedIndex;
            data[0x01] = (byte)CB_Quality.SelectedIndex;
            data[0x02] = (byte)CB_Category.SelectedIndex;
            data[0x03] = (byte)NUD_Power.Value;
            data[0x04] = (byte)NUD_Accuracy.Value;
            data[0x05] = (byte)NUD_PP.Value;
            data[0x06] = (byte)(int)NUD_Priority.Value;
            data[0x07] = (byte)((byte)NUD_HitMin.Value | ((byte)NUD_HitMax.Value << 4));
            int inflictval = CB_Inflict.SelectedIndex; if (inflictval == CB_Inflict.Items.Count) inflictval = -1;
            Array.Copy(BitConverter.GetBytes((short)inflictval), 0, data, 0x08, 2);
            data[0x0A] = (byte)NUD_Inflict.Value;
            data[0x0B] = (byte)NUD_0xB.Value;
            data[0x0C] = (byte)NUD_TurnMin.Value;
            data[0x0D] = (byte)NUD_TurnMax.Value;
            data[0x0E] = (byte)NUD_CritStage.Value;
            data[0x0F] = (byte)NUD_Flinch.Value;
            Array.Copy(BitConverter.GetBytes((ushort)NUD_Effect.Value), 0, data, 0x10, 2);
            data[0x12] = (byte)(int)NUD_Recoil.Value;
            data[0x13] = (byte)NUD_Heal.Value;
            data[0x14] = (byte)CB_Targeting.SelectedIndex;
            data[0x15] = (byte)CB_Stat1.SelectedIndex;
            data[0x16] = (byte)CB_Stat2.SelectedIndex;
            data[0x17] = (byte)CB_Stat3.SelectedIndex;
            data[0x18] = (byte)(int)NUD_Stat1.Value;
            data[0x19] = (byte)(int)NUD_Stat2.Value;
            data[0x1A] = (byte)(int)NUD_Stat3.Value;
            data[0x1B] = (byte)NUD_StatP1.Value;
            data[0x1C] = (byte)NUD_StatP2.Value;
            data[0x1D] = (byte)NUD_StatP3.Value;

            uint flagval = 0;
            for (int i = 0; i < CLB_Flags.Items.Count; i++)
                flagval |= CLB_Flags.GetItemChecked(i) ? 1u << i : 0;
            BitConverter.GetBytes(flagval).CopyTo(data, 0x20);
        }
        files[entry] = data;
    }

    private void B_Table_Click(object sender, EventArgs e)
    {
        var items = files.Select(z => new Move6(z));
        Clipboard.SetText(TableUtil.GetTable(items, movelist));
        System.Media.SystemSounds.Asterisk.Play();
    }

    private void CloseForm(object sender, FormClosingEventArgs e)
    {
        SetEntry();
        RandSettings.SetFormSettings(this, groupBox1.Controls);
    }

    private void B_RandAll_Click(object sender, EventArgs e)
    {
        if (!CHK_Category.Checked && !CHK_Type.Checked)
        {
            WinFormsUtil.Alert("Cannot randomize Moves.", "Please check any of the options on the right to randomize Moves.");
            return;
        }

        if (WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "Randomize Moves? Cannot undo.", "Double check options on the right before continuing.") != DialogResult.Yes) return;
        Random rnd = Util.Rand;
        for (int i = 0; i < CB_Move.Items.Count; i++)
        {
            CB_Move.SelectedIndex = i; // Get new Move
            if (i is 165 or 174) continue; // Don't change Struggle or Curse

            // Change Damage Category if Not Status
            if (CB_Category.SelectedIndex > 0 && CHK_Category.Checked) // Not Status
                CB_Category.SelectedIndex = rnd.Next(1, 3);

            // Change Move Type
            if (CHK_Type.Checked)
                CB_Type.SelectedIndex = rnd.Next(0, 18);
        }
        WinFormsUtil.Alert("All Moves have been randomized!");
    }

    private void B_Metronome_Click(object sender, EventArgs e)
    {
        if (WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "Play using Metronome Mode?", "This will set the Base PP for every other Move to 0!") != DialogResult.Yes) return;

        for (int i = 0; i < CB_Move.Items.Count; i++)
        {
            CB_Move.SelectedIndex = i;
            if (CB_Move.SelectedIndex != 117 || CB_Move.SelectedIndex != 32)
                NUD_PP.Value = 0;
            if (CB_Move.SelectedIndex == 117)
                NUD_PP.Value = 40;
            if (CB_Move.SelectedIndex == 32)
                NUD_PP.Value = 1;
        }
        CB_Move.SelectedIndex = 0;
        WinFormsUtil.Alert("All Moves have had their Base PP values modified!");
    }

	private void B_ExportCalc_Click(object sender, EventArgs e)
	{
		if (DialogResult.Yes != WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "Export Moves in Showdown Calc format?"))
			return;

		ExportMoveListTxt moveList = new();

		for (int i = 0; i < CB_Move.Items.Count; i++)
		{
			CB_Move.SelectedIndex = i;

			string name = ((string)CB_Move.SelectedItem).Replace("’", "'");
			string type = (string)CB_Type.SelectedItem;
			int basePower = (int)NUD_Power.Value;
			string category = (string)CB_Category.SelectedItem;

			int[] multihit = [(int)NUD_HitMin.Value, (int)NUD_HitMax.Value];


			int[] drain, recoil;
			float recoilVal = (float)NUD_Recoil.Value;
			if (recoilVal > 0)
			{
				drain = MathHelper.FloatToFraction(recoilVal == 33 ? 1 / 3f : recoilVal / 100);
				recoil = new int[2];
			}
			else
			{
				recoilVal *= -1;

				drain = new int[2];
				recoil = MathHelper.FloatToFraction(recoilVal == 33 ? 1 / 3f : recoilVal / 100);
			}

			int priority = (int)NUD_Priority.Value;
			bool makesContact = CLB_Flags.CheckedIndices.Contains(0);
			bool secondaries = false;

			if (category != "Status" &&
				(CB_Quality.SelectedIndex == 4 ||
				 NUD_Flinch.Value > 0 ||
				 (CB_Quality.SelectedIndex == 6 &&
				  NUD_Stat1.Value < 0) ||
				 (CB_Quality.SelectedIndex == 7 &&
				  NUD_Stat1.Value > 0)))
				secondaries = true;

			moveList.MoveList.Add(name, new ExportMoveTxt(type, basePower, category,
														  drain, multihit, recoil,
														  priority, makesContact, secondaries));
		}

		SaveFileDialog sfd = new() { FileName = "Moves - Showdown Calc.json", Filter = "JSON|*.json" };
		SystemSounds.Asterisk.Play();

		if (sfd.ShowDialog() == DialogResult.OK)
		{
			string path = sfd.FileName;
			string json = JsonSerializer.Serialize(moveList);

			File.WriteAllText(path, json);
		}
	}

	private void B_Export_Site(object sender, EventArgs e)
	{
		if (DialogResult.Yes != WinFormsUtil.Prompt(MessageBoxButtons.YesNo, "Export Moves for Site?"))
			return;

		Dictionary<string, ExportMoveDataSite> moveList = [];

		for (int i = 0; i < CB_Move.Items.Count; i++)
		{
			CB_Move.SelectedIndex = i;

			ExportMoveDataSite move = new()
			{
				Type = CB_Type.Text.Replace("’", "'"),
				Category = CB_Category.Text,
				Power = (int)NUD_Power.Value,
				Acc = (int)NUD_Accuracy.Value,
				PP = (int)NUD_PP.Value,
				Description = RTB.Text.Replace("’", "'")
			};

			moveList.Add(CB_Move.Text.Replace("’", "'"), move);
		}

		SaveFileDialog sfd = new() { FileName = "moves.json", Filter = "JSON|*.json" };
		SystemSounds.Asterisk.Play();

		if (sfd.ShowDialog() == DialogResult.OK)
		{
			string path = sfd.FileName;
			string json = JsonSerializer.Serialize(moveList);

			File.WriteAllText(path, json);
		}
	}
}