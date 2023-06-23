using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee
{

    public class cofevubor
    {

        public string name;//имя
        public string number;//номер
        public int cost;// цена
        public int sum;//внесенная сумма
        public int f;
        public void menu()
        {
            string[] mass = { "Кофе A11  ", "Кофе1 B22 ", "Кофе2 C33 ", "Кофе3 D44 " };


            foreach (string i in mass)
                Console.WriteLine(i);

        }
        public void qqq(string number)
        {
            while (true)
            {
                switch (number)
                {
                    case "A11":
                        name = "Кофе ";
                        cost = 200;
                       //-----------------------
                        break;
                    case "B22":
                        name = "Кофе1";
                        cost = 400;
                        // --------------------------
                        break;
                    case "C33":
                        name = "Кофе2";
                        cost = 260;
                        //-------------------------------
                       
                        break;
                    default:
                        name = "";
                        break;
                }

                if (name == "")
                {
                    Console.WriteLine("неверно ввели номер ");
                    qqq(Console.ReadLine());
                    return;
                }

                else break;
            }

            Console.WriteLine("цена " + name + " " + " имя " + cost);
        }

        public void pocub(int sum)
        {

            if (sum >= cost)
            {
                f = sum - cost;
            }
            else if (sum == cost)
            {
                f = 0;

            }
            else
            {
                f = sum - cost;
            }

        }


        public void toint()
        {
            if (f >= 0)
            {
                Console.WriteLine("Номер " + number + " имя " + name + " Цена " + cost
                   + " Введенная сумма " + sum + " Остаток " + f);
            }
            else if (f < 0)
            {
                Console.WriteLine(" недостаточно средств");
            }

        }
    }
}
