using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorOOAD.Models
{
    internal class ScratchSensor
    {
        private System.Timers.Timer _timer;
        private DogDoor Door;

        public ScratchSensor(DogDoor door)
        {
            Door = door;
        }
        public void ScratchDoor()
        {

            if (!Door.IsOpen())
            {
                Console.WriteLine("Dog scratches the door...");
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
