using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ConsoleMeetingApp.Commands;
namespace ConsoleMeetingApp.Display
{
    class DisplayMenu
    {
        public void Start()
        {
            RunMainMeniu();

        }
        private void RunMainMeniu()
        {

            Type lookupType = typeof(ICommand);
            IEnumerable<Type> lookupTypes = GetType().Assembly.GetTypes().Where(
                 t => lookupType.IsAssignableFrom(t) && !t.IsInterface);

            List<Type> types = lookupTypes.ToList();
            string prompt = @"
  __  __           _   _               __  __                                     ____   ___   ___   ___  
 |  \/  |         | | (_)             |  \/  |                                   |___ \ / _ \ / _ \ / _ \ 
 | \  / | ___  ___| |_ _ _ __   __ _  | \  / | __ _ _ __   __ _  __ _  ___ _ __    __) | | | | | | | | | |
 | |\/| |/ _ \/ _ \ __| | '_ \ / _` | | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|  |__ <| | | | | | | | | |
 | |  | |  __/  __/ |_| | | | | (_| | | |  | | (_| | | | | (_| | (_| |  __/ |     ___) | |_| | |_| | |_| |
 |_|  |_|\___|\___|\__|_|_| |_|\__, | |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_|    |____/ \___/ \___/ \___/ 
                                __/ |                            __/ |                                    
                               |___/                            |___/                                   
                        Select a command";
            Menu mainMenu = new Menu(types, prompt);
            string chosenOption = mainMenu.Run();
                        
        }
        public void RenderPage(string chosenOption)
        {
            
        }
        
    }
}
