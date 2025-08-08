public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Aluno(int id, string nome, int idade)
    {
        Id = id;
        Nome = nome;
        Idade = idade;
    }
}