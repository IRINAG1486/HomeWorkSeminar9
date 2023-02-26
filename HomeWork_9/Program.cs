//Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Выполнить с помощью рекурсии.

//1
/*void NumbersBetweenMN (int m, int n)
{
    
    if ( m < n && n != m) NumbersBetweenMN (m , n - 1);
    Console.Write ($"{n} ");
    
}

NumbersBetweenMN (4, 9);
*/

//2
/*string NumbersBetweenMN (int m, int n)
{
    
    if (m <= n ) return $"{m} " + NumbersBetweenMN (m + 1 , n);
    
    else return String.Empty;
   
}

string result = NumbersBetweenMN (1, 6);
Console.Write(result);
*/


//Задача 2. 
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*int SumOfNumbers (int m, int n)
{
    if (m <= n) return m + SumOfNumbers (m + 1, n);
    else return 0;
}

int result = SumOfNumbers (1, 15);
Console.Write(result);
*/


//Задача 3. 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int FindAkkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FindAkkerman (m - 1, 1);
    else return FindAkkerman (m - 1, FindAkkerman (m, n - 1));
}

int result = FindAkkerman (3, 2);
Console.Write(result);

