using System;

namespace LV6_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2020, 5, 20, 19, 45, 36); //year,month,day,hour,minute,second

            ToDoItem item = new ToDoItem("M", "A", date);
            Console.WriteLine(item.ToString());
            CareTaker careTaker = new CareTaker();
            careTaker.PushStack(item.StoreState());
            item.Rename("Mihael");
            item.ChangeTask("Antolovic");
            Console.WriteLine(item.ToString());
            item.RestoreState(careTaker.PopStack());
            Console.WriteLine(item.ToString());
        }
    }
}
