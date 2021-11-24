using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoodBosses
{
    public partial class NPCRework : GlobalNPC
    {
        public override bool PreAI(NPC npc)
        {
            switch (npc.type)
            {
                case NPCID.SkeletronHand:
                    SkeltronHandAI(npc);
                    return false;
                case NPCID.SkeletronHead:
                    SkeltronHeadAI(npc);
                    return false;
            }
            return base.PreAI(npc);
        }
    }
}