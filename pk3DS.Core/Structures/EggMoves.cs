﻿using System.IO;

namespace pk3DS.Core.Structures;

public abstract class EggMoves
{
    public int Count;
    public int[] Moves;
    public int FormTableIndex;

    public abstract byte[] Write();
}

public class EggMoves6 : EggMoves
{
    public EggMoves6(byte[] data)
    {
        if (data.Length < 2 || data.Length % 2 != 0)
        { Count = 0; Moves = []; return; }

        using var br = new BinaryReader(new MemoryStream(data));
        Moves = new int[Count = br.ReadUInt16()];
        for (int i = 0; i < Count; i++)
            Moves[i] = br.ReadUInt16();
    }

    public static EggMoves[] GetArray(byte[][] entries)
    {
        var data = new EggMoves[entries.Length];
        for (int i = 0; i < data.Length; i++)
            data[i] = new EggMoves6(entries[i]);
        return data;
    }

    public override byte[] Write()
    {
        Count = Moves.Length;
        if (Count == 0) return [];
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);
        bw.Write((ushort)Count);
        for (int i = 0; i < Count; i++)
            bw.Write((ushort)Moves[i]);

        return ms.ToArray();
    }
}

public class EggMoves7 : EggMoves
{
    public EggMoves7(byte[] data)
    {
        if (data.Length < 2 || data.Length % 2 != 0)
        { Count = 0; Moves = []; return; }

        using var br = new BinaryReader(new MemoryStream(data));
        FormTableIndex = br.ReadUInt16();
        Count = br.ReadUInt16();
        Moves = new int[Count];
        for (int i = 0; i < Count; i++)
            Moves[i] = br.ReadUInt16();
    }

    public static EggMoves[] GetArray(byte[][] entries)
    {
        var data = new EggMoves[entries.Length];
        for (int i = 0; i < data.Length; i++)
            data[i] = new EggMoves7(entries[i]);
        return data;
    }

    public override byte[] Write()
    {
        Count = Moves.Length;
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);
        bw.Write((ushort)FormTableIndex);
        bw.Write((ushort)Count);
        for (int i = 0; i < Count; i++)
            bw.Write((ushort)Moves[i]);

        return ms.ToArray();
    }
}