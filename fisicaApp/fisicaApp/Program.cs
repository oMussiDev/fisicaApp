//Colocando int na função, ela vai esperar um resultado no final, a menos que coloquemos return 0; no final
//Lembrando que em C# podemos programar direto como em Python, portanto o direto vira o nosso main() em C
int Menu()
{
    //Ao colocarmos o ? definimos que aquela variável pode assumir o valor nulo, caso contrário, não consiguirá
    string? i;
    int op;
    //O Console é a biblioteca, e o que vem depois é a função
    Console.WriteLine("======= FisicaApp =======");
    //A função Console.WriteLine escreve algo e logo após escrevê-lo pula a linha
    Console.WriteLine("1- Velocidade Média");
    Console.WriteLine("2- Aceleração");
    Console.WriteLine("3- Movimento Uniforme");
    Console.WriteLine("4- Torricelli");
    Console.WriteLine("0- Sair");
    Console.WriteLine();
    //Usmaos o Console.Write para escrevermos sem pular linhas
    Console.Write("Opção: ");

    //O nosso scanf, no caso mais parecido com o input em C# é o Console.ReadLine(); na frente dele jogamos a variável que receberá o valor, normalmente i
    i = Console.ReadLine();
    //O out joga o valor da variável i para a variável op
    Int32.TryParse(i, out op);

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

    return v / t;
}

double MovimentoUniforme()
{
    string? i;
    double s0, v, t;
    Console.Write("Espaço inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s0);
    Console.Write("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.Write("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);

    return s0 + v * t;
}

double Torricelli()
{
    string? i;
    double v0, s0, s, a;
    Console.Write("Velocidade inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v0);
    Console.Write("Espaço incial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s0);
    Console.Write("Espaço final: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    Console.Write("Aceleração: ");
    i = Console.ReadLine();
    Double.TryParse(i, out a);

    //Para calcularmos a raiz quadrada utilizamos a função Sqrt, da biblioteca Math
    //Para calcularmos a potência de uma variável utilizamos a função Pow, onde colocamos "(variável, potência), da também biblioteca Math
    return Math.Sqrt(Math.Pow(v0, 2) + 2 * a * (s - s0));
}

int escolha;
do
{
    escolha = Menu();

    if (escolha == 1)
    {
        double v = VelocidadeMedia();
        //Console.WriteLine("Velocidade Média: " + v);
        Console.WriteLine("Velocidade Média: " + String.Format("{0:.##}", v));
    }

    else if (escolha == 2)
    {
        double a = Aceleracao();
        //Console.WriteLine("Aceleração: " + a);
        Console.WriteLine("Aceleração: " + String.Format("{0:.##}", a));
    }

    else if (escolha == 3)
    {
        double s = MovimentoUniforme();
        Console.WriteLine("Espaço Final: " + s);
    }

    else if (escolha == 4)
    {
        double v = Torricelli();
        //Console.WriteLine("Velocidade Final: " + v);
        Console.WriteLine("Velocidade Final: " + String.Format("{0:}"));
    }

} while (escolha != 0);