﻿using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        ~Page1()
        {
            Debug.WriteLine("Page dead :(");
        }
    }
}
