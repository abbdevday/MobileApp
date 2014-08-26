using System;
using System.Collections.Generic;
using System.Text;
using DevDay.Mobile.DTO;
using Xamarin.Forms;
using DevDay.Mobile.CellTemplates;

namespace DevDay.Mobile
{
    class SessionPage : ContentPage
    {
        public SessionPage(Session session)
        {
            Title = "Session";

            #if __ANDROID__
                Title = "DevDay 2014";
            #endif

            var stack = new StackLayout
            {
                Padding = new Thickness(5)
            };

            var scroll = new ScrollView { Content = stack };

            var title = new Label
            {
                Text = session.Title,
                TextColor = Utils.DevDayGreen,
                Font = Font.BoldSystemFontOfSize(30),
                HorizontalOptions = LayoutOptions.Center
            };
            stack.Children.Add(title);

            var timeslot = new Label
            {
                Text = session.Timeslot,
                Font = Font.SystemFontOfSize(12),
                HorizontalOptions = LayoutOptions.Start
            };
            stack.Children.Add(timeslot);

            stack.Children.Add(new Label
            {
                Text = session.Description,
                Font = Font.SystemFontOfSize(16)
            });

            stack.Children.Add(new Label
            {
                Text = "SPEAKER",
                TextColor = Utils.DevDayGreen,
                HorizontalOptions = LayoutOptions.Start,
                Font = Font.BoldSystemFontOfSize(20)
            });

            var speaker = new ListView
            {
                ItemsSource = new [] { session },
                ItemTemplate = new DataTemplate(typeof(SpeakerCell))
            };
            speaker.ItemTapped += (sender, e) =>
            {
                speaker.SelectedItem = "";
                Navigation.PushAsync(new SpeakerPage(e.Item as Session));
            };
            stack.Children.Add(speaker);

            Content = scroll;
        }
    }
}
