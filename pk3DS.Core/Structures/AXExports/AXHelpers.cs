using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pk3DS.Core.Structures.AXExports;

public static class AXHelpers
{
	public static readonly int[] AXTrainerIndexes =
	[
		// 1-25
		1, 3, 6, 21, 22, 23, 24, 25,
		// 26-50
		26, 27, 28, 29, 30, 31, 32, 36, 37, 39, 40, 41, 43, 44, 45, 46, 47, 48, 49, 50,
		// 51-75
		52, 53, 55, 56, 57, 58, 59, 60, 61, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72,
		// 76-100
		76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 95, 96, 97, 98, 99, 100,
		// 101-125
		104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124,
		// 126-150
		129, 130, 131, 132, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150,
		// 151-175
		151, 152, 153, 156, 157, 158, 160, 161, 162, 163, 164, 165, 166, 168, 169, 170, 171, 172, 174, 175,
		// 176-200
		176, 177, 182, 183, 184, 185, 186, 187, 188,
		// 226-250
		243, 245, 248, 250,
		// 251-275
		269, 270, 271,
		// 276-300
		276,
		// 301-325
		302, 303, 304, 305, 306, 308, 309, 310, 313, 315, 316, 317, 318, 319, 321, 322, 323, 324, 325,
		// 326-350
		326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350,
		// 351-375
		351, 352, 353, 356, 357, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372,
		// 376-400
		376, 377, 378, 379, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400,
		// 401-425
		401, 402, 403, 404, 406, 408, 409, 410, 411, 412, 413, 414, 415, 416, 419, 420, 421, 422, 423, 424, 425,
		// 426-450
		426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439,
		// 451-475
		459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 472, 473,
		// 476-500
		476, 477, 478, 479, 480, 481, 482, 483, 484,
		// 501-525
		524, 525,
		// 526-550
		526, 527, 528, 529, 530, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549,
		// 551-575
		554, 555, 556, 557, 558, 573, 575,
		// 576-600
		576, 577, 578, 579, 580, 581, 582, 583, 584, 585, 586, 587, 588, 589, 590, 591, 592, 593, 594, 595, 596, 597, 598,
		// 601-625
		602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613
	];

	public static readonly Tuple<int, int, int>[] AXTagTrainerIndexes =
	[
		new(439, 438, -1),  // Route 7, Trevor & Tierno
		new(108, 111, -1),  // Glittering Cave, Team Flare Grunts
		new(348, 350, -1),  // Poke Ball Factory, Celosia & Bryony
		new(470, 611, -1),  // Team Flare Secret HQ, Admin & Grunt 1
		new(476, 612, -2),  // Team Flare Secret HQ, Admin & Grunt 2
		new(472, 610, -3),  // Team Flare Secret HQ, Admin & Grunt 3
	];

	public static readonly Dictionary<string, string> AXPokemonFormNamesSite = new()
	{
		{ "Basculin 1", 	"Basculin-Blue-Striped" },
		{ "Deoxys 1",		"Deoxys-Attack" },
		{ "Deoxys 2",		"Deoxys-Defense" },
		{ "Deoxys 3",		"Deoxys-Speed" },
		{ "Wormadam 1",		"Wormadam-Sandy" },
		{ "Wormadam 2",		"Wormadam-Trash" },
		{ "Shaymin 1",		"Shaymin-Sky" },
		{ "Giratina 1",		"Giratina-Origin" },
		{ "Rotom 1",		"Rotom-Heat" },
		{ "Rotom 2",		"Rotom-Wash" },
		{ "Rotom 3",		"Rotom-Frost" },
		{ "Rotom 4",		"Rotom-Fan" },
		{ "Rotom 5",		"Rotom-Mow" },
		{ "Castform 1",		"Castform-Sunny" },
		{ "Castform 2",		"Castform-Rainy" },
		{ "Castform 3",		"Castform-Snowy" },
		{ "Cherrim 1",		"Cherrim-Sunshine" },
		{ "Darmanitan 1",	"Darmanitan-Zen" },
		{ "Meloetta 1",		"Meloetta-Pirouette" },
		{ "Kyurem 1",		"Kyurem-White" },
		{ "Kyurem 2",		"Kyurem-Black" },
		{ "Keldeo 1",		"Keldeo-Resolute" },
		{ "Tornadus 1",		"Tornadus-Therian" },
		{ "Thundurus 1",	"Thundurus-Therian" },
		{ "Landorus 1",		"Landorus-Therian" },
		{ "Meowstic 1",		"Meowstic-F" },
		// Skipping Furfrous
		{ "Charizard 1",	"Charizard-Mega-X" },
		{ "Charizard 2",	"Charizard-Mega-Y" },
		{ "Mewtwo 1",		"Mewtwo-Mega-X" },
		{ "Mewtwo 2",		"Mewtwo-Mega-Y" },
		{ "Aegislash 1",	"Aegislash-Blade" },
		{ "Pumpkaboo 1",	"Pumpkaboo-Small" },
		{ "Pumpkaboo 2",	"Pumpkaboo-Large" },
		{ "Pumpkaboo 3",	"Pumpkaboo-Super" },
		{ "Gourgeist 1",	"Gourgeist-Small" },
		{ "Gourgeist 2",	"Gourgeist-Large" },
		{ "Gourgeist 3",	"Gourgeist-Super" },
		// Skipping Floettes
		// Adding in conversion for cosmetic forms to default
		{ "Gastrodon 1",	"Gastrodon" },
		{ "Sawsbuck 1",		"Sawsbuck" },
		{ "Sawsbuck 2",		"Sawsbuck" },
		{ "Sawsbuck 3",		"Sawsbuck" },
		{ "Vivillon 1",		"Vivillon" },
		{ "Vivillon 2",		"Vivillon" },
		{ "Vivillon 3",		"Vivillon" },
		{ "Vivillon 4",		"Vivillon" },
		{ "Vivillon 5",		"Vivillon" },
		{ "Vivillon 6",		"Vivillon" },
		{ "Vivillon 7",		"Vivillon" },
		{ "Vivillon 8",		"Vivillon" },
		{ "Vivillon 9",		"Vivillon" },
		{ "Vivillon 10",	"Vivillon" },
		{ "Vivillon 11",	"Vivillon" },
		{ "Vivillon 12",	"Vivillon" },
		{ "Vivillon 13",	"Vivillon" },
		{ "Vivillon 14",	"Vivillon" },
		{ "Vivillon 15",	"Vivillon" },
		{ "Vivillon 16",	"Vivillon" },
		{ "Vivillon 17",	"Vivillon" },
		{ "Vivillon 18",	"Vivillon" },
		{ "Vivillon 19",	"Vivillon" },
	};

