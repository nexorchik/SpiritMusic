namespace SpiritMusic.Content;

internal class CorruptNightBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<CorruptNightBoxItem>();
}

internal class CorruptNightBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<CorruptNightBox>();
}
