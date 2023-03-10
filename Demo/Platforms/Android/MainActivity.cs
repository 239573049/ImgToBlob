using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace Demo;
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public override Context CreateContext(ContextParams contextParams)
    {
        var data = FileSystem.AppDataDirectory;
        return base.CreateContext(contextParams);
    }
}
