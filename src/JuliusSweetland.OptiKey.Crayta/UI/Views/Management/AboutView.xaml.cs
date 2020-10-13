
// Copyright (c) 2020 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using System.Windows.Controls;

namespace JuliusSweetland.OptiKey.Crayta.UI.Views.Management
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender,
            System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
