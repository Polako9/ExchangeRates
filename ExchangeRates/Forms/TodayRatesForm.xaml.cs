﻿using System;
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

namespace ExchangeRates.Forms
{
    /// <summary>
    /// Interaction logic for mainView.xaml
    /// </summary>
    public partial class mainView : UserControl
    {
        public List<List<RateModel>> todayRatesList = new List<List<RateModel>>();
        public List<RateModel> childTodayRatesList;
        public List<Rates> endList;
        public mainView()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> tablenames = new List<string>(new string[] { "A", "B", "C" });
            RatesProcessor ratesProcessor = new RatesProcessor();
            todayRatesList.Clear();

            foreach (var item in tablenames)
            {
                try
                {
                    todayRatesList.Add(await ratesProcessor.GetTodaysRates(item));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            
            childTodayRatesList = todayRatesList.SelectMany(x => x).ToList();
            endList = childTodayRatesList.SelectMany(x => x.Rates).ToList();
            fillDataGrid();      
           
        }
        private void fillDataGrid()
        {
            todayRatesDataGrid.ItemsSource = endList;
            foreach (var item in todayRatesDataGrid.Columns.ToList())
            {
                item.Width = new DataGridLength(33, DataGridLengthUnitType.Star);
            }
        }
    }
}
