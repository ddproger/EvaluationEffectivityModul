using EvaluationOfEffectivenessModul.Services;
using EvaluationOfEffectivenessModul.Services.Models;
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
        private readonly ObservableCollection<Investment> investmentRows = new ObservableCollection<Investment>();
        private readonly ObservableCollection<InformationRisk> informationRiskRows = new ObservableCollection<InformationRisk>();
    
        private double getDouble(String text)
        {
            double res = 0;
            if (Double.TryParse(text, out res))
            {
                return res;
            }
            else
            {
                throw new Exception("Cannot convert input string");
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
            public MainWindow(Collection<Intruder> intruders)
        {
            dgInformationRisks.ItemsSource = intruders;
        }

        public ObservableCollection<Investment> InvestmentRows
        {
            get { return investmentRows; }
        }
        public ObservableCollection<InformationRisk> InforamtionRiskRows
        {
            get { return informationRiskRows; }
        }

      private void buttonFormInvestFlow_Click(object sender, RoutedEventArgs e)
        {
            txtCoeffInvest.Text = EvaluationClass.getCoefficientRentabilnosti(InvestmentRows).ToString();
            txtProcessRang.Text = EvaluationClass.getRang(getInt(txtExpectedProfit.Text),
                                                        getDouble(txtProbabilityOfSuccess.Text),
                                                        getInt(txtExpenseSZI.Text)).ToString();
           // txtPresentValue.Text = EvaluationClass.getCost(getDouble(txtCoefficient.Text),

        }

        private void frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void loadDate(object sender, EventArgs e)
        {
            InformationAssets infAssets = new InformationAssets(TypeIA.BT,"infAsset1", true, true, false, true, false);
            Collection<NetworkObject> netObjects = new Collection<NetworkObject>
            {
                new NetworkObject(LevelHierarchy.BL, "TO1"),
            new NetworkObject(LevelHierarchy.DBL, "TO2"),
            new NetworkObject(LevelHierarchy.DBL, "TO3"),
            new NetworkObject(LevelHierarchy.OSL, "TO4"),
            new NetworkObject(LevelHierarchy.OSL, "TO5"),
            new NetworkObject(LevelHierarchy.BL, "TO6")
            };
        
            Collection<Intruder> intruders = new Collection<Intruder>
            {
                new Intruder(Category.trusted, infAssets,1000,new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f),
                                                                     new Damage(0.516f,0.3f),
                                                                     new Damage(0.3f,0.3f) },
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 1",0.1f },
                                                                         {"Рекомендация 2",0.2f },
                                                                         {"Рекомендация 3",0.5f },
                                                                     }),
                new Intruder(Category.trusted, infAssets,784,new Collection<Damage>{
                                                                     new Damage(0.5f,0.4f),
                                                                     new Damage(0.6f,0.3f),
                                                                     new Damage(0.3f,0.3f) },
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 4",0.1f },
                                                                         {"Рекомендация 5",0.2f },
                                                                         {"Рекомендация 6",0.5f },
                                                                     }),
                new Intruder(Category.trusted, infAssets,589,new Collection<Damage>{
                                                                     new Damage(0.1f,0.4f),
                                                                     new Damage(0.39f,0.4f),
                                                                     new Damage(0.15f,0.2f) },
                                                                     new Dictionary<String, float>{
                                                                         {"Рекомендация 7",0.1f },
                                                                         {"Рекомендация 8",0.2f },
                                                                         {"Рекомендация 9",0.5f },
                                                                     }),
            };
            dgInformationRisks.ItemsSource = intruders;
        }
    }
}
