using BepInEx;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace UnUltrasYourKill
{
	// Load plugin
	[BepInPlugin("com.coatlessali.uuyk", "Un ULTRAs Your KILL", "1.0.0")]
   	public class Plugin : BaseUnityPlugin
   	{
   		public static Plugin Instance;
   	 	private void Awake()
   	 	{
   	 		Instance = this;
           	// Plugin startup logic
           	Logger.LogInfo("Loaded plugin.");
           	// Honestly should I not provide binaries?
           	Logger.LogWarning("WARNING: Your save files will be DELETED if you die.");
           	// I have no idea what I'm doing
           	Harmony har = new Harmony("com.coatlessali.uuyk");
           	har.PatchAll();
        }
    }

    // Death behavior
	[HarmonyPatch(typeof(LaughingSkull), nameof(LaughingSkull.Start))]
	class PatchDeath // : MonoBehaviour
	{
		static void Postfix()
		{
			int uwu = 1;
			string path = Application.dataPath;
			
			// Darwin is uh, special
    		if (Application.platform == RuntimePlatform.OSXPlayer) {
       			path += "/../../../";
   			}
   			else {
      			path += "/../";
    		}

    		// You know what? Fuck you. *Un-ULTRAs your KILL* 
			string saveDir = Path.Combine(path, "Saves");
			while (uwu <= 5){
				if (Directory.Exists(Path.Combine(saveDir, "Slot" + uwu)))
				{
					Directory.Delete(Path.Combine(saveDir, "Slot") + uwu, true);
				}
				uwu += 1;
			}
			// not actually a crash but I like calling it a crash because of how abrupt it is
			Application.Quit();
		}		
	}
}
