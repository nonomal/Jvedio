﻿using SuperUtils.NetWork;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using static Jvedio.App;

namespace Jvedio.Pages
{
    public class ActorNavigator
    {
        // todo tab

        private static Frame frame { get; set; }


        public static NavigationService NavigationService { get; set; } =
            frame.NavigationService;

        public static void Navigate(string path, object param = null)
        {
            try {
                NavigationService?.Navigate(new Uri(path, UriKind.RelativeOrAbsolute), param);
            } catch (Exception ex) {
                Logger.Error(ex);
            }
        }

        public static void GoBack()
        {
            NavigationService?.GoBack();
        }

        public static void GoForward()
        {
            NavigationService?.GoForward();
        }
    }
}