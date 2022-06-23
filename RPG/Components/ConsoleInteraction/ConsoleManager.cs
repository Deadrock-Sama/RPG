using System;
using System.Threading.Tasks;

namespace RPG
{
    public class ConsoleManager
    {
        public event Action<ConsoleKey> KeyPressed;
        public event Action<string> LineWritten;

        private bool _isWaiting;

        public void ShowAndReadLine(string msg)
        {
            Show(msg);
            Task.Run(() => WaitString());
        }
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public void ShowAndReadKey(string msg)
        {
            Show(msg);
            Task.Run(() => WaitKey());
        }


        private void WaitString()
        {
            if (_isWaiting)
            {
                throw new Exception($"Одновременно вызвано два ожидания в {nameof(ConsoleManager)}");
            }
            _isWaiting = true;

            var line = Console.ReadLine();
            LineWritten.Invoke(line);

            _isWaiting = false;
        }
        private void WaitKey()
        {
            if (_isWaiting)
            {
                throw new Exception($"Одновременно вызвано два ожидания в {nameof(ConsoleManager)}");
            }
            _isWaiting = true;

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            KeyPressed.Invoke(key.Key);

            _isWaiting = false;
        }

    }
}
