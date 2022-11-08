using Xaminals.Views;

namespace Xaminals;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        BindingContext = this;

        Routing.RegisterRoute("monkeydetails", typeof(MonkeyDetailPage));
        Routing.RegisterRoute("beardetails", typeof(BearDetailPage));
        Routing.RegisterRoute("catdetails", typeof(CatDetailPage));
        Routing.RegisterRoute("dogdetails", typeof(DogDetailPage));
        Routing.RegisterRoute("elephantdetails", typeof(ElephantDetailPage));
    }
}
