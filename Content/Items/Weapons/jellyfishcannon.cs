using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items.Weapons
{
    internal class jellyfishcannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jellyfish cannon");
            Tooltip.SetDefault("Warning, may sting a little.\nFires electrifying jellyfish");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;

            Item.value = Item.buyPrice(copper: 10);
            Item.maxStack = 1;

            //Use and animations
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 10;
            Item.useAnimation = 20;
            Item.useAmmo = AmmoID.Rocket;
            Item.shoot = ModContent.ProjectileType<Projectiles.jellyfishproj>();
            Item.autoReuse = true;
            Item.shootSpeed = 10;

            //Damage values
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 80;
            Item.knockBack = 5;
            Item.crit = 25;

            //misc
            Item.value = Item.buyPrice(silver: 80);
            Item.rare = ItemRarityID.Pink;

            Item.UseSound = SoundID.Item67;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(2, 5)
                .AddTile(18)
                .Register();
        }
    }
}
