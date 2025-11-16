using ActorsApplication.Pages;

namespace ActorsApplication
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ActorDetailPage), typeof(ActorDetailPage));
        }
    }
}
