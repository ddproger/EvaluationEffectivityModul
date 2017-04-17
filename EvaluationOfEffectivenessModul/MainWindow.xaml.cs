using EvaluationOfEffectivenessModul.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EvaluationOfEffectivenessModul
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        
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

        private void buttonFormInvestFlow_Click(object sender, RoutedEventArgs e)
        {
            txtCoeffInvest.Text = EvaluationClass.getCoefficientRentabilnosti(MainFormServices.getInvestmentList(dgInvestment)).ToString();
            txtProcessRang.Text = EvaluationClass.getRang(getInt(txtExpectedProfit.Text),
                                                        getDouble(txtProbabilityOfSuccess.Text),
                                                        getInt(txtExpenseSZI.Text)).ToString();
            //txtPresentValue.Text = EvaluationClass
        }

        private void dgInvestment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addRow(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void updateDgInvest(object sender, RoutedEventArgs e)
        {
            List<Investment> res = new List<Investment>()
            {
                new Investment(1,2,"3")
            };
            dgInvestment.ItemsSource = res;
        }
    }
}
