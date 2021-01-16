using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Models;
using Organizer.ViewModels;
using Xamarin.Forms;

namespace Organizer
{
    public partial class MainPage : ContentPage
    {
        async void AddEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EventEditorPage());
        }

        async void AllEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AllEventPage());
        }

        async void OnItemTapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ExtEventPage());
        }

        public MainPage()
        {
            InitializeComponent();
        }

        
    }
}
