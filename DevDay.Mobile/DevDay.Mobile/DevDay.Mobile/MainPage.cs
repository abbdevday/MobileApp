using Xamarin.Forms;

namespace DevDay.Mobile
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Title = "DevDay 2014";

            var agendaTab = new ContentPage { Title = "AGENDA" };
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(10, 0)
            };
            var label1 = new Label { Text = "Agenda goes here" };
            stack.Children.Add(label1);
            agendaTab.Content = stack;

            var speakersTab = new ContentPage { Title = "SPEAKERS" };
            var label2 = new Label { Text = "They're basically awesome" };
            speakersTab.Content = label2;

            var aboutTab = new ContentPage { Title = "ABOUT US" };
            var label3 = new Label { Text = "DevDay 2014 - 26th of September 2014, Kraków" };
            aboutTab.Content = label3;

            Children.Add(agendaTab);
            Children.Add(speakersTab);
            Children.Add(aboutTab);
        }
    }
}