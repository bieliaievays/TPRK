﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf3DChartTutorial;

namespace Test3DChart
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {           
             InitializeComponent();
             textBoxActions.Text = wPF3DChart1.XValuesInput;
             textBoxConsequences.Text = wPF3DChart1.YValuesInput;
             textBoxParameters.Text = wPF3DChart1.ZValuesInput;
             textBox4.Text = wPF3DChart1.ChartTitle;
             textBox5.Text = wPF3DChart1.ZValuesColor;

             slider1.Minimum = 1.0;
             slider1.Maximum = 20.0;
             slider1.Value = wPF3DChart1.MouseSens;

             Binding MouseValueBinding = new Binding("Value");
             MouseValueBinding.Source = slider1;
             MouseValueBinding.Mode = BindingMode.TwoWay;
             wPF3DChart1.SetBinding(WPF3DChart.MouseSensProperty, MouseValueBinding);


             Binding XValueBinding = new Binding("Text");
             XValueBinding.Source = textBoxActions;
             XValueBinding.Mode = BindingMode.TwoWay;
             wPF3DChart1.SetBinding(WPF3DChart.XValuesInputProperty, XValueBinding);

             Binding YValueBinding = new Binding("Text");
             YValueBinding.Source = textBoxConsequences;
             YValueBinding.Mode = BindingMode.TwoWay;
             wPF3DChart1.SetBinding(WPF3DChart.YValuesInputProperty, YValueBinding);

             Binding ZValueBinding = new Binding("Text");
             ZValueBinding.Source = textBoxParameters;
             ZValueBinding.Mode = BindingMode.TwoWay;
             wPF3DChart1.SetBinding(WPF3DChart.ZValuesInputProperty, ZValueBinding);

             Binding ChartTitleBinding = new Binding("Text");
             ChartTitleBinding.Source = textBox4;
             ChartTitleBinding.Mode = BindingMode.TwoWay;
             wPF3DChart1.SetBinding(WPF3DChart.ChartTitleProperty, ChartTitleBinding);

             Binding ZValueColorBinding = new Binding("Text");
             ZValueColorBinding.Source = textBox5;
             ZValueColorBinding.Mode = BindingMode.TwoWay;
             wPF3DChart1.SetBinding(WPF3DChart.ZValuesColorProperty, ZValueColorBinding);
            
            Graph2D graph = new Graph2D();
            graph.Show();
        }

        public void Update()
        {
            wPF3DChart1.XValuesInput = textBoxActions.Text;
            wPF3DChart1.YValuesInput = textBoxConsequences.Text;
            wPF3DChart1.ZValuesInput = textBoxParameters.Text;
            wPF3DChart1.ChartTitle = textBox4.Text;
            wPF3DChart1.Update();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Update();
            }
            base.OnKeyUp(e);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
