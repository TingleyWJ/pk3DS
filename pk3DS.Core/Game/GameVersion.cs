﻿namespace pk3DS.Core;

public enum GameVersion
{
    // Indicators
    Invalid = -2,
    Any = -1,
    Unknown = 0,

    // Version IDs, also stored in PKM structure
    /*Gen3*/
    S = 1, R = 2, E = 3, FR = 4, LG = 5,

    /*Gen4*/
    HG = 7, SS = 8, D = 10, P = 11, Pt = 12,

    // Gen3
    CXD = 15,

    /*Gen5*/
    W = 20, B = 21, W2 = 22, B2 = 23,

    /*Gen6*/
    X = 24, Y = 25, AS = 26, OR = 27,

    /*Gen7*/
    SN = 30, MN = 31, US = 32, UM = 33,

    /* GO */
    GO = 34,
    /* VC1*/
    RD = 35, GN = 36, BU = 37, YW = 38, // GN = Blue for international release

    /* VC2*/
    GD = 39, SV = 40, C = 41, // Crystal is unused

    // Not actually stored values, but assigned as properties.

    // Game Groupings (SaveFile type)
    /*SAV1*/
    RB, RBY,

    /*SAV2*/
    GS, GSC,

    /*SAV3*/
    RS, FRLG, RSBOX, COLO, XD,

    /*SAV4*/
    DP, HGSS, BATREV,

    /*SAV5*/
    BW, B2W2,

    /*SAV6*/
    XY, ORASDEMO, ORAS,

    /*SAV7*/
    SM, USUM,

    // Extra Game Groupings (Generation)
    Gen1, Gen2, Gen3, Gen4, Gen5, Gen6, Gen7,

    GBCartEraOnly,
    Stadium,
    Stadium2,
    EventsGBGen1,
    EventsGBGen2,
    VCEvents,

    SMDEMO,
}

public static class Extensions
{
    public static bool Contains(this GameVersion g1, GameVersion g2)
    {
        if (g1 == g2 || g1 == GameVersion.Any)
            return true;

        switch (g1)
        {
            case GameVersion.RB:
                return g2 is GameVersion.RD or GameVersion.BU or GameVersion.GN;
            case GameVersion.RBY:
                return GameVersion.RB.Contains(g2) || g2 == GameVersion.YW;
            case GameVersion.Gen1:
                return GameVersion.RBY.Contains(g2) || g2 == GameVersion.Stadium || g2 == GameVersion.EventsGBGen1 || g2 == GameVersion.VCEvents;
            case GameVersion.Stadium:
            case GameVersion.EventsGBGen1:
            case GameVersion.VCEvents:
                goto case GameVersion.RBY;

            case GameVersion.GS: return g2 is GameVersion.GD or GameVersion.SV;
            case GameVersion.GSC:
                return GameVersion.GS.Contains(g2) || g2 == GameVersion.C;
            case GameVersion.Gen2:
                return GameVersion.GSC.Contains(g2) || g2 == GameVersion.Stadium2 || g2 == GameVersion.EventsGBGen2;
            case GameVersion.Stadium2:
            case GameVersion.EventsGBGen2:
                goto case GameVersion.GSC;
            case GameVersion.GBCartEraOnly:
                return g2 is GameVersion.Stadium or GameVersion.Stadium2 or GameVersion.EventsGBGen1 or GameVersion.EventsGBGen2;

            case GameVersion.RS: return g2 is GameVersion.R or GameVersion.S;
            case GameVersion.FRLG: return g2 is GameVersion.FR or GameVersion.LG;
            case GameVersion.CXD: return g2 is GameVersion.COLO or GameVersion.XD;
            case GameVersion.RSBOX: return GameVersion.RS.Contains(g2) || g2 == GameVersion.E || GameVersion.FRLG.Contains(g2);
            case GameVersion.Gen3:
                return GameVersion.RS.Contains(g2) || g2 == GameVersion.E || GameVersion.FRLG.Contains(g2) || GameVersion.CXD.Contains(g2) || g2 == GameVersion.RSBOX;

            case GameVersion.DP: return g2 is GameVersion.D or GameVersion.P;
            case GameVersion.HGSS: return g2 is GameVersion.HG or GameVersion.SS;
            case GameVersion.BATREV: return GameVersion.DP.Contains(g2) || g2 == GameVersion.Pt || GameVersion.HGSS.Contains(g2);
            case GameVersion.Gen4:
                return GameVersion.DP.Contains(g2) || g2 == GameVersion.Pt || GameVersion.HGSS.Contains(g2) || g2 == GameVersion.BATREV;

            case GameVersion.BW: return g2 is GameVersion.B or GameVersion.W;
            case GameVersion.B2W2: return g2 is GameVersion.B2 or GameVersion.W2;
            case GameVersion.Gen5:
                return GameVersion.BW.Contains(g2) || GameVersion.B2W2.Contains(g2);

            case GameVersion.XY: return g2 is GameVersion.X or GameVersion.Y;
            case GameVersion.ORAS: return g2 is GameVersion.OR or GameVersion.AS;
            case GameVersion.Gen6:
                return GameVersion.XY.Contains(g2) || GameVersion.ORAS.Contains(g2);

            case GameVersion.SM:
                return g2 is GameVersion.SN or GameVersion.MN;
            case GameVersion.USUM:
                return g2 is GameVersion.US or GameVersion.UM;
            case GameVersion.Gen7:
                return GameVersion.SM.Contains(g2) || GameVersion.USUM.Contains(g2);

            default: return false;
        }
    }
}