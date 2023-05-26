using ListViewDemo.Model;
using ListViewDemo.Templates;
using Syncfusion.Maui.DataSource;

namespace ListViewDemo;

public partial class MainPage : PageTemplate
{
    MainViewModel vm => BindingContext as MainViewModel;

    public MainPage()
	{
		InitializeComponent();

        ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
        {
            PropertyName = "Title",
            KeySelector = (object obj) =>
            {
                var item = obj as Book;
                return item.Title[0];
            }
        });

        BindingContext = new MainViewModel();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await vm.Initialize();
    }
}

