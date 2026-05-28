/* 1 - Crie um programa que leia valores digitados pelo usuário e armazene-os em uma matriz. 
O programa deve aceitar somente números de 0 ao 9. Caso o usuário digite um valor fora desse intervalo,
 solicite uma nova entrada até que o valor seja válido. */
public static class Atividade1
{
    public static void Executar()
    {
        int[,] numeros = new int[3, 3];
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"Digite o número: ");
                int resposta = int.Parse(Console.ReadLine()!);
                if (resposta > 0 && resposta < 10)
                {
                    numeros[linha, coluna] = resposta;
                }
                else
                {
                    coluna--;
                }

            }
        }

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {numeros[linha, coluna]}");
            }
        }
    }
}