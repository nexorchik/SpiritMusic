global using Terraria.ModLoader;
global using Terraria;

using Terraria.Localization;

namespace SpiritMusic;

public class SpiritMusic : Mod
{
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
    }

    private void LoadMusicBox(string name, string path) 
        => MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot(this, path), Find<ModItem>(name + "Item").Type, Find<ModTile>(name).Type);
}
