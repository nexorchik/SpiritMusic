namespace SpiritMusic.Content;

internal class DesertNightBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<DesertNightBoxItem>();
}

internal class DesertNightBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<DesertNightBox>();
}
