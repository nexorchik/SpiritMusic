namespace SpiritMusic.Content;

internal class SpiderCaveBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<SpiderCaveBoxItem>();
}

internal class SpiderCaveBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<SpiderCaveBox>();
}