	public static readonly Dictionary<string, AXExtraRouteInfo> RouteMappings = new()
	{
		{ "Aquacorde Town",					AXExtraRouteInfo.Create(true) },
		{ "Route 2",						AXExtraRouteInfo.Create(true) },
		{ "Santalune Forest",				AXExtraRouteInfo.Create(true) },
		{ "Route 3",						AXExtraRouteInfo.Create(true) },
		{ "Route 22",                       AXExtraRouteInfo.Create(false, "This route is technically optional, though you probably want the Pokémon catch here before the first gym.") },
		{ "Santalune City",					AXExtraRouteInfo.Create(true) },
		{ "Santalune Gym",					AXExtraRouteInfo.Create(true) },
		{ "Route 4",						AXExtraRouteInfo.Create(true) },
		{ "Lumiose City",					AXExtraRouteInfo.Create(true) },
		{ "Route 5",						AXExtraRouteInfo.Create(true) },
		{ "Route 6 - Pathway",				AXExtraRouteInfo.Create(true) },
		{ "Route 6 - West",                 AXExtraRouteInfo.Create(false) },
		{ "Route 6 - East",					AXExtraRouteInfo.Create(false) },
		{ "Route 7",						AXExtraRouteInfo.Create(true) },
		{ "Connecting Cave",				AXExtraRouteInfo.Create(true) },
		{ "Route 8 - Upper",				AXExtraRouteInfo.Create(true) },
		{ "Glittering Cave",				AXExtraRouteInfo.Create(true) },
		{ "Route 8 - Lower",				AXExtraRouteInfo.Create(true) },
		{ "Cyllage Gym",					AXExtraRouteInfo.Create(true) },
		{ "Route 10",						AXExtraRouteInfo.Create(true) },
		{ "Geosenge Town",					AXExtraRouteInfo.Create(true) },
		{ "Route 11",						AXExtraRouteInfo.Create(true) },
		{ "Reflection Cave - 1F",			AXExtraRouteInfo.Create(true) },
		{ "Reflection Cave - B1F",			AXExtraRouteInfo.Create(true) },
		{ "Tower of Mastery",				AXExtraRouteInfo.Create(true) },
		{ "Shalour Gym",					AXExtraRouteInfo.Create(true) },
		{ "Route 12",						AXExtraRouteInfo.Create(true) },
		{ "Azure Bay",						AXExtraRouteInfo.Create(false) },
		{ "Coumarine City",					AXExtraRouteInfo.Create(true) },
		{ "Coumarine Gym",					AXExtraRouteInfo.Create(true) },
		{ "Route 13",						AXExtraRouteInfo.Create(true) },
		{ "Kalos Power Plant",				AXExtraRouteInfo.Create(true) },
		{ "Lumiose Gym",					AXExtraRouteInfo.Create(true) },
		{ "Route 14",						AXExtraRouteInfo.Create(true) },
		{ "Laverre Gym",					AXExtraRouteInfo.Create(true) },
		{ "Poke Ball Factory",				AXExtraRouteInfo.Create(true) },
		{ "Route 15",						AXExtraRouteInfo.Create(true) },
		{ "Route 16",						AXExtraRouteInfo.Create(false) },
		{ "Lost Hotel - Route 15 Side",		AXExtraRouteInfo.Create(false) },
		{ "Lost Hotel - Route 16 Side",		AXExtraRouteInfo.Create(false) },
		{ "Frost Cavern - Outside",			AXExtraRouteInfo.Create(true) },
		{ "Frost Cavern - 1F",				AXExtraRouteInfo.Create(true) },
		{ "Frost Cavern - 2F",				AXExtraRouteInfo.Create(true) },
		{ "Frost Cavern - 3F",				AXExtraRouteInfo.Create(true) },
		{ "Anistar City",					AXExtraRouteInfo.Create(true) },
		{ "Anistar Gym",					AXExtraRouteInfo.Create(true) },
		{ "Lysandre Cafe",					AXExtraRouteInfo.Create(true) },
		{ "Lysandre Labs - B1",				AXExtraRouteInfo.Create(true) },
		{ "Lysandre Labs - B3",				AXExtraRouteInfo.Create(true) },
		{ "Geosenge Town - Part 2",			AXExtraRouteInfo.Create(true) },
		{ "Team Flare Secret HQ - 1F",		AXExtraRouteInfo.Create(true) },
		{ "Team Flare Secret HQ - Walkway", AXExtraRouteInfo.Create(true) },
		{ "Route 18",						AXExtraRouteInfo.Create(true) },
		{ "Terminus Cave - B1F",			AXExtraRouteInfo.Create(false) },
		{ "Terminus Cave - B2F",			AXExtraRouteInfo.Create(false) },
		{ "Couriway Town",					AXExtraRouteInfo.Create(true) },
		{ "Route 19",						AXExtraRouteInfo.Create(true) },
		{ "Route 20",						AXExtraRouteInfo.Create(true) },
		{ "Snowbelle Gym",					AXExtraRouteInfo.Create(true) },
		{ "Route 21",						AXExtraRouteInfo.Create(true) },
		{ "Route 22 - Part 2",				AXExtraRouteInfo.Create(false) },
		{ "Victory Road - Entrance",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Inside 1",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Outside 2",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Inside 2",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Outside 3",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Inside 3",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Outside 4",		AXExtraRouteInfo.Create(true) },
		{ "Victory Road - Inside 4",		AXExtraRouteInfo.Create(true) },
		{ "Elite Four",						AXExtraRouteInfo.Create(true, "The Elite Four may be challenged in any order you choose.\n\nHowever, because of the addition of the Mobile PC, you are able to adjust your team between fights.\n\nThe choice to do so is ultimately up to you, but the intended design is that your team will be locked in upon entering the Elite 4, as per the base game.") },
		{ "Kalos League Champion",			AXExtraRouteInfo.Create(true) },
		{ "Lumiose Parade",					AXExtraRouteInfo.Create(false, "I'm not sure whether most players will consider the challenge complete upon defeating Diantha or upon defeating AZ.\n\nAs such, I leave it up to you to choose whether or not you wish to consider AZ optional or mandatory.") },
	};

