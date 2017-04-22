using EvaluationOfEffectivenessModul.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EvaluationOfEffectivenessModul
{
    
    public partial class MainWindow : Window
    {
      private readonly ObservableCollection<Investment> investmentRows = new ObservableCollection<Investment>()
      {
        new Investment()
      };


    
        private double getDouble(String text)
        {
            double res = 0;
            if (Double.TryParse(text, out res))
            {
                return res;
            }
            else
            {
                throw new Exception("Cannot convert input strin");
            }

        }
        private Int32 getInt(String text)
        {
            Int32 res = 0;
            if (Int32.TryParse(text, out res))
            {
                return res;
            }
            else
            {
                throw new Exception("Cannot convert input strin");
            }

        }
        public MainWindow()
        {
            
        }

      public ObservableCollection<Investment> InvestmentRows
      {
        get { return investmentRows; }
      }

      private void buttonFormInvestFlow_Click(object sender, RoutedEventArgs e)
        {
            txtCoeffInvest.Text = EvaluationClass.getCoefficientRentabilnosti(MainFormServices.getInvestmentList(dgInvestment)).ToString();
            txtProcessRang.Text = EvaluationClass.getRang(getInt(txtExpectedProfit.Text),
                                                        getDouble(txtProbabilityOfSuccess.Text),
                                                        getInt(txtExpenseSZI.Text)).ToString();
            //txtPresentValue.Text = EvaluationClass
        }
    }
}
