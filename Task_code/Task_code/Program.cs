using System;

namespace Task_code
{
    public class Program
    {
        public static int[] CreatingRandomNumbers(int arraySize)
        {
            Random ramdomNumbers = new Random();
            int[] arrayNumbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayNumbers[i] = ramdomNumbers.Next(1, 26);
            }

            return arrayNumbers;
        }

        public static (int[], int[]) CreatingParityArray(int[] array)
        {
            int[] even;
            int[] notEven;
            int sizeEven = 0;
            int sizeNotEven = 0;
            int indexEven = 0;
            int indexNotEven = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    sizeNotEven++;
                }
                else
                {
                    sizeEven++;
                }
            }

            even = new int[sizeEven];
            notEven = new int[sizeNotEven];
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    notEven[indexNotEven] = number;
                    indexNotEven++;
                }
                else
                {
                    even[indexEven] = number;
                    indexEven++;
                }
            }

            return (even, notEven);
        }

        public static (int, char[]) ChangeNumberstoLetters(int[] array)
        {
            int uppercaseLetters = 0;
            char[] arrayChar = new char[array.Length];
            int i = 0;
            foreach (int number in array)
            {
                switch (number)
                {
                    case 1:
                        arrayChar[i] = 'A';
                        uppercaseLetters++;
                        i++;
                        break;
                    case 2:
                        arrayChar[i] = 'b';
                        i++;
                        break;
                    case 3:
                        arrayChar[i] = 'c';
                        i++;
                        break;
                    case 4:
                        arrayChar[i] = 'D';
                        uppercaseLetters++;
                        i++;
                        break;
                    case 5:
                        arrayChar[i] = 'E';
                        uppercaseLetters++;
                        i++;
                        break;
                    case 6:
                        arrayChar[i] = 'f';
                        i++;
                        break;
                    case 7:
                        arrayChar[i] = 'g';
                        i++;
                        break;
                    case 8:
                        arrayChar[i] = 'H';
                        uppercaseLetters++;
                        i++;
                        break;
                    case 9:
                        arrayChar[i] = 'I';
                        uppercaseLetters++;
                        i++;
                        break;
                    case 10:
                        arrayChar[i] = 'J';
                        uppercaseLetters++;
                        i++;
                        break;
                    case 11:
                        arrayChar[i] = 'k';
                        i++;
                        break;
                    case 12:
                        arrayChar[i] = 'l';
                        i++;
                        break;
                    case 13:
                        arrayChar[i] = 'm';
                        i++;
                        break;
                    case 14:
                        arrayChar[i] = 'n';
                        i++;
                        break;
                    case 15:
                        arrayChar[i] = 'o';
                        i++;
                        break;
                    case 16:
                        arrayChar[i] = 'p';
                        i++;
                        break;
                    case 17:
                        arrayChar[i] = 'q';
                        i++;
                        break;
                    case 18:
                        arrayChar[i] = 'r';
                        i++;
                        break;
                    case 19:
                        arrayChar[i] = 's';
                        i++;
                        break;
                    case 20:
                        arrayChar[i] = 't';
                        i++;
                        break;
                    case 21:
                        arrayChar[i] = 'u';
                        i++;
                        break;
                    case 22:
                        arrayChar[i] = 'v';
                        i++;
                        break;
                    case 23:
                        arrayChar[i] = 'w';
                        i++;
                        break;
                    case 24:
                        arrayChar[i] = 'x';
                        i++;
                        break;
                    case 25:
                        arrayChar[i] = 'y';
                        i++;
                        break;
                    case 26:
                        arrayChar[i] = 'z';
                        i++;
                        break;
                }
            }

            return (uppercaseLetters, arrayChar);
        }

        public static void PrintArrayChar(char[] array)
        {
            foreach (char englishLetter in array)
            {
                Console.Write(englishLetter + " ");
            }
        }

        public static void Main(string[] args)
        {
            int arraySize;
            int[] evenArray;
            int[] notEvenArray;
            int[] arrayOfNumbers;
            Console.Write("Пожалуйста введите размер массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());
            arrayOfNumbers = new int[arraySize];
            arrayOfNumbers = CreatingRandomNumbers(arraySize);
            (evenArray, notEvenArray) = CreatingParityArray(arrayOfNumbers);
            char[] charArrayFirst = new char[evenArray.Length];
            char[] charArraySecond = new char[notEvenArray.Length];
            int uppercaseLettersFirst;
            int uppercaseLettersSecond;
            (uppercaseLettersFirst, charArrayFirst) = ChangeNumberstoLetters(evenArray);
            (uppercaseLettersSecond, charArraySecond) = ChangeNumberstoLetters(notEvenArray);
            if (uppercaseLettersFirst > uppercaseLettersSecond)
            {
                Console.WriteLine("Больше букв в верхнем регистре в первом (четном) массиве");
            }
            else if (uppercaseLettersFirst < uppercaseLettersSecond)
            {
                Console.WriteLine("Больше букв в верхнем регистре во втором (не четном) массиве");
            }
            else
            {
                Console.WriteLine("В верхнем регистре у обеих массивов букв поровну=)");
            }

            Console.Write("Первый массив символов: ");
            PrintArrayChar(charArrayFirst);
            Console.WriteLine();
            Console.Write("Второй массив символов: ");
            PrintArrayChar(charArraySecond);
        }
    }
}
