namespace SpiritMusic.Common.Scenes;

internal class MarbleScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/MarbleBiome");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
    public override bool IsSceneEffectActive(Player player) => MusicConfig.Instance.Marble && Main.LocalPlayer.ZoneMarble;
}