﻿// Copyright (c) 2020 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using JuliusSweetland.OptiKey.Models.ScalingModels;
using System.Collections.Generic;
using System.ComponentModel;

namespace JuliusSweetland.OptiKey.UI.ViewModels
{
    public interface ILookToScrollOverlayViewModel : INotifyPropertyChanged
    {
        bool IsActive { get; }
        List<Region> ZeroContours { get;  }
    }
}
