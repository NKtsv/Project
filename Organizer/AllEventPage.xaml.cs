using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Organizer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllEventPage : ContentPage
    {
        async void AddEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync( new EventEditorPage());
        }

        async void OnItemTapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ExtEventPage());
        }

        public AllEventPage()
        {
            InitializeComponent();
        }
    }
}