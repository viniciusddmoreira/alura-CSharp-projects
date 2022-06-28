namespace DesafioPropriedades
{
    public class Aluno
    { 
        private int matricula;
        public int Matricula 
        { 
            get
            {
                return matricula;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Valor da matrícula não pode ser menor que zero.");             
                }
                else
                {
                    matricula = value;
                }
            }
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
