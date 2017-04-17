using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EvaluationOfEffectivenessModul.Services
{
    class MainFormServices
    {
        public static ICollection<Investment> getInvestmentList(DataGrid dg)
        {
            ICollection<Investment> res = new LinkedList<Investment>();
            int n = dg.Items.Count;
            for (int i = 0; i < n; i++)
            {
                res.Add(new Investment(i,0,dg.Items[i].ToString()));
            }
            return res;
        }
    }
}
