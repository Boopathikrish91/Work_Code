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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = "Hello Wpf";
            this.Content = 3.141592;
            this.Content = DateTime.Now;
            this.Content = new Book()
            {
                Title = "The Accursed God",
                Author = "Boopathi",
                Price = 399
            };

        }

        void HandleShowDetails(object sender, EventArgs e)
        {

        }
    }
}
