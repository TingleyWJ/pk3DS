﻿using System;

namespace pk3DS.Core.Structures;

public class EncounterTrade7(byte[] data) : EncounterStatic
{
    public const int SIZE = 0x34;

    public readonly byte[] Data = data;

    public override int Species
    {
        get => BitConverter.ToUInt16(Data, 0x0);
        set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x0);
    }

    public int String1
    {
        get => BitConverter.ToUInt16(Data, 0x2);
        set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x2);
    }

    public int Form { get => Data[0x4]; set => Data[0x4] = (byte)value; }
    public int Level { get => Data[0x5]; set => Data[0x5] = (byte)value; }

    public int[] IVs
    {
        get =>
        [
            (sbyte) Data[0x6], (sbyte) Data[0x7], (sbyte) Data[0x8], (sbyte) Data[0x9], (sbyte) Data[0xA], (sbyte) Data[0xB],
        ];
        set
        {
            if (value.Length != 6)
                return;
            for (int i = 0; i < 6; i++)
                Data[i + 0x6] = (byte)Convert.ToSByte(value[i]);
        }
    }

    public int Ability { get => Data[0xC]; set => Data[0xC] = (byte)value; }
    public int Nature { get => Data[0xD]; set => Data[0xD] = (byte)value; }
    public int Gender { get => Data[0xE]; set => Data[0xE] = (byte)value; }
    public int TID { get => BitConverter.ToUInt16(Data, 0x10); set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x10); }
    public int SID { get => BitConverter.ToUInt16(Data, 0x12); set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x12); }
    public uint ID { get => BitConverter.ToUInt32(Data, 0x10); set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x10); }

    public override int HeldItem
    {
        get
        {
            int item = BitConverter.ToInt16(Data, 0x14);
            if (item < 0) item = 0;
            return item;
        }
        set
        {
            if (value == 0) value = -1;
            BitConverter.GetBytes((short)value).CopyTo(Data, 0x14);
        }
    }

    public int String2
    {
        get => BitConverter.ToUInt16(Data, 0x18);
        set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x18);
    }

    public int OT_Gender { get => Data[0x1A]; set => Data[0x1A] = (byte)value; }

    public ushort OT_Intensity { get => BitConverter.ToUInt16(Data, 0x1C); set => BitConverter.GetBytes(value).CopyTo(Data, 0x1C); }
    public ushort OT_Memory { get => BitConverter.ToUInt16(Data, 0x1E); set => BitConverter.GetBytes(value).CopyTo(Data, 0x1E); }
    public ushort OT_TextVar { get => BitConverter.ToUInt16(Data, 0x20); set => BitConverter.GetBytes(value).CopyTo(Data, 0x20); }
    public ushort OT_Feeling { get => BitConverter.ToUInt16(Data, 0x22); set => BitConverter.GetBytes(value).CopyTo(Data, 0x22); }

    // 0x24-0x2B are language IDs set depending on the game's current language; all default to -1

    public int TradeRequestSpecies
    {
        get => BitConverter.ToUInt16(Data, 0x2C);
        set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x2C);
    }
}