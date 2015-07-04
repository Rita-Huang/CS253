using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS253_HW01_finger_guessing_game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FingerGuessingGame player = new FingerGuessingGame();
            player.LetsPlay();
        }
    }
}