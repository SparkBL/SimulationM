using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace SimulationM.Sys
{
    static class Utility
    {
        const double TimeCoeff = 1000;
        static RandomNumberGenerator rg = RandomNumberGenerator.Create();
        static Random gen = new Random(DateTime.Now.Second);
        
        public  static Int64 GetDelay( double intensity)
        {
            unchecked
            {
                Int64 a = (Int64)Math.Ceiling(TimeCoeff * (Math.Log(1.00 - NextDouble()) / -intensity));
                if (a == Int64.MinValue) return Int64.MaxValue;
               return a;
            }
        }

        public static double NextDouble()
        {
                 byte[] rno = new byte[8];
                 rg.GetBytes(rno);
                double a = (double)(BitConverter.ToUInt64(rno,0) / (decimal)ulong.MaxValue);
            //если надо крипто генератор - возращать переменную а или gen.NextDouble()
            return a;
        }

        public static double KDistance(double[] v1, double[] v2)
        {
            int vSize = v1.Length < v2.Length ? v1.Length : v2.Length;
            double sum = 0;
            for (int i = 0; i < vSize; i++)
            {
                double f = 0;
                for (int j = 0; j < i; j++)
                {
                    f += v1[j] - v2[j];
                }
                if (sum < Math.Abs(f)) sum = Math.Abs(f);
            }
            return sum;
        }
    }
}
