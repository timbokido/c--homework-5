// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int[10];
int count = 0;
for (int i = 0; i < 10; i++){
    array[i] = new Random().Next(0, 100);
    if (array[i]%2==1) count+=array[i];
    Console.WriteLine(array[i]);
}
Console.WriteLine($"сумма нечетных элементов равняется {count}");
