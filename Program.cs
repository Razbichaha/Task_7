using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество золота ");
            string plaersGoldToEnter = Console.ReadLine();
            int goldPlaer;
            int crystalPrice = 12;
            if(int.TryParse(plaersGoldToEnter, out goldPlaer))
            {
                Console.WriteLine("Приветствую тебя авантюрист\nв нашем магазине ты можешь купить кристаллы\nцена одного кристала = " + crystalPrice + " золота");
                ///Console.ReadLine();
                Console.WriteLine("Сколько кристаллов ты хочешь купить?");
                int bayCrystals;
                string enterPlaerCrystalsToStore = Console.ReadLine();
                bool boughtCrystals = true ;
                while (boughtCrystals)
                {
                    if (int.TryParse(enterPlaerCrystalsToStore, out bayCrystals))
                    {
                        int theAmountOfGoldToBayCrystals = crystalPrice * bayCrystals;
                        goldPlaer = goldPlaer - theAmountOfGoldToBayCrystals;
                        Console.WriteLine("Куплено кристаллов - " + bayCrystals + ". Осталось золота - " + goldPlaer + ".");
                        boughtCrystals = false;
                    }
                    else
                    {
                        Console.WriteLine("ММММ это не золото попробуйте ещё раз");
                        enterPlaerCrystalsToStore = Console.ReadLine();
                    }
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Введёные значения не являются числом\nприложение будет закрыто");
            }

        }
    }
}
