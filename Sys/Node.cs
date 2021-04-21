using System;

namespace SimulationM.Sys
{
    class Node
    {
        double intensity;
        Claim nowServing;       

       public Node(double mu)
        {
            this.intensity = mu;
            this.nowServing = null;           
        }

        public Claim Apply(Claim claim)
        {
            if (this.nowServing == null)
            {
                claim.SetTime(Utility.GetDelay(intensity));
                this.nowServing = claim;
                return null;
            }
            return claim;
        }

        public Claim Serve()
        {
            if (nowServing != null)
            {
                if (nowServing.RemainingTime == Model.time)
                {
                    Claim toReturn = nowServing;
                    this.nowServing = null;
                    return toReturn;
                }
            }            
            return null;
        }
 
    }
}
