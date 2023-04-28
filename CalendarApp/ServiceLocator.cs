using CalendarApp.Services;
using CalendarApp.ViewModels;
using CalendarApp.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{
    public class ServiceLocator
    {
        private static IServiceProvider serviceProvider;

        public MainViewModel MainViewModel => serviceProvider.GetRequiredService<MainViewModel>();
        public CalendarViewModel CalendatViewModel => serviceProvider.GetRequiredService<CalendarViewModel>();
        public DayInfoViewModel DayInfoViewModel => serviceProvider.GetRequiredService<DayInfoViewModel>();

        public static void Init()
        {
            ServiceCollection services = new ServiceCollection();


            services.AddSingleton<MainViewModel>();
            services.AddTransient<CalendarViewModel>();
            services.AddTransient<DayInfoViewModel>();


            services.AddSingleton<PageService>();
            services.AddTransient<DayInfoService>();
            services.AddTransient<DataSerializer, JsonSerializerService>(x => 
                new JsonSerializerService(() => new FileStream("data.json", FileMode.OpenOrCreate, FileAccess.ReadWrite)));
            
            serviceProvider = services.BuildServiceProvider();
        }



    }
}
