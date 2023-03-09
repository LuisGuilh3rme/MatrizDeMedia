double[,] mat = new double[5, 3];

// Popular matriz:
for (int i = 0; i < mat.GetLength(0); i++)
{
	for (int j = 0; j < (mat.GetLength(1) - 1); j++)
	{
        Console.Write("Posição {0}:{1}:", i + 1, j + 1);
        double.TryParse(Console.ReadLine(), out mat[i, j]);
    }
    Console.WriteLine();
}

// Fazer média
for (int i = 0; i < mat.GetLength(0); i++)
{
	double media = 0;
	for (int j = 0; j < mat.GetLength(1); j++)
	{
		media += mat[i, j];
		if ((mat.GetLength(1) - 1) == j)
		{
			mat[i, j] = media / j;
		}
	}
}

// Imprimir matriz:
Console.WriteLine("Matriz final:");
for (int i = 0; i < mat.GetLength(0); i++)
{
    double media = 0;
    for (int j = 0; j < mat.GetLength(1); j++)
    {
		Console.Write("\t {0} \t", mat[i, j]);
    }
    Console.WriteLine();
}