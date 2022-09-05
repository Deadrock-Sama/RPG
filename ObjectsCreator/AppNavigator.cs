using ObjectsCreator.MVVM.Models;
using System.Collections.Generic;

namespace ObjectsCreator
{
    public class AppNavigator : ViewModel
    {

        public object Current
        {
            get => _current;
            set
            {
                _current = value;
                Notify();
            }
        }

        private Stack<object> _history { get; } = new Stack<object>();
        private object _current;

        
        public void Show(object content)
        {

            if (Current != null)
            {
                _history.Push(Current);
            }
            Current = content;
        }

        public void Back()
        {
            if (_history.Count > 0)
            {
                Current = _history.Pop();
            }
        }
    }
}
