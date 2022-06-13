// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine("Введите количество строк и столбцов");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n,m];
Random rnd = new Random();
for (int i = 0; i < n; i++){
    for (int j = 0; j < m; j++){
        array[i,j] = rnd.Next(0,100);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

if (n != m){
    Console.WriteLine("Выполнение программы не возможно");
}
else {
    int[,] t = new int[n,m];
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            t[i,j] = array[j,i];
        }
    }

    Console.WriteLine();
    for (int i = 0; i < n; i ++){
        for (int j = 0; j < m; j ++){
            Console.Write($"{t[i,j]} ");
        }
    Console.WriteLine();
    }
}

