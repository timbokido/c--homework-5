// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array = new int[10];
int count = 0;
for (int i = 0; i < 10; i++){
    array[i] = new Random().Next(100, 1000);
    if (array[i]%2==0) count++;
    Console.WriteLine(array[i]);
}
Console.WriteLine($"{count} четных элементов в массиве");