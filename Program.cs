// string curso = "Curso estudado";
// Console.WriteLine(curso);

// string nome = "Micael";
// string sobrenome = "Businari";
// Console.WriteLine(nome);
// Console.WriteLine(sobrenome);

// int notaMedia = 4;

// if(notaMedia >= 5)
// {
//     Console.WriteLine("Nota suficiente para aprovação.");
// } else
// {
//     Console.WriteLine("Nota insuficiente para aprovação");
// }

// void ListaDeLinguagensDeProgamacao()
// {
//     string cs = "C#";
//     string java = "java";
//     string js = "JavaScript";
//     Console.WriteLine("Digite 1 para C#");
//     Console.WriteLine("Digite 2 para Java");
//     Console.WriteLine("Digite 3 para JavaScript");

//     Console.Write("\nDigite um numero de 1 a 3: ");
//     string numeroEscolhido = Console.ReadLine()!;
//     int numeroEscolhidoNumerico = int.Parse(numeroEscolhido);

//     switch(numeroEscolhidoNumerico)
//     {
//         case 1: Console.WriteLine("Voce escolheu "+ cs);
//             break;
//         case 2: Console.WriteLine("Voce escolheu "+ java);
//             break;
//         case 3: Console.WriteLine("Voce escolheu "+ js);
//             break;
//         default: Console.WriteLine("Opção invalida");
//             break;
//     }
// }

// ListaDeLinguagensDeProgamacao();

// List <string> liguagens = new List<string> {"Java", "C#", "JavaScript"};
// Console.WriteLine(liguagens[2]);


void mensagemDeBoasVindas()
{
string bemVindo = "Bem vindo ao jogo do numero secreto";
Console.WriteLine(bemVindo);
}

int opcaoEscolhida()
{
    Console.WriteLine("Digite 1 para jogar");
    Console.WriteLine("Digite 2 para sair");
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch(opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Vamos começar");
            return 1;
        case 2: Console.WriteLine("Ok, até mais");
            return 2;
        default: Console.WriteLine("Opção invalida");
            return 0;
    }
}

void jogoDoNumeroSecreto()
{
    int numeroSecreto = 5;
    Console.WriteLine("Digite um numero de 1 a 10");
    string chute = Console.ReadLine();
    int verificarChute = int.Parse(chute);
    while(numeroSecreto != verificarChute)
    {
        if (verificarChute == numeroSecreto)
        {
        Console.WriteLine("Parabens, voce acertou o numero secreto!");
        } else
        if (verificarChute > numeroSecreto)
        {
            Console.WriteLine("O numero secreto é menor");
        } else
        {
            Console.WriteLine("O numero secreto é maior");
        }
        verificarChute = int.Parse( Console.ReadLine());
    }

}

mensagemDeBoasVindas();
int opcao = opcaoEscolhida();
if(opcao == 1){
  jogoDoNumeroSecreto();
}