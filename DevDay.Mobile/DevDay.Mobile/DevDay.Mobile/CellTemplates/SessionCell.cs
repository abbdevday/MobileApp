using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DevDay.Mobile.CellTemplates
{
    class SessionCell : ViewCell
    {
        public SessionCell()
        {
            var session = new Label
            {
                Font = Font.BoldSystemFontOfSize(20)
            };
            session.SetBinding(Label.TextProperty, "Title");

            View = session;
        }
    }
}
