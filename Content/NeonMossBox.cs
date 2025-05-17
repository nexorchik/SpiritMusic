namespace SpiritMusic.Content;

internal class NeonMossBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<NeonMossBoxItem>();
}

internal class NeonMossBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<NeonMossBox>();
}
