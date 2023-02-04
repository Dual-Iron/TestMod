using BepInEx;
using System.Security.Permissions;

#pragma warning disable CS0618 // Do not remove the following line.
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace TestMod;

[BepInPlugin("com.author.testmod", "Test Mod", "0.1.0")]
sealed class Plugin : BaseUnityPlugin
{
    bool init;

    public void OnEnable()
    {
        // Add hooks here.
        On.RainWorld.OnModsInit += Init;
    }

    private void Init(On.RainWorld.orig_OnModsInit orig, RainWorld self)
    {
        orig(self);

        if (!init) {
            init = true;

            // Initialize assets, your mod config, and anything that uses RainWorld here.
            Logger.LogDebug("Hello world!");
        }
    }
}
