using Prism.Unity;
using TabbedAppSample.Views;

namespace TabbedAppSample
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync(nameof(TabbedPageHost));
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<TabbedPageHost>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<AnotherPage>();
		}
	}
}

