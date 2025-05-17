using System;
using Terraria.ID;

namespace SpiritMusic.Common.Scenes;

internal class GraniteScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Granite");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
    public override bool IsSceneEffectActive(Player player) => MusicConfig.Instance.Granite && ModContent.GetInstance<GraniteTileCounter>().InGranite;
}

public class GraniteTileCounter : ModSystem
{
    public bool InGranite => _graniteCount > 400;

    private int _graniteCount = 0;

    public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
    {
        _graniteCount = tileCounts[TileID.Granite];

    }
}