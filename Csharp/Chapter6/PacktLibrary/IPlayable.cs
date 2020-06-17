using static System.Console;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void play();

        void Pause();

        void Stop()
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}