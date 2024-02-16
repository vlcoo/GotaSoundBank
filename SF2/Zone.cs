using System.Collections.Generic;

namespace GotaSoundBank.SF2;

/// <summary>
///     An instrument or preset zone.
/// </summary>
public class Zone
{
    /// <summary>
    ///     Generators.
    /// </summary>
    public List<Generator> Generators = new();

    /// <summary>
    ///     Modulators.
    /// </summary>
    public List<Modulator> Modulators = new();
}