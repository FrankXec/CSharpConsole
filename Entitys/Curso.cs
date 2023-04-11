using System;

namespace CoreEscuela.Entitys
{
    class Curso
    {
        public string UniqueID { get; private set; }
        public string Name { get; set; }
        public TiposJornada TipoJornada { get; set; }
        public Curso() { UniqueID = Guid.NewGuid().ToString();}
    }
}