// See https://aka.ms/new-console-template for more information

// Console.Write("Enter the length of the first array: ");
// int arrayFirstLength = Convert.ToInt32(Console.ReadLine());
//
// int[] arrayFirst = new int[arrayFirstLength];
//
// Console.Write("Enter the length of the second array: ");
// int arraySecondLength = Convert.ToInt32(Console.ReadLine());
//
// int[] arraySecond = new int[arraySecondLength];
//
 //bool isEqual = true;
//
// for(int i = 0; i < arrayFirstLength; i++)
// {
//     Console.Write($"Enter integer {i + 1} for first array: ");
//     arrayFirst[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("_________________________________________________________");
// for(int j = 0; j < arraySecondLength; j++)
// {
//     Console.Write($"Enter integer {j + 1} for second array: ");
//     arraySecond[j] = Convert.ToInt32(Console.ReadLine());
// }
//
// if (arrayFirstLength == arraySecondLength)
// {
//     for (int k = 0; k < arrayFirstLength; k++)
//     {
//         if (arrayFirst[k] != arraySecond[k])
//         {
//             Console.WriteLine("The array are not equal");
//             isEqual = false;
//             break;
//         }
//        
//         
//     }
//     
// }
// else
// {
//     Console.WriteLine("The arrays are not equal");
// }
//
// if (isEqual)
// {
//     Console.WriteLine("The arrays are equal");
// }

// char[] array1 = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l'};
// char[] array2 = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
//
// int length = Math.Min(array1.Length, array2.Length);
//
// bool foundDifference = true;
//
//
// for (int i = 0; i < length; i++)
// {
//     if (array1[i] > array2[i])
//     {
//         Console.WriteLine("array2 comes first in lexicographic order");
//         break;
//     }
//     if (array2[i] > array1[i])
//     {
//         Console.WriteLine("array1 comes first in lexicographic order");
//         break;
//     }
//     foundDifference = false;
// }
//
// if (!foundDifference)
// {
//     if (array1.Length > array2.Length)
//     {
//         Console.WriteLine("array2 comes first in lexicographic order");
//     }
//     else if (array2.Length > array1.Length)
//     {
//         Console.WriteLine("array1 comes first in lexicographic order");
//     }
//     else
//     {
//         Console.WriteLine("The arrays are equal");
//     }
//     
// }

// int[] arrayNumber = new int [2];
//
// for (int k = 0; k < arrayNumber.Length; k++)
// {
//     Console.Write($"Enter integer{k + 1}: ");
//     arrayNumber[k] = Convert.ToInt32(Console.ReadLine());
// }
//
// string comma = ", ";
// Console.WriteLine($"The numbers between {arrayNumber.Min()} and {arrayNumber.Max()} are: ");
// for(int j = arrayNumber.Min(); j <= arrayNumber.Max(); j++)
// {
//     if (j % 5 == 0)
//     {
//         if (j == arrayNumber.Max())
//         {
//             comma = string.Empty;
//         }
//         Console.Write(j + comma);
//     }
// }

// While Loop

int i = 0;

while (i < 10)
{
    Console.WriteLine(i);
    i++;
}







