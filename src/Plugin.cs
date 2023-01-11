global using System;
global using System.Linq;
global using System.Text;
global using System.Collections.Generic;
global using UnityEngine;

using BepInEx;

namespace TestMod;

// Add target_game_version and youtube_trailer_id to modinfo.json if applicable.
// See https://rainworldmodding.miraheze.org/wiki/Downpour_Reference/Mod_Directories

[BepInPlugin("com.author.testmod", "Test Mod", "0.1.0")]
sealed class Plugin : BaseUnityPlugin
{
    public void OnEnable()
    {
        On.RainWorld.OnModsInit += Init;
    }

    private void Init(On.RainWorld.orig_OnModsInit orig, RainWorld self)
    {
        orig(self);

        Logger.LogDebug("Hello world!");
    }
}
