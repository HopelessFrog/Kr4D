using Multiprocessor_And_Multithreaded_Programming.Presenter;
using Autofac;
using Multiprocessor_And_Multithreaded_Programming.Model;
using WinFormsApp1;
using WinFormsApp1.View;


namespace Multiprocessor_And_Multithreaded_Programming
{
    public static class AutofacManager
    {
        public static IContainer? Container { get; private set; }
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();//создаём контейнер объектов
            // Регистрируем сервис сообщений и валидатор
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<Validator>().As<IValidator>();
            builder.RegisterType<FileManager>().As<IFileManager>();

            // Регистрируем формы
            builder.RegisterType<MainForm>().As<IMain>();
            builder.RegisterType<ChangeForm>().As<ITrainChange>();
            builder.RegisterType<TrainForm>().As<ITrainAdd>();
            builder.RegisterType<WayForm>().As<IAddWay>();

            // Регистрируем презентеры с их зависимостями

            builder.RegisterType<TrainAddPresenter>().As<ITrainAddPresenter>();
            builder.RegisterType<AddWayPresenter>().As<IWayAddPresenter>();
            builder.RegisterType<MainformPresenter>().As<IMainFormPresenter>();
            builder.RegisterType<TrainChangePresenter>().As<IChangePresenter>();
            builder.RegisterType<MainPresenter>();

            // Создаем контейнер
            Container = builder.Build();

        }
    }
}
