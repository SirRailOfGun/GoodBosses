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
			//npc.spriteDirection = -(int)npc.ai[0];
			//if (!Main.npc[(int)npc.ai[1]].active || Main.npc[(int)npc.ai[1]].aiStyle != 11)
			//{
			//	npc.ai[2] += 10f;
			//	if (npc.ai[2] > 50f || Main.netMode != 2)
			//	{
			//		npc.life = -1;
			//		npc.HitEffect();
			//		npc.active = false;
			//	}
			//}
			//if (npc.ai[2] == 0f || npc.ai[2] == 3f)
			//{
			//	if (Main.npc[(int)npc.ai[1]].ai[1] == 3f && npc.timeLeft > 10)
			//	{
			//		npc.timeLeft = 10;
			//	}
			//	if (Main.npc[(int)npc.ai[1]].ai[1] != 0f)
			//	{
			//		if (npc.position.Y > Main.npc[(int)npc.ai[1]].position.Y - 100f)
			//		{
			//			if (npc.velocity.Y > 0f)
			//			{
			//				npc.velocity.Y *= 0.96f;
			//			}
			//			npc.velocity.Y -= 0.07f;
			//			if (npc.velocity.Y > 6f)
			//			{
			//				npc.velocity.Y = 6f;
			//			}
			//		}
			//		else if (npc.position.Y < Main.npc[(int)npc.ai[1]].position.Y - 100f)
			//		{
			//			if (npc.velocity.Y < 0f)
			//			{
			//				npc.velocity.Y *= 0.96f;
			//			}
			//			npc.velocity.Y += 0.07f;
			//			if (npc.velocity.Y < -6f)
			//			{
			//				npc.velocity.Y = -6f;
			//			}
			//		}
			//		if (npc.position.X + (float)(npc.width / 2) > Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 120f * npc.ai[0])
			//		{
			//			if (npc.velocity.X > 0f)
			//			{
			//				npc.velocity.X *= 0.96f;
			//			}
			//			npc.velocity.X -= 0.1f;
			//			if (npc.velocity.X > 8f)
			//			{
			//				npc.velocity.X = 8f;
			//			}
			//		}
			//		if (npc.position.X + (float)(npc.width / 2) < Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 120f * npc.ai[0])
			//		{
			//			if (npc.velocity.X < 0f)
			//			{
			//				npc.velocity.X *= 0.96f;
			//			}
			//			npc.velocity.X += 0.1f;
			//			if (npc.velocity.X < -8f)
			//			{
			//				npc.velocity.X = -8f;
			//			}
			//		}
			//	}
			//	else
			//	{
			//		npc.ai[3] += 1f;
			//		if (Main.expertMode)
			//		{
			//			npc.ai[3] += 0.5f;
			//		}
			//		if (npc.ai[3] >= 300f)
			//		{
			//			npc.ai[2] += 1f;
			//			npc.ai[3] = 0f;
			//			npc.netUpdate = true;
			//		}
			//		if (Main.expertMode)
			//		{
			//			if (npc.position.Y > Main.npc[(int)npc.ai[1]].position.Y + 230f)
			//			{
			//				if (npc.velocity.Y > 0f)
			//				{
			//					npc.velocity.Y *= 0.96f;
			//				}
			//				npc.velocity.Y -= 0.04f;
			//				if (npc.velocity.Y > 3f)
			//				{
			//					npc.velocity.Y = 3f;
			//				}
			//			}
			//			else if (npc.position.Y < Main.npc[(int)npc.ai[1]].position.Y + 230f)
			//			{
			//				if (npc.velocity.Y < 0f)
			//				{
			//					npc.velocity.Y *= 0.96f;
			//				}
			//				npc.velocity.Y += 0.04f;
			//				if (npc.velocity.Y < -3f)
			//				{
			//					npc.velocity.Y = -3f;
			//				}
			//			}
			//			if (npc.position.X + (float)(npc.width / 2) > Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0])
			//			{
			//				if (npc.velocity.X > 0f)
			//				{
			//					npc.velocity.X *= 0.96f;
			//				}
			//				npc.velocity.X -= 0.07f;
			//				if (npc.velocity.X > 8f)
			//				{
			//					npc.velocity.X = 8f;
			//				}
			//			}
			//			if (npc.position.X + (float)(npc.width / 2) < Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0])
			//			{
			//				if (npc.velocity.X < 0f)
			//				{
			//					npc.velocity.X *= 0.96f;
			//				}
			//				npc.velocity.X += 0.07f;
			//				if (npc.velocity.X < -8f)
			//				{
			//					npc.velocity.X = -8f;
			//				}
			//			}
			//		}
			//		if (npc.position.Y > Main.npc[(int)npc.ai[1]].position.Y + 230f)
			//		{
			//			if (npc.velocity.Y > 0f)
			//			{
			//				npc.velocity.Y *= 0.96f;
			//			}
			//			npc.velocity.Y -= 0.04f;
			//			if (npc.velocity.Y > 3f)
			//			{
			//				npc.velocity.Y = 3f;
			//			}
			//		}
			//		else if (npc.position.Y < Main.npc[(int)npc.ai[1]].position.Y + 230f)
			//		{
			//			if (npc.velocity.Y < 0f)
			//			{
			//				npc.velocity.Y *= 0.96f;
			//			}
			//			npc.velocity.Y += 0.04f;
			//			if (npc.velocity.Y < -3f)
			//			{
			//				npc.velocity.Y = -3f;
			//			}
			//		}
			//		if (npc.position.X + (float)(npc.width / 2) > Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0])
			//		{
			//			if (npc.velocity.X > 0f)
			//			{
			//				npc.velocity.X *= 0.96f;
			//			}
			//			npc.velocity.X -= 0.07f;
			//			if (npc.velocity.X > 8f)
			//			{
			//				npc.velocity.X = 8f;
			//			}
			//		}
			//		if (npc.position.X + (float)(npc.width / 2) < Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0])
			//		{
			//			if (npc.velocity.X < 0f)
			//			{
			//				npc.velocity.X *= 0.96f;
			//			}
			//			npc.velocity.X += 0.07f;
			//			if (npc.velocity.X < -8f)
			//			{
			//				npc.velocity.X = -8f;
			//			}
			//		}
			//	}
			//	Vector2 vector22 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			//	float num181 = Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0] - vector22.X;
			//	float num182 = Main.npc[(int)npc.ai[1]].position.Y + 230f - vector22.Y;
			//	float num183 = (float)Math.Sqrt(num181 * num181 + num182 * num182);
			//	npc.rotation = (float)Math.Atan2(num182, num181) + 1.57f;
			//}
			//else if (npc.ai[2] == 1f)
			//{
			//	Vector2 vector23 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			//	float num184 = Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0] - vector23.X;
			//	float num185 = Main.npc[(int)npc.ai[1]].position.Y + 230f - vector23.Y;
			//	float num186 = (float)Math.Sqrt(num184 * num184 + num185 * num185);
			//	npc.rotation = (float)Math.Atan2(num185, num184) + 1.57f;
			//	npc.velocity.X *= 0.95f;
			//	npc.velocity.Y -= 0.1f;
			//	if (Main.expertMode)
			//	{
			//		npc.velocity.Y -= 0.06f;
			//		if (npc.velocity.Y < -13f)
			//		{
			//			npc.velocity.Y = -13f;
			//		}
			//	}
			//	else if (npc.velocity.Y < -8f)
			//	{
			//		npc.velocity.Y = -8f;
			//	}
			//	if (npc.position.Y < Main.npc[(int)npc.ai[1]].position.Y - 200f)
			//	{
			//		npc.TargetClosest();
			//		npc.ai[2] = 2f;
			//		vector23 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			//		num184 = Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2) - vector23.X;
			//		num185 = Main.player[npc.target].position.Y + (float)(Main.player[npc.target].height / 2) - vector23.Y;
			//		num186 = (float)Math.Sqrt(num184 * num184 + num185 * num185);
			//		num186 = ((!Main.expertMode) ? (18f / num186) : (21f / num186));
			//		npc.velocity.X = num184 * num186;
			//		npc.velocity.Y = num185 * num186;
			//		npc.netUpdate = true;
			//	}
			//}
			//else if (npc.ai[2] == 2f)
			//{
			//	if (npc.position.Y > Main.player[npc.target].position.Y || npc.velocity.Y < 0f)
			//	{
			//		npc.ai[2] = 3f;
			//	}
			//}
			//else if (npc.ai[2] == 4f)
			//{
			//	Vector2 vector24 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			//	float num187 = Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 200f * npc.ai[0] - vector24.X;
			//	float num188 = Main.npc[(int)npc.ai[1]].position.Y + 230f - vector24.Y;
			//	float num189 = (float)Math.Sqrt(num187 * num187 + num188 * num188);
			//	npc.rotation = (float)Math.Atan2(num188, num187) + 1.57f;
			//	npc.velocity.Y *= 0.95f;
			//	npc.velocity.X += 0.1f * (0f - npc.ai[0]);
			//	if (Main.expertMode)
			//	{
			//		npc.velocity.X += 0.07f * (0f - npc.ai[0]);
			//		if (npc.velocity.X < -12f)
			//		{
			//			npc.velocity.X = -12f;
			//		}
			//		else if (npc.velocity.X > 12f)
			//		{
			//			npc.velocity.X = 12f;
			//		}
			//	}
			//	else if (npc.velocity.X < -8f)
			//	{
			//		npc.velocity.X = -8f;
			//	}
			//	else if (npc.velocity.X > 8f)
			//	{
			//		npc.velocity.X = 8f;
			//	}
			//	if (npc.position.X + (float)(npc.width / 2) < Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - 500f || npc.position.X + (float)(npc.width / 2) > Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) + 500f)
			//	{
			//		npc.TargetClosest();
			//		npc.ai[2] = 5f;
			//		vector24 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			//		num187 = Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2) - vector24.X;
			//		num188 = Main.player[npc.target].position.Y + (float)(Main.player[npc.target].height / 2) - vector24.Y;
			//		num189 = (float)Math.Sqrt(num187 * num187 + num188 * num188);
			//		num189 = ((!Main.expertMode) ? (17f / num189) : (22f / num189));
			//		npc.velocity.X = num187 * num189;
			//		npc.velocity.Y = num188 * num189;
			//		npc.netUpdate = true;
			//	}
			//}
			//else if (npc.ai[2] == 5f && ((npc.velocity.X > 0f && npc.position.X + (float)(npc.width / 2) > Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2)) || (npc.velocity.X < 0f && npc.position.X + (float)(npc.width / 2) < Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2))))
			//{
			//	npc.ai[2] = 0f;
			//}
		}
		public void SkeltronHeadAI(NPC npc)
		{
            npc.defense = npc.defDefense;

			//Spawn the hands
            if (npc.ai[0] == 0f && Main.netMode != NetmodeID.MultiplayerClient)
            {
                npc.TargetClosest();
                npc.ai[0] = 1f;
                if (npc.type != NPCID.DungeonGuardian)
                {
                    int newHand = NPC.NewNPC((int)(npc.position.X + (float)(npc.width / 2)), (int)npc.position.Y + npc.height / 2, 36, npc.whoAmI);
                    Main.npc[newHand].ai[0] = -1f;
                    Main.npc[newHand].ai[1] = npc.whoAmI;
                    Main.npc[newHand].target = npc.target;
                    Main.npc[newHand].netUpdate = true;
                    newHand = NPC.NewNPC((int)(npc.position.X + (float)(npc.width / 2)), (int)npc.position.Y + npc.height / 2, 36, npc.whoAmI);
                    Main.npc[newHand].ai[0] = 1f;
                    Main.npc[newHand].ai[1] = npc.whoAmI;
                    Main.npc[newHand].ai[3] = 150f;
                    Main.npc[newHand].target = npc.target;
                    Main.npc[newHand].netUpdate = true;
                }
            }

			//If the current target id dead or fucks off, retarget
			if (Main.player[npc.target].dead || Math.Abs(npc.position.X - Main.player[npc.target].position.X) > 2000f || Math.Abs(npc.position.Y - Main.player[npc.target].position.Y) > 2000f)
			{
				npc.TargetClosest();
				//if the next closest target is also dead or fucked off, start despawning
				if (Main.player[npc.target].dead || Math.Abs(npc.position.X - Main.player[npc.target].position.X) > 2000f || Math.Abs(npc.position.Y - Main.player[npc.target].position.Y) > 2000f)
				{
					npc.ai[1] = 3f;
				}
			}
			//enrage
			if (npc.ai[3] > 36000f && npc.ai[1] != 3f && npc.ai[1] != 2f)
			{
				npc.ai[1] = 2f;
				Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
			}

			if (npc.ai[1] == 0f)
			{
				npc.damage = npc.defDamage;
				npc.ai[2] += 1f;
				if (npc.ai[2] >= 800f)
				{
					npc.ai[2] = 0f;
					npc.ai[1] = 1f;
					npc.TargetClosest();
					npc.netUpdate = true;
				}
				npc.rotation = npc.velocity.X / 15f;	//lean into movement
				float num168 = 0.02f;					//Y acceleration
				float num169 = 2f;						//Y max speed
				float num170 = 0.05f;					//X Accelearation
				float num171 = 8f;						//X max speed
				if (Main.expertMode)					//Expert mode speed stats
				{
					num168 = 0.03f;
					num169 = 4f;
					num170 = 0.07f;
					num171 = 9.5f;
				}
				if (npc.position.Y > Main.player[npc.target].position.Y - 250f)	//if more than 250 units below
				{
					if (npc.velocity.Y > 0f)			//reduce speed to 98% of current
					{
						npc.velocity.Y *= 0.98f;
					}
					npc.velocity.Y -= num168;			//accelerate by .02 or .03 in expert upwards
					if (npc.velocity.Y > num169)		//cap speed
					{
						npc.velocity.Y = num169;
					}
				}
				else if (npc.position.Y < Main.player[npc.target].position.Y - 250f) //same but when above
				{
					if (npc.velocity.Y < 0f)
					{
						npc.velocity.Y *= 0.98f;
					}
					npc.velocity.Y += num168;
					if (npc.velocity.Y < 0f - num169)
					{
						npc.velocity.Y = 0f - num169;
					}
				}
				if (npc.position.X + (float)(npc.width / 2) > Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2)) //if right of the player
				{
					if (npc.velocity.X > 0f)			//same deal
					{
						npc.velocity.X *= 0.98f;
					}
					npc.velocity.X -= num170;			//accelerate by .05 or .07
					if (npc.velocity.X > num171)		//cap speed
					{
						npc.velocity.X = num171;
					}
				}
				if (npc.position.X + (float)(npc.width / 2) < Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2)) //if left
				{
					if (npc.velocity.X < 0f)
					{
						npc.velocity.X *= 0.98f;
					}
					npc.velocity.X += num170;
					if (npc.velocity.X < 0f - num171)
					{
						npc.velocity.X = 0f - num171;
					}
				}
			}
		}
	}
}