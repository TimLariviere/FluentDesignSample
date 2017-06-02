using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoFluentDesign
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PictureDetailPage : Page
    {
        public PictureDetailPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = e.Parameter;
            BigImage.Opacity = 0;
        }

        private void BigImage_ImageOpened(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            BigImage.Opacity = 1;
            var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("picture");
            animation?.TryStart(BigImage, new[] { DescriptionRoot });
        }

        private void BackButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("picture-back", BigImage);
            Frame.GoBack();
        }
    }
}
