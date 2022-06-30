using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMeetingApp.Commands
{
    class DeleteMeeting : ICommand
    {
        public string InformationAboutCommand { get => "Authorize yourself as an Organizer and find your meeting that you want to delete:"; }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
