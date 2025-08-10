namespace SpiritMusic.Content;

internal class OtherworldBlizzardBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<OtherworldBlizzardBoxItem>();
}

internal class OtherworldBlizzardBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<OtherworldBlizzardBox>();
}
