namespace SpiritMusic.Common.Scenes;

internal class LavaScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/LavaLayer");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

    public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<MusicConfig>().LavaLayer
            && player.position.Y / 16 >= (Main.maxTilesY - (Main.maxTilesY * .28f))
            && !player.ZoneJungle
            && !player.ZoneCorrupt
            && !player.ZoneHallow
            && !player.ZoneCrimson
            && !player.ZoneMarble
            && !player.ZoneGranite
            && !player.ZoneGlowshroom
            && !player.ZoneSnow
            && !player.ZoneUndergroundDesert;
}
