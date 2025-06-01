namespace SpiritMusic.Content;

internal class VictoryDayBox : MusicBox
{
    protected override int ItemId => ModContent.ItemType<VictoryDayBoxItem>();
}

internal class VictoryDayBoxItem : MusicBoxItem
{
    protected override int TileId => ModContent.TileType<VictoryDayBox>();
}
