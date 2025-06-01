using Terraria.GameContent.Events;

namespace SpiritMusic.Common.Scenes;

internal class VictoryDayScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/VictoryDay");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
    public override bool IsSceneEffectActive(Player player) => player.ZoneOverworldHeight && ModContent.GetInstance<VictoryDaySystem>().VictoryDay 
        && ModContent.GetInstance<MusicConfig>().VictoryDay;
}

public class VictoryDaySystem : ModSystem
{
    public bool VictoryDay => wasLanternNight && Main.dayTime;

    private bool wasLanternNight = false;

    public override void PostUpdateDusts()
    {
        if (LanternNight.LanternsUp)
            wasLanternNight = true;
        else if (!Main.dayTime)
            wasLanternNight = false;
    }
}