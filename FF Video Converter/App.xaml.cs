﻿using System;
using System.Windows;

namespace FFVideoConverter
{

    public partial class App : Application
    {
        public App()
        {
            Unosquare.FFME.Library.FFmpegDirectory = Environment.CurrentDirectory;
        }
    }
}
