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
            LaunchSiteFacility[] lsf = GameObject.FindObjectsOfType(typeof(LaunchSiteFacility)) as LaunchSiteFacility[];

            foreach (LaunchSiteFacility f in lsf)
            {
                Debug.Log("LSF SubFolder: " + f.craftSubfolder);
                f.craftSubfolder = f.craftSubfolder + "-Complete";
            }
        }

        public void onGUILaunchScreenSpawn(GameEvents.VesselSpawnInfo vesselSpawnInfo)
        {
            Debug.Log("Subfolder: " + vesselSpawnInfo.craftSubfolder + " " + "profile: " + vesselSpawnInfo.profileName);

            EditorLogic fakeEditor = new EditorLogic();

            CraftBrowser cb = new CraftBrowser(new Rect((float)(((double)Screen.width - (double)Camera.main.rect.x) / 2.0) + Camera.main.rect.x, (float)((double)Screen.height / 2.0 - 250.0), 350f, 500f),
                EditorFacility.VAB,
                HighLogic.SaveFolder,
                "VAB", 
                new CraftBrowser.SelectedCallback(this.shipToLoadSelected),
                new CraftBrowser.CancelledCallback(this.craftBrowseCancelled),
                fakeEditor.shipBrowserSkin,
                fakeEditor.shipFileImage, 
                false);
        }

        public void shipToLoadSelected(string path, string flagURL)
        {

        }

        public void craftBrowseCancelled()
        {

        }
    }
}
