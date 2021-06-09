using System;
using DIO.Series.Controllers;

namespace DIO.Series.Views
{
    public class Display
    {
        public readonly SeriesController _controller;

        public Display(SeriesController controller)
        {
            this._controller = controller;
        }
        public void Call()
        {
            ConsoleKeyInfo option = Options();
            while (option.Key != ConsoleKey.Escape){
                switch (option.KeyChar.ToString().ToLower()){
                    case "1":
                        _controller.GetAll();
                        break;
                    case "2":
                        _controller.Insert();
                        break;
                    case "3":
                        _controller.Edit();
                        break;
                    case "4":
                        _controller.Delete();
                        break;
                    case "5":
                        _controller.GetById();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                option = Options();
            }

            Console.WriteLine("Obrigado por ter usado nossos serviços!");
        }

        private static ConsoleKeyInfo Options()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao seu controle de Séries!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar Série");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("ESC- Sair");
            Console.WriteLine();

            ConsoleKeyInfo cki = Console.ReadKey(false);
            Console.WriteLine();

            return cki; ;
        }
    }
}