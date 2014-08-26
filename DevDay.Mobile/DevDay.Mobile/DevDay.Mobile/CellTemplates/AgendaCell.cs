using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DevDay.Mobile.CellTemplates
{
    class AgendaCell : ViewCell
    {
        public AgendaCell()
        {
            var timeslot = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Font = Font.BoldSystemFontOfSize(20),
                TextColor = Utils.DevDayGreen,
            };
            timeslot.SetBinding(Label.TextProperty, "Name");
            timeslot.SetBinding(Label.IsVisibleProperty, "IsTimeslot");

            var title = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Font = Font.BoldSystemFontOfSize(20)
            };
            title.SetBinding(Label.TextProperty, "Name");
            title.SetBinding(Label.IsVisibleProperty, "IsNotTimeslot");

            View = new StackLayout()
            {
                Padding = new Thickness(0, 10),
                Children = {timeslot, title}
            };
        }
    }
}
