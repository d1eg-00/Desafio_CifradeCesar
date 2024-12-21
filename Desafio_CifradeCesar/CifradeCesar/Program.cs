namespace CifradeCesar
{
    class Program
    {
        static void Main(string[] args)
        {

            string txt1 = "", txt2 = "";
            int numCar = 0, num = 0, escolha;// contagem o numero de caracteres

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para Cripitografar: ");
                Console.WriteLine("Digite 2 para Descripitografar: ");
                escolha = Convert.ToInt32(Console.ReadLine());

                CripDescrip crip = new CripDescrip();

                switch(escolha)
                {
                    default:
                    Console.WriteLine("Operação Inválida.");
                    break;
                    case 1:
                        Console.WriteLine("Digite a mensagem para ser criptografada: ");
                        txt1 = Console.ReadLine();
                        txt2 = crip.cripTo(txt1); // Recebe a string criptografada
                        Console.WriteLine($"Mensagem criptografada: {txt2}");
                        break;
                    case 2:
                        Console.WriteLine("Digite a mensagem para ser descriptografada: ");
                        txt1 = Console.ReadLine();
                        txt2 = crip.deCripto(txt1); // Recebe a string criptografada
                        Console.WriteLine($"Mensagem descriptografada: {txt2}");
                        break;

                }

                Console.Write("Deseja Continuar na Aplicação? (S/N)");
                string opcao = Console.ReadLine();

                if (opcao.ToLower() != "s")
                {
                    Console.WriteLine("Aplicação sendo encerrada. ");
                    break;
                }
            }

                Console.ReadKey();
            
        }
    }
}
