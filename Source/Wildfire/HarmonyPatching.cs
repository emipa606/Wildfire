using System.Reflection;
using HarmonyLib;
using Verse;

namespace Wildfire;

[StaticConstructorOnStartup]
internal static class HarmonyPatching
{
    static HarmonyPatching()
    {
        new Harmony("com.Pelador.RW.Wildfire").PatchAll(Assembly.GetExecutingAssembly());
    }
}