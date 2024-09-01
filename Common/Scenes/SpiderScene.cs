namespace SpiritMusic.Common.Scenes;

internal class SpiderScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/SpiderCave");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
    public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<MusicConfig>().Spider && player.GetModPlayer<MusicPlayer>().ZoneSpider;
}
