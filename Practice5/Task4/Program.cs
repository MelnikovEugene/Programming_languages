int [,] Create2dArray(int min, int max, int rows, int cols){
    int [,] array = new int [rows,cols];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0;i<array.GetLength(0);i++){
        for(int j =0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}