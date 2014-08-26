using System.Linq;
using DevDay.Mobile.CellTemplates;
using DevDay.Mobile.DataSources;
using DevDay.Mobile.DTO;
using Xamarin.Forms;

namespace DevDay.Mobile
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Title = "DevDay 2014";

            Children.Add(getAgendaTab());
            Children.Add(getSpeakersTab());
            Children.Add(getAboutTab());

            Padding = new Thickness(5);
        }

        private ContentPage getAgendaTab()
        {
            var agendaTab = new ContentPage
            {
                Title = "AGENDA",
            };

            var agenda = new ListView
            {
                ItemsSource = SessionRepository.GetAgenda(),
                ItemTemplate = new DataTemplate(typeof(AgendaCell))
            };

            agenda.ItemTapped += (sender, e) =>
            {
                agenda.SelectedItem = "";
                var agendaItem = ((AgendaItem) e.Item);
                if(agendaItem.Session == null){ return; }
                Navigation.PushAsync(new SessionPage(agendaItem.Session));
            };

            agendaTab.Content = agenda;

            return agendaTab;
        }

        private ContentPage getSpeakersTab()
        {
            var speakersTab = new ContentPage
            {
                Title = "SPEAKERS",
            };

            var speakers = new ListView
            {
                ItemsSource = SessionRepository.GetSessions().Where(s => !string.IsNullOrWhiteSpace(s.Speaker)),
                ItemTemplate = new DataTemplate(typeof(SpeakerCell))
            };

            speakers.ItemTapped += (sender, e) =>
            {
                speakers.SelectedItem = "";
                Navigation.PushAsync(new SpeakerPage(e.Item as Session));
            };

            speakersTab.Content = speakers;

            return speakersTab;
        }

        private ContentPage getAboutTab()
        {
            var aboutTab = new ContentPage
            {
                Title = "ABOUT US",
            };
            var label = new Label { Text = "DevDay 2014 - 26th of September 2014, Kraków" };
            aboutTab.Content = label;
            return aboutTab;
        }
    }
}