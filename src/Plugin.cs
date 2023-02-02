global using System;
global using System.Linq;
global using System.Collections.Generic;
global using UnityEngine;

using BepInEx;
using System.Security.Permissions;

#pragma warning disable CS0618 // Do not remove the following line.
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace TestMod;

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
