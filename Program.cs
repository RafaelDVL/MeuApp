internal class Program
{
    private static void Main(string[] args)
    {

        Produto p1 = new Produto(1, "Pizza", 10.00);


        Console.WriteLine(p1.Id);
        Console.WriteLine(p1.Nome);
        Console.WriteLine(p1.Preco);
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Eae meu chapa!");

        var nome = "Rafael";

        double nota1 = 9;
        double nota2 = 3;
        double media = (nota1+nota2)/2;
        
        if(media >= 5){
            Console.WriteLine("O aluno " + nome + " foi aprovado!");
        } else {
            Console.WriteLine("O aluno " + nome + " foi reprovado!");
        }

        Console.WriteLine(media);

        switch(media){
            case 1 : Console.WriteLine("A nota é final foi pessima!Sujeito a reprova na materia!"); break;
            case 2 : Console.WriteLine("A nota é final foi pessima!Sujeito a reprova na materia!"); break;
            case 3 : Console.WriteLine("A nota é final foi ruim!Sujeito a reprova na materia!"); break;
            case 4 : Console.WriteLine("A nota é final foi ruim!Sujeito a reprova na materia!"); break;
            case 5 : Console.WriteLine("A nota é final foi aceitavel!"); break;
            case 6 : Console.WriteLine("A nota é final foi aceitavel!"); break;
            case 7 : Console.WriteLine("A nota é final foi boa!"); break;
            case 8 : Console.WriteLine("A nota é final foi muito boa!"); break;
            case 9 : Console.WriteLine("A nota é final foi excelente!Parabens pela nota exemplar"); break;
            case 10 : Console.WriteLine("A nota é final foi Extraordinaria!Conseguiu a nota honrosa!"); break;
            default : Console.WriteLine("Nota invalida!"); break;
        }

        for( var i = 0; i <= 10; i++){
            Console.WriteLine(i);
        }


        var cont = 0;
        while(cont <= 10 ){
            Console.WriteLine(cont);
            cont += 2;
        }


         int soma(int x, int y){
            return x + y;
        }

        Console.WriteLine(soma(6,4));
    }

    struct Produto{

        public Produto(int id, string nome, double preco){
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public int Id;
        public string Nome { get; set; }
        public double Preco;


        public double PrecoDolar(double dolar){
            return Preco * dolar;
        }
    }
}