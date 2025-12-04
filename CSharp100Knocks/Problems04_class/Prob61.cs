namespace CSharp100Knocks.Problems04_class
{
    public class Prob61
    {
        public interface IGame
        {
            void Play();
        }

        public interface IMusic
        {
            void Play();
        }

        public class MultiMediaPlayer : IGame, IMusic
        {
            void IGame.Play()
            {
                Console.WriteLine("Play game.");
            }

            void IMusic.Play()
            {
                Console.WriteLine("Play music.");
            }
        }
    }
}