// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
int[] MyArray = FillArray(5, 1, 100);
int[] FillArray(int size, int MinValue, int MaxValue){
    int[] mas = new int[size];
    for(int i=0;i<size;i++){
        mas[i]=new Random().Next(MinValue,MaxValue);
        Console.WriteLine($"{mas[i]}");
    }
    return mas;
}
Console.WriteLine($"Max - Min  = {FindRazn(MyArray)}");
int FindRazn(int[] array){
    int min=array[0];
    int max=array[0];
    int dif = 0;
    for(int i=0;i<array.Length;i++){
        if(array[i] < min){
             min = array[i];
        }
        if(array[i] > max){
             max = array[i];
        }
    dif = max - min;
}
return dif;
}