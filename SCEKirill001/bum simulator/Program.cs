using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bum_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует симулятор бомжа");
            int day = 0;
            int Gender = 0;
            string Name = ("f");
            int age = 0;
            int money = 0;
            int hunger = 100;
            int health = 100;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Выберайте пол вашего персонажа(Введите 0 если мужчина , Введите 1 если женщина):");
                Gender = Convert.ToInt32(Console.ReadLine());
                if (Gender == 0)
                {
                    Console.WriteLine("Введите мужское имя:");
                    Name = Convert.ToString(Console.ReadLine());
                    break;
                }
                else if (Gender == 1)
                {
                    Console.WriteLine("Введите  женское имя:");
                    Name = Convert.ToString(Console.ReadLine());
                    break;
                }
                else
                {
                    Console.WriteLine("Ваша сексуальная ориентация тут не причем ,введите ваш пол заново:");
                }
            }
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Введите взраст вашего персонажа(от 18 до 100 лет):");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18 || age > 100)
                {
                    Console.WriteLine("Я же попросил");
                }
                else
                {
                    break;
                }
            }
            Charecter charecter = Gender == 0 ? new ManCharacter() : (Charecter)new WomanCharecter();
            charecter.Age = age;
            charecter.Name = Name;
            string Story = charecter.backstory();

            Console.WriteLine(Story);

            Console.WriteLine("Нажмите Enter чтобы начать игру.");
            Console.Read();
            Console.WriteLine("Каждый день будет сниматсь по 5 сытости и 5 здоровья.");
            Console.Read();
            for (int i = 0; i <= 101; i++)
            {
                if (i == 101 && money > 999)
                {
                    Console.WriteLine("Поздровляю вы выиграли");
                }
                else if (i == 101 && money < 999)
                {
                    Console.WriteLine("Вы проиграли, бомжуй дальше");
                }
                if (hunger > 1 || health > 1 || hunger > 1 && health > 1)
                {
                    Console.WriteLine("Выберайте чем хотите занятся \n" +
                        "(0 - заработать денег\n" +
                        "1 - покушать\n" +
                        "2 - подлечится\n" +
                        "3 - Спать целый день)");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        (money, hunger, health, day) = Money(money, hunger, health, day);

                    }
                    else if (choice == 1)
                    {
                        (money, hunger, health, day) = Hunger(money, hunger, health, day);
                    }
                    else if (choice == 2)
                    {
                        (money, hunger, health, day) = Health(money, hunger, health, day);
                    }
                    else
                    {
                        hunger -= 5;
                        health -= 5;
                        day++;
                        statistics(money, hunger, health, day);
                    }

                }
                else if(hunger<1|| health<1||hunger <1 && health < 1)
                {
                    Console.WriteLine("Ты мертв, живи с этим");
                    Thread.Sleep(10000);
                    return;
                }
            }
            Console.Read();

        }
        private static (int, int, int,int) Money(int money, int hunger, int health, int day)
        {
            day++;            
            bool iu = true;

            for (int i = 0; ; i++)
            {
                Console.WriteLine("Введите 0 если хотите попрошайничать возле метро\n" +
                    "Введите 1 если хотите работать в кафе (30 дней+)\n" +
                    "Введите 2 если хотите работать в СТО(70 дней+)");
                int mon = Convert.ToInt32(Console.ReadLine());

                if (mon == 1 && day < 30 && iu == true)
                {
                    Console.WriteLine("Сейчас вообше без работы будешь\n");
                    iu = false;
                }
                else if (mon == 2 && day < 70 && iu == true)
                {
                    Console.WriteLine("Сейчас вообше без работы будешь\n");
                    iu = false;
                }
                else if (mon < 0 || mon > 2)
                {
                    Console.WriteLine("Сейчас вообше без работы будешь\n");
                    iu = false;
                }
                else if (mon == 1 && day < 30 && iu != true)
                {
                    hunger -= 5;
                    health -= 5;
                    statistics(money, hunger, health, day);
                    return (money, hunger, health,day);
                }
                else if(mon == 2&& day < 70&& iu == false)
                {
                    hunger -= 5;
                    health -= 5;
                    statistics(money, hunger, health, day);
                    return (money, hunger, health, day);
                }

                if (mon == 0)
                {
                    Random g = new Random();
                    int value = g.Next(10, 20);

                    money += value;
                    hunger -= 5;
                    health -= 5;
                    statistics(money, hunger, health, day);
                    return (money, hunger, health,day);

                }
                else if (mon == 1 && day > 29)
                {
                    money += 50;
                    hunger -= 5;
                    health -= 5;
                    statistics(money, hunger, health, day);
                    return (money, hunger, health,day);

                }
                else if (mon == 1 && day > 59)
                {
                    money += 100;
                    hunger -= 5;
                    health -= 5;
                    statistics(money, hunger, health, day);
                    return (money, hunger, health,day);
                }

            }

        }
        private static (int, int, int,int) Hunger(int money, int hunger, int health,int day)
        {
            day++;
            
            bool a = true;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Выберете где хотите поесть\n" +
                    "0 - покушать на помойке(от -5 до +10)\n" +
                    "1 - покушать в кафе(+50 голода, но - 20грн)\n" +
                    "2 - покушать в ресторане(+100 голода, но - 40грн");
                int hun = Convert.ToInt32(Console.ReadLine());

                if (hun == 1 && money < 20 && a == true)
                {
                    Console.WriteLine("Сейчас вообше кушать не будешь\n");
                    a = false;
                }
                else if (hun == 1 && money < 20 && a == false)
                {
                    statistics(money, hunger - 5, health - 5, day);
                    return (money, hunger, health, day);
                }
                if (hun == 2 && money < 40 && a == true)
                {
                    Console.WriteLine("Сейчас вообше кушать не будешь\n");
                    a = false;
                }
                else if (hun == 2 && money < 40 && a == false)
                {
                    statistics(money, hunger - 5, health - 5, day);
                    return (money, hunger, health, day);
                }
                if (hun < 0 && a == true || hun > 2 && a == true)
                {
                    Console.WriteLine("Сейчас вообше кушать не будешь\n");
                    a = false;
                }
                else if (hun < 0 && a == false || hun > 2 && a == false)
                {
                    statistics(money, hunger - 5, health - 5, day);
                    return (money, hunger, health, day);
                }
                if (hun == 0)
                {
                    Random g = new Random();
                    int value = g.Next(-5, 10);
                    if (value < 0)
                    {
                        Console.WriteLine("Вы отравились\n");
                        hunger += value;
                    }
                    else
                    {
                        hunger += value;
                    }
                    if (hunger > 100)
                    {
                        hunger = 100;
                        statistics(money, hunger - 5, health - 5, day);
                    }
                    else
                    {
                        statistics(money, hunger - 5, health - 5, day);
                    }
                    return (money, hunger, health, day);
                }
                else if (hun == 1 && money > 20)
                {
                    if (hunger > 100)
                    {
                        hunger = 100;
                        statistics(money - 20, hunger + 45, health - 5, day);
                    }
                    else
                    {
                        statistics(money - 20, hunger + 45, health - 5, day);
                    }
                    return (money, hunger, health, day);
                }
                else if (hun == 2 && money > 40) 
                {
                    if (hunger > 100)
                    {
                        hunger = 100;
                        statistics(money - 40, hunger + 95, health - 5, day);
                    }
                    else
                    {
                        statistics(money - 40, hunger + 95, health - 5, day);
                    }
                    return (money, hunger, health, day);
                }
            }
            
        }
        private static (int, int, int,int) Health(int money, int hunger, int health, int day)
        {
            day++;
            bool b = true;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Введите как хотите подлечится \n" +
                    "( 0 - Поспать (+10 здоровья)\n" +
                    "1 - Пойти в аптеку (+ 25 здоровья, но - 25 гривен )\n" +
                    "2 - Лечь в больницу (+ 100 здоровья, но - 50 гривен");
                int Hea = Convert.ToInt32(Console.ReadLine());
                if (Hea == 1 && money < 25 && b == true)
                {
                    Console.WriteLine("Сейчас вообше лечится не будешь");
                    b = false;
                }
                else if (Hea == 1 && money < 25 && b == false)
                {
                    statistics(money, hunger - 5, health - 5, day);
                    return (money, hunger, health, day);
                }
                if (Hea == 2 && money < 50 && b == true)
                {
                    Console.WriteLine("Сейчас вообше лечится не будешь");
                    b = false;
                }
                else if (Hea == 2 && money < 50 && b == false)
                {
                    statistics(money, hunger - 5, health - 5, day);
                    return (money, hunger, health, day);
                }
                if(Hea < 0 || Hea > 2 && b == true)
                {
                    Console.WriteLine("Сейчас вообше лечится не будешь");
                    b = false;
                }
                else if(Hea < 0 || Hea > 2 && b == false)
                {
                    statistics(money, hunger - 5, health - 5, day);
                    return (money, hunger, health, day);
                }
                if (Hea == 0) 
                {
                    hunger -= 5;
                    health += 5;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    statistics(money , hunger , health , day);
                    return (money, hunger, health, day);
                }
                else if (Hea == 1 && money > 24)
                {
                    money -= 25;
                    hunger -= 5;
                    health += 20;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    statistics(money , hunger , health , day);
                    return (money, hunger, health, day);
                }
                else if(Hea == 2&& money > 49)
                {
                    money -= 50;
                    hunger -= 5;
                    health += 95;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    statistics(money , hunger , health , day);
                    return (money, hunger, health, day);
                }
            }
           
        }

            private static void statistics(int money, int hunger, int health, int day)
            {
                Console.WriteLine($"У вас {money} гривен\n");
                Console.WriteLine($"Ваше состояние сытости {hunger}\n");
                Console.WriteLine($"Ваше состояние здоровья {health}\n");
                Console.WriteLine($"Текущий день {day}\n");
            }
        }
    }
