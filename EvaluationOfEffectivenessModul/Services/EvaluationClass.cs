using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services
{
    class EvaluationClass
    {
        private double getImportanceInformationAsset(long E, double Y)//1
        {
            return E/Y;
        }
        private double getEfficiencyCost(double e, long b)//2
        {
            return e / b;
        }
        private double getSumSingleRiskList(IList<double> p, IList<long> u)//3
        {
            int n = p.Count;
            double res = 0;
            for (int i = 0; i<n;i++)
            {
               res+= p[i] * u[i];
            }
            return res;
        } 
        private double getRisk(Int32 E, Int32 M)//4
        {
            return E / M;
        }
        private double getAgregateRisk(List<double> p, List<long> u, Int32 E, Int32 M)//5
        {
            return getSumSingleRiskList(p, u)+getRisk(E,M);
        }
        private double getRang(long sum, double p, long cost)//6
        {
            return (sum * p) / cost;
        }
        private double getCost(double D, long I, long W)//7
        {
            return D + I * W;
        }
        private double getCoefficientRentabilnosti(IList<long> CF, long k)//8
        {
            double res = 0;
            int i = 1;
            foreach(long item in CF){
                res+=item/Math.Pow((1+k),i);
                i++;
            }
            return res;
        }
        

    }
}
