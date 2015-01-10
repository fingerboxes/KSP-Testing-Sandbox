using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KSPTesting
{
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    class OverrideLaunchButton : MonoBehaviour
    {
        void Start()
        {
            EditorLogic.fetch.launchBtn.scriptWithMethodToInvoke = this;
            EditorLogic.fetch.launchBtn.methodToInvoke = "LaunchButton";
        }

        void LaunchButton()
        {
            //Insert your code here
        }
    }
}
