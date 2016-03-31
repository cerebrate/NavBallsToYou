using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KSP.UI.Screens.Flight ;

namespace ArkaneSystems.KerbalSpaceProgram.NavBallsToYou
{
    [KSPAddon (KSPAddon.Startup.Flight, true)]
    public class NavBallsToYou : UnityEngine.MonoBehaviour
    {
        void Start ()
        {
            MapView.OnEnterMapView += () =>
                                      {
                                          if (NavBallToggle.Instance.ManeuverModeActive == false)
                                            NavBallToggle.Instance.overrideButton.onClick.Invoke () ;
                                      } ;
        }
    }
}
