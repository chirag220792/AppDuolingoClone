﻿using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Views.TitleViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDuolingoClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LessonsView : ContentPage, IDynamicTitle
    {
        private View _title;
        public LessonsView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if(_title == null)
                _title = new LessonsTitleView();

            return _title;
        }
    }
}