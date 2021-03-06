using AppDuolingoClone.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDuolingoClone.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new LessonsView());
            Children.Add(new TrainingView());
            //if(Device.RuntimePlatform == Device.iOS)
            //    Children.Add(new TrainingView());

            Children.Add(new ProfileView());
            Children.Add(new RankingView());
            Children.Add(new StoreView());
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            //System.Diagnostics.Debug.WriteLine("the flap has changed");

            //Title = DateTime.Now.ToString();
            if(CurrentPage is IDynamicTitle page)
            {
                NavigationPage.SetHasNavigationBar(this, true);
                NavigationPage.SetTitleView(this, page.GetTitle());
                return;
            }
            NavigationPage.SetHasNavigationBar(this, false);
            //NavigationPage.SetTitleView(this, new Label { Text = DateTime.Now.ToString(), BackgroundColor = Color.Fuchsia });
        }
    }
}
