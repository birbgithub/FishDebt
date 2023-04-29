using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items
{
    internal class FishSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fish Soul");
            Tooltip.SetDefault("'The essence of water creatures'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            // Registers a vertical animation with 4 frames and each one will last 5 ticks (1/12 second)
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 7));
			
            ItemID.Sets.AnimatesAsSoul[Item.type] = true; // Makes the item have an animation while in world (not held.). Use in combination with RegisterItemAnimation
            ItemID.Sets.ItemIconPulse[Item.type] = true; // The item pulses while in the player's inventory
			ItemID.Sets.ItemNoGravity[Item.type] = true; // Makes the item have no gravity
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.value = Item.sellPrice(gold: 1, silver: 24);
            Item.maxStack = 99;
        }
            
        public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.70f * Main.essScale); // Makes this item glow when thrown out of inventory.
            }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(520, 1) // Soul of Light
                .AddIngredient(521, 1) // Soul of Night
                .AddIngredient(261, 1) // Goldfish
                .AddTile(77)
                .Register();
        }
    }
}