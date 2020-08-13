using System;
using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace Wildfire
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(FireWatcher), "UpdateObservations")]
	public class UpdateObservations_PostPatch
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002120 File Offset: 0x00000320
		[HarmonyPostfix]
		public static void PostFix(ref FireWatcher __instance, ref float ___fireDanger, ref Map ___map)
		{
			float num;
			if (Controller.Settings.AllowLrgFire)
			{
				num = 0f;
			}
			else
			{
				num = 0f;
				List<Thing> list = ___map.listerThings.ThingsOfDef(ThingDefOf.Fire);
				for (int i = 0; i < list.Count; i++)
				{
					Fire fire = list[i] as Fire;
					num += 0.5f + fire.fireSize;
				}
			}
			___fireDanger = num;
		}
	}
}