	public static readonly Dictionary<int, AXExtraTrainerInfo> TrainerIDToRoute = new()
	{
		{ 137,	AXExtraTrainerInfo.Create("Aquacorde Town",					"Mandatory",		"If Starter is Chespin",	true) },
		{ 138,	AXExtraTrainerInfo.Create("Aquacorde Town",					"Mandatory",		"If Starter is Fennekin"		) },
		{ 139,	AXExtraTrainerInfo.Create("Aquacorde Town",					"Mandatory",		"If Starter is Froakie"			) },
		
		{ 37,	AXExtraTrainerInfo.Create("Route 2",						"Mandatory",		true) },

		{ 36,	AXExtraTrainerInfo.Create("Santalune Forest",				"Mandatory",		true) },
		{ 45,	AXExtraTrainerInfo.Create("Santalune Forest",				"Mandatory"				) },
		{ 3,	AXExtraTrainerInfo.Create("Santalune Forest",				"Optional"				) },

		{ 55,	AXExtraTrainerInfo.Create("Route 3",						"Mandatory",		true) },
		{ 57,	AXExtraTrainerInfo.Create("Route 3",						"Mandatory"				) },
		{ 52,	AXExtraTrainerInfo.Create("Route 3",						"Optional"				) },
		{ 49,	AXExtraTrainerInfo.Create("Route 3",						"Optional"				) },

		{ 61,	AXExtraTrainerInfo.Create("Route 22",						"Mandatory",		true) },
		{ 46,	AXExtraTrainerInfo.Create("Route 22",						"Mandatory"				) },
		{ 59,	AXExtraTrainerInfo.Create("Route 22",						"Optional"				) },
		{ 50,	AXExtraTrainerInfo.Create("Route 22",						"Optional"				) },
		{ 53,	AXExtraTrainerInfo.Create("Route 22",						"Optional"				) },
		{ 47,	AXExtraTrainerInfo.Create("Route 22",						"Optional"				) },

		{ 166,	AXExtraTrainerInfo.Create("Santalune City",					"Mandatory",		true) },

		{ 39,	AXExtraTrainerInfo.Create("Santalune Gym",					"Optional",			true) },
		{ 40,	AXExtraTrainerInfo.Create("Santalune Gym",					"Optional"				) },
		{ 48,	AXExtraTrainerInfo.Create("Santalune Gym",					"Mandatory"				) },
		{ 6,	AXExtraTrainerInfo.Create("Santalune Gym",					"Mandatory"				) },

		{ 70,	AXExtraTrainerInfo.Create("Route 4",						"Optional",			"In the SW hedge maze",	true) },
		{ 459,	AXExtraTrainerInfo.Create("Route 4",						"ChoiceMandatory",	"Choice Pair w/ Calida"		) },
		{ 460,	AXExtraTrainerInfo.Create("Route 4",						"ChoiceMandatory",	"Choice Pair w/ Roland"		) },
		{ 68,	AXExtraTrainerInfo.Create("Route 4",						"ChoiceMandatory",	"Choice Pair w/ Mia"		) },
		{ 58,	AXExtraTrainerInfo.Create("Route 4",						"ChoiceMandatory",	"Choice Pair w/ Agnes"		) },
		{ 56,	AXExtraTrainerInfo.Create("Route 4",						"ChoiceMandatory",	"Choice Pair w/ Gabe"		) },
		{ 67,	AXExtraTrainerInfo.Create("Route 4",						"ChoiceMandatory",	"Choice Pair w/ Adrian"		) },
		{ 71,	AXExtraTrainerInfo.Create("Route 4",						"Optional",			"In the NE hedge maze"		) },
		{ 72,	AXExtraTrainerInfo.Create("Route 4",						"Optional",			"In the NW hedge maze"		) },

		{ 327,	AXExtraTrainerInfo.Create("Lumiose City",					"Mandatory",		true) },

		{ 88,	AXExtraTrainerInfo.Create("Route 5",						"Mandatory",		true) },
		{ 573,	AXExtraTrainerInfo.Create("Route 5",						"Mandatory"				) },
		{ 60,	AXExtraTrainerInfo.Create("Route 5",						"Mandatory"				) },
		{ 164,	AXExtraTrainerInfo.Create("Route 5",						"Optional"				) },
		{ 165,	AXExtraTrainerInfo.Create("Route 5",						"Optional"				) },
		{ 603,	AXExtraTrainerInfo.Create("Route 5",						"Mandatory"				) },
		{ 85,	AXExtraTrainerInfo.Create("Route 5",						"Mandatory"				) },
		{ 41,	AXExtraTrainerInfo.Create("Route 5",						"Mandatory"				) },

		{ 80,	AXExtraTrainerInfo.Create("Route 6 - Pathway",				"Mandatory",		true) },
		{ 79,	AXExtraTrainerInfo.Create("Route 6 - Pathway",				"Mandatory"				) },

		{ 69,	AXExtraTrainerInfo.Create("Route 6 - West",					"Mandatory",		true) },
		{ 89,	AXExtraTrainerInfo.Create("Route 6 - West",					"Optional"				) },
		{ 44,	AXExtraTrainerInfo.Create("Route 6 - West",					"Optional"				) },
		{ 87,	AXExtraTrainerInfo.Create("Route 6 - West",					"Optional"				) },

		{ 86,	AXExtraTrainerInfo.Create("Route 6 - East",					"Mandatory",		true) },
		{ 43,	AXExtraTrainerInfo.Create("Route 6 - East",					"Optional"				) },
		{ 78,	AXExtraTrainerInfo.Create("Route 6 - East",					"Mandatory"				) },
		{ 77,	AXExtraTrainerInfo.Create("Route 6 - East",					"Optional"				) },

		{ 91,	AXExtraTrainerInfo.Create("Route 7",						"Mandatory",		true					) },
		{ 92,	AXExtraTrainerInfo.Create("Route 7",						"Optional"									) },
		{ 90,	AXExtraTrainerInfo.Create("Route 7",						"Mandatory"									) },
		{ 596,	AXExtraTrainerInfo.Create("Route 7",						"DoublesPartner",	"If Starter is Chespin"	) },
		{ 597,	AXExtraTrainerInfo.Create("Route 7",						"DoublesPartner",	"If Starter is Fennekin") },
		{ 598,	AXExtraTrainerInfo.Create("Route 7",						"DoublesPartner",	"If Starter is Froakie"	) },
		{ 435,	AXExtraTrainerInfo.Create("Route 7",						"DoublesPartner",	"If Starter is Chespin"	) },
		{ 436,	AXExtraTrainerInfo.Create("Route 7",						"DoublesPartner",	"If Starter is Fennekin") },
		{ 437,	AXExtraTrainerInfo.Create("Route 7",						"DoublesPartner",	"If Starter is Froakie"	) },
		{ 438,	AXExtraTrainerInfo.Create("Route 7",						"Mandatory",		true,	false			) },
		{ 439,	AXExtraTrainerInfo.Create("Route 7",						"Mandatory",		true,	false			) },

		{ 95,	AXExtraTrainerInfo.Create("Connecting Cave",				"Mandatory",		true) },

		{ 481,	AXExtraTrainerInfo.Create("Route 8 - Upper",				"Mandatory",		true) },
		{ 480,	AXExtraTrainerInfo.Create("Route 8 - Upper",				"Mandatory"				) },
		{ 104,	AXExtraTrainerInfo.Create("Route 8 - Upper",				"Mandatory"				) },

		{ 107,	AXExtraTrainerInfo.Create("Glittering Cave",				"Mandatory",		true					) },
		{ 110,	AXExtraTrainerInfo.Create("Glittering Cave",				"Mandatory"									) },
		{ 575,	AXExtraTrainerInfo.Create("Glittering Cave",				"DoublesPartner",	"If Starter is Chespin"	) },
		{ 576,	AXExtraTrainerInfo.Create("Glittering Cave",				"DoublesPartner",	"If Starter is Fennekin") },
		{ 577,	AXExtraTrainerInfo.Create("Glittering Cave",				"DoublesPartner",	"If Starter is Froakie"	) },
		{ 130,	AXExtraTrainerInfo.Create("Glittering Cave",				"DoublesPartner",	"If Starter is Chespin"	) },
		{ 131,	AXExtraTrainerInfo.Create("Glittering Cave",				"DoublesPartner",	"If Starter is Fennekin") },
		{ 132,	AXExtraTrainerInfo.Create("Glittering Cave",				"DoublesPartner",	"If Starter is Froakie"	) },
		{ 108,	AXExtraTrainerInfo.Create("Glittering Cave",				"Mandatory",		true,	false			) },
		{ 111,	AXExtraTrainerInfo.Create("Glittering Cave",				"Mandatory",		true,	false			) },

		{ 99,	AXExtraTrainerInfo.Create("Route 8 - Lower",				"Mandatory",		true					) },
		{ 97,	AXExtraTrainerInfo.Create("Route 8 - Lower",				"ChoiceMandatory",	"Choice Pair w/ Wharton") },
		{ 96,	AXExtraTrainerInfo.Create("Route 8 - Lower",				"ChoiceMandatory",	"Choice Pair w/ Shad"	) },
		{ 100,	AXExtraTrainerInfo.Create("Route 8 - Lower",				"Mandatory"									) },

		{ 64,	AXExtraTrainerInfo.Create("Cyllage Gym",					"Mandatory",		true) },
		{ 106,	AXExtraTrainerInfo.Create("Cyllage Gym",					"Mandatory"				) },
		{ 63,	AXExtraTrainerInfo.Create("Cyllage Gym",					"Mandatory"				) },
		{ 105,	AXExtraTrainerInfo.Create("Cyllage Gym",					"Mandatory"				) },
		{ 76,	AXExtraTrainerInfo.Create("Cyllage Gym",					"Mandatory"				) },

		{ 484,	AXExtraTrainerInfo.Create("Route 10",						"Mandatory",		true									) },
		{ 81,	AXExtraTrainerInfo.Create("Route 10",						"Mandatory"													) },
		{ 109,	AXExtraTrainerInfo.Create("Route 10",						"Mandatory",		"Appears after defeating Cyllage Gym"	) },
		{ 113,	AXExtraTrainerInfo.Create("Route 10",						"Optional"													) },
		{ 129,	AXExtraTrainerInfo.Create("Route 10",						"Mandatory",		"Appears after defeating Cyllage Gym"	) },
		{ 82,	AXExtraTrainerInfo.Create("Route 10",						"Mandatory"													) },
		{ 112,	AXExtraTrainerInfo.Create("Route 10",						"Mandatory",		"Appears after defeating Cyllage Gym"	) },

		{ 613,	AXExtraTrainerInfo.Create("Geosenge Town",					"Mandatory",		true) },

		{ 115,	AXExtraTrainerInfo.Create("Route 11",						"Mandatory",		true) },
		{ 116,	AXExtraTrainerInfo.Create("Route 11",						"Mandatory"				) },
		{ 114,	AXExtraTrainerInfo.Create("Route 11",						"Mandatory"				) },

		{ 144,	AXExtraTrainerInfo.Create("Reflection Cave - 1F",			"Mandatory",		true) },
		{ 162,	AXExtraTrainerInfo.Create("Reflection Cave - 1F",			"Mandatory"				) },
		{ 145,	AXExtraTrainerInfo.Create("Reflection Cave - 1F",			"Mandatory"				) },
		{ 153,	AXExtraTrainerInfo.Create("Reflection Cave - 1F",			"Mandatory",		"Last fight of Reflection Cave. Occurs after you come back up from B1F.") },

		{ 142,	AXExtraTrainerInfo.Create("Reflection Cave - B1F",			"Mandatory",		true) },
		{ 163,	AXExtraTrainerInfo.Create("Reflection Cave - B1F",			"Mandatory"				) },
		{ 143,	AXExtraTrainerInfo.Create("Reflection Cave - B1F",			"Mandatory"				) },
		{ 141,	AXExtraTrainerInfo.Create("Reflection Cave - B1F",			"Mandatory"				) },
		{ 140,	AXExtraTrainerInfo.Create("Reflection Cave - B1F",			"Mandatory"				) },
		{ 27,	AXExtraTrainerInfo.Create("Reflection Cave - B1F",			"Mandatory"				) },

		{ 581,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"If Starter is Chespin",	true	) },
		{ 582,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"If Starter is Fennekin"			) },
		{ 583,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"If Starter is Froakie"				) },
		{ 329,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"If Starter is Chespin"				) },
		{ 330,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"If Starter is Fennekin"			) },
		{ 331,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"If Starter is Froakie"				) },
		{ 188,	AXExtraTrainerInfo.Create("Tower of Mastery",				"Mandatory",		"Occurs after defeating Shalour Gym") },

		{ 83,	AXExtraTrainerInfo.Create("Shalour Gym",					"Mandatory",		"Southeast",	true) },
		{ 147,	AXExtraTrainerInfo.Create("Shalour Gym",					"Mandatory",		"Southwest"			) },
		{ 84,	AXExtraTrainerInfo.Create("Shalour Gym",					"Mandatory",		"Northwest"			) },
		{ 146,	AXExtraTrainerInfo.Create("Shalour Gym",					"Mandatory",		"Northeast"			) },
		{ 21,	AXExtraTrainerInfo.Create("Shalour Gym",					"Mandatory"								) },

		{ 152,	AXExtraTrainerInfo.Create("Route 12",						"Optional",			true) },
		{ 148,	AXExtraTrainerInfo.Create("Route 12",						"Mandatory"				) },
		{ 151,	AXExtraTrainerInfo.Create("Route 12",						"Optional"				) },
		{ 1,	AXExtraTrainerInfo.Create("Route 12",						"Optional"				) },
		{ 150,	AXExtraTrainerInfo.Create("Route 12",						"Mandatory"				) },

		{ 149,	AXExtraTrainerInfo.Create("Azure Bay",						"Mandatory",		true) },
		{ 482,	AXExtraTrainerInfo.Create("Azure Bay",						"Mandatory"				) },
		{ 483,	AXExtraTrainerInfo.Create("Azure Bay",						"Mandatory"				) },
		{ 524,	AXExtraTrainerInfo.Create("Azure Bay",						"Optional"				) },
		{ 98,	AXExtraTrainerInfo.Create("Azure Bay",						"Optional"				) },

		{ 578,	AXExtraTrainerInfo.Create("Coumarine City",					"Mandatory",		"If Starter is Chespin",	true) },
		{ 579,	AXExtraTrainerInfo.Create("Coumarine City",					"Mandatory",		"If Starter is Fennekin"		) },
		{ 580,	AXExtraTrainerInfo.Create("Coumarine City",					"Mandatory",		"If Starter is Froakie"			) },
		{ 184,	AXExtraTrainerInfo.Create("Coumarine City",					"Mandatory",		"If Starter is Chespin"			) },
		{ 185,	AXExtraTrainerInfo.Create("Coumarine City",					"Mandatory",		"If Starter is Fennekin"		) },
		{ 186,	AXExtraTrainerInfo.Create("Coumarine City",					"Mandatory",		"If Starter is Froakie"			) },

		{ 123,	AXExtraTrainerInfo.Create("Coumarine Gym",					"Mandatory",		true) },
		{ 124,	AXExtraTrainerInfo.Create("Coumarine Gym",					"Optional"				) },
		{ 121,	AXExtraTrainerInfo.Create("Coumarine Gym",					"Mandatory"				) },
		{ 122,	AXExtraTrainerInfo.Create("Coumarine Gym",					"Mandatory"				) },
		{ 22,	AXExtraTrainerInfo.Create("Coumarine Gym",					"Mandatory"				) },

		{ 308,	AXExtraTrainerInfo.Create("Route 13",						"Mandatory",		true) },

		{ 183,	AXExtraTrainerInfo.Create("Kalos Power Plant",				"Mandatory",		true) },
		{ 182,	AXExtraTrainerInfo.Create("Kalos Power Plant",				"Mandatory"				) },
		{ 176,	AXExtraTrainerInfo.Create("Kalos Power Plant",				"Mandatory"				) },
		{ 177,	AXExtraTrainerInfo.Create("Kalos Power Plant",				"Mandatory"				) },
		{ 174,	AXExtraTrainerInfo.Create("Kalos Power Plant",				"Mandatory"				) },
		{ 175,	AXExtraTrainerInfo.Create("Kalos Power Plant",				"Mandatory"				) },

		{ 461,	AXExtraTrainerInfo.Create("Lumiose Gym",					"Mandatory",		true) },
		{ 464,	AXExtraTrainerInfo.Create("Lumiose Gym",					"Mandatory"				) },
		{ 28,	AXExtraTrainerInfo.Create("Lumiose Gym",					"Mandatory"				) },
		{ 467,	AXExtraTrainerInfo.Create("Lumiose Gym",					"Mandatory"				) },
		{ 23,	AXExtraTrainerInfo.Create("Lumiose Gym",					"Mandatory"				) },

		{ 584,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory",		"If Starter is Chespin",	true) },
		{ 585,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory",		"If Starter is Fennekin"		) },
		{ 586,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory",		"If Starter is Froakie"			) },
		{ 332,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory",		"If Starter is Chespin"			) },
		{ 333,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory",		"If Starter is Fennekin"		) },
		{ 334,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory",		"If Starter is Froakie"			) },
		{ 158,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory"											) },
		{ 161,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory"											) },
		{ 157,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory"											) },
		{ 160,	AXExtraTrainerInfo.Create("Route 14",						"Mandatory"											) },
		{ 156,	AXExtraTrainerInfo.Create("Route 14",						"Optional"											) },

		{ 245,	AXExtraTrainerInfo.Create("Laverre Gym",					"ChoiceMandatory",	"Choice Pair w/ Linnea",	true) },
		{ 250,	AXExtraTrainerInfo.Create("Laverre Gym",					"ChoiceMandatory",	"Choice Pair w/ Kali"			) },
		{ 248,	AXExtraTrainerInfo.Create("Laverre Gym",					"Mandatory"											) },
		{ 243,	AXExtraTrainerInfo.Create("Laverre Gym",					"Mandatory"											) },
		{ 24,	AXExtraTrainerInfo.Create("Laverre Gym",					"Mandatory"											) },

		{ 305,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory",		"First Grunt encountered after using the conveyer belts.",	true) },
		{ 315,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory",		"In front of the staircase,	guarding the way up."				) },
		{ 306,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory",		"Watching the walkway after you go up the first set of stairs. Can be encountered first if you want.") },
		{ 316,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory",		"Guarding the doorway on the upper floor."						) },
		{ 607,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"DoublesPartner",	"If Starter is Chespin"											) },
		{ 608,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"DoublesPartner",	"If Starter is Fennekin"										) },
		{ 609,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"DoublesPartner",	"If Starter is Froakie"											) },
		{ 604,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"DoublesPartner",	"If Starter is Chespin"											) },
		{ 605,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"DoublesPartner",	"If Starter is Fennekin"										) },
		{ 606,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"DoublesPartner",	"If Starter is Froakie"											) },
		{ 304,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory"																			) },
		{ 348,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory",		true,						false								) },
		{ 350,	AXExtraTrainerInfo.Create("Poke Ball Factory",				"Mandatory",		true,						false								) },

		{ 430,	AXExtraTrainerInfo.Create("Route 15",						"Mandatory",		true					) },
		{ 431,	AXExtraTrainerInfo.Create("Route 15",						"Mandatory"									) },
		{ 362,	AXExtraTrainerInfo.Create("Route 15",						"ChoiceMandatory",	"Choice Pair w/ Dean"	) },
		{ 429,	AXExtraTrainerInfo.Create("Route 15",						"ChoiceMandatory",	"Choice Pair w/ Luna"	) },
		{ 428,	AXExtraTrainerInfo.Create("Route 15",						"Mandatory"									) },
		{ 403,	AXExtraTrainerInfo.Create("Route 15",						"Mandatory"									) },
		{ 410,	AXExtraTrainerInfo.Create("Route 15",						"Mandatory"									) },
		{ 363,	AXExtraTrainerInfo.Create("Route 15",						"Optional"									) },

		{ 423,	AXExtraTrainerInfo.Create("Route 16",						"ChoiceMandatory",	"Top - Choice Pair w/ Olle",	true) },
		{ 422,	AXExtraTrainerInfo.Create("Route 16",						"ChoiceMandatory",	"Left - Choice Pair w/ Jet"			) },
		{ 549,	AXExtraTrainerInfo.Create("Route 16",						"Mandatory"												) },
		{ 364,	AXExtraTrainerInfo.Create("Route 16",						"Optional"												) },
		{ 548,	AXExtraTrainerInfo.Create("Route 16",						"Mandatory"												) },
		{ 404,	AXExtraTrainerInfo.Create("Route 16",						"Mandatory"												) },
		{ 411,	AXExtraTrainerInfo.Create("Route 16",						"Mandatory"												) },
		{ 396,	AXExtraTrainerInfo.Create("Route 16",						"Optional"												) },
		{ 395,	AXExtraTrainerInfo.Create("Route 16",						"Optional"												) },
		{ 394,	AXExtraTrainerInfo.Create("Route 16",						"Optional"												) },

		{ 389,	AXExtraTrainerInfo.Create("Lost Hotel - Route 15 Side",		"Mandatory",		true) },
		{ 388,	AXExtraTrainerInfo.Create("Lost Hotel - Route 15 Side",		"Optional"				) },
		{ 427,	AXExtraTrainerInfo.Create("Lost Hotel - Route 15 Side",		"Mandatory"				) },

		{ 391,	AXExtraTrainerInfo.Create("Lost Hotel - Route 16 Side",		"Mandatory",		true) },
		{ 390,	AXExtraTrainerInfo.Create("Lost Hotel - Route 16 Side",		"Mandatory"				) },
		{ 392,	AXExtraTrainerInfo.Create("Lost Hotel - Route 16 Side",		"Mandatory"				) },

		{ 416,	AXExtraTrainerInfo.Create("Frost Cavern - Outside",			"Mandatory",		true) },
		{ 372,	AXExtraTrainerInfo.Create("Frost Cavern - Outside",			"Mandatory"				) },

		{ 353,	AXExtraTrainerInfo.Create("Frost Cavern - 1F",				"Mandatory",		true										) },
		{ 413,	AXExtraTrainerInfo.Create("Frost Cavern - 1F",				"Mandatory"														) },
		{ 357,	AXExtraTrainerInfo.Create("Frost Cavern - 1F",				"Mandatory",		"Occurs after you come back down from 2F"	) },

		{ 414,	AXExtraTrainerInfo.Create("Frost Cavern - 2F",				"Mandatory",		true						) },
		{ 379,	AXExtraTrainerInfo.Create("Frost Cavern - 2F",				"ChoiceMandatory",	"Choice Pair w/ Alonzo"		) },
		{ 367,	AXExtraTrainerInfo.Create("Frost Cavern - 2F",				"ChoiceMandatory",	"Choice Pair w/ Eoin & Wolf") },
		{ 397,	AXExtraTrainerInfo.Create("Frost Cavern - 2F",				"Mandatory"										) },

		{ 415,	AXExtraTrainerInfo.Create("Frost Cavern - 3F",				"Mandatory",		true) },
		{ 368,	AXExtraTrainerInfo.Create("Frost Cavern - 3F",				"Mandatory"				) },
		{ 398,	AXExtraTrainerInfo.Create("Frost Cavern - 3F",				"Optional"				) },
		{ 317,	AXExtraTrainerInfo.Create("Frost Cavern - 3F",				"Mandatory"				) },
		{ 346,	AXExtraTrainerInfo.Create("Frost Cavern - 3F",				"Mandatory"				) },

		{ 587,	AXExtraTrainerInfo.Create("Anistar City",					"Mandatory",		"If Starter is Chespin",	true) },
		{ 588,	AXExtraTrainerInfo.Create("Anistar City",					"Mandatory",		"If Starter is Fennekin"		) },
		{ 589,	AXExtraTrainerInfo.Create("Anistar City",					"Mandatory",		"If Starter is Froakie"			) },
		{ 335,	AXExtraTrainerInfo.Create("Anistar City",					"Mandatory",		"If Starter is Chespin"			) },
		{ 336,	AXExtraTrainerInfo.Create("Anistar City",					"Mandatory",		"If Starter is Fennekin"		) },
		{ 337,	AXExtraTrainerInfo.Create("Anistar City",					"Mandatory",		"If Starter is Froakie"			) },

		{ 170,	AXExtraTrainerInfo.Create("Anistar Gym",					"Mandatory",		true) },
		{ 171,	AXExtraTrainerInfo.Create("Anistar Gym",					"Optional"				) },
		{ 172,	AXExtraTrainerInfo.Create("Anistar Gym",					"Optional"				) },
		{ 366,	AXExtraTrainerInfo.Create("Anistar Gym",					"Optional"				) },
		{ 365,	AXExtraTrainerInfo.Create("Anistar Gym",					"Optional"				) },
		{ 25,	AXExtraTrainerInfo.Create("Anistar Gym",					"Mandatory"				) },

		{ 326,	AXExtraTrainerInfo.Create("Lysandre Cafe",					"Mandatory",		"On the left side",			true) },
		{ 352,	AXExtraTrainerInfo.Create("Lysandre Cafe",					"Mandatory",		"In the back of the room"		) },

		{ 303,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory",		true) },
		{ 344,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory"				) },
		{ 318,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory"				) },
		{ 310,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory"				) },
		{ 349,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Optional",			"WARNING!\r\n\r\nThis is optional, but difficult. There is no rest between Celosia & Bryony! Be prepared!"			) },
		{ 351,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Optional",			"WARNING!\r\n\r\nThis is optional, but difficult. There is no rest between Celosia & Bryony! Be prepared!"			) },
		{ 309,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory"				) },
		{ 319,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory"				) },
		{ 347,	AXExtraTrainerInfo.Create("Lysandre Labs - B1",				"Mandatory"				) },

		{ 345,	AXExtraTrainerInfo.Create("Lysandre Labs - B3",				"Mandatory",		true) },

		{ 313,	AXExtraTrainerInfo.Create("Geosenge Town - Part 2",			"Mandatory",		true) },

		{ 525,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - 1F",		"Mandatory",		true) },

		{ 590,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"DoublesPartner",	"If Starter is Chespin",	true	) },
		{ 591,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"DoublesPartner",	"If Starter is Fennekin"			) },
		{ 592,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"DoublesPartner",	"If Starter is Froakie"				) },
		{ 338,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"DoublesPartner",	"If Starter is Chespin"				) },
		{ 339,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"DoublesPartner",	"If Starter is Fennekin"			) },
		{ 340,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"DoublesPartner",	"If Starter is Froakie"				) },
		{ 470,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		true,						false	) },
		{ 611,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		true,						false	) },
		{ 476,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		true,						false	) },
		{ 612,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		true,						false	) },
		{ 472,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		true,						false	) },
		{ 610,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		true,						false	) },
		{ 477,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		"Left (F)"							) },
		{ 478,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		"Middle Front (F)"					) },
		{ 479,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		"Right (M)"							) },
		{ 473,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory",		"Back (M)"							) },
		{ 526,	AXExtraTrainerInfo.Create("Team Flare Secret HQ - Walkway",	"Mandatory"												) },

		{ 393,	AXExtraTrainerInfo.Create("Route 18",						"Optional",			true) },
		{ 399,	AXExtraTrainerInfo.Create("Route 18",						"Mandatory"				) },
		{ 419,	AXExtraTrainerInfo.Create("Route 18",						"Mandatory"				) },
		{ 369,	AXExtraTrainerInfo.Create("Route 18",						"Optional"				) },
		{ 409,	AXExtraTrainerInfo.Create("Route 18",						"Mandatory"				) },

		{ 377,	AXExtraTrainerInfo.Create("Terminus Cave - B1F",			"Mandatory",		true															) },
		{ 420,	AXExtraTrainerInfo.Create("Terminus Cave - B1F",			"Mandatory"																			) },
		{ 421,	AXExtraTrainerInfo.Create("Terminus Cave - B1F",			"Optional"																			) },
		{ 376,	AXExtraTrainerInfo.Create("Terminus Cave - B1F",			"Mandatory"																			) },
		{ 378,	AXExtraTrainerInfo.Create("Terminus Cave - B1F",			"Mandatory",		"Occurs in the pre-Zygarde room after you come back up from B2F") },

		{ 400,	AXExtraTrainerInfo.Create("Terminus Cave - B2F",			"Mandatory",		true) },
		{ 371,	AXExtraTrainerInfo.Create("Terminus Cave - B2F",			"Optional"				) },
		{ 401,	AXExtraTrainerInfo.Create("Terminus Cave - B2F",			"Mandatory"				) },
		{ 370,	AXExtraTrainerInfo.Create("Terminus Cave - B2F",			"Mandatory"				) },
		{ 425,	AXExtraTrainerInfo.Create("Terminus Cave - B2F",			"Mandatory"				) },

		{ 328,	AXExtraTrainerInfo.Create("Couriway Town",					"Mandatory",		true) },

		{ 361,	AXExtraTrainerInfo.Create("Route 19",						"ChoiceMandatory",	"Choice Pair w/ Clementine",	true												) },
		{ 433,	AXExtraTrainerInfo.Create("Route 19",						"ChoiceMandatory",	"Choice Pair w/ Josette"															) },
		{ 426,	AXExtraTrainerInfo.Create("Route 19",						"Optional"																								) },
		{ 402,	AXExtraTrainerInfo.Create("Route 19",						"Optional"																								) },
		{ 434,	AXExtraTrainerInfo.Create("Route 19",						"Optional"																								) },
		{ 432,	AXExtraTrainerInfo.Create("Route 19",						"Optional"																								) },
		{ 412,	AXExtraTrainerInfo.Create("Route 19",						"Mandatory"																								) },
		{ 321,	AXExtraTrainerInfo.Create("Route 19",						"Mandatory",        "WARNING!\r\n\r\nThere is no rest between the Shauna and Tierno fights!\r\nBe prepared!"	) },
		{ 322,	AXExtraTrainerInfo.Create("Route 19",						"Mandatory",        "WARNING!\r\n\r\nThere is no rest between the Shauna and Tierno fights!\r\nBe prepared!"   ) },
		{ 323,	AXExtraTrainerInfo.Create("Route 19",						"Mandatory",        "WARNING!\r\n\r\nThere is no rest between the Shauna and Tierno fights!\r\nBe prepared!"   ) },
		{ 324,	AXExtraTrainerInfo.Create("Route 19",						"Mandatory",        "WARNING!\r\n\r\nThere is no rest between the Shauna and Tierno fights!\r\nBe prepared!"   ) },
		{ 325,	AXExtraTrainerInfo.Create("Route 19",						"Mandatory",        "Trevor is a friendly lad. He will heal you before you fight him.\r\n\r\nHowever, there is still no opportunity to change your team.") },

		{ 554,	AXExtraTrainerInfo.Create("Route 20",						"Mandatory",		true) },
		{ 556,	AXExtraTrainerInfo.Create("Route 20",						"Mandatory"				) },
		{ 557,	AXExtraTrainerInfo.Create("Route 20",						"Mandatory"				) },
		{ 555,	AXExtraTrainerInfo.Create("Route 20",						"Optional"				) },
		{ 558,	AXExtraTrainerInfo.Create("Route 20",						"Optional"				) },

		{ 169,	AXExtraTrainerInfo.Create("Snowbelle Gym",					"Mandatory",		true) },
		{ 32,	AXExtraTrainerInfo.Create("Snowbelle Gym",					"Mandatory"				) },
		{ 168,	AXExtraTrainerInfo.Create("Snowbelle Gym",					"Mandatory"				) },
		{ 31,	AXExtraTrainerInfo.Create("Snowbelle Gym",					"Mandatory"				) },
		{ 26,	AXExtraTrainerInfo.Create("Snowbelle Gym",					"Mandatory"				) },

		{ 356,	AXExtraTrainerInfo.Create("Route 21",						"Mandatory",		true) },
		{ 424,	AXExtraTrainerInfo.Create("Route 21",						"Mandatory"				) },
		{ 360,	AXExtraTrainerInfo.Create("Route 21",						"Mandatory"				) },
		{ 408,	AXExtraTrainerInfo.Create("Route 21",						"Optional"				) },
		{ 406,	AXExtraTrainerInfo.Create("Route 21",						"Optional"				) },

		{ 66,	AXExtraTrainerInfo.Create("Route 22 - Part 2",				"Mandatory",		true) },
		{ 65,	AXExtraTrainerInfo.Create("Route 22 - Part 2",				"Mandatory"				) },

		{ 302,	AXExtraTrainerInfo.Create("Victory Road - Entrance",		"Mandatory",		true) },

		{ 527,	AXExtraTrainerInfo.Create("Victory Road - Inside 1",		"Mandatory",		true) },
		{ 528,	AXExtraTrainerInfo.Create("Victory Road - Inside 1",		"Mandatory"				) },
		{ 529,	AXExtraTrainerInfo.Create("Victory Road - Inside 1",		"Mandatory"				) },

		{ 533,	AXExtraTrainerInfo.Create("Victory Road - Outside 2",		"Mandatory",		true) },

		{ 532,	AXExtraTrainerInfo.Create("Victory Road - Inside 2",		"Mandatory",		true) },
		{ 534,	AXExtraTrainerInfo.Create("Victory Road - Inside 2",		"Mandatory"				) },
		{ 547,	AXExtraTrainerInfo.Create("Victory Road - Inside 2",		"Mandatory"				) },
		{ 530,	AXExtraTrainerInfo.Create("Victory Road - Inside 2",		"Mandatory"				) },

		{ 536,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		true						) },
		{ 535,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory"										) },
		{ 593,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		"If Starter is Chespin"		) },
		{ 594,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		"If Starter is Fennekin"	) },
		{ 595,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		"If Starter is Froakie"		) },
		{ 341,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		"If Starter is Chespin"		) },
		{ 342,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		"If Starter is Fennekin"	) },
		{ 343,	AXExtraTrainerInfo.Create("Victory Road - Outside 3",		"Mandatory",		"If Starter is Froakie"		) },

		{ 543,	AXExtraTrainerInfo.Create("Victory Road - Inside 3",		"Mandatory",		true) },
		{ 539,	AXExtraTrainerInfo.Create("Victory Road - Inside 3",		"Mandatory"				) },
		{ 542,	AXExtraTrainerInfo.Create("Victory Road - Inside 3",		"Mandatory"				) },
		{ 537,	AXExtraTrainerInfo.Create("Victory Road - Inside 3",		"Mandatory"				) },

		{ 546,	AXExtraTrainerInfo.Create("Victory Road - Outside 4",		"Mandatory",		true) },
		{ 544,	AXExtraTrainerInfo.Create("Victory Road - Outside 4",		"Mandatory"				) },
		{ 545,	AXExtraTrainerInfo.Create("Victory Road - Outside 4",		"Mandatory"				) },

		{ 538,	AXExtraTrainerInfo.Create("Victory Road - Inside 4",		"Mandatory",		true) },
		{ 540,	AXExtraTrainerInfo.Create("Victory Road - Inside 4",		"Mandatory"				) },
		{ 541,	AXExtraTrainerInfo.Create("Victory Road - Inside 4",		"Mandatory"				) },

		{ 269,	AXExtraTrainerInfo.Create("Elite Four",						"Mandatory",		true) },
		{ 271,	AXExtraTrainerInfo.Create("Elite Four",						"Mandatory"				) },
		{ 187,	AXExtraTrainerInfo.Create("Elite Four",						"Mandatory"				) },
		{ 270,	AXExtraTrainerInfo.Create("Elite Four",						"Mandatory"				) },

		{ 276,	AXExtraTrainerInfo.Create("Kalos League Champion",			"Mandatory",		"For Illusion purposes, Entei is the set as the last member of the party.\r\n\r\nThis can mean that Zoroark copies either Entei or Diancie, as the AI will always send the mega out last.",	true) },

		{ 602,	AXExtraTrainerInfo.Create("Lumiose Parade",					"Mandatory",		"While you cannot change your party before AZ, your team will be fully healed.",	true) },
	};

	public static readonly Tuple<int, string>[] TrainerIDRenames =
	[
		new(461,	"Arno, Sherlock, & Finnian"),
		new(464,	"Estel, Nelly, & Helene"),
		new(28,		"Mathis, Maxim, & Rico"),
		new(467,	"Abigail, Lydie, & Tara")	
	];

	public static readonly int[] TrainerIDSkips =
	[
		462,	// Sherlock
		463,	// Finnian
		465,	// Nelly
		466,	// Helene
		29,		// Maxim
		30,		// Rico
		468,	// Lydie
		469,	// Tara
	];

	public static readonly Dictionary<int, string> BetterEvoMethodDesc = new()
	{
		// See pk3DS\Subforms\Gen6\EvolutionEditor6.cs for list
		{ 8,	"Use Item: PARAM" },
		{ 12,	"Level Up: PARAM (Random)" },
		{ 13,	"Level Up: PARAM (Random)" },
		{ 23,	"Level Up: PARAM (Male)" },
		{ 34,	"Level Up: PARAM (Female, Form Change)" }
	};

	public static string GetJSONPkmName(string pkmName, int cbIndex)
	{
		if (pkmName == "")
			return pkmName;

		pkmName = pkmName.Replace("’", "'");

		if (pkmName.Contains("Nidoran"))
		{
			if (cbIndex == 28 || cbIndex == 29)
				pkmName = pkmName.Substring(0, pkmName.Length - 1) + "-F";
			else if (cbIndex == 31 || cbIndex == 32)
				pkmName = pkmName.Substring(0, pkmName.Length - 1) + "-M";
		}

		if (AXPokemonFormNamesSite.TryGetValue(pkmName, out string value))
			pkmName = value;
		else if (pkmName.Substring(pkmName.Length - 1) == "1")
			pkmName = pkmName.Substring(0, pkmName.Length - 2) + "-Mega";

		return pkmName;
	}

	public static string GetJSONPkmName(ComboBox cb, bool fromPersonal = false)
	{
		string pkmName = fromPersonal ? cb.Text.Substring(0, cb.Text.Length - 6) : cb.Text;

		if (pkmName == "")
			return pkmName;

		pkmName = pkmName.Replace("’", "'");

		if (pkmName.Contains("Nidoran"))
		{
			if (cb.SelectedIndex == 28 || cb.SelectedIndex == 29)
				pkmName = pkmName.Substring(0, pkmName.Length - 1) + "-F";
			else if (cb.SelectedIndex == 31 || cb.SelectedIndex == 32)
				pkmName = pkmName.Substring(0, pkmName.Length - 1) + "-M";
		}

		if (AXPokemonFormNamesSite.TryGetValue(pkmName, out string value))
			pkmName = value;
		else if (pkmName.Substring(pkmName.Length - 1) == "1")
			pkmName = pkmName.Substring(0, pkmName.Length - 2) + "-Mega";

		return pkmName;
	}
}

