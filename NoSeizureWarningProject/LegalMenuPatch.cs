using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using KSP.Game;
using KSP.Game.StartupFlow;

namespace NoSeizureWarning;

[HarmonyPatch(typeof(LegalMenu), nameof(LegalMenu.OpenPhotosensitivityWarning))]
public class LegalMenuPatch
{
    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    private static bool Prefix(LegalMenu __instance)
    {
        GameManager.Instance.HasPhotosensitivityWarningBeenShown = true;
        __instance.FinishStartupFlow();
        return false;
    }
}