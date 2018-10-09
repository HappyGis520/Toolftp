using System.Reactive;
using System.Reactive.Linq;
using MVVMSidekick.ViewModels;
using MVVMSidekick.Views;
using MVVMSidekick.Reactive;
using MVVMSidekick.Services;
using MVVMSidekick.Commands;
using EllaMaker.FTP;
using EllaMaker.FTP.ViewModels;
using System;
using System.Net;
using System.Windows;


namespace MVVMSidekick.Startups
{
    internal static partial class StartupFunctions
    {
        static Action SelectPersonWindowConfig =
            CreateAndAddToAllConfig(ConfigSelectPersonWindow);

        public static void ConfigSelectPersonWindow()
        {
            ViewModelLocator<SelectPersonWindow_Model>
                .Instance
                .Register(context =>
                    new SelectPersonWindow_Model())
                .GetViewMapper()
                .MapToDefault<SelectPersonWindow>();

        }
    }
}
