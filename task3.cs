// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double [] array = new double[10];
double max = -1;
double min = 11;
for (int i = 0; i < 10; i++){
    array[i] = new Random().NextDouble() * 10;
    if (array[i]>max) max=array[i];
    if (array[i]<min) min=array[i];
    Console.WriteLine(array[i]);
}
Console.WriteLine("");
Console.WriteLine($"{max} - {min} = {max-min}");
