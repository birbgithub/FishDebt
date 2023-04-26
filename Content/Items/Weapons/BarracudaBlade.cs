using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class BarracudaBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barracuda Blade");
            Tooltip.SetDefault("mmm.. ferocious");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 128;
            Item.height = 128;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 15;
            Item.knockBack = 1.5f;
            Item.crit = 80;

            // Misc
            Item.rare = 1;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BarracudaEye>(), 5)
                //.AddTile(TileID.Anvils)
                .AddTile(18)
                .Register();
        }
    }
}