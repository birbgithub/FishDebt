using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class FlavoEnsis : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flavo-Ensis");
            Tooltip.SetDefault("The Muramasa but coated in compressed Goldfish.\nFires flying goldish from its blade.");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 128;
            Item.height = 128;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.value = 40000;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Melee;
            Item.knockBack = 1;
            Item.crit = 4;
            Item.damage = 72;

            // Misc
            Item.rare = 3;
            // Item.shoot = ModContent.ProjectileType<Goldfish>();
            Item.shoot = 116;
            Item.shootSpeed = 9.8f;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Sakana>(), 1) // Sakana
                .AddIngredient(ModContent.ItemType<FishSoul>(), 8) // Fish Soul
                .AddIngredient(724, 1) // Ice Blade
                //.AddTile(TileID.Anvils)
                .AddTile(77)
                .Register();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 60);
        }
    }
}