using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS253_HW01_finger_guessing_game
{
    public class FingerGuessingGame
    {
        private string playAgainChick;
        private int playerWantedNumber;
        private int computerWantedNumber;

        private Random randomNumber = new Random();

        public void LetsPlay()
        {
            Console.WriteLine("猜拳遊戲!!");
            do
            {
                Console.WriteLine("請輸入你要出的招:1.剪刀 2.石頭 3.布");
                string playerWanted = Console.ReadLine();
                if (playerWanted == "1" | playerWanted == "2" | playerWanted == "3")
                {
                    playerWantedNumber = int.Parse(playerWanted);
                    computerWantedNumber = randomNumber.Next(1, 4);

                    Console.WriteLine("你出{0},我出{1}", TranslateNumberToChinese(playerWantedNumber), TranslateNumberToChinese(computerWantedNumber));
                    Judge();
                }
                else
                {
                    Console.WriteLine("蛤 你說什麼?!");
                }

                Console.WriteLine("要再玩一次嗎? 要請輸入1");
                playAgainChick = Console.ReadLine();
            } while (playAgainChick == "1");
            Console.WriteLine("掰掰~~");
        }

        public string TranslateNumberToChinese(int number)
        {
            if (number == 1)
                return "剪刀";
            else if (number == 2)
                return "石頭";
            else if (number == 3)
                return "布";
            else
                return "什麼東西";
        }

        public void Judge()
        {
            //請輸入你要出的招:1.剪刀 2.石頭 3.布
            if ((playerWantedNumber - computerWantedNumber) == 1 | (playerWantedNumber - computerWantedNumber) == -2)
                Console.WriteLine("你贏了");
            else if (playerWantedNumber == computerWantedNumber)
                Console.WriteLine("平手");
            else
                Console.WriteLine("我贏了");
        }
    }
}