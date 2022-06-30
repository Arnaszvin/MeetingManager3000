using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMeetingApp.Commands
{
    class ListAllMeetings : ICommand
    {
        public string InformationAboutCommand { get => "In this command you can browse Meeting List and select filtering criteria"; }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
