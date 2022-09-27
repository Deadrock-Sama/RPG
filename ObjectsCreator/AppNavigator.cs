using ObjectsCreator.MVVM.Models;
using System;
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

        private readonly Stack<object> _history = new();
        private readonly Stack<object> _forwardHistory  = new();
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

            _forwardHistory.Push(Current);
            if (isBackAble())
            {
                Current = _history.Pop();
                return;
            }
        }

        public void Close()
        {
            if (isBackAble())
            {
                Current = _history.Pop();
                return;
            }
            Environment.Exit(0);
        }

        public void Forward()
        {
            _history.Push(Current);

            if (isForwardAble())
            {
                Current = _forwardHistory.Pop();
            }
        }

        public bool isBackAble() => _history.Count > 0;
        public bool isForwardAble() => _forwardHistory.Count > 0; 
        
    }
}
