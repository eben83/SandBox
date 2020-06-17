using static System.Console;

namespace Packt.Shared
{
    public class DvdPlayer: IPlayable
    {
        public void play()
        {
            WriteLine("DVD player is playing");
        }

        public void Pause()
        {
            WriteLine("DVD is paused");
        }
    }
}