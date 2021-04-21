using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using System.Diagnostics;

namespace SimulationM.Sys
{
    static class Model
    {
        public static Int64 time { get; private set; } = 0;
        public static int eventsInvoked { get; private set; }  = 0;
        public static int EventLimit { get;  set; } = 0;
        static Sys system;
        static List<Int64> stats = new List<Int64>();
        static Int64 lastOrbitEventTime = 0;

        public static void NextMoment()
        {
            system.Process();
            Claim claim = Claim.PopClosestClaim();
            
            if (claim != null)
            {
                if (claim.RemainingTime < Int64.MaxValue)
                    time = claim.RemainingTime;
                else {
                    EventLimit = eventsInvoked; }
            }
            
        }

        public static void SetSystem(Sys system)
        {
            Model.system = system;
        }

        public static void Reset()
        {
            time = 0;
            eventsInvoked = 0;
            lastOrbitEventTime = 0;
            stats.Clear();
            Claim.ClearStorage();
        }

        public static void GatherOrbitStats(int orbitSize)
        {
            if (stats.ElementAtOrDefault(orbitSize) == 0) stats.Insert(orbitSize, 0);
            stats[orbitSize] += Model.time - lastOrbitEventTime;
            lastOrbitEventTime = Model.time;
            eventsInvoked++;
        }

        public static double[] GetCurrentIntervalStatistics()
        {
            double[] result = new double[stats.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = stats[i]/ (double)time;
            }
            return result;
        }

        public static bool IsFinished()
        {
            return EventLimit <= eventsInvoked;
        }

    }
}
