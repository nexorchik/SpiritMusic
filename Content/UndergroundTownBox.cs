namespace SpiritMusic.Content;

internal class UndergroundTownBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<UndergroundTownBoxItem>();
}

internal class UndergroundTownBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<UndergroundTownBox>();
}
