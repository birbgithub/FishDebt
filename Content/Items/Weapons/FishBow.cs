using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class FishBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goldfish Bow");
            Tooltip.SetDefault("Is that a goldfish on a bow?");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 64;
            Item.height = 32;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = 1;
            Item.shootSpeed = 6.25f;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 8;
            Item.knockBack = 8.0f;
            Item.crit = 18;

            // Misc
            Item.rare = 1;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(261, 1)
                .AddIngredient(3504, 1)
                //.AddIngredient(9, 1)
                //.AddTile(TileID.Anvils)
                .AddTile(18)
                .Register();
        }
    }
}