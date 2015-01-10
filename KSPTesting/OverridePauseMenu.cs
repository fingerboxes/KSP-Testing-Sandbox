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
            PauseMenu.Close();

            GUISkin guiSkin = (GameObject.FindObjectOfType(typeof(PauseMenu)) as PauseMenu).guiSkin;

            DialogOption[] options = { new DialogOption("Resume Simulation", invokeResume),                                         
                                       new DialogOption("Build this Vessel", invokeBuild),
                                       new DialogOption("Abort Simulation", invokeAbort), 
                                       new DialogOption("Restart Simulation", invokeRestart),
                                       new DialogOption("Settings", invokeSettings)};

            PopupDialog.SpawnPopupDialog(new MultiOptionDialog(null, "Game Paused - Simulation", guiSkin, options), false, guiSkin);
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
