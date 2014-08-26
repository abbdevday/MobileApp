using System;
using System.Collections.Generic;
using System.Text;
using DevDay.Mobile.DTO;
using Xamarin.Forms;
using DevDay.Mobile.CellTemplates;

namespace DevDay.Mobile
{
    class SpeakerPage : ContentPage
    {
        public SpeakerPage(Session session)
        {
            Title = "Speaker";

            #if __ANDROID__
                Title = "DevDay 2014";
            #endif

            var stack = new StackLayout
            {
                Padding = new Thickness(5)
            };

            var scroll = new ScrollView { Content = stack };

            stack.Children.Add(new Label
            {
                Text = session.Speaker, 
                Font = Font.BoldSystemFontOfSize(30), 
                TextColor = Utils.DevDayGreen,
                XAlign = TextAlignment.Center
            });
            
            stack.Children.Add(new Label
            {
                Text = session.TagLine.ToUpper(), 
                Font = Font.SystemFontOfSize(12), 
                XAlign = TextAlignment.Center
            });
            
            var img = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile(session.Image)
            };
            stack.Children.Add(img);

            stack.Children.Add(new Label()
            {
                Text = session.Bio,
                Font = Font.SystemFontOfSize(16)
            });

            stack.Children.Add(new Label
            {
                Text = "SESSION",
                TextColor = Utils.DevDayGreen,
                HorizontalOptions = LayoutOptions.Start,
                Font = Font.BoldSystemFontOfSize(20)
            });

            var sessionList = new ListView
            {
                ItemsSource = new[] { session },
                ItemTemplate = new DataTemplate(typeof(SessionCell))
            };
            sessionList.ItemTapped += (sender, e) =>
            {
                sessionList.SelectedItem = "";
                Navigation.PushAsync(new SessionPage(e.Item as Session));
            };
            stack.Children.Add(sessionList);

            Content = scroll;
        }
    }
}
