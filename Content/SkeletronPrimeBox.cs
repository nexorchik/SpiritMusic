namespace SpiritMusic.Content;

internal class SkeletronPrimeBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<SkeletronPrimeBoxItem>();
}

internal class SkeletronPrimeBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<SkeletronPrimeBox>();
}
