using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class PelagicTomeOfWisdom : ModItem
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
            Item.useTime = 2;//one fifth of the use animation, fires 5 at once
            Item.useAnimation = 100;
            Item.shoot = ProjectileID.WaterStream;
            Item.shoot = ModContent.ProjectileType<Projectiles.Sardine>();
            Item.shootSpeed = 20f;
            Item.reuseDelay = 10;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Magic;
            Item.damage = 25;
            Item.knockBack = 0;
            Item.mana = 25;
            Item.crit = 0;

            // Misc
            Item.rare = 5;

            // Sound
            Item.UseSound = SoundID.Item170;


        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)//makes slighly inaccurate
        {
            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(15));
        }
    }
}

