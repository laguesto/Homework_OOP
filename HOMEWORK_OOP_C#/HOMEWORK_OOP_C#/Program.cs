using Class_char_matrix;
char[,] char_matrix =
{
    {'b','c','9'},
    {'3','2','z'},
    {'0','4','f'}
};

CLASS_CHAR_MATRIX matrix = new CLASS_CHAR_MATRIX(char_matrix);


Console.WriteLine("column 0: " + matrix[0]);
Console.WriteLine("column 1: " + matrix[1]);
Console.WriteLine("column 2: " + matrix[2]);

Console.WriteLine();

Console.WriteLine("The number of digits in the array " + matrix.Digit_Count);
