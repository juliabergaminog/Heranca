namespace Heranca
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(string nome)
        {
            Nome = nome;

        }
        public virtual double CalcularBonusAnual()
        {
            return Salario * 0.1;

        }
    }
}