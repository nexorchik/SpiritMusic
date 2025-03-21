namespace SpiritMusic.Content;

internal class SnowNightBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<SnowNightBoxItem>();
}

internal class SnowNightBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<SnowNightBox>();
}
