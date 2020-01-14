﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleSample.SegmentedControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoLayout : ContentView
    {
        public VideoLayout(BaseViewModel model)
        {
            InitializeComponent();
            this.BindingContext = model;
        }
    }
}