//**USAR PascalCase em C#**//

//Para escrever apenas 2 casas decimais = String.Format("{0:.##}", v);

int Menu()
{
    string? i; //A interrogação indica que ou a string tem um valor, ou é vazia.
    int op;

    Console.WriteLine("=====Aplicação Computacional de Física=====");
    Console.WriteLine("[1] - Velocidade Média");
    Console.WriteLine("[2] - Aceleração");
    Console.WriteLine("[3] - Movimeno Uniforme");
    Console.WriteLine("[4] - Torricelli");
    Console.WriteLine("[0] - Sair");
    Console.WriteLine();
    Console.Write("Opção: ");

    i = Console.ReadLine();
    Int32.TryParse(i, out op); // out = joga nesse cara.
    //Int32 bibliotéca
    return op;
}

double VelocidadeMedia()
{
    string? i;
    double s, t;
    Console.Write("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    Console.Write("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);
    Console.WriteLine();

    return s / t;
}

double Aceleracao()
{
    string? i;
    double v, t;
    Console.Write("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.Write("Tempo: ");
    i = Console.ReadLine(); 
    Double.TryParse(i, out t);
    Console.WriteLine();
    return v / t;

}

double MovimentoUniforme()
{
    string? i;
    double s0, v, t;
    Console.Write("Espaço Inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s0);
    Console.Write("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.Write("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);
    Console.WriteLine();

    return s0 = v*t;
}

double Torricelli()
{
    string? i;
    double v, v0, a, s;
    Console.Write("Velocidade inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v0);
    Console.Write("Aceleração: ");
    i = Console.ReadLine();
    Double.TryParse(i, out a);
    Console.Write("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    Console.WriteLine();

    return (v = Math.Sqrt((Math.Pow(v0, 2) + (2*a*s))));
}
/*
double CominEgipsso()
{
    string? i;
    double a, b;

    Console.Write("Digite o valor primário: ");
    i = Console.ReadLine();
    Double.TryParse(i, out a);
    Console.Write("Digite o valor secundário: ");
    i = Console.ReadLine();
    Double.TryParse(i, out b);

    if(a*b < 70)
    {

    }
}*/


int escolha;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    escolha = Menu();
    if(escolha == 1)
    {
        double v = VelocidadeMedia();
        Console.WriteLine("Velocidade Média: " + String.Format("{0:.##}", v));
    }else if(escolha == 2)
    {
        double a = Aceleracao();
        Console.WriteLine("Aceleração: " + String.Format("{0:.##}", a));
    }else if(escolha == 3)
    {
        double s = MovimentoUniforme();
        Console.WriteLine("Movimento Uniforme: " + String.Format("{0:.##}", s));
    }else if(escolha == 4)
    {
        double v = Torricelli();
        Console.WriteLine("Velocidade Final: " + String.Format("{0:.##}", v));
    }/*else if(escolha == 5)
    {
        double e = CominEgipsso();
        Console.WriteLine("VALOR??: " + String.Format("{0:.##}", e));
    }
    */
}while(escolha != 0);








/*
bool paula = false;
if (paula == true) {
    Console.WriteLine("Paula luce est");
} else
{
    Console.WriteLine("Paula non luce est.");
}
*/