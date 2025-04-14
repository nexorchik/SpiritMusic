namespace SpiritMusic.Common.Scenes;

internal class TownUndergroundScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/TownUnderground");
    public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

    public override bool IsSceneEffectActive(Player player) => 
            ModContent.GetInstance<MusicConfig>().TownUnderground
            //contition 1: normal underground (no conflicting pylons)
            && (player.position.Y / 16 >= Main.worldSurface 
            && Main.LocalPlayer.townNPCs > 2f
            && !player.ZoneSnow
            && !player.ZoneJungle
            && !player.ZoneDesert) ||
            //condition 2: surface mushrooms
            (player.position.Y/16 <= Main.worldSurface && player.ZoneGlowshroom);
}
