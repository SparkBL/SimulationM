using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationM.Sys
{
    class Claim
    {
        public Int64 RemainingTime { get; private set; }
        static private List<Claim> Claims = new List<Claim>();

        public Claim(Int64 time)
        {
            try
            {
                checked
                {
                    if (time != Int64.MaxValue)
                    {
                        Claims.Add(this);
                        this.RemainingTime = Model.time + time;
                        
                    }
                    else throw new OverflowException();
                }
            }
            catch (OverflowException ex)
            {
                this.RemainingTime = Int64.MaxValue;
            }
        }

        public void SetTime(Int64 time)
        {
            Claims.Remove(this);
            try
            {
                checked { this.RemainingTime = Model.time + time; Claims.Add(this); }
            }
            catch (OverflowException ex)
            {
                this.RemainingTime = Int64.MaxValue;
            }
        }

        static public Claim PopClosestClaim()
        {
            if (Claims.Count > 0)
            {
                Claim claim = Claims.Aggregate((curMin, x) => x.RemainingTime < curMin.RemainingTime ? x : curMin);
                Claims.Remove(claim);
                return claim;
            }
            return null;
        }
        static public void ClearStorage()
        {
            Claims.Clear();
        }

        ~Claim()
        {
            Claims.Remove(this);
        }
    }
}
