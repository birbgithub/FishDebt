using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class CrabAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crab Axe");
            Tooltip.SetDefault("'Snip Snap' the Onomatopoeia");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 32;
            Item.height = 32;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 3;
            Item.knockBack = 200;
            Item.crit = 100;

            // Misc
            Item.rare = 2;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(9, 8)
                //.AddTile(TileID.Anvils)
                .AddTile(18)
                .Register();
        }
    }
}
