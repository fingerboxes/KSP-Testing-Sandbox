using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KSPTesting
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class OverridePauseMenu : MonoBehaviour
    {
        public void Start()
        {
            GameEvents.onGamePause.Add(OnPause);
        }

        public void OnPause()
        {
            // Kill vanilla pause menu, doesn't even render for 1 frame!
            PauseMenu.Close();

            DialogOption[] options = { new DialogOption("Resume Simulation", invokeResume),                                         
                                       new DialogOption("Build this Vessel", invokeBuild),
                                       new DialogOption("Abort Simulation", invokeAbort), 
                                       new DialogOption("Restart Simulation", invokeRestart),
                                       new DialogOption("Settings", invokeSettings)};

            PopupDialog.SpawnPopupDialog(new MultiOptionDialog(null, 
                                                               "Game Paused - Simulation", 
                                                               (GameObject.FindObjectOfType(typeof(PauseMenu)) as PauseMenu).guiSkin, 
                                                               options), 
                                                               false,
                                                               HighLogic.Skin);
        }

        public void invokeResume()
        {

        }

        public void invokeBuild()
        {

        }

        public void invokeAbort()
        {

        }

        public void invokeRestart()
        {

        }

        public void invokeSettings()
        {

        }

        public void OnDestroy()
        {
            GameEvents.onGamePause.Remove(OnPause);
        }
    }
}
