/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

Console.WriteLine("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine());
string[] stringArray1 = new string[length];

void InputArrayElements(string[] stringArray1)
{
  for (int i = 0; i < stringArray1.Length; i++)
  {
    Console.WriteLine($"введите {i+1} элемент массива: ");
    stringArray1[i] = Console.ReadLine();
  }
}

string[] CheckingArrayElements(string[] stringArray1)
{
  int count = 0;
  for (int i = 0; i < stringArray1.Length; i++)
  {
    if (stringArray1[i].Length <=3)
    count++;
  }
  string[] array2 = new string[count];
  int newElements = 0;
  for (int i = 0; i < stringArray1.Length; i++)
  {
    if (stringArray1[i].Length <=3)
    {
      array2[newElements] = stringArray1[i];
      newElements++;
    }
  }
  return array2;
}

InputArrayElements(stringArray1);