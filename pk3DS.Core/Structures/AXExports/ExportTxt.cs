using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace pk3DS.Core.Structures.AXExports;

// Moves
public class ExportMoveTxt
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("basePower")]
    public int BasePower { get; set; }
    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("drain"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int[] Drain { get; set; }
    [JsonPropertyName("multihit"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int[] Multihit { get; set; }
    [JsonPropertyName("recoil"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int[] Recoil { get; set; }

    [JsonPropertyName("priority"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Priority { get; set; }

    [JsonPropertyName("makesContact"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool MakesContact { get; set; }
    [JsonPropertyName("secondaries"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool Secondaries { get; set; }

    public ExportMoveTxt(string type, int basePower, string category,
                            int[] drain, int[] multihit, int[] recoil,
                            int priority, bool makesContact, bool secondaries)
    {
        Type = type;
        BasePower = basePower;
        Category = category;

        Drain = null;
        Multihit = null;
        Recoil = null;

        Priority = priority;
        MakesContact = makesContact;
        Secondaries = secondaries;

        if (drain[0] != 0)
            Drain = drain;
        if (multihit[0] != 0 || multihit[1] != 0)
            Multihit = multihit;
        if (recoil[0] != 0)
            Recoil = recoil;
    }
}

public class ExportMoveListTxt()
{
	[JsonPropertyName("moves")]
	public Dictionary<string, ExportMoveTxt> MoveList { get; set; } = [];
}

// Pkm
public class ExportStatBlockTxt(int hp, int atk, int def, int spa, int spd, int spe)
{
	[JsonPropertyName("hp")]
	public int HP { get; set; } = hp;
	[JsonPropertyName("at")]
	public int ATK { get; set; } = atk;
	[JsonPropertyName("df")]
	public int DEF { get; set; } = def;
	[JsonPropertyName("sa")]
	public int SPA { get; set; } = spa;
	[JsonPropertyName("sd")]
	public int SPD { get; set; } = spd;
	[JsonPropertyName("sp")]
	public int SPE { get; set; } = spe;
}

public class ExportPokemonTxt()
{
	[JsonPropertyName("types")]
	public string[] Types { get; set; } = [];
	[JsonPropertyName("abilities")]
	public string[] Abilities { get; set; } = [];
	[JsonPropertyName("bs")]
	public Dictionary<string, int> BaseStats { get; set; } = [];
}

public class ExportPokemonListTxt()
{
	[JsonPropertyName("poks")]
	public Dictionary<string, ExportPokemonTxt> PokemonList { get; set; } = [];
}

// Trainers
public class ExportTrainerDataTxt()
{
	// General Trainer Info

	[JsonPropertyName("tr_id")]
	public int TrainerID { get; set; }
	[JsonPropertyName("ai")]
	public int AI { get; set; }
	[JsonPropertyName("battle_type")]
	public string BattleType { get; set; }
	[JsonPropertyName("reward_item")]
	public string RewardItem { get; set; }

	// Pokemon Specific Info

	[JsonPropertyName("sub_index")]
	public int PartyPosition { get; set; }

	[JsonPropertyName("level")]
	public int Level { get; set; }
	[JsonPropertyName("form")]
	public int Form { get; set; }
	[JsonPropertyName("gender")]
	public string Gender { get; set; } = "";
	[JsonPropertyName("item")]
	public string HeldItem { get; set; }
	[JsonPropertyName("nature")]
	public string Nature { get; set; }
	[JsonPropertyName("ability")]
	public string Ability { get; set; }
	[JsonPropertyName("moves")]
	public string[] Moves { get; set; } = ["", "", "", ""];
	[JsonPropertyName("ivs")]
	public Dictionary<string, int> IVs { get; set; } = [];
	[JsonPropertyName("evs")]
	public Dictionary<string, int> EVs { get; set; } = new() { { "df", 0 } };
}

public class ExportTrainerPokemonTxt()
{
	public Dictionary<string, ExportTrainerDataTxt> TrainerList { get; set; } = [];
}

public class ExportFormattedSetsTxt()
{
	[JsonPropertyName("formatted_sets")]
	public Dictionary<string, Dictionary<string, ExportTrainerDataTxt>> TrPokemonList { get; set; } = [];
}
