using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello();
            Console.WriteLine(Sum());

        }

        private static void Hello()
        {
            //5.Написать приложение, которое выведет на экран Ваше имя и фамилию. 
            //(Жду что у вас будет приложение, которое я сам запущу и где у меня 
            //попросят ввести ФИО, после я нажму Enter и мне выдастся сообщение – «Приветствую тебя - ФИО»)
            string name;
            Console.WriteLine("Представьтесь, пожалуйста: ");
            name = Console.ReadLine();
            Console.WriteLine("Приветствую тебя, " + name);
        }

        private static List<int> GetIntListFromString()
        {
            string userString;
            Console.WriteLine("Введите числа через пробел");
            userString = Console.ReadLine();
            string[] bufString = userString.Split(' ');
            List<int> numbers = new List<int>();
            foreach (var item in bufString)
            {
                int number = Convert.ToInt32(item);
                numbers.Add(number);
            }
            return numbers;
        }

        private static int Sum()
        {
            //6.Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму. 
            //(Так же как и в предыдущем примере, только с цифрами. 
            //Мы проходили как можно из строки перевести в число.)
            List<int> numbers = GetIntListFromString();
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}


