using System.ComponentModel;
using System.ComponentModel.Design;

namespace _4PROECT
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {


                List<NAVALNYI> myZametki = MakeZametki();
                DateTime date = DateTime.Now;
                int position = 1;
                ConsoleKeyInfo key = Console.ReadKey();
                while (key.Key != ConsoleKey.Enter)
                {

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        date = data(date, 1);
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        date = data(date, -1);
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }

                    Console.Clear();
                    List<NAVALNYI> sortedZam = myZametki.Where(NAVALNYI => NAVALNYI.Date.Date == date.Date).ToList();
                    Menu(date, sortedZam);
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("=>");

                    key = Console.ReadKey();
                }
                Console.Clear();
                List<NAVALNYI> sZam = myZametki.Where(NAVALNYI => NAVALNYI.Date.Date == date.Date).ToList();
                Console.WriteLine(sZam[position - 1].Description);
                if (key.Key == ConsoleKey.Tab)
                {
                    break;
                }
            }
        }

        static void Menu(DateTime selectedDAte, List<NAVALNYI> zametki)
        {
            Console.WriteLine("Выбрана дата: " + selectedDAte);
            foreach (NAVALNYI NAVALNYI in zametki)
            {
                Console.WriteLine("  " + NAVALNYI.Name);
            }
        }

        static DateTime data(DateTime dateTime, int add)
        {
            return dateTime.AddDays(add);
        }

        static List<NAVALNYI> MakeZametki()
        {
            NAVALNYI zam1 = new NAVALNYI();
            zam1.Name = "Пойти в кальнную";
            zam1.Description = "Название:\n" +
                "Пойти в кальнную\n" +
                "-----------\n" +
                "Описание:\n" +
                "Не забыть покурить перед выходом\n" +
                "-----------\n" +
                "Дата:\n" +
                "01.02.2023";
            zam1.Date = new DateTime(2023, 02, 01);

            NAVALNYI zam2 = new NAVALNYI();
            zam2.Name = "Посмотреть футбол";
            zam2.Description = "Название:\n" +
                "Посмотреть футбол\n" +
                "-----------\n" +
                "Описание:\n" +
                "Разбаньте футбол\n" +
                "-----------\n" +
                "Дата:\n" +
                "02.02.2023";
            zam2.Date = new DateTime(2023, 02, 02);

            NAVALNYI zam3 = new NAVALNYI();
            zam3.Name = "Сходить покурить";
            zam3.Description = "Название:\n" +
                "Сходить в табачку\n" +
                "-----------\n" +
                "Описание:\n" +
                "Купить табак\n" +
                "-----------\n" +
                "Дата:\n" +
                "03.02.2023";
            zam3.Date = new DateTime(2023, 02, 03);

            NAVALNYI zam4 = new NAVALNYI();
            zam4.Name = "Посмотреть на дзюбу";
            zam4.Description = "Название:\n" +
                "Потрогать дзюбу\n" +
                "-----------\n" +
                "Описание:\n" +
                "Словить лютый кринж\n" +
                "-----------\n" +
                "Дата:\n" +
                "04.02.2023";
            zam4.Date = new DateTime(2023, 02, 04);

            NAVALNYI zam5 = new NAVALNYI();
            zam5.Name = "выгулить альберта";
            zam5.Description = "Название:\n" +
                "Выгулить альберта\n" +
                "-----------\n" +
                "Описание:\n" +
                "Не забыть покурить\n" +
                "-----------\n" +
                "Дата:\n" +
                "05.02.2023";
            zam5.Date = new DateTime(2023, 02, 05);


            List<NAVALNYI> list = new List<NAVALNYI>();
            list.Add(zam1);
            list.Add(zam2);
            list.Add(zam3);
            list.Add(zam4);
            list.Add(zam5);

            return list;
        }
    }
}