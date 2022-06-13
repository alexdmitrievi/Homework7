// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк и столбцов");
int n = int.Parse(Console.ReadLine()??"");
int m = int.Parse(Console.ReadLine()??"");
int[,] array = new int[n,m];
Random rnd = new Random();
for (int i = 0; i < n; i++){
    for (int j = 0; j < m; j++){
        array[i,j] = rnd.Next(0,100);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

int min = 100*m;
int mini = -1;
for (int i = 0; i < n; i++){
    int sum = 0;
    for (int j = 0; j < m; j++){
        sum = array[i,j] + sum;
    }
    if (sum < min){
        mini = i;
        min = sum;
    }
}
Console.WriteLine($"номмер строки с минимальной суммой {mini}" );