using Android.Content;
using Android.Support.Design.Widget;
using AppDuolingoClone.Droid.Renderers;
using AppDuolingoClone.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace AppDuolingoClone.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {

        private TabbedPage _formsTabs;
        private BottomNavigationView _bottomNavigationView;

        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                _formsTabs = Element;
                _formsTabs.CurrentPageChanged += OnCurrentPageChanged;

                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                _bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                _bottomNavigationView.SetMinimumHeight(300);
                _bottomNavigationView.ItemIconTintList = null;
                _bottomNavigationView.ItemIconSize = 150;
                UpdateAllTabs(_formsTabs, _bottomNavigationView);
            }

        }
        private void UpdateAllTabs(TabbedPage formsTabs, BottomNavigationView bottomNavigationView)
        {
            for (var index = 0; index < formsTabs.Children.Count; index++)
            {
                var androidTab = bottomNavigationView.Menu.GetItem(index);
                if (formsTabs.Children[index] is LessonsView)
                {
                    if (formsTabs.Children[index] == formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_lessons_selected);
                        continue;
                    }
                    androidTab.SetIcon(Resource.Drawable.tab_lessons);
                    continue;
                }
                if (formsTabs.Children[index] is ProfileView)
                {
                    if (formsTabs.Children[index] == formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_profile_selected);
                        continue;
                    }
                    androidTab.SetIcon(Resource.Drawable.tab_profile);
                    continue;
                }
                if (formsTabs.Children[index] is RankingView)
                {
                    if (formsTabs.Children[index] == formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_ranking_selected);
                        continue;
                    }
                    androidTab.SetIcon(Resource.Drawable.tab_ranking);
                    continue;
                }
                if (formsTabs.Children[index] is StoreView)
                {
                    if (formsTabs.Children[index] == formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(Resource.Drawable.tab_store_selected);
                        continue;
                    }
                    androidTab.SetIcon(Resource.Drawable.tab_store);
                    continue;
                }
            }
        }
        private void OnCurrentPageChanged(object sender, System.EventArgs e)
        {
            UpdateAllTabs(_formsTabs, _bottomNavigationView);
            //System.Diagnostics.Debug.WriteLine("");
        }
    }
}