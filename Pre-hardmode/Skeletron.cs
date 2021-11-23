using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoodBosses
{
	public partial class NPCRework
	{
		public void SkeltronHandAI(NPC npc)
		{
		}
		public void SkeltronHeadAI(NPC npc)
		{
			this.defense = this.defDefense;
			if (this.ai[0] == 0f && Main.netMode != 1)
			{
				this.TargetClosest();
				this.ai[0] = 1f;
				if (this.type != 68)
				{
					int num154 = NPC.NewNPC((int)(base.position.X + (float)(base.width / 2)), (int)base.position.Y + base.height / 2, 36, base.whoAmI);
					Main.npc[num154].ai[0] = -1f;
					Main.npc[num154].ai[1] = base.whoAmI;
					Main.npc[num154].target = this.target;
					Main.npc[num154].netUpdate = true;
					num154 = NPC.NewNPC((int)(base.position.X + (float)(base.width / 2)), (int)base.position.Y + base.height / 2, 36, base.whoAmI);
					Main.npc[num154].ai[0] = 1f;
					Main.npc[num154].ai[1] = base.whoAmI;
					Main.npc[num154].ai[3] = 150f;
					Main.npc[num154].target = this.target;
					Main.npc[num154].netUpdate = true;
				}
			}

		}
	}
}