using System;
using Terraria.ID;

namespace SpiritMusic.Common.Scenes;

internal class NeonMossScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/NeonMoss");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
    public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<MusicConfig>().NeonMoss && ModContent.GetInstance<NeonMossTileCounter>().InNeonMoss;
}

public class NeonMossTileCounter : ModSystem
{
    public bool InNeonMoss => _neonCount > 200;

    private int _neonCount = 0;

    public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
    {
        _neonCount = tileCounts[TileID.ArgonMoss] + tileCounts[TileID.KryptonMoss] + tileCounts[TileID.XenonMoss] + tileCounts[TileID.VioletMoss] 
            + tileCounts[TileID.RainbowMoss];

        if (ModLoader.TryGetMod("SpiritReforged", out Mod reforged))
        {
            if (reforged.TryFind("RadonMoss", out ModTile radon))
                _neonCount += tileCounts[radon.Type];

            if (reforged.TryFind("OganessonMoss", out ModTile oganesson))
                _neonCount += tileCounts[oganesson.Type];
        }
    }
}