namespace SpiritMusic.Content;

internal class LavaLayerBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<LavaLayerBoxItem>();
}

internal class LavaLayerBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<LavaLayerBox>();
}