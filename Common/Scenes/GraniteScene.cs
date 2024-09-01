namespace SpiritMusic.Common.Scenes;

internal class GraniteScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Granite");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
    public override bool IsSceneEffectActive(Player player) => MusicConfig.Instance.Granite && Main.LocalPlayer.ZoneGranite;
}