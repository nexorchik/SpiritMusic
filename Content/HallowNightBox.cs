namespace SpiritMusic.Content;

internal class HallowNightBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<HallowNightBoxItem>();
}

internal class HallowNightBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<HallowNightBox>();
}
