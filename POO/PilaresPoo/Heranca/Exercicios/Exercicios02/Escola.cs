
namespace Exercicios02

  {
  
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }

  
    public class Aluno : Pessoa
    {
        public string Curso;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Aluno ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Curso: {Curso}");
        }
    }

    
    public class Professor : Pessoa
    {
        public string Disciplina;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== Professor ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Disciplina: {Disciplina}");
        }
    }
    }
