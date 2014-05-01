using Cirrious.MvvmCross.ViewModels;

namespace XamarinMvx.Core.ViewModels
{
    // TODO: MvxViewModel‚ðŒp³‚·‚é
    public class MainViewModel : MvxViewModel
    {
        public int _X = 0;
        public int X
        {
            get { return _X; }
            set { _X = value; RaisePropertyChanged(() => X); }
        }
        public int _Y = 0;
        public int Y
        {
            get { return _Y; }
            set { _Y = value; RaisePropertyChanged(() => Y); }
        }
        public int _Ans = 0;
        public int Ans
        {
            get { return _Ans; }
            set { _Ans = value; RaisePropertyChanged(() => Ans); }
        }
    }
}
