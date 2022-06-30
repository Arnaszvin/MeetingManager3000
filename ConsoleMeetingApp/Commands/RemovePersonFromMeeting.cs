using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMeetingApp.Commands
{
    class RemovePersonFromMeeting : ICommand
    {
        public string InformationAboutCommand { get => "In this command you can remove a person from meeting"; }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
