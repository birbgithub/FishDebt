/*using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FishDebt.Content.NPCs
{
    [AutoloadHead]

    public class FishDebtTownNPC : ModNPC
    {

        public override string Texture
        {
            get { return "FishDebt/NPCs/FishDebtTownNPC"; }
        }


        public override string[] AltTextures
        {
            get { return new[] { "FishDebt/NPCs/FishDebtTownNPC_Alt_1" }; }
        }

        public override bool AutoLoad(ref string name)
        {
            name = "Mermaid";
            return Mod.Properties/* tModPorter Note: Removed. Instead, assign the properties directly (ContentAutoloadingEnabled, GoreAutoloadingEnabled, MusicAutoloadingEnabled, and BackgroundAutoloadingEnabled) .AutoLoad;
        }

        public override void SetStaticDefaults()
        {
            Main.mpcFrameCount[NPC.type] = 26;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 9;
            NPCID.Sets.AttackFrameCount[NPC.type] = 5;
            NPCID.Sets.DangerDetectRange[NPC.type] = 700;
            NPCID.Sets.AttackType[NPC.type] = 0;
            NPCID.Sets.AttackTime[NPC.type] = 90;
            NPCID.Sets.AttackAverageChance[NPC.type] = 30;
            NPCID.Sets.HatOffsetY[NPC.type] = 4;
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 40;
            NPC.aiStyle = 7;
            NPC.damage = 12;
            NPC.defense = 17;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                foreach (Item item in player.inventory)
                {
                    if (item.type == Mod.Find<ModItem>("Sakana").Type)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override List<string> SetNPCNameList()/* tModPorter Suggestion: Return a list of names 
        {
            switch (WorldGen.GenRand.Next(4))
            {
                case 0:
                    return "Ariel";
                case 1:
                    return "Marina";
                case 2:
                    return "Kailani";
                case 3:
                    return "Nori";
                default:
                    return "Yara";
            }
        }

        public override string GetChat()
        {
            int otherNPC = NPC.FindFirstNPC(NPCID.Angler);
        }
    }
}*/