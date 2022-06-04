using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace OG
{
    class OGReader
    {
        public string URL { get; private set; }
        public bool isStarted { get; private set; }
        public int readDelay { get; set; }

        public Thread ReadThread;

        public delegate void Read();
        public Read ReadFunction { get; set; }


        public delegate void OnChangeFunction(string command);
        public event OnChangeFunction OnChange;


        public string lastCommand { get; set; }

        public OGReader(string u,int d)
        {
            URL = u;
            readDelay = d;
        }

        public void Start()
        {
         
            ReadThread = new Thread(new ThreadStart(ReadFunction));
            ReadThread.Start();
            isStarted = true;
        }

        public void Changed(string command)
        {
            OnChange.Invoke(command);
        }

        public string GetText()
        {
            try
            {
                WebClient wc = new WebClient();

                var text = wc.DownloadString(URL);
                return text;

            }
            catch (Exception ex)
            {
                Alert.Warning(ex.Message);

                return null;
            }
    
            
        }

        public void Abort()
        {
            isStarted = false;
            ReadThread.Abort();
        }
            



    }
}
