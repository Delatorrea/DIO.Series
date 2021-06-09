using System;
using DIO.Series.Models;
using DIO.Series.Models.Enum;
using DIO.Series.Repository.Interfaces;

namespace DIO.Series.Controllers
{
    public class SeriesController
    {
        public readonly ISeriesRepository<Serie> _repository;

        public SeriesController (ISeriesRepository<Serie> repository){
            this._repository = repository;
        }

        public void GetAll(){
            Console.WriteLine("Listar Séries");
            Console.WriteLine("");
            
            var list = _repository.GetAll();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhuma Série cadastrada.");
            }

            foreach (var serie in list)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.GetId(), serie.GetTitle());
            }
        }

        public void Insert()
        {
            Console.WriteLine("Inserir nova Série");
            Console.WriteLine("");

            foreach (int i in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.Write("Digite o Gênero entre as opções acima: ");
            int gender = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string title = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string description = Console.ReadLine();           

            Serie serie = new Serie(id: _repository.NextId(),
                                    gender: (Gender)gender,
                                    title: title,
                                    year: year,
                                    description: description);

            _repository.Insert(serie);

        }

        public void Edit()
        {
            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.Write("Digite o Gênero entre as opções acima: ");
            int gender = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string title = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string description = Console.ReadLine();

            Serie serie = new Serie(id: idSerie,
                                    gender: (Gender)gender,
                                    title: title,
                                    year: year,
                                    description: description);

            _repository.Edit(idSerie, serie);
        }
        public void Delete()
        {
            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            _repository.Delete(idSerie);
        }

        public void GetById()
        {
            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            Serie serie = _repository.GetById(idSerie);

            Console.WriteLine(serie);
        }
    }
}