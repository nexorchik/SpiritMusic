using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace SpiritMusic;

internal class MusicConfig : ModConfig
{
    public static MusicConfig Instance => ModContent.GetInstance<MusicConfig>();

    public override ConfigScope Mode => ConfigScope.ClientSide;

    [DefaultValue(true)]
    public bool Blizzard { get; set; }

    [DefaultValue(true)]
    public bool CorruptNight { get; set; }

    [DefaultValue(true)]
    public bool CrimsonNight { get; set; }

    [DefaultValue(true)]
    public bool SnowNight { get; set; }

    [DefaultValue(true)]
    public bool HallowNight { get; set; }

    [DefaultValue(true)]
    public bool DesertNight { get; set; }

    [DefaultValue(true)]
    public bool FrostLegion { get; set; }

    [DefaultValue(true)]
    public bool Granite { get; set; }

    [DefaultValue(true)]
    public bool Marble { get; set; }

    [DefaultValue(true)]
    public bool Meteor { get; set; }

    [DefaultValue(true)]
    public bool Spider { get; set; }

    [DefaultValue(true)]
    public bool SkeletronPrime { get; set; }

    [DefaultValue(true)]
    public bool LavaLayer { get; set; }
}
