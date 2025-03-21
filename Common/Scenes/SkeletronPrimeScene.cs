using Terraria.ID;

namespace SpiritMusic.Common.Scenes;

internal class SkeletronPrimeScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/SkeletronPrime");
    public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
    public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<MusicConfig>().SkeletronPrime && NPC.AnyNPCs(NPCID.SkeletronPrime);
}
