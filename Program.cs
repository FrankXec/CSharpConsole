using System;
using CoreEscuela.Entitys;

namespace CoreEscuela
{
    class Program
    {
        public static void Main(string[] args)
        {
            var school = new Escuela("Frank Scool",2012);
            school.Pais = "Guatemala";
            school.Ciudad = "Solola";
            school.TiposEscuela = TiposEscuela.Secundaria;
            /*Console.WriteLine("Escuela: "+school.Name);
            Console.WriteLine("Año: "+school.YearCreation);*/
            Console.WriteLine(school);
            System.Console.WriteLine("===========================");
            var curse1 = new Curso();
            curse1.Name = "101";
            curse1.TipoJornada = TiposJornada.Matutina;
            var curse2 = new Curso();
            curse2.Name = "201";
            curse2.TipoJornada = TiposJornada.Matutina;
            var curse3 = new Curso();
            curse3.Name = "301";
            curse3.TipoJornada = TiposJornada.Matutina;
            Console.WriteLine($"Nombre: {curse1.Name}, ID: {curse1.UniqueID}");
            Console.WriteLine($"Nombre: {curse2.Name}, ID: {curse2.UniqueID}");
            Console.WriteLine($"Nombre: {curse3.Name}, ID: {curse3.UniqueID}");
        }
    }
}