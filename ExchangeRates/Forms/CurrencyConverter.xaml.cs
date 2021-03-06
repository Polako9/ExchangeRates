﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExchangeRates;

namespace ExchangeRates.Forms
{
    /// <summary>
    /// Interaction logic for CurrencyConverter.xaml
    /// </summary>
    public partial class CurrencyConverter : UserControl
    {
        public List<List<RateModel>> RatesList = new List<List<RateModel>>();
        public List<RateModel> childRatesList;
        public List<Rates> endList;

        public CurrencyConverter()
        {
            InitializeComponent();
            ShowButton.IsEnabled = false;
        }
        /// <summary>
        /// filling list with Today rates. List will be useful as combobox item source.
        /// </summary>
        public  async void loadList()
        {
            if (fromCombobox.ItemsSource ==null && toCombobox.ItemsSource == null)
            {
                RatesProcessor ratesProcessor = new RatesProcessor();
                RatesList.Clear();
                List<string> tablenames = new List<string>(new string[] { "A", "B", "C" });
                foreach (var item in tablenames)
                {
                    try
                    {
                        RatesList.Add(await ratesProcessor.GetTodaysRates(item));
                    }
                    catch (Exception ec )
                    {

                        MessageBox.Show(ec.Message);
                    }
                    
                }
          
                childRatesList = RatesList.SelectMany(x => x).ToList();
                endList = childRatesList.SelectMany(x => x.Rates).ToList();
                fromCombobox.ItemsSource = endList.Select(x => x.Code + " - " + x.Currency).ToList();
                toCombobox.ItemsSource = endList.Select(x => x.Code + " - " + x.Currency).ToList();
            }
          
        }
        /// <summary>
        /// event after clik submit button
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            amountTextbox.Text = Regex.Replace(amountTextbox.Text, @"\s+", "");
            amountTextbox.Text = amountTextbox.Text.Replace(".", ",");
            double amount = 1;
            double.TryParse(amountTextbox.Text, out amount);
            string firstRateString = fromCombobox.SelectedItem.ToString();
            string secondRateString = toCombobox.SelectedItem.ToString();
            int index1 = firstRateString.IndexOf(" ");
            if (index1 > 0)
                firstRateString = firstRateString.Substring(0, index1);
            int index2 = secondRateString.IndexOf(" ");
            if (index2 > 0)
                secondRateString = secondRateString.Substring(0, index2);
            double firstRate = endList.Find(x => x.Code == firstRateString).Mid;
            double secondRate = endList.Find(x => x.Code == secondRateString).Mid;
            double result = CurrencyConverterOperations.ConvertCurrencies(amount, firstRate, secondRate);
            resultLabel.Content = amount + " " + firstRateString + " = " + result + " " + secondRateString;
        }

        private void FromCombobox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            loadList();
        }
        /// <summary>
        /// prevents from entering letters to textbox
        /// </summary>
        private void AmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static readonly Regex _regex = new Regex("[^0-9,-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }
        private void TextBoxPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
        /// <summary>
        /// checking if button should be enabled of disabled.
        /// </summary>
        private void valid()
        {
            amountTextbox.Text = amountTextbox.Text.Replace(" ", string.Empty);
            if ((amountTextbox.Text!= string.Empty) && (fromCombobox.SelectedItem!=null) &&(toCombobox.SelectedItem!=null))
            {
                ShowButton.IsEnabled = true;
            }
            else
            {
                ShowButton.IsEnabled = false;
            }
        
        }
        private void AmountTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            valid();
        }

        private void FromCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valid();
        }

        private void ToCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            valid();
        }
    }
}
