namespace SpiritMusic.Content;

internal class MarbleBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<MarbleBoxItem>();
}

internal class MarbleBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<MarbleBox>();
}
