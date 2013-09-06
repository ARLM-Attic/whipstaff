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

namespace Dhgms.Whipstaff.View.Wndw
{
    using ReactiveUI;
    using System.Windows.Controls.Ribbon.Primitives;

    /// <summary>
    /// Interaction logic for MainRibbonWindow.xaml
    /// </summary>
    public partial class MainRibbonWindow
    {
        public MainRibbonWindow()
        {
            this.ViewModel = ((Controller.Base)System.Windows.Application.Current).MainWindowViewModel;

            InitializeComponent();

            this.QuickAccessShowKeyboardShortcuts.SmallImageSource = new WpfTools.ImageFromFont
                {
                    Text= "\xf11c",
                    FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                    Brush = System.Windows.Media.Brushes.Green
                }.GetGlyph();

            this.QuickAccessSearch.SmallImageSource = new WpfTools.ImageFromFont() 
            {
                Text="\xf002",
                FontFamily= new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                Brush=System.Windows.Media.Brushes.Black
            }.GetGlyph();

            this.Bind(this.ViewModel, model => model.MainControl, control => control.MainControl.Content);
            this.Bind(this.ViewModel, model => model.ShowKeyboardShortcutsCommand, control => control.QuickAccessShowKeyboardShortcuts.Command);
            this.Bind(this.ViewModel, model => model.ShowSearchCommand, control => control.QuickAccessSearch.Command);
        }
    }
}
