using System.Security.Cryptography.X509Certificates;
using CSharp100Knocks.Problems04_class;
using Microsoft.VisualBasic;

namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Prob61.MultiMediaPlayer player = new Prob61.MultiMediaPlayer();
            ((Prob61.IGame)player).Play();

            Prob61.IMusic musicPlayer = player;
            musicPlayer.Play();
        }
    }
    
    
}