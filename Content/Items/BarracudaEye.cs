using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items
{
    internal class BarracudaEye : ModItem
    { 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barracuda Eye");
            Tooltip.SetDefault("an eye... i hope there isn't any other eyes you will have to fight.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.sellPrice(silver: 18);
            Item.maxStack = 1000;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 1)
                //.AddTile(TileID.Anvils)
                .AddTile(18)
                .Register();
        }
    }
}