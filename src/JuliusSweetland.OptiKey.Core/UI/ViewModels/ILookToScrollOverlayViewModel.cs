﻿// Copyright (c) 2020 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using System.ComponentModel;
using System.Windows;

namespace JuliusSweetland.OptiKey.UI.ViewModels
{
    public interface ILookToScrollOverlayViewModel : INotifyPropertyChanged
    {
        bool IsActive { get; }
        Rect ActiveBounds { get; }
        Rect ActiveDeadzone { get; }
        Thickness ActiveMargins { get; } // between deadzone and border
    }
}
