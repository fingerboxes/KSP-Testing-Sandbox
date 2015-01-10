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

            // This doesn't actually work here, it can't happen on the same frame.
            // Not problem in a 'real world' application.
            FlightDriver.SetPause(false);
        }

        public void OnDestroy()
        {
            GameEvents.onGamePause.Remove(OnPause);
        }
    }
}
