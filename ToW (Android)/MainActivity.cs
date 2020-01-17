using System;
using Android;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Webkit;

namespace ToW__Android_
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        WebView web_home;
        WebView web_devos;
        WebView web_sched;
        WebView web_sub;
        WebView web_about;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            web_home = FindViewById<WebView>(Resource.Id.home);
            web_home.Settings.JavaScriptEnabled = true;
            web_home.LoadUrl("https://thoughtsofworship.weebly.com");

            web_devos = FindViewById<WebView>(Resource.Id.devos);
            web_devos.Settings.JavaScriptEnabled = true;
            web_devos.LoadUrl("https://thoughtsofworship.weebly.com/devotionals");

            web_sched = FindViewById<WebView>(Resource.Id.sched);
            web_sched.Settings.JavaScriptEnabled = true;
            web_sched.LoadUrl("https://thoughtsofworship.weebly.com/schedule.html");

            web_sub = FindViewById<WebView>(Resource.Id.sub);
            web_sub.Settings.JavaScriptEnabled = true;
            web_sub.LoadUrl("https://thoughtsofworship.weebly.com/subscribe.html");

            web_about = FindViewById<WebView>(Resource.Id.about);
            web_about.Settings.JavaScriptEnabled = true;
            web_about.LoadUrl("https://thoughtsofworship.weebly.com/about-us.html");

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                if (web_home.CanGoBack())
                {
                    web_home.GoBack();
                }
                else
                {
                    base.OnBackPressed();
                }
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.home)
            {
                if(web_home.Visibility != ViewStates.Visible)
                {
                    ChangeViews(ViewStates.Visible, ViewStates.Gone, ViewStates.Gone, ViewStates.Gone, ViewStates.Gone);
                    }
            }
            else if (id == Resource.Id.devos)
            {
                if (web_devos.Visibility != ViewStates.Visible)
                {
                    ChangeViews(ViewStates.Gone, ViewStates.Visible, ViewStates.Gone, ViewStates.Gone, ViewStates.Gone);
                }
            }
            else if (id == Resource.Id.sched)
            {
                if (web_sched.Visibility != ViewStates.Visible)
                {
                    ChangeViews(ViewStates.Gone, ViewStates.Gone, ViewStates.Visible, ViewStates.Gone, ViewStates.Gone);
                }
            }
            else if (id == Resource.Id.sub)
            {
                if (web_sub.Visibility != ViewStates.Visible)
                {
                    ChangeViews(ViewStates.Gone, ViewStates.Gone, ViewStates.Gone, ViewStates.Visible, ViewStates.Gone);

                }
            }
            else if (id == Resource.Id.about)
            {
                if (web_about.Visibility != ViewStates.Visible)
                {
                    ChangeViews(ViewStates.Gone, ViewStates.Gone, ViewStates.Gone, ViewStates.Gone, ViewStates.Visible);

                }
            }
            else if (id == Resource.Id.nav_share)
            {

            }
            else if (id == Resource.Id.nav_send)
            {

            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void ChangeViews(ViewStates home, ViewStates devos, ViewStates sched, ViewStates sub, ViewStates about) 
        {
            web_home.Visibility = home;
            web_devos.Visibility = devos;
            web_sched.Visibility = sched;
            web_sub.Visibility = sub;
            web_about.Visibility = about;
        }
    }
}

