namespace DesenhoDiamante.ConsoleApp
{
    /**
     *  Padrões da parte superior do diamante:
     *  
     *  -A quantidade de espaços na primeira linha é o número - 1 / 2
     *  -A quantidade de espaços em branco é subtraído 1 a cada linha
     *  -A quantidade inicial de X será sempre 1
     *  -A quantidade de X é adicionado 2 a cada linha
     */

    /**
     *  Regra para a linha do meio do diamante:
     * 
     *  -Escrever "X" na quantidade do tamanho do diamante 
     */

    /**
     * Padrões da parte inferior do diamante
     * -A quantidade de espaços na primeira linha é 1
     * -A quantidade de espaços em branco é adicionado 1 a cada linha
     * -A quantidade de X é subtraído 2 a cada linha     
     */

    internal class Program
    {
        // Resolvedor de Problemas

        //Clean Code - Dê nome as suas variáveis que revelem sua intenção
        static void Main(string[] args)
        {
            #region input de dados
            Console.Write("Informe o tamanho do diamante: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            
            while (tamanhoDiamante % 2 == 0) //verifica se o número par
            {
                Console.WriteLine("O número é par, informe um número ímpar");

                tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            }
            #endregion

            #region desenhando a parte superior do diamente
            int quantidadeEspacosEmBranco = (tamanhoDiamante - 1) / 2; //2

            int quantidadeDeLinhas = (tamanhoDiamante - 1) / 2; //2

            int quantidadeDeX = 1;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeEspacosEmBranco; i++)
                    Console.Write(" ");

                for (int i = 0; i < quantidadeDeX; i++)
                    Console.Write("x");

                quantidadeEspacosEmBranco -= 1;
                quantidadeDeX += 2;

                Console.WriteLine();
            }
            #endregion

            #region desenhando a linha do meio do diamante

            for (int i = 0; i < tamanhoDiamante; i++)
                Console.Write("x");

            Console.WriteLine();

            #endregion

            #region desenhando a parte inferior do diamante

            quantidadeEspacosEmBranco = 1;
            quantidadeDeX = quantidadeDeX - 2;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeEspacosEmBranco; i++)
                    Console.Write(" ");

                for (int i = 0; i < quantidadeDeX; i++)
                    Console.Write("x");

                quantidadeEspacosEmBranco += 1;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
        }
    }
}