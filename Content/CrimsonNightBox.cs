namespace SpiritMusic.Content;

internal class CrimsonNightBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<CrimsonNightBoxItem>();
}

internal class CrimsonNightBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<CrimsonNightBox>();
}
