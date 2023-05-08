using FishDebt.Content.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishDebt.Content.Items.Weapons
{
    internal class GoldfishBall : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goldfish Ball");
            // Tooltip.SetDefault("'Its not animal abuse, its just a gold fish!'");
        }

        public override void SetDefaults()
        {
            Projectile.width = 32;
            Projectile.height = 32;
            
            Projectile.DamageType = DamageClass.Magic;

            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = true;

            Projectile.aiStyle = -1;
            Projectile.penetrate = -1;

        }
        
        public override void AI()
        {
            int dustnumber = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Water, 0f, 0f, 200, default(Color), 0.8f);
	        Main.dust[dustnumber].velocity *= 0.3f;
        
        }
         
    }
}