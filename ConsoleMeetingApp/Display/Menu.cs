using static System.Console;
namespace ConsoleMeetingApp.Display
{
    class Menu
    {
        private int currentID;
        private List<string> options = new List<string>();
        private string prompt;

        public Menu(List<Type> options, string prompt)
        {
            for (int i = 0; i < options.Count; i++)
            {
                this.options.Add(options[i].Name);
            }
            this.prompt = prompt;
        }
        public Menu(List<string> displayListOptions, string prompt)
        {
            this.options = displayListOptions;
            this.prompt = prompt;
        }

        public void DisplayOptions()
        {
            WriteLine(prompt);

            for (int i = 0; i < options.Count; i++)
            {
                string prefix;

                string option = options[i];
                if (i == currentID)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<<{option}>>");
                ResetColor();
            }

        }

        public string Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (currentID <= 0)
                    {
                        currentID = options.Count - 1;
                    }
                    else
                        currentID--;
                }

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    if (currentID >= options.Count - 1)
                    {
                        currentID = 0;
                    }
                    else
                    {
                        currentID++;
                    }

                }
            } while (keyPressed != ConsoleKey.Enter);
            return options[currentID];
        }
    }
}
