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
        private double getEfficiencyCost(double e, long b)
        {
            return e / b;
        }
        private double getSumSingleRiskList(IList<double> p, IList<long> u)
        {
            int n = p.Count;
            double res = 0;
            for (int i = 0; i<n;i++)
            {
               res+= p[i] * u[i];
            }
            return res;
        } 
        private double getRisk(Int32 E, Int32 M)
        {
            return E / M;
        }
        private double getAgregateRisk(List<double> p, List<long> u, Int32 E, Int32 M)
        {
            return getSumSingleRiskList(p, u)+getRisk(E,M);
        }
        private double getRang(long sum, double p, long cost)
        {
            return (sum * p) / cost;
        }

    }
}
