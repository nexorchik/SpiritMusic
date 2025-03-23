namespace SpiritMusic.Common.Scenes;

internal class FrostLegionScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/FrostLegion");
    public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;

    public override bool IsSceneEffectActive(Player player) => Main.invasionType == 2 && ModContent.GetInstance<MusicConfig>().FrostLegion 
        && player.ZoneOverworldHeight && Main.invasionProgressNearInvasion;
}
