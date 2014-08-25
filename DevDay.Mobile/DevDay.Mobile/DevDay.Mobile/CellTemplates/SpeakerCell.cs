using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DevDay.Mobile.CellTemplates
{
    class SpeakerCell : ViewCell
    {
        public SpeakerCell()
        {
            var image = new Image
            {
                HeightRequest = 100,
                WidthRequest = 100
            };
            image.SetBinding(Image.SourceProperty, "Image");

            var speaker = new Label
            {
                Font = Font.BoldSystemFontOfSize(20),
                VerticalOptions = LayoutOptions.Center,
                MinimumHeightRequest = 100
            };
            speaker.SetBinding(Label.TextProperty, "Session.Speaker");

            View = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = {image, speaker}
            };
        }
    }
}
