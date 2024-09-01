global using Terraria.ModLoader;
global using Terraria;

using Terraria.Localization;

namespace SpiritMusic;

public class SpiritMusic : Mod
{
    public override void PostSetupContent()
    {
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
    }
}
