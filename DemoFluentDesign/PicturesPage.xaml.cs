using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoFluentDesign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PicturesPage : Page
    {
        public PicturesPage()
        {
            this.InitializeComponent();
            DataContext = DataSource.Pictures;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
            {
                await Task.Delay(100);
                var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("picture-back");
                if (animation != null)
                {
                    var picture = Frame.ForwardStack[0].Parameter;
                    var container = PicturesListView.ContainerFromItem(picture);
                    if (container == null)
                    {
                        PicturesListView.ScrollIntoView(picture);
                    }
                    await PicturesListView.TryStartConnectedAnimationAsync(animation, picture, "SmallImage");
                }
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0) return;

            var picture = e.AddedItems[0];

            PicturesListView.PrepareConnectedAnimation("picture", picture, "SmallImage");

            Frame.Navigate(typeof(PictureDetailPage), picture);
        }
    }
}
