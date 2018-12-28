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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Int32.Parse(txtNumber1.Text);
            int secondNumber = Int32.Parse(txtNumber2.Text);
            int resultSum = firstNumber + secondNumber;
            lblSumResult.Content = firstNumber+" + "+ secondNumber +" = "+ (firstNumber + secondNumber); 
            lblMinResult.Content = firstNumber+" - "+ secondNumber +" = "+ (firstNumber - secondNumber); 
            lblMulResult.Content = firstNumber+" x "+ secondNumber +" = "+ (firstNumber * secondNumber); 
            lblDivResult.Content = firstNumber+ " / " + secondNumber +" = "+ (firstNumber / secondNumber); 
        }
    }
}
