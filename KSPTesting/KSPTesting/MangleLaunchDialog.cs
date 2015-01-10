using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KSPTesting
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    class MangleLaunchDialog : MonoBehaviour
    {
        public void Start()
        {
            GameEvents.onGUILaunchScreenSpawn.Add(onGUILaunchScreenSpawn);
            LaunchSiteFacility lsf = GameObject.FindObjectOfType(typeof(LaunchSiteFacility)) as LaunchSiteFacility;
            Debug.Log("LSF SubFolder: " + lsf.craftSubfolder);

            lsf.craftSubfolder = "VAB-Complete";
        }

        public void onGUILaunchScreenSpawn(GameEvents.VesselSpawnInfo vesselSpawnInfo)
        {
            Debug.Log("Subfolder: " + vesselSpawnInfo.craftSubfolder + " " + "profile: " + vesselSpawnInfo.profileName);
        }
    }
}
