// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] MyArray = FillArray(6, 100 , 999);
int[] FillArray(int size,int MinValue, int MaxValue){
    int[] mas = new int[size];
    for(int i = 0; i<size; i++){
        mas[i] = new Random().Next(MinValue,MaxValue + 1);
         Console.Write($"{mas[i]} ");
    }
    return mas;
}
Console.WriteLine($"Количество чётных чисел: {FindCount(MyArray)}");
int FindCount(int[] array){
    int colvo = 0;
    for(int i = 0;i<array.Length;i++ ){
        if( array[i]%2 == 0){
            colvo++;
        }
    }
    return colvo;
}