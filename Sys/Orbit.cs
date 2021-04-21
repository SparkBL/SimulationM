using System;
using System.Collections.Generic;

namespace SimulationM.Sys
{
    class Orbit
    {
        List<Claim> Claims;
        double intensity;
      public  Orbit( double sigma)
        {
            this.intensity = sigma;
            Claims = new List<Claim>();
        }
       
        public void Push(Claim claim)
        {
            Model.GatherOrbitStats(Claims.Count);
            claim.SetTime(Utility.GetDelay(intensity));
            Claims.Add(claim);
        }

        public Claim Send()
        {
            Claim toSend = Claims.Find(claim => claim.RemainingTime == Model.time);
            if (toSend != null)
            {
                Model.GatherOrbitStats(Claims.Count);
                Claims.Remove(toSend);
            }
            return toSend;
        }
       
    }
}
