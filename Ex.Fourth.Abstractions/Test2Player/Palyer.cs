using System;

namespace Ex.Fourth.Abstractions
{
    class Player : IPlayable, IRecodable
    {
        private bool record = false, play = false;
        private bool recordPause = false, playPause = false;
        public Player()
        {
            Console.Clear();
            Console.WriteLine("*---Player---*");
            Console.WriteLine("To use player enter commands: record, pause, stop");
        }

        private void CheckActions()
        {
            IPlayable linkIPlay = this;
            IRecodable linkIRec = this;

            while (play)
            {
                string action = Console.ReadLine();

                if (action == "record") linkIRec.Record();
                else if (action == "pause" && record) linkIRec.Pause();
                else if (action == "stop" && record) linkIRec.Stop();
                else if (action == "pause" && !record) linkIPlay.Pause();
                else if (action == "stop" && !record) linkIPlay.Stop();
                else Console.WriteLine("Incorrect command.");
            }
        }

        public void Play(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("Playing ...");
            play = true;
            CheckActions();
        }

        void IPlayable.Pause()
        {
            if (!playPause)
            {
                Console.WriteLine("Playing paused");
                playPause = true;
            }
            else
            {
                Console.WriteLine("Playing resumed");
                playPause = false;
            }
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing is stopped.");
            play = false;
        }

        void IRecodable.Record()
        {
            if (!record)
            {
                Console.WriteLine("\tStart recording");
                record = true;
            }
            else Console.WriteLine("\tAlready recording");
        }

        void IRecodable.Pause()
        {
            if (!recordPause && record)
            {
                Console.WriteLine("\tRecotding paused");
                recordPause = true;
            }
            else
            {
                Console.WriteLine("\tRecording resumed");
                recordPause = false;
            }
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("\tRecording is stopped");
            record = false;
        }
    }
}
