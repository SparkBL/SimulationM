using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace SimulationM.Sys
{
    interface IStream
    {
        Claim Send();
    }

    class SimpleStream : IStream
    {
        Claim nextSend;
        double intensity;

      public SimpleStream(double lambda)
        {
            this.intensity = lambda;
            nextSend = new Claim(Utility.GetDelay(intensity));
        }

     public Claim Send()
        {
            if (this.nextSend.RemainingTime == Model.time)
            {
                Claim ret = nextSend;
                nextSend = new Claim(Utility.GetDelay(intensity));
                return ret;
            }
            return null;
        }    
    }

    class MMPPStream : IStream
    {
        private double[,] ShiftProbs;
        private double[] Lambdas;
        private int matrixSize;
        private Claim shiftDelay;
        public int currentState { get; private set; }
        private Claim nextSend;

        public MMPPStream(double[,] ShiftProbs, double[] Lambdas, int matrixSize)
        {
            this.ShiftProbs = ShiftProbs;
            this.Lambdas = Lambdas;
            this.matrixSize = matrixSize;
            currentState = 0;
            shiftDelay = new Claim( Utility.GetDelay(-ShiftProbs[currentState, currentState]));
            this.nextSend = new Claim(Utility.GetDelay(Lambdas[currentState]));
        }
       
        public Claim Send()
        {          
            if (this.nextSend.RemainingTime == Model.time)
            {
                Claim ret = nextSend;
                this.nextSend = new Claim( Utility.GetDelay(this.Lambdas[currentState]));
                return ret;
            }
            Shift();
            return null;
        }

        private void Shift()
        {   
            if( shiftDelay.RemainingTime == Model.time)
            {
                double prob = Utility.NextDouble();
                double sum = 0;
                for (int i = 0; i< matrixSize;i++)
                {
                    if (i!=currentState)
                    sum += ShiftProbs[currentState, i] / (-ShiftProbs[currentState, currentState]);

                    if (prob <= sum)
                    {
                        currentState = i;
                        shiftDelay = new Claim( Utility.GetDelay(-ShiftProbs[currentState, currentState]));
                        break;
                    }    
                }
            }                  
        }
    }
}
