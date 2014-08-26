﻿using System;
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
            Title = "DevDay 2014";

            var stack = new StackLayout()
            {
                Padding = new Thickness(10)
            };
            
            stack.Children.Add(new Label
            {
                Text = session.Speaker, 
                Font = Font.BoldSystemFontOfSize(30), 
                TextColor = Color.Aqua,
                XAlign = TextAlignment.Center
            });
            
            stack.Children.Add(new Label
            {
                Text = session.TagLine.ToUpper(), 
                Font = Font.SystemFontOfSize(12), 
                XAlign = TextAlignment.Center
            });

            var scroll = new ScrollView();
            var scrolledStack = new StackLayout();
            scroll.Content = scrolledStack;
            stack.Children.Add(scroll);
            
            var img = new Image
            {
                Aspect = Aspect.AspectFit,
                Source = ImageSource.FromFile(session.Image)
            };
            scrolledStack.Children.Add(img);

            scrolledStack.Children.Add(new Label()
            {
                Text = session.Bio,
                Font = Font.SystemFontOfSize(16)
            });

            scrolledStack.Children.Add(new Label
            {
                Text = "SESSION",
                TextColor = Color.Aqua,
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
            scrolledStack.Children.Add(sessionList);

            Content = stack;
        }
    }
}