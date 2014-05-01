using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using XamarinMvx.Core.ViewModels;

namespace XamarinMvx.iOS
{
    // TODO: MvxViewController を継承する
    // TODO: XamarinMvx_iOSViewController を MainView に変更する
    // IBからは、XamarinMvx_iOSViewController のままで参照している。look *.designer.cs
    // [Register ("XamarinMvx_iOSViewController")]
    // partial class MainView
    public partial class XamarinMvx_iOSViewController : MvxViewController
    {
        public XamarinMvx_iOSViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            this.Request = new MvxViewModelRequest<MainViewModel>(null, null, new MvxRequestedBy());
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            // TODO: こうすると、View, ViewModel の名前の制約を回避できる
            var set = this.CreateBindingSet<XamarinMvx_iOSViewController, MainViewModel>();
            // TODO: コードでバインドする
            set.Bind(this.editX).To(vm => vm.X);
            set.Bind(this.editY).To(vm => vm.Y);
            set.Bind(this.textAns).To(vm => vm.Ans);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        /// <summary>
        /// クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        partial void clickCalc(MonoTouch.Foundation.NSObject sender)
        {
            var vm = this.ViewModel as MainViewModel;
            vm.Ans = vm.X + vm.Y;
        }
    }
}

