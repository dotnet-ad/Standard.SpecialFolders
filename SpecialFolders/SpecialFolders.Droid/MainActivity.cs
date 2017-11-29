using Android.App;
using Android.OS;

namespace SpecialFolders.Droid
{
    [Activity(Label = "SpecialFolders.Droid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Helper.LogSpecialFolders();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

