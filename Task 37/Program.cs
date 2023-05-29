// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] FillArrayWithRandomNumber(int size) // создаем массив
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr; // возвращаем в основной код
}

System.Console.Write("Введите размер массива: "); 
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

int newLength = array.Length / 2 + array.Length % 2; // определяем новую длину нового массива т.е. сколько будет ячеек в новом массиве (array.Length % 2 для массива (старого) с нечетным количеством эдементов)
int[] newArray = new int[newLength]; // создаем новый массив

for (int i = 0; i < array.Length / 2; i++) // array.Length / 2 потому то определяем сколько пар будет
{
newArray[i] = array[i] * array[array.Length - i - 1]; // записываем в новый массив
}
if (array.Length % 2 == 1)
{
newArray[newArray.Length - 1] = array[array.Length / 2]; // array.Length / 2 всегда будет указывать на элемент который в середине в нечетном массиве например 7/2=3 (3 это номер индекса элемента)
}
System.Console.WriteLine(string.Join(", ", newArray));
