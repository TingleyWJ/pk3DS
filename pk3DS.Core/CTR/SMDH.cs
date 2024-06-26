﻿using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace pk3DS.Core.CTR;

// System Menu Data Header
public class SMDH
{
    public uint Magic;
    public ushort Version;
    public ushort Reserved2;
    public ApplicationInfo[] AppInfo = new ApplicationInfo[16];
    public ApplicationSettings AppSettings;
    public ulong Reserved8;
    public SmallIcon SmallIcon;
    public LargeIcon LargeIcon;

    public SMDH(byte[] data)
    {
            Read(new BinaryReader(new MemoryStream(data)));
        }

    public SMDH(string path)
    {
            Read(new BinaryReader(File.OpenRead(path)));
        }

    public void Read(BinaryReader br)
    {
            // Check to see if the first 4 bytes (magic) is valid.
            if (br.BaseStream.Length != 0x36C0 || (Magic = br.ReadUInt32()) != 0x48444D53)
                return; // Abort

            Version = br.ReadUInt16();
            Reserved2 = br.ReadUInt16();

            for (int i = 0; i < 16; i++)
                AppInfo[i] = new ApplicationInfo(br);

            AppSettings = new ApplicationSettings(br);
            Reserved8 = br.ReadUInt64();
            SmallIcon = new SmallIcon(br);
            LargeIcon = new LargeIcon(br);
        }

    public byte[] Write()
    {
            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.Write(Magic);
            bw.Write(Version);
            bw.Write(Reserved2);
            for (int i = 0; i < 16; i++) AppInfo[i].Write(bw);
            AppSettings.Write(bw);
            bw.Write(Reserved8);
            SmallIcon.Write(bw);
            LargeIcon.Write(bw);
            return ms.ToArray();
        }
}

// Thanks to Gericom for EveryFileExplorer's SMDH.cs as a basis for the object code (and AppSettings enumeration)
public class ApplicationInfo(BinaryReader br)
{
    public string ShortDescription = Encoding.Unicode.GetString(br.ReadBytes(0x80)).TrimEnd('\0'); //0x80
    public string LongDescription = Encoding.Unicode.GetString(br.ReadBytes(0x100)).TrimEnd('\0'); //0x100
    public string Publisher = Encoding.Unicode.GetString(br.ReadBytes(0x80)).TrimEnd('\0'); //0x80

    public void Write(BinaryWriter bw)
    {
            bw.Write(Encoding.Unicode.GetBytes(ShortDescription.PadRight(0x80 / 2, '\0')));
            bw.Write(Encoding.Unicode.GetBytes(LongDescription.PadRight(0x100 / 2, '\0')));
            bw.Write(Encoding.Unicode.GetBytes(Publisher.PadRight(0x80 / 2, '\0')));
        }
}

public class ApplicationSettings(BinaryReader br)
{
    public readonly byte[] GameRatings = br.ReadBytes(0x10); //0x10
    public readonly RegionLockoutFlags RegionLockout = (RegionLockoutFlags)br.ReadUInt32();
    public readonly uint MatchMakerID = br.ReadUInt32();
    public readonly ulong MatchMakerBITID = br.ReadUInt64();
    public readonly AppSettingsFlags Flags = (AppSettingsFlags)br.ReadUInt32();
    public readonly ushort EULAVersion = br.ReadUInt16();
    public readonly ushort Reserved = br.ReadUInt16();
    public readonly float AnimationDefaultFrame = br.ReadSingle();
    public readonly uint StreetPassID = br.ReadUInt32();

    [Flags]
    public enum RegionLockoutFlags : uint
    {
        None,
        Japan = 0x01,
        NorthAmerica = 0x02,
        Europe = 0x04,
        Australia = 0x08,
        China = 0x10,
        Korea = 0x20,
        Taiwan = 0x40,
    }

    [Flags]
    public enum AppSettingsFlags : uint
    {
        None,
        Visible = 1,
        AutoBoot = 2,
        Allow3D = 4,
        ReqAcceptEULA = 8,
        AutoSaveOnExit = 16,
        UsesExtendedBanner = 32,
        ReqRegionGameRating = 64,
        UsesSaveData = 128,
        RecordUsage = 256,
        DisableSDSaveBackup = 512,
    }

    public void Write(BinaryWriter bw)
    {
            bw.Write(GameRatings, 0, 0x10);
            bw.Write((uint)RegionLockout);
            bw.Write(MatchMakerID);
            bw.Write(MatchMakerBITID);
            bw.Write((uint)Flags);
            bw.Write(EULAVersion);
            bw.Write(Reserved);
            bw.Write(AnimationDefaultFrame);
            bw.Write(StreetPassID);
        }
}

public class SmallIcon // 24x24
{
    public Bitmap Icon;
    public byte[] Bytes;

    public SmallIcon(BinaryReader br)
    {
            Bytes = br.ReadBytes(0x480);
            Icon = ImageUtil.GetBitmap(Bytes, 24, 24);
        }

    public void Write(BinaryWriter bw)
    {
            bw.Write(Bytes);
        }

    public bool ChangeIcon(Bitmap img)
    {
            if (img.Width != Icon.Width || img.Height != Icon.Height) return false;
            Icon = img;
            Bytes = ImageUtil.GetPixelData(Icon);
            return true;
        }
}

public class LargeIcon // 48x48
{
    public Bitmap Icon;
    public byte[] Bytes;

    public LargeIcon(BinaryReader br)
    {
            Bytes = br.ReadBytes(0x1200);
            Icon = ImageUtil.GetBitmap(Bytes, 48, 48);
        }

    public void Write(BinaryWriter bw)
    {
            bw.Write(Bytes);
        }

    public bool ChangeIcon(Bitmap img)
    {
            if (img.Width != Icon.Width || img.Height != Icon.Height) return false;
            Icon = img;
            Bytes = ImageUtil.GetPixelData(Icon);
            return true;
        }
}