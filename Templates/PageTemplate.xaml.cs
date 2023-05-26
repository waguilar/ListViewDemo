namespace ListViewDemo.Templates;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class PageTemplate : ContentPage
{
    public PageTemplate()
    {
        InitializeComponent();
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        // Binding context wasn't attached to the ContentPresenters
        if (NavBarRightIcons != null)
        {
            NavBarRightIcons.BindingContext = BindingContext;
        }
        if (HeaderContent != null)
        {
            HeaderContent.BindingContext = BindingContext;
        }
        if (BodyContent != null)
        {
            BodyContent.BindingContext = BindingContext;
        }
        if (FooterContent != null)
        {
            FooterContent.BindingContext = BindingContext;
        }
    }

    public static readonly BindableProperty NavBarLeftIconProperty = BindableProperty.Create(
        propertyName: nameof(NavBarLeftIcon),
        returnType: typeof(string),
        declaringType: typeof(PageTemplate),
        defaultValue: default(string));

    public string NavBarLeftIcon
    {
        get => (string)GetValue(NavBarLeftIconProperty);
        set => SetValue(NavBarLeftIconProperty, value);
    }


    public static readonly BindableProperty HasNavBarProperty = BindableProperty.Create(
        propertyName: nameof(HasNavBar),
        returnType: typeof(bool),
        declaringType: typeof(PageTemplate),
        defaultValue: true);

    public bool HasNavBar
    {
        get => (bool)GetValue(HasNavBarProperty);
        set => SetValue(HasNavBarProperty, value);
    }


    public static readonly BindableProperty HeaderContentProperty = BindableProperty.Create(
        propertyName: nameof(HeaderContent),
        returnType: typeof(View),
        declaringType: typeof(PageTemplate),
        defaultValue: default(View));

    public View HeaderContent
    {
        get => (View)GetValue(HeaderContentProperty);
        set => SetValue(HeaderContentProperty, value);
    }

    public static readonly BindableProperty BodyContentProperty = BindableProperty.Create(
        propertyName: nameof(BodyContent),
        returnType: typeof(View),
        declaringType: typeof(PageTemplate),
        defaultValue: default(View));

    public View BodyContent
    {
        get => (View)GetValue(BodyContentProperty);
        set => SetValue(BodyContentProperty, value);
    }

    public static readonly BindableProperty FooterContentProperty = BindableProperty.Create(
        propertyName: nameof(FooterContent),
        returnType: typeof(View),
        declaringType: typeof(PageTemplate),
        defaultValue: default(View));

    public View FooterContent
    {
        get => (View)GetValue(FooterContentProperty);
        set => SetValue(FooterContentProperty, value);
    }

    public static readonly BindableProperty NavBarRightIconsProperty = BindableProperty.Create(
        propertyName: nameof(NavBarRightIcons),
        returnType: typeof(View),
        declaringType: typeof(PageTemplate),
        defaultValue: default(View));

    public View NavBarRightIcons
    {
        get => (View)GetValue(NavBarRightIconsProperty);
        set => SetValue(NavBarRightIconsProperty, value);
    }

    public static readonly BindableProperty LeftIconCommandProperty = BindableProperty.Create(
        propertyName: nameof(LeftIconCommand),
        returnType: typeof(Command),
        declaringType: typeof(PageTemplate),
        defaultValue: default(Command));

    public Command LeftIconCommand
    {
        get => (Command)GetValue(LeftIconCommandProperty);
        set => SetValue(LeftIconCommandProperty, value);
    }
}
