// Написать программу сортировки одномерного массива по возрастанию

int[] array = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++){
    array[i] = rnd.Next(0,100);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < 8; i++){
    for (int j = i + 1; j < 8; j++){
        if (array[i] > array[j]){
            int t = array[i];
            array[i] = array[j];
            array[j] = t;
        }
    }
}
Console.WriteLine();

 for (int i = 0; i < 8; i++){
    Console.Write($"{array[i]} ");
 }            