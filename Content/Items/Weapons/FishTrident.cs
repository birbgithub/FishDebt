using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class FishTrident : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goldfish Trident");
            Tooltip.SetDefault("The end culmination of a fish journey.");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 64;
            Item.height = 32;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 10;
            Item.useAnimation = 1; 
            Item.shoot = ModContent.ProjectileType<Goldfish>();
            Item.shootSpeed = 12.5f;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Magic;
            Item.damage = 84;
            Item.knockBack = 0;
            Item.mana = 4;
            Item.crit = 24;

            // Misc
            Item.rare = 5;

            // Sound
            Item.UseSound = SoundID.Item71;
        }

        public override void AddRecipes()
        {
            CreateRecipe() // Corruption
                .AddIngredient(ModContent.ItemType<FishStaff>(), 1) // Fish Staff
                .AddIngredient(261, 1) // Goldfish
                .AddIngredient(2314, 1) // Honeyfin
                .AddIngredient(2315, 1) // Obsidifish
                .AddIngredient(2303, 1) // Armored Cavefish
                .AddIngredient(2318, 1) // Ebonkio
                .AddIngredient(4402, 1) // Rock Lobster
                .AddIngredient(2310, 1) // Prismite
                .AddIngredient(2302, 1) // Neon Tetra
                .AddIngredient(2306, 1) // Frost Minnow
                .AddIngredient(2301, 1) // Red Snapper
                .AddIngredient(2304, 1) // Damselfish


                .AddTile(77)
                .Register();

            CreateRecipe() // Crimson
                .AddIngredient(ModContent.ItemType<FishStaff>(), 1) // Fish Staff
                .AddIngredient(261, 1) // Goldfish
                .AddIngredient(2314, 1) // Honeyfin
                .AddIngredient(2315, 1) // Obsidifish
                .AddIngredient(2303, 1) // Armored Cavefish
                .AddIngredient(2305, 1) // Crimson Tigerfish
                .AddIngredient(4402, 1) // Rock Lobster
                .AddIngredient(2310, 1) // Prismite
                .AddIngredient(2302, 1) // Neon Tetra
                .AddIngredient(2306, 1) // Frost Minnow
                .AddIngredient(2301, 1) // Red Snapper
                .AddIngredient(2304, 1) // Damselfish


                .AddTile(77)
                .Register();
        }
    }
}