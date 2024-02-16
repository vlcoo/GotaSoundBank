﻿using System.Collections.Generic;
using GotaSoundIO.IO;

namespace GotaSoundBank.SF2;

/// <summary>
///     An instrument.
/// </summary>
public class Instrument : IReadable, IWriteable
{
    /// <summary>
    ///     Global zone.
    /// </summary>
    public Zone GlobalZone = null;

    /// <summary>
    ///     Instrument name.
    /// </summary>
    public string Name = "";

    /// <summary>
    ///     Bag index to only be used when reading and writing.
    /// </summary>
    public ushort ReadingBagIndex;

    /// <summary>
    ///     Zones.
    /// </summary>
    public List<Zone> Zones = new();

    /// <summary>
    ///     Number of zones.
    /// </summary>
    public int NumZones => Zones.Count + (GlobalZone != null ? 1 : 0);

    /// <summary>
    ///     Read the instrument.
    /// </summary>
    /// <param name="r">The reader.</param>
    public void Read(FileReader r)
    {
        Name = r.ReadFixedString(20);
        ReadingBagIndex = r.ReadUInt16();
    }

    /// <summary>
    ///     Write the instrument.
    /// </summary>
    /// <param name="w">The writer.</param>
    public void Write(FileWriter w)
    {
        w.WriteFixedString(Name, 20);
        w.Write(ReadingBagIndex);
    }

    /// <summary>
    ///     Get a list of all the zones.
    /// </summary>
    /// <returns>The zones.</returns>
    public List<Zone> GetAllZones()
    {
        var ret = new List<Zone>();
        if (GlobalZone != null) ret.Add(GlobalZone);
        foreach (var z in Zones) ret.Add(z);
        return ret;
    }
}