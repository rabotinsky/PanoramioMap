﻿using Windows.UI.Xaml.Navigation;

namespace PanoramioMap
{
    public sealed partial class ImageViewPage
    {
        public ImageViewPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            DataContext = e.Parameter;
        }
    }
}
