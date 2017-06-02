using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoFluentDesign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShellPage : Page
    {
        public ShellPage()
        {
            this.InitializeComponent();
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            var homeItem = new NavigationMenuItem() { Text = "Home", Icon = new SymbolIcon(Symbol.Home) };
            var photosItem = new NavigationMenuItem() { Text = "Photos", Icon = new SymbolIcon(Symbol.Pictures) };
            var friendsItem = new NavigationMenuItem() { Text = "Friends", Icon = new SymbolIcon(Symbol.People) };

            homeItem.IsSelected = true;

            NavView.MenuItems.Add(homeItem);
            NavView.MenuItems.Add(photosItem);
            NavView.MenuItems.Add(friendsItem);

            homeItem.Invoked += (s, e2) => ContentFrame.Navigate(typeof(HomePage));
            photosItem.Invoked += (s, e2) => ContentFrame.Navigate(typeof(PicturesPage));
            friendsItem.Invoked += (s, e2) => ContentFrame.Navigate(typeof(EmptyPage), s.Text);

            var meItem = new NavigationMenuItem() { Text = "Timothé Larivière", Icon = new SymbolIcon(Symbol.Account) };
            meItem.Invoked += (s, e2) =>
            {
                ContentFrame.Navigate(typeof(EmptyPage), s.Text);
                s.IsSelected = true;
            };
            NavView.PaneFooter = meItem;

            NavView.SettingsInvoked += (s, e2) => ContentFrame.Navigate(typeof(EmptyPage), "Settings");
        }

        private void ContentFrame_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(HomePage));
        }
    }
}
