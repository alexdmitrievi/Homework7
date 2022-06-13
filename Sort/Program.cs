// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] array = new int[5,5];
Random rnd = new Random();
for (int i = 0; i < 5; i++){
    for (int j = 0; j < 5; j++){
        array[i,j] = rnd.Next(0,100);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 5; i++){
    for (int j = 0; j < 4; j++){
        for (int k = j+1; k < 5; k++){
            if (array[i,j] < array[i,k]){
                int t = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = t;
            }

        }

    }
}
Console.WriteLine();

for (int i = 0; i < 5; i ++){
    for (int j = 0; j < 5; j ++){
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}