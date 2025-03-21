namespace SpiritMusic.Content;

internal class GraniteBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<GraniteBoxItem>();
}

internal class GraniteBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<GraniteBox>();
}
