using System;
using System.Configuration;
using Catel.IoC;
using FriendOrganizer.UI.Data;

namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var serviceLocator = ServiceLocator.Default;


            //Registering an instance
            //var friendService = new FriendDataService();
            //serviceLocator.RegisterInstance<IFriendDataService>(friendService);

            //    //Registering a type
            //serviceLocator.RegisterType<IFriendDataService, FriendDataService>();
            //var service = serviceLocator.ResolveType<IFriendDataService>();
            //var a = service.GetAlll();
        }
    }
}
