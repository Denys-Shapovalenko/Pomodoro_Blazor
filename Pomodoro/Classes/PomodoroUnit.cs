using System;
using System.Timers;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodoro.Classes
{
    public enum PomodoroMode
    {
        Work =0,
        Rest
    }
    public class PomodoroUnit
    {
        private int _duration;
        public int Duration {
            get
            { return _duration; }
            private set
            {
                _duration = Math.Abs(value); 
            } 
        }
        public int Intermission { get; private set; } = 5;

        public int MinutesToGo { get; private set; }
        public int SecondsToGo { get; private set; }

        public Timer WorkTimer { get; private set; }
        public ElapsedEventHandler OnSecondElapsed { get; set; }
        public bool Elapsed { get { return MinutesToGo == 0 && SecondsToGo == 0; } }
        public PomodoroMode Mode { get; private set; } = PomodoroMode.Work;
        public static bool AnythingRunning { get; private set; } = false;

        public PomodoroUnit()
        {
            Duration = 25;
            WorkTimer = new Timer(1000);
        }

        public PomodoroUnit(int intermission)
        {
            Intermission = intermission;
        }

        public void StartCountdown(Action OnCountdown, Action OnWork, Action OnRest)
        {
            MinutesToGo = Duration;
            OnSecondElapsed += (obj, args) =>
            {
                SecondsToGo = SecondsToGo <= 0 ? 59 : SecondsToGo - 1;
                MinutesToGo = MinutesToGo - (SecondsToGo == 59 ? 1 : 0);
                OnCountdown();
                if (Elapsed)
                {
                    WorkTimer.Stop();
                    if (Mode == PomodoroMode.Work)
                    {
                        OnRest();
                        Mode = PomodoroMode.Rest;
                        MinutesToGo = Intermission;
                        WorkTimer.Start();
                    }
                    else
                    {
                        OnWork();
                        PomodoroUnit.AnythingRunning = false;
                    }
                }
            };
            WorkTimer.Elapsed += OnSecondElapsed;
            WorkTimer.Start();
        }

        public void StopCountdown()
        {
            WorkTimer.Stop();
            MinutesToGo = Duration;
            SecondsToGo = 0;
            Mode = PomodoroMode.Work;
            WorkTimer.Elapsed -= OnSecondElapsed;
        }
    }
}
