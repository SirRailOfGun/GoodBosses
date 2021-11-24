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
			float enrageTime = 36000f;

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
					npc.ai[0] = 4f;
				}
			}
			//enrage conditions (now timer based rather than Time of Day
			if (npc.ai[3] > enrageTime && npc.ai[0] != 4f && npc.ai[0] != 3f)
			{
				npc.ai[0] = 3f;
				Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
			}

			int liveHands = 0;//number of alive hands
			if (Main.expertMode)
			{
				for (int npcCheck = 0; npcCheck < 200; npcCheck++)	//loop over the first 200 npcs
				{
					if (Main.npc[npcCheck].active && Main.npc[npcCheck].type == npc.type + 1)	//if alive and a skeletron hand, count it
					{
						liveHands++;
					}
				}
				npc.defense += liveHands * 25;	//gain 25 defence for each hand
			}

			//idle mode
			if (npc.ai[0] == 1f)
			{
				npc.damage = npc.defDamage;
				npc.ai[2] += 1f;
				if (npc.ai[2] >= 800f && !Main.expertMode)
				{
					npc.ai[2] = 0f;
					npc.ai[0] = 2f;
					npc.TargetClosest();
					npc.netUpdate = true;
				}
				else if(npc.ai[2] >= 600f)
                {
					npc.ai[2] = 0f;
					npc.ai[0] = 2f;
					int randRoll = Main.rand.Next(6);
					if (randRoll + liveHands <= 1)
					{
						npc.ai[0] = 5f;
					}
					npc.TargetClosest();
					npc.netUpdate = true;
				}
				npc.rotation = npc.velocity.X / 15f;	//lean into movement
				float yAccel = 0.02f;					//Y acceleration
				float ySpeed = 2f;						//Y max speed
				float xAccel = 0.05f;					//X Accelearation
				float xSpeed = 8f;						//X max speed
				if (Main.expertMode)					//Expert mode speed stats
				{
					yAccel = 0.03f;
					ySpeed = 4f;
					xAccel = 0.07f;
					xSpeed = 9.5f;
				}
				if (npc.position.Y > Main.player[npc.target].position.Y - 250f)	//if more than 250 units below
				{
					if (npc.velocity.Y > 0f)			//reduce speed to 98% of current
					{
						npc.velocity.Y *= 0.98f;
					}
					npc.velocity.Y -= yAccel;			//accelerate by .02 or .03 in expert upwards
					if (npc.velocity.Y > ySpeed)		//cap speed
					{
						npc.velocity.Y = ySpeed;
					}
				}
				else if (npc.position.Y < Main.player[npc.target].position.Y - 250f) //same but when above
				{
					if (npc.velocity.Y < 0f)
					{
						npc.velocity.Y *= 0.98f;
					}
					npc.velocity.Y += yAccel;
					if (npc.velocity.Y < 0f - ySpeed)
					{
						npc.velocity.Y = 0f - ySpeed;
					}
				}
				if (npc.position.X + (float)(npc.width / 2) > Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2)) //if right of the player
				{
					if (npc.velocity.X > 0f)			//same deal
					{
						npc.velocity.X *= 0.98f;
					}
					npc.velocity.X -= xAccel;			//accelerate by .05 or .07
					if (npc.velocity.X > xSpeed)		//cap speed
					{
						npc.velocity.X = xSpeed;
					}
				}
				if (npc.position.X + (float)(npc.width / 2) < Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2)) //if left
				{
					if (npc.velocity.X < 0f)
					{
						npc.velocity.X *= 0.98f;
					}
					npc.velocity.X += xAccel;
					if (npc.velocity.X < 0f - xSpeed)
					{
						npc.velocity.X = 0f - xSpeed;
					}
				}
			}
			//attack mode
			else if (npc.ai[0] == 2f)
			{
				npc.ai[2] += 1f;
				if (npc.ai[2] == 1)       //pick a direction to dash from
				{
					npc.ai[1] = (Main.rand.Next(2) * 2) - 1;
				}
				float leadTime = 90f;
				float holdTime = 60f;
				float dashTime = 40f;
				float speedFactor = 1.5f;
				if (Main.expertMode)
				{
					npc.damage = (int)((double)npc.defDamage * 1.3);
					speedFactor = 4f;
					switch (liveHands)  //makes the head faster in expert mode for each dead hand
					{
						case 0:
							speedFactor *= 1.2f;
							break;
						case 1:
							speedFactor *= 1.1f;
							break;
					}
				}
				if (Main.expertMode)
                {
					leadTime = 60f;
					holdTime = 30f;
                }
				if (npc.ai[2] < leadTime)       //move to above the player
				{
					Vector2 skullCenter = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);					//center of the skull
					float xDist = (Main.player[npc.target].position.X + (384f * npc.ai[1])) + (float)(Main.player[npc.target].width / 2) - skullCenter.X;	//24 tiles horiz
					float yDist = (Main.player[npc.target].position.Y - 128f) + (float)(Main.player[npc.target].height / 2) - skullCenter.Y;				//8 tiles up
					float realDist = (float)Math.Sqrt(xDist * xDist + yDist * yDist);																		//distance to target
					
					realDist = speedFactor / realDist;
					npc.velocity.X = xDist * realDist;
					npc.velocity.Y = yDist * realDist;

				}
				else if (npc.ai[2] > leadTime)	//dash chargeup
                {
					npc.defense -= 10;
					npc.rotation += (float)npc.direction * 0.3f;

					npc.velocity.X = 0;
					npc.velocity.Y = 0;
				}
				else							//roar when starting dash
				{
					Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
					npc.rotation += (float)npc.direction * 0.3f;
				}
				if (npc.ai[2] > leadTime + holdTime)//dash
                {
					npc.velocity.X = -3f * npc.ai[1];
					npc.velocity.Y = 1.5f;
					if (Main.expertMode)
                    {
						npc.velocity.X *= 2f;
						npc.velocity.Y *= 2f;
						dashTime /= 2;
					}
				}
				if (npc.ai[2] >= leadTime + holdTime + dashTime) //reset to idle mode
				{
					npc.ai[0] = 1f;
					npc.ai[1] = 0f;
					npc.ai[2] = 0f;
				}
			}
			//Summon Skull Attack
			else if (npc.ai[0] == 5f)
			{
				npc.ai[2] += 1f;
				float slowRate = 1 - npc.ai[2] / 100;
				if (npc.velocity.Y != 0f)		//slow down
				{
					npc.velocity.Y *= slowRate;
				}
				if (npc.velocity.X != 0f)
				{
					npc.velocity.X *= slowRate;
				}
				if (npc.ai[2] == 30f)
				{
					Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
				}
				if (npc.ai[2] == 61f)
                {
					//spawn the skulls
					int numbSkull = Main.rand.Next(3);
					if (Main.expertMode)
                    {
						numbSkull += Main.rand.Next(2) + 1;
                    }
					numbSkull = (numbSkull * 2) + 3;
					for (int i = 0; i < numbSkull; i++)
					{
						float randoffset = (float)Math.Sin(((float)i - .5f) * (float)(Math.PI / 1));
						randoffset *= (Main.rand.Next(5) * 5 * i);
						int newHand = NPC.NewNPC((int)(Main.player[npc.target].position.X + (randoffset * 5)), (int)Main.player[npc.target].position.Y + (Main.screenHeight / 2) + 32, 34, npc.whoAmI);
						Main.npc[newHand].netUpdate = true;
					}
				}
				if (npc.ai[2] > 90f)
				{
					npc.ai[2] = 300f;
					npc.ai[0] = 1f;
				}
            }
			//enrage mode
			else if (npc.ai[0] == 3f)	
			{
				npc.damage = 1000;
				npc.defense = 9999;
				npc.rotation += (float)npc.direction * 0.3f;
				Vector2 vector21 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
				float num176 = Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2) - vector21.X;
				float num177 = Main.player[npc.target].position.Y + (float)(Main.player[npc.target].height / 2) - vector21.Y;
				float num178 = (float)Math.Sqrt(num176 * num176 + num177 * num177);
				num178 = 8f / num178;
				npc.velocity.X = num176 * num178;
				npc.velocity.Y = num177 * num178;
			}
			//despawn mode
			else if (npc.ai[0] == 4f)
			{
				npc.velocity.Y += 0.1f;
				if (npc.velocity.Y < 0f)
				{
					npc.velocity.Y *= 0.95f;
				}
				npc.velocity.X *= 0.95f;
				if (npc.timeLeft > 50)
				{
					npc.timeLeft = 50;
				}
			}

			//spawn blood dusts
			if (npc.ai[0] != 3f && npc.ai[0] != 4f && npc.type != NPCID.DungeonGuardian && (liveHands != 0 || !Main.expertMode))
			{
				int dustNew = Dust.NewDust(new Vector2(npc.position.X + (float)(npc.width / 2) - 15f - npc.velocity.X * 5f, npc.position.Y + (float)npc.height - 2f), 30, 10, DustID.Blood, (0f - npc.velocity.X) * 0.2f, 3f, 0, default(Color), 2f);
				Main.dust[dustNew].noGravity = true;
				Main.dust[dustNew].velocity.X *= 1.3f;
				Main.dust[dustNew].velocity.X += npc.velocity.X * 0.4f;
				Main.dust[dustNew].velocity.Y += 2f + npc.velocity.Y;
				for (int i = 0; i < 2; i++)
				{
					dustNew = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y + 120f), npc.width, 60, DustID.Blood, npc.velocity.X, npc.velocity.Y, 0, default(Color), 2f);
					Main.dust[dustNew].noGravity = true;
					Dust dust = Main.dust[dustNew];
					dust.velocity -= npc.velocity;
					Main.dust[dustNew].velocity.Y += 5f;
				}
			}

			npc.ai[3]++;//increment enrage timer
		}
	}
}