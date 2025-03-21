namespace SpiritMusic.Content;

internal class BlizzardBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<BlizzardBoxItem>();
}

internal class BlizzardBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<BlizzardBox>();
}
