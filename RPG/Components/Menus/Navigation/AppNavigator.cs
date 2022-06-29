using System.Collections.Generic;

namespace RPG
{
    public class AppNavigator
    {
        private Stack<INavigatorContent> _history { get; } = new Stack<INavigatorContent>();
        private INavigatorContent _current;

        public INavigatorContent Current => _current;
        public void Show(INavigatorContent content)
        {

            if (_current != null)
            {
                _current.Hide();
                _history.Push(_current);
            }
            _current = content;
            
            content.Show();
            
        }

        public void Back()
        {
            _current.Hide();
            if (_history.Count > 0)
            {
                _current = _history.Pop();
                _current.Show();
            }
        }
    }
}
