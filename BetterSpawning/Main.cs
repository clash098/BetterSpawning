using System;
using System.Collections.Generic;
using BepInEx;
using GorillaLocomotion;
using UnityEngine;

namespace BetterSpawning;

[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
public class Main : BaseUnityPlugin
{
    private static Main? _instance;
    
    private void Start()
    {
        _instance ??= this;

        GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);
    }

    private void OnPlayerSpawned()
    {
        GTPlayer.Instance.TeleportTo(new Vector3(-63.5f, 12.50f, -82.75f),  new Quaternion(0, 0, 0, 0));
        GTPlayer.Instance.Turn(-135);
    }
}