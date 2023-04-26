using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class Sakana : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sakana");
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
            Item.damage = 25;
            Item.knockBack = 1.8f;
            Item.crit = 8;

            // Misc
            Item.rare = 3;
            Item.shoot = ModContent.ProjectileType<Goldfish>();
            // Item.shoot = 116;
            Item.shootSpeed = 7.2f;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(155, 1) // Muramasa
                .AddIngredient(261, 1) // Goldfish
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