namespace SpiritMusic.Common.Scenes;

internal class NightScene : ModSceneEffect
{
    private static MusicConfig Config => ModContent.GetInstance<MusicConfig>();
    private static Player Player => Main.LocalPlayer;

    private static bool ValidCorruption => Config.CorruptNight && Player.ZoneCorrupt && Player.ZoneOverworldHeight 
        && !Player.ZoneHallow && !Player.ZoneMeteor && !Main.bloodMoon;
    
    private static bool ValidHallow => Config.HallowNight && Player.ZoneHallow && Player.ZoneOverworldHeight && !Main.raining && !Main.bloodMoon
            && !Player.ZoneCorrupt && !Player.ZoneCrimson && !Player.ZoneJungle && !Player.ZoneBeach && !Player.ZoneMeteor;
    private static bool ValidCrimson => Config.CrimsonNight && Player.ZoneCrimson && Player.ZoneOverworldHeight
            && !Player.ZoneHallow && !Player.ZoneMeteor && !Main.bloodMoon;
    private static bool ValidSnow => Config.SnowNight && Player.ZoneSnow && Player.ZoneOverworldHeight && !Player.ZoneCorrupt
            && !Player.ZoneMeteor && !Player.ZoneCrimson && !Player.ZoneHallow && !Main.raining && !Main.bloodMoon;
    private static bool ValidDesert => Config.DesertNight && Player.ZoneDesert && Player.ZoneOverworldHeight && !Player.ZoneCorrupt
            && !Player.ZoneCrimson && !Player.ZoneBeach;

    public override int Music => GetMusic();

    public int GetMusic()
    {
        int music = -1;

        if (ValidSnow)
            music = MusicLoader.GetMusicSlot(Mod, "Sounds/Music/SnowNight");

        if (ValidDesert)
            music = MusicLoader.GetMusicSlot(Mod, "Sounds/Music/DesertNight");

        if (ValidHallow)
            music = MusicLoader.GetMusicSlot(Mod, "Sounds/Music/HallowNight");

        if (ValidCorruption)
            music = MusicLoader.GetMusicSlot(Mod, "Sounds/Music/CorruptNight");

        if (ValidCrimson)
            music = MusicLoader.GetMusicSlot(Mod, "Sounds/Music/CrimsonNight");

        return music;
    }

    public override SceneEffectPriority Priority => ValidCorruption || ValidCrimson ? SceneEffectPriority.BiomeHigh : SceneEffectPriority.BiomeMedium;
    public override bool IsSceneEffectActive(Player player) => !Main.dayTime && (ValidHallow || ValidCrimson || ValidCorruption || ValidSnow || ValidDesert);
}
