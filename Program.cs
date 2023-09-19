// ДОМАШКА!!!
//задача № 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//задача № 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//задача № 6: Напишите программу, которая на вход принимает число и выдает, является числом четным (делится ли онон на два без остатка).
//задача № 8: Напишите программу, которая на вход принимает число (N), а на выхлде показывает все чётные числа от 1 до N

// РЕШЕНИЕ
//задача № 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

// int max = 0;
// int min = 0;

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

//  if(firstNumber > secondNumber)
//  {
//      max = firstNumber;
//      min = secondNumber;
//  }
//  else
//  {
//      max = secondNumber;
//      min = firstNumber;
//  }
// Console.WriteLine("max = " + max + " и " + "min = " + min);

// ----------------------------------------------------------------
//задача № 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
 
// int max = 0;

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber > max)
//  {
//      max = firstNumber;
//  }
// if(secondNumber > max)
//  {
//      max = secondNumber;
//  }
//  if(thirdNumber > max)
//  {
//      max = thirdNumber;
//  }

// Console.WriteLine("max = " + max);

// ------------------------------------------------------

//задача № 6: Напишите программу, которая на вход принимает число и выдает, является числом четным (делится ли онон на два без остатка).

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int remDiv = number % 2;

//  if(remDiv == 0)
//  {
//      Console.WriteLine("Да");
//  }
//  else
//  {
// Console.WriteLine("Нет");
//  }

// --------------------------------------------------

//задача № 8: Напишите программу, которая на вход принимает число (N), а на выхлде показывает все чётные числа от 1 до N

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

//  if(number > 1)
//  {
//      while(evenNumber <= number)
//      {
//          Console.Write(evenNumber + " ");
//          evenNumber = evenNumber + 2;
//      }
//  }
