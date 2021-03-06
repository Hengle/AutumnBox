﻿using AutumnBox.GUI.Services;
using AutumnBox.GUI.Util.UI;
using AutumnBox.Leafx.Container;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace AutumnBox.GUI.View.Windows
{
    /// <summary>
    /// AdbFailedWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AdbFailedWindow
    {
        public AdbFailedWindow(string message)
        {
            InitializeComponent();
            tbOutput.Text = message;
            this.Loaded += (s, e) =>
            {
                App.Current.Lake.Get<IOperatingSystemService>().EnableHelpButton(this, () =>
                {
                    try
                    {
                        Process.Start(App.Current.Resources["UrlGoPrefix"].ToString() + App.Current.Resources["AGoAdbFail"].ToString());
                    }
                    catch { }
                });
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clipboard.SetText(tbOutput.Text);
            }
            catch { }
        }
    }
}
