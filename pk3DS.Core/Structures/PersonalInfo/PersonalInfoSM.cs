﻿using System;
using System.Linq;

namespace pk3DS.Core.Structures.PersonalInfo;

public class PersonalInfoSM : PersonalInfoXY
{
    public new const int SIZE = 0x54;

    public PersonalInfoSM(byte[] data)
    {
        if (data.Length != SIZE)
            return;
        Data = data;

        TMHM = GetBits(Data.Skip(0x28).Take(0x10).ToArray()); // 36-39
        TypeTutors = GetBits(Data.Skip(0x38).Take(0x4).ToArray()); // 40
        SpecialTutors =
        [
            GetBits(Data.Skip(0x3C).Take(0x0A).ToArray()),
        ];
    }

    public override byte[] Write()
    {
        SetBits(TMHM).CopyTo(Data, 0x28);
        SetBits(TypeTutors).CopyTo(Data, 0x38);
        SetBits(SpecialTutors[0]).CopyTo(Data, 0x3C);
        return Data;
    }

    // No accessing for 3C-4B

    public int SpecialZ_Item { get => BitConverter.ToUInt16(Data, 0x4C); set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x4C); }
    public int SpecialZ_BaseMove { get => BitConverter.ToUInt16(Data, 0x4E); set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x4E); }
    public int SpecialZ_ZMove { get => BitConverter.ToUInt16(Data, 0x50); set => BitConverter.GetBytes((ushort)value).CopyTo(Data, 0x50); }
    public bool LocalVariant { get => Data[0x52] == 1; set => Data[0x52] = value ? (byte)1 : (byte)0; }
}