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
using Xamarin.Forms.Xaml;

namespace Organizer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class EventEditorPage : ContentPage
    {
        public EventEditorPage()
        {
            InitializeComponent();
        }

    }
}