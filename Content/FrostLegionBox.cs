namespace SpiritMusic.Content;

internal class FrostLegionBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<FrostLegionBoxItem>();
}

internal class FrostLegionBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<FrostLegionBox>();
}
