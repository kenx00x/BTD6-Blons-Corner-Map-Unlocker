﻿using Assets.Scripts.Unity;
using Harmony;
using MelonLoader;
[assembly: MelonInfo(typeof(BTD6_Blons_Corner_Map_Unlocker.Class1), "Blons/Corner Map Unlocker", "1.0.0", "kenx00x")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace BTD6_Blons_Corner_Map_Unlocker
{
	public class Class1 : MelonMod
	{
		public override void OnApplicationStart()
		{
			MelonLogger.Log("Blons/Corner Map Unlocker loaded!");
		}
		[HarmonyPatch(typeof(Game), "Awake")]
		public class Awake_Patch
		{
			[HarmonyPostfix]
			public static void Postfix()
			{
				for (int i = 0; i < Game.instance.mapSet.Maps.items.Length; i++)
				{
					Game.instance.mapSet.Maps.items[i].isBrowserOnly = false;
				}
			}
		}
	}
}