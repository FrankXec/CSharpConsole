namespace CoreEscuela.Entitys
{
    class Escuela
    {
        //atributos
        string name;
        public string Name
        {
            get{ return name; }
            set{ name = value.ToUpper(); }
        }
        public int YearCreation{ get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public TiposEscuela TiposEscuela{ get; set; }
        //constructor
        /*public Escuela(string name){
            this.name = name;
        }*/
        public Escuela(string name, int yearCreaction) => (Name,this.YearCreation) = (name,yearCreaction);
        //sobreescritura
        public override string ToString()
        {
            return $"Nombre: {Name}, Tipos Escuela: {TiposEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}