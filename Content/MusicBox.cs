using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Utilities;

namespace SpiritMusic.Content;

internal abstract class MusicBox : ModTile
{
    protected abstract int ItemId { get; }

    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileObsidianKill[Type] = true;
        TileID.Sets.HasOutlines[Type] = true;
        TileID.Sets.DisableSmartCursor[Type] = true;

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

    public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref TileDrawInfo drawData)
    {
        if (Lighting.UpdateEveryFrame && new FastRandom(Main.TileFrameSeed).WithModifier(i, j).Next(4) != 0)
        {
            return;
        }

        Tile tile = Main.tile[i, j];

        if (!TileDrawing.IsVisible(tile) || tile.TileFrameX != 36 || tile.TileFrameY % 36 != 0 || (int)Main.timeForVisualEffects % 7 != 0 || !Main.rand.NextBool(3))
        {
            return;
        }

        int note = Main.rand.Next(570, 573);
        var pos = new Vector2(i * 16 + 8, j * 16 - 8);
        var vel = new Vector2(Main.WindForVisuals * 2f, -0.5f);
        vel.X *= Main.rand.NextFloat(0.5f, 1.5f);
        vel.Y *= Main.rand.NextFloat(0.5f, 1.5f);

        switch (note)
        {
            case 572:
                pos.X -= 8f;
                break;
            case 571:
                pos.X -= 4f;
                break;
        }

        Gore.NewGore(new EntitySource_TileUpdate(i, j), pos, vel, note, 0.8f);
    }

    public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings) => true;
    public override bool CanDrop(int i, int j) => false;
    public override void KillMultiTile(int i, int j, int frameX, int frameY) => Item.NewItem(null, new Rectangle(i * 16, j * 16, 32, 32), new Item(ItemId), false, true);
}

internal abstract class MusicBoxItem : ModItem
{
    protected abstract int TileId { get; }

    public override void SetStaticDefaults()
    {
        ItemID.Sets.CanGetPrefixes[Type] = false;
        ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.MusicBox;
    }

    public override void SetDefaults()
    {
        Item.DefaultToMusicBox(TileId);
        Item.Size = new Vector2(32);
    }
}