/* 2 - Crie um programa que leia valores digitados pelo usuário e armazene-os em uma  matriz. 
Organize a matriz em order crescente. */

public static class Atividade2
{
    public static void Executar()
    {
        int[,] valores = new int[5, 2];
        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.Write($"Digite um número: ");
                valores[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.Clear();

        for (int linha1 = 0; linha1 < 5; linha1++)
        {
            for (int coluna1 = 0; coluna1 < 2; coluna1++)
            {
                for (int linha2 = 0; linha2 < 5; linha2++)
                {
                    for (int coluna2 = 0; coluna2 < 2; coluna2++)
                    {
                        if (valores[linha1, coluna1] < valores[linha2, coluna2])
                        {
                            int variavel = valores[linha1, coluna1];
                            valores[linha1, coluna1] = valores[linha2, coluna2];
                            valores[linha2, coluna2] = variavel;
                        }
                    }
                }
            }
        }

        Console.WriteLine("Os números em forma crescente são: ");
        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {

                Console.Write(valores[linha, coluna]);
            }
        }

    }
}
