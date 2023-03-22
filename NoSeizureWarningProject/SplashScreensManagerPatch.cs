using HarmonyLib;

namespace NoSeizureWarning;

[HarmonyPatch(typeof(SplashScreensManager))]
[HarmonyPatch("StartAnimations")]
public class SplashScreensManagerPatch
{
    // ReSharper disable once UnusedMember.Local
    // ReSharper disable once InconsistentNaming
    private static void Prefix(SplashScreensManager __instance)
    {
        __instance.gameObject.GetChild("SeizureWarningText_Localized").SetActive(false);
        __instance._firstScreenAnimation.DOComplete();
    }
}