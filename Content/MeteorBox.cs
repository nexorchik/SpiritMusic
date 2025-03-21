namespace SpiritMusic.Content;

internal class MeteorBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<MeteorBoxItem>();
}

internal class MeteorBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<MeteorBox>();
}
