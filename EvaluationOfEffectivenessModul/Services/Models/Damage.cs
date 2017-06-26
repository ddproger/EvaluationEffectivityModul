using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfEffectivenessModul.Services.Models
{
    public class Damage
    {
        public float metric { get; set; }
        public float weight { get; set; }
        public Damage(float metric, float weight)
        {
            this.metric = metric;
            this.weight = weight;
        }
        public float getWeightedMetric()
        {
            return metric * weight;
        }

    }
}
