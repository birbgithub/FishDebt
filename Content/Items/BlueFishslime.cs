using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace FishDebt.Content.Items
{
    internal class BlueFishslime : ModNPC
    { 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Fishslime");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }

        public override void SetDefaults()
        {
            // Defaults
            NPC.width = 32;
            NPC.height = 22;
            NPC.damage = 7;
            NPC.defense = 2;
            NPC.lifeMax = 25;
            NPC.value = 500f;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;

            // Npc AI Behaviour
            AIType = NPCID.BlueSlime;
            AnimationType = NPCID.GreenSlime;
        }

        //public override float SpawnChance(NPCSpawnInfo spawnInfo)
        //{
            //return SpawnCondition.OverworldDaySlime.Chance * 0.2f;
        //}

        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if (NPC.frameCounter >= 20)
            {
                NPC.frameCounter = 0;
            }
            NPC.frame.Y = (int)NPC.frameCounter / 12 * frameHeight;
        }

        //public override void NPCLoot()
        //{
            //Item.NewItem(NPC.getRect(), 261, Main.rand.Next(1, 1)); // Drops Goldfish
            //Item.NewItem(NPC.getRect(), ItemID.Gel, Main.rand.Next(1, 2)); // Drops Gel
        //}
    }
}