// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

namespace Task_03
{
    class Program
    {
        static void Main(string [] args)
        {
            int [] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        
            System.Console.WriteLine(ReverseArray(array, 0));

        }

        static string ReverseArray(int [] array, int i)
        {
            if(i == array.Length) 
                return "";


            return ReverseArray(array, i + 1) + $" {array[i]}" ;
        }
    }
}

