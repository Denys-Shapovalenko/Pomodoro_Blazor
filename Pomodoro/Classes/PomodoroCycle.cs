using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodoro.Classes
{
    public class PomodoroCycle
    {
        private List<PomodoroUnit> _pomodoros = new List<PomodoroUnit>(new[]
        {
            new PomodoroUnit(),
            new PomodoroUnit(),
            new PomodoroUnit(10)
        });

        private int _currentPomodoroPosition = 0;

        public PomodoroUnit CurrentPomodoroUnit => _pomodoros[_currentPomodoroPosition];

        public Action DoOnCountdown { get; private set; }
        public Action DoOnWork { get; private set; }
        public Action DoOnRest { get; private set; }

        public int CurrentPomodoroPosition
        {
            get => _currentPomodoroPosition;
            private set
            {
                if (!PomodoroUnit.AnythingRunning)
                {
                    CurrentPomodoroUnit.StopCountdown();
                    _currentPomodoroPosition = value % _pomodoros.Count;
                    CurrentPomodoroUnit.StartCountdown(DoOnCountdown,
                        () => { CurrentPomodoroPosition = CurrentPomodoroPosition + 1; DoOnWork(); },
                        () => DoOnRest());
                }
            }
        }

        public void StartPomodoroCycle(Action OnCountdown, Action OnWork, Action OnRest)
        {
            DoOnCountdown = OnCountdown;
            DoOnWork = OnWork;
            DoOnRest = OnRest;

            CurrentPomodoroUnit.StartCountdown(DoOnCountdown,
                        () => { CurrentPomodoroPosition = CurrentPomodoroPosition + 1; DoOnWork(); },
                        () => DoOnRest());

        }

        public void StopPomodoroCycle()
        {
            CurrentPomodoroPosition = 0;
            CurrentPomodoroUnit.StopCountdown();
        }
    }
}
