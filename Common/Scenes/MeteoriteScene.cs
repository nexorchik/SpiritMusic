namespace SpiritMusic.Common.Scenes;

internal class MeteoriteScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Meteor");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
    public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<MusicConfig>().Meteor && player.ZoneMeteor && !Main.bloodMoon;
}
