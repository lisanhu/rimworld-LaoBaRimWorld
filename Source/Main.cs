using Verse;

// using System.Reflection;
using HarmonyLib;

namespace LaoBa
{
    [StaticConstructorOnStartup]
    public static class Start
    {
        static Start()
        {
            Log.Message("LaoBa's RimWorld loaded successfully!");
        }
    }

}
