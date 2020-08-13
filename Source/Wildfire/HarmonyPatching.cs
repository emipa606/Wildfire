using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace Wildfire
{
	// Token: 0x02000003 RID: 3
	[StaticConstructorOnStartup]
	internal static class HarmonyPatching
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002082 File Offset: 0x00000282
		static HarmonyPatching()
		{
			new Harmony("com.Pelador.RW.Wildfire").PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
