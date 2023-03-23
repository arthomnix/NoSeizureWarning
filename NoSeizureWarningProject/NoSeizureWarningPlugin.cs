using BepInEx;
using HarmonyLib;
using SpaceWarp;
using SpaceWarp.API.Mods;

namespace NoSeizureWarning;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(SpaceWarpPlugin.ModGuid, "1.0.0")]
public class NoSeizureWarningPlugin : BaseSpaceWarpPlugin
{
    // These are useful in case some other mod wants to add a dependency to this one
    public const string ModGuid = MyPluginInfo.PLUGIN_GUID;
    public const string ModName = MyPluginInfo.PLUGIN_NAME;
    public const string ModVer = MyPluginInfo.PLUGIN_VERSION;
    
    public static NoSeizureWarningPlugin Instance { get; private set; }

    public void Start()
    {
        Harmony.CreateAndPatchAll(typeof(NoSeizureWarningPlugin).Assembly);
    }

    /// <summary>
    /// Runs when the mod is first initialized.
    /// </summary>
    public override void OnInitialized()
    {
        base.OnInitialized();

        Instance = this;
    }
}
