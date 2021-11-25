using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoodBosses
{
    public partial class NPCRework : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            switch (npc.type)
            {
                case NPCID.SkeletronHead:
                    NPCID.Sets.TrailCacheLength[npc.type] = 1; //Higher numbers mean longer trails
                    NPCID.Sets.TrailingMode[npc.type] = 0;
                    break;
            }
            base.SetDefaults(npc);
        }
        public override bool PreDraw(NPC npc, SpriteBatch spriteBatch, Color drawColor)
        {
            if(npc.type == NPCID.SkeletronHead && npc.ai[0] == 5f && npc.ai[2] > 30f && npc.ai[2] <= 60f)
            {
                float scalar = npc.ai[2] - 30f;
                scalar /= 30f;
                scalar += 1f;
                Vector2 drawOrigin = new Vector2(Main.npcTexture[npc.type].Width * 0.5f, npc.height * 0.5f);
                Vector2 drawPos = npc.position - Main.screenPosition + drawOrigin + new Vector2(0f, npc.gfxOffY);
                Color color = npc.GetAlpha(drawColor) * .25f;
                spriteBatch.Draw(Main.npcTexture[npc.type], drawPos, npc.frame, color, npc.rotation, drawOrigin, (npc.scale * scalar), SpriteEffects.None, 0f);
            }
            return base.PreDraw(npc, spriteBatch, drawColor);
        }
        public override bool PreAI(NPC npc)
        {
            switch (npc.type)
            {
                //case NPCID.SkeletronHand:
                //    SkeltronHandAI(npc);
                //    return false;
                case NPCID.SkeletronHead:
                    SkeltronHeadAI(npc);
                    return false;
            }
            return base.PreAI(npc);
        }
    }
}