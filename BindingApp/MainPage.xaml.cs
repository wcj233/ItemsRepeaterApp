using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BindingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class NavigationItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<Vector2> Location { get; set; }

        public NavigationItem() {
            Location = new List<Vector2>();
            Location.Add(new Vector2(1,2));
            Location.Add(new Vector2(2, 3));
            Location.Add(new Vector2(3, 4));
        }
    }

    public class MyViewModel { 

        
        public List<NavigationItem> NavigationItems { get; set; }

        public MyViewModel() {
            NavigationItems = new List<NavigationItem>();
            NavigationItems.Add(new NavigationItem() { Name = "123",Icon = "Assets/StoreLogo.png" }) ;
            NavigationItems.Add(new NavigationItem() { Name = "123", Icon = "Assets/StoreLogo.png" });
            NavigationItems.Add(new NavigationItem() { Name = "123", Icon = "Assets/StoreLogo.png" });
        }

    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            VM = new MyViewModel();
            this.DataContext = VM;
            
        }

        private MyViewModel VM { get; set; }

        

        private void ItemsRepeater_ElementPrepared(Microsoft.UI.Xaml.Controls.ItemsRepeater sender, Microsoft.UI.Xaml.Controls.ItemsRepeaterElementPreparedEventArgs args)
        {
            var repeaterDataContext = sender.DataContext;
            Image MyImage = args.Element as Image;
            MyImage.DataContext = repeaterDataContext;
        }
    }
}