public class AXExtraTrainerInfo(string route, string required, bool resetEncounterIndex = false, string notes = "", bool tagBattle = false)
{
	static int trIDIncr = 0;

	public string Route { get; set; } = route;
	public int EncounterIndex { get; set; } = resetEncounterIndex ? trIDIncr = 0 : ++trIDIncr;
	public string Required { get; set; } = required;
	public string Notes { get; set; } = notes;
	public bool IsTagBattle { get; set; } = tagBattle;

	public static AXExtraTrainerInfo Create(string route, string required, bool resetEncounterIndex = false)
	{
		return new AXExtraTrainerInfo(route, required, resetEncounterIndex);
	}

	public static AXExtraTrainerInfo Create(string route, string required, string notes, bool resetEncounterIndex = false)
	{
		return new AXExtraTrainerInfo(route, required, resetEncounterIndex, notes);
	}

	public static AXExtraTrainerInfo Create(string route, string required, bool tagBattle, bool resetEncounterIndex = false)
	{
		return new AXExtraTrainerInfo(route, required, resetEncounterIndex, "", tagBattle);
	}

	public static AXExtraTrainerInfo Create(string route, string required, string notes, bool tagBattle, bool resetEncounterIndex = false)
	{
		return new AXExtraTrainerInfo(route, required, resetEncounterIndex, notes, tagBattle);
	}
}

public class AXExtraRouteInfo(bool required, string notes = "")
{
	static int routeIncr = 0;

	public int RouteIndex { get; set; } = routeIncr++;
	public bool Required { get; set; } = required;
	public string Notes { get; set; } = notes;

	public static AXExtraRouteInfo Create(bool required, string notes = "")
	{
		return new AXExtraRouteInfo(required, notes);
	}
}
