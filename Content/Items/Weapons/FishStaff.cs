using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class FishStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goldfish Staff");
            Tooltip.SetDefault("You now have Fish magic.");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 64;
            Item.height = 32;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 26;
            Item.useAnimation = 26; 
            Item.shoot = ModContent.ProjectileType<Goldfish>();
            Item.shootSpeed = 7.2f;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Magic;
            Item.damage = 28;
            Item.knockBack = 0;
            Item.mana = 4;
            Item.crit = 2;

            // Misc
            Item.rare = 1;

            // Sound
            Item.UseSound = SoundID.Item71;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(261, 1) // Goldfish
                .AddIngredient(743, 1)
                .AddTile(TileID.Anvils)
                .Register();

            CreateRecipe()
                .AddIngredient(261, 1) // Goldfish
                .AddIngredient(744, 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}