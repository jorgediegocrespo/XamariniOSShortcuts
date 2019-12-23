
using Foundation;
using System;
using UIKit;

namespace iPhoneHomeQuickActions.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            CreateDynamicShortcuts(app);
            
            return base.FinishedLaunching(app, options);
        }

        public override void PerformActionForShortcutItem(UIApplication application, UIApplicationShortcutItem shortcutItem, UIOperationHandler completionHandler)
        {
            completionHandler(HandleShortcutItem(shortcutItem));
        }

        private bool HandleShortcutItem(UIApplicationShortcutItem shortcutItem)
        {
            if (shortcutItem == null)
                return false;

            return (App.Current as App).ManageMenuAction(shortcutItem.Type);
        }

        private void CreateDynamicShortcuts(UIApplication application)
        {
            var dynamicShortcut = new UIMutableApplicationShortcutItem(MenuActions.ShowPage3, "Dynamic - Page 3")
            {
                LocalizedSubtitle = "Open Page 3",
                Icon = UIApplicationShortcutIcon.FromType(UIApplicationShortcutIconType.Play)
            };

            application.ShortcutItems = new UIApplicationShortcutItem[] { dynamicShortcut };
        }
    }
}
