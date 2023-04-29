using Microsoft.Xna.Framework;
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
            Item.width = 10;
            Item.height = 35;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 7;//one fifth of the use animation, fires 5 at once
            Item.useAnimation = 35;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = ModContent.ProjectileType<Projectiles.CrabClipper>();
            Item.shootSpeed = 15;
            Item.autoReuse = true;
            Item.reuseDelay = 10;
            Item.consumeAmmoOnLastShotOnly = true;

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
       public override Vector2? HoldoutOffset()
       {
			return new Vector2(-6f, -2f);//changes position in hands
	   }

       public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)//makes slighly inaccurate
       {
			velocity = velocity.RotatedByRandom(MathHelper.ToRadians(10));
            if (type == ProjectileID.WoodenArrowFriendly) 
            { // or ProjectileID.WoodenArrowFriendly
				type = ModContent.ProjectileType<Projectiles.CrabClipper>();; // or ProjectileID.FireArrow;
	   
       }    }

     
    }   
}