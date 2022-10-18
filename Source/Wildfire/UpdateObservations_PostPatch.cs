using HarmonyLib;
using RimWorld;
using Verse;

namespace Wildfire;

[HarmonyPatch(typeof(FireWatcher), "UpdateObservations")]
public class UpdateObservations_PostPatch
{
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
            var list = ___map.listerThings.ThingsOfDef(ThingDefOf.Fire);
            foreach (var thing in list)
            {
                if (thing is Fire fire)
                {
                    num += 0.5f + fire.fireSize;
                }
            }
        }

        ___fireDanger = num;
    }
}