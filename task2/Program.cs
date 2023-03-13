//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
int[] MyArray = FillArray(7 , 1 , 100);
int[] FillArray(int size, int MinValue, int MaxValue){
    int[] mas = new int[size];
    for(int i = 0; i<size; i++){
    mas[i]=new Random().Next(MinValue,MaxValue);
    Console.WriteLine($"{mas[i]} ");}
    return mas;
}
Console.WriteLine($"Sum = {FindSum(MyArray)}");
int FindSum(int[] array){
    int sum = 0;
    for(int i = 1; i<array.Length;i+=2){
            sum = array[i] + sum;
        }
        return sum;
    }
    
