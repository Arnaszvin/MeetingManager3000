using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMeetingApp.Commands
{
    class CreateMeeting : ICommand
    {
        public string InformationAboutCommand { get => "Input meeting Name, then add Description, Members, Organizer, Start and end dates:"; }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
