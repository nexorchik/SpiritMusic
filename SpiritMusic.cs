global using Terraria.ModLoader;
global using Terraria;

using Terraria.Localization;
using System.Runtime.CompilerServices;

namespace SpiritMusic;

public class SpiritMusic : Mod
{
    /// <summary>
    /// Gets if Otherworld Music is turned on. <see cref="Main.swapMusic"/> is private for some reason.
    /// </summary>
    public static bool SwapMusic => GetSwapMusic(null);

    [UnsafeAccessor(UnsafeAccessorKind.StaticField, Name = "swapMusic")]
    private static extern ref bool GetSwapMusic(Main main);

    public override void PostSetupContent()
    {
        LoadMusicBox("BlizzardBox", "Sounds/Music/Blizzard");
        LoadMusicBox("CorruptNightBox", "Sounds/Music/CorruptNight");
        LoadMusicBox("CrimsonNightBox", "Sounds/Music/CrimsonNight");
        LoadMusicBox("DesertNightBox", "Sounds/Music/DesertNight");
        LoadMusicBox("FrostLegionBox", "Sounds/Music/FrostLegion");
        LoadMusicBox("GraniteBox", "Sounds/Music/Granite");
        LoadMusicBox("HallowNightBox", "Sounds/Music/HallowNight");
        LoadMusicBox("MarbleBox", "Sounds/Music/MarbleBiome");
        LoadMusicBox("MeteorBox", "Sounds/Music/Meteor");
        LoadMusicBox("SkeletronPrimeBox", "Sounds/Music/SkeletronPrime");
        LoadMusicBox("SnowNightBox", "Sounds/Music/SnowNight");
        LoadMusicBox("SpiderCaveBox", "Sounds/Music/SpiderCave");
        LoadMusicBox("LavaLayerBox", "Sounds/Music/LavaLayer");
        LoadMusicBox("NeonMossBox", "Sounds/Music/NeonMoss");
        LoadMusicBox("UndergroundTownBox", "Sounds/Music/TownUnderground");
        LoadMusicBox("VictoryDayBox", "Sounds/Music/VictoryDay");
        LoadMusicBox("OtherworldBlizzardBox", "Sounds/Music/OtherworldBlizzard");

        if (!ModLoader.TryGetMod("MusicDisplay", out Mod display))
            return;

        LocalizedText modName = Language.GetText("Mods.SpiritMusic.MusicDisplay.ModName");

        void AddMusic(string name)
        {
            LocalizedText author = Language.GetText("Mods.SpiritMusic.MusicDisplay." + name + ".Author");
            LocalizedText displayName = Language.GetText("Mods.SpiritMusic.MusicDisplay." + name + ".DisplayName");
            display.Call("AddMusic", (short)MusicLoader.GetMusicSlot(this, "Sounds/Music/" + name), displayName, author, modName);
        }

        AddMusic("Blizzard");
        AddMusic("CorruptNight");
        AddMusic("CrimsonNight");
        AddMusic("DesertNight");
        AddMusic("FrostLegion");
        AddMusic("Granite");
        AddMusic("HallowNight");
        AddMusic("MarbleBiome");
        AddMusic("Meteor");
        AddMusic("SnowNight");
        AddMusic("SpiderCave");
        AddMusic("SkeletronPrime");
        AddMusic("LavaLayer");
        AddMusic("NeonMoss");
        AddMusic("TownUnderground");
        AddMusic("VictoryDay");
        AddMusic("OtherworldBlizzard");
    }

    private void LoadMusicBox(string name, string path) 
        => MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(this, path), Find<ModItem>(name + "Item").Type, Find<ModTile>(name).Type);
}
