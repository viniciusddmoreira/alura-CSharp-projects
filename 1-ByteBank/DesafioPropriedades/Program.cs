using DesafioPropriedades;

/*O encapsulamento é uma prática recomendada. 
 * Definimos campos privados usando métodos públicos ou utilizando propriedades. 
 * Com base nisso, Pedro criou a seguinte classe:
 * class Aluno
 *   {
 *       public int Matricula { get; set; }
 *       public string Nome { get; set; }
 *       public string Email { get; set; }
 *       public bool Status { get; set; }
 *       public int TipoCurso { get; set; }
 *   }
 * Porém, a propriedade Matricula precisa validar a operação de Set, não permitindo a inserção de valores menores ou iguais a zero.
 *
 * Como Pedro poderia resolver o problema? E você, consegue solucionar esse desafio?.
 */

Aluno aluno1 = new();
aluno1.Matricula = -52323;

Console.WriteLine();

Aluno aluno2 = new();
aluno2.Matricula = 424231;
Console.WriteLine("Número de matrícula do segundo aluno: " + aluno2.Matricula);

Console.ReadKey();