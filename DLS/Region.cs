using System.Collections.Generic;

namespace GotaSoundBank.DLS;

/// <summary>
///     Region.
/// </summary>
public class Region
{
    /// <summary>
    ///     Articulators.
    /// </summary>
    public List<Articulator> Articulators = new();

    /// <summary>
    ///     Channel flags.
    /// </summary>
    public uint ChannelFlags;

    /// <summary>
    ///     If the same note is played when already playing, it will not stop the first one if this is enabled.
    /// </summary>
    public bool DoublePlayback = true;

    /// <summary>
    ///     Gain.
    /// </summary>
    public int Gain;

    /// <summary>
    ///     Key group. 0 if disabled, 1-15 if used.
    /// </summary>
    public byte KeyGroup;

    /// <summary>
    ///     Layer.
    /// </summary>
    public ushort Layer;

    /// <summary>
    ///     If the loop is to loop and be released instead of looping forward only.
    /// </summary>
    public bool LoopAndRelease;

    /// <summary>
    ///     Loop length.
    /// </summary>
    public uint LoopLength;

    /// <summary>
    ///     Loops.
    /// </summary>
    public bool Loops;

    /// <summary>
    ///     Loop start.
    /// </summary>
    public uint LoopStart;

    /// <summary>
    ///     Ignore steering in articulation.
    /// </summary>
    public bool MultiChannel;

    /// <summary>
    ///     No compression.
    /// </summary>
    public bool NoCompression;

    /// <summary>
    ///     High note.
    /// </summary>
    public ushort NoteHigh = 127;

    /// <summary>
    ///     Low note.
    /// </summary>
    public ushort NoteLow = 0;

    /// <summary>
    ///     No truncation.
    /// </summary>
    public bool NoTruncation = true;

    /// <summary>
    ///     Phase group.
    /// </summary>
    public ushort PhaseGroup;

    /// <summary>
    ///     Master link.
    /// </summary>
    public bool PhaseMaster;

    /// <summary>
    ///     Root note.
    /// </summary>
    public byte RootNote = 60;

    /// <summary>
    ///     Tuning.
    /// </summary>
    public short Tuning;

    /// <summary>
    ///     High velocity.
    /// </summary>
    public ushort VelocityHigh = 127;

    /// <summary>
    ///     Low velocity.
    /// </summary>
    public ushort VelocityLow = 0;

    /// <summary>
    ///     Wave Id.
    /// </summary>
    public uint WaveId;
}