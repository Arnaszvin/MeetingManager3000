using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMeetingApp.Commands
{
    class AddPersonToMeeting : ICommand
    {
        public string InformationAboutCommand
        {
            get => "In this command select a Meeting with arrow keys and enter, then input name and surname of the person that you want to add";
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
