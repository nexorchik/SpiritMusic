using Terraria.ID;

namespace SpiritMusic;

internal class MusicPlayer : ModPlayer
{
    internal bool ZoneSpider = false;

    public override void ResetEffects() => ZoneSpider = Main.tile[Player.Center.ToTileCoordinates()].WallType == WallID.SpiderUnsafe;
}
