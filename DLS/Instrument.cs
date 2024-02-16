using System.Collections.Generic;

namespace GotaSoundBank.DLS;

/// <summary>
///     Instrument.
/// </summary>
public class Instrument
{
    /// <summary>
    ///     Bank Id.
    /// </summary>
    public uint BankId;

    /// <summary>
    ///     Instrument Id.
    /// </summary>
    public uint InstrumentId;

    /// <summary>
    ///     Instrument name.
    /// </summary>
    public string Name = "";

    /// <summary>
    ///     Regions.
    /// </summary>
    public List<Region> Regions = new();
}