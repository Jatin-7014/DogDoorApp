using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorOOAD.Models
{
    internal class Remote
    {
        private System.Timers.Timer _timer;
        private DogDoor Door;

        public Remote(DogDoor door)
        {
            Door =door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button");
            if(Door.IsOpen())
            {
                Door.Close();
                StopTimer();
            }
            else
            {
                Door.Open();
                StartTimer();
            }
        }
        private void StartTimer()
        {
            _timer = new System.Timers.Timer(5000); 
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = false;
            _timer.Start();
        }
        private void StopTimer()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(" Closing the door automatically......");
            Door.Close();
            StopTimer();

        }
    }
}
