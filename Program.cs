namespace ZooSystem
{
    class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som");
        }
    }

    class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("O Cachorro está Latindo: Au au!");
        }
    }

    class Gato : Animal
    {

        public Gato(string nome, int idade) : base(nome, idade)
        {
        }
        
        public override void EmitirSom()
        {
            Console.WriteLine("O gato está miando: Miau!");
        }
        
    }

    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sistema animais");
        Console.WriteLine();

        
        Cachorro rex = new Cachorro("Rex", 3);
        Gato felix = new Gato("Felix", 2);

       
        Console.WriteLine($"Animal: {rex.Nome}");
        Console.WriteLine($"Idade: {rex.Idade} anos");
        rex.EmitirSom();

        Console.WriteLine(); 

        
        Console.WriteLine($"Animal: {felix.Nome}");
        Console.WriteLine($"Idade: {felix.Idade} anos");
        felix.EmitirSom();
    }
} 
}