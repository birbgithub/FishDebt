using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class Goldfish : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goldfish the projectile");
            // Tooltip.SetDefault("'Its not animal abuse, its just a gold fish!'");
        }

        public override void SetDefaults()
        {
            Projectile.width = 32;
            Projectile.height = 32;
            
            Projectile.DamageType = DamageClass.Magic;

            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;

            Projectile.aiStyle = -1;
            Projectile.penetrate = 1;
        }
    }
}