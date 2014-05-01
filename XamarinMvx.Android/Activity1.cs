using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Binding.BindingContext;    // TODO: CreateBindingSetのため

using XamarinMvx.Core.ViewModels;

namespace XamarinMvx.Android
{
    // TODO: MvxActivity を継承して Core.MainViewModel と名称をあわせる。
    [Activity(Label = "XamarinMvx.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // axml に local:MvxBind="Text X" を書かずにコードでバインドする方法
            // iOSの場合も同じ
            // この方式にすると、ViewとViewModelの名前を統一しなくてよい。
            /*
            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(FindViewById<EditText>(Resource.Id.editText1)).To(m => m.X);
            set.Bind(FindViewById<EditText>(Resource.Id.editText2)).To(m => m.Y);
            set.Bind(FindViewById<TextView>(Resource.Id.textView1)).To(m => m.Ans);
            set.Apply();
            */
            // TODO: 説明を簡単にするため、テキストだけバインド
            MainViewModel vm = this.ViewModel as MainViewModel;
            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += (s, e) =>
            {
                vm.Ans = vm.X + vm.Y;
            };
        }
    }
}

