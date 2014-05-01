using Cirrious.CrossCore.IoC;

namespace XamarinMvx.Core
{

    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // TODO: MainViewModel��MainView�Ɍ��ѕt����
            RegisterAppStart<ViewModels.MainViewModel>();
        }
    }
}
