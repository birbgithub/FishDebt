using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class CrustaceanLongbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crustacean Longbow");
            Tooltip.SetDefault("Made outta crabs'n sh- stuff.");
        }

        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 17;
            Item.height = 35;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 35;
            Item.useAnimation = 35;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = ModContent.ProjectileType<Goldfish>();
            Item.shootSpeed = 10;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 42;
            Item.knockBack = 14.0f;
            Item.crit = 22;

            // Misc
            Item.rare = 3;

            // Sound
            Item.UseSound = SoundID.Item1;
        }
    }
}