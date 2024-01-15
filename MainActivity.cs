using ReactiveUI;

namespace ReactiveUI_WireUpControls_Issue;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : ReactiveActivity
{

    [WireUpResource("app_text")]
    public TextView AppText { get; private set; }

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        this.WireUpControls(ControlFetcherMixin.ResolveStrategy.ExplicitOptIn);

        AppText.SetText("Hello, ReactiveUI!", TextView.BufferType.Normal);
    }
}