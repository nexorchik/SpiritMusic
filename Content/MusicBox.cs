using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;

namespace SpiritMusic.Content;

internal abstract class MusicBox : ModTile
{
    protected abstract int ItemId { get; }

    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileObsidianKill[Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.Origin = new Point16(0, 1);
        TileObjectData.newTile.LavaDeath = false;
        TileObjectData.newTile.DrawYOffset = 2;
        TileObjectData.addTile(Type);

        TileID.Sets.DisableSmartCursor[Type] = true;

        AddMapEntry(new Color(200, 200, 200), Language.GetText("ItemName.MusicBox"));
        RegisterItemDrop(ItemId);
        
        DustType = -1;
    }

    public override void MouseOver(int i, int j)
    {
        Player player = Main.LocalPlayer;
        player.noThrow = 2;
        player.cursorItemIconEnabled = true;
        player.cursorItemIconID = ItemId;
    }

    public override bool CanDrop(int i, int j) => false;
    public override void KillMultiTile(int i, int j, int frameX, int frameY) => Item.NewItem(null, new Rectangle(i * 16, j * 16, 32, 32), new Item(ItemId), false, true);
}

internal abstract class MusicBoxItem : ModItem
{
    protected abstract int TileId { get; }

    public override void SetDefaults()
    {
        Item.DefaultToPlaceableTile(TileId);
        Item.Size = new Vector2(32);
    }
}