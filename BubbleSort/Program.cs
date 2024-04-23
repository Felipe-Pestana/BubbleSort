int size = 1000, aux = 0;
int[] vetorOriginal = new int[size];
int[] vetorOrdenado = new int[size];

for (int i = 0; i < size; i++)
{
    vetorOriginal[i] = new Random().Next(0,size);
    vetorOrdenado[i] = vetorOriginal[i];
}

Console.WriteLine("Vetor Original");
for (int i = 0;i < size; i++)
    Console.Write(vetorOriginal[i]+" ");

Console.ReadLine();

for (int referencia = 0; referencia < size; referencia++)
{
    for (int comparacao = referencia + 1; comparacao < size; comparacao++)
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
    }
}

Console.WriteLine("Vetor Ordenado");
for (int i = 0; i < size; i++)
    Console.Write(vetorOrdenado[i] + " ");

Console.ReadKey();