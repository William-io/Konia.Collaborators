// See https://aka.ms/new-console-template for more information
using App.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace App
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=KoniaEmployeeDb;User ID=sa;Password=3%OfCoffee; TrustServerCertificate=True";

        static void Main(string[] args)
        {
            //Comentar o método que não for utilizar
            ReadCollaborators();
            // CreateCollaborators();
        }

        #region READ
        public static void ReadCollaborators()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var collaborators = connection.GetAll<Collaborator>();

                foreach (var collaborator in collaborators)
                {
                    System.Console.WriteLine($"Lista de Colaboradores: {collaborator.Name}");
                }
            }
        }
        #endregion

        #region CREATE
        public static void CreateCollaborators()
        {
            var collaborator = new List<Collaborator>
            {
                new Collaborator
                {
                    Name = "Williamtest"
                },
                new Collaborator
                {
                    Name = "Silvateste"
                },
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {

                connection.Insert(collaborator);
                System.Console.WriteLine("Cadastro Realizado!");
            }
        }
        #endregion
    }
}
