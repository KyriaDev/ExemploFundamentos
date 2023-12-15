//CONVENÇÕES DO C#

//Variáveis seguem a convenção camelCase
// > 1° palavra começa com minúscula e a
// 2° palavra e adiante começam com maiúscula.

//Outra convenção para a escrita de variáveis, propiedades e classes,
//é nunca usar abreviações.

//Uma outra convenção sobre o nome de Classes propiedades e váriaveis,
//é de não por nenhum caractere especial, com excessão ao _.

//Classes, propiedades e métodos seguem a PascalCase >
// 1° palavra > começa com maiúscula,
// 2° palavra e adiante > começa com maiúscula também.
//Classes = Objetos e Métodos = Funções.

//Outra convenção para o nome de classes é de que
//o nome do arquivo que armazena a classe, deve ser igual ao da classe.


//CONVERSÃO DE VARIÁVEIS PARA TIPOS DIFERENTES
// Cast - Casting

//Não existe Parse para string.
//int inteiro = 5;
//string a = Convert.ToString(inteiro); ou de forma mais otimizada, usando a função ToString  da Classe Object do C#.
//Object é a mãe de todas as classes (objetos).
//string a = inteiro.ToString();
//Console.WriteLine(a);

//Qualquer tipo pode ser convertido para string,
//utilizando o ToString(), sem necessidade do Convert.

//int a = Convert.ToInt32("5");
//int a = int.Parse("5");
//No Convert você precisa selecionar manualmente o tipo de dado.
//O Parse serve para qualquer tipo.
//EXEMPLO DE ERRO
//DIFERENÇA ENTRE CONVERT E PARSE, TRATAMENTO DE VALORES NULOS.
//int a = Convert.ToInt32(null);
//int a = int.Parse(null);
//No Convert, o valor 0 é imprimido,
//enquanto que pelo Parse, o programa dá erro e é encerrado.
//Por isso  o recomendado é usar o Convert.

//Console.WriteLine(a);

//CAST IMPLÍCITO

//int a = 5;
//Como int é um subconjunto. de double, por isso, ao atribuir o valor de uma váriavel int para uma váriavel double o programa não dá erro. 
//double b = a;
//Isso também vale para int e long: (Por que o inteiro "cabe" no long.)
//int a = 5;
//long b = a;
//No oposto isso não acontece, pois long pode ter um valor que int não pode representar, e assis o uso do Convert se torna necessário.
// long a = 5;
// int b = Convert.ToInt32(a);
//No caso do valor de a ser realmente impossível no int, o código apresentará erro:
//long a = long.MaxValue;
//int b = Convert.ToInt32(a);
//Isso não acontece na situação oposta, pois a capacidade de long é maior que a de int. O valor é devidamente mostrado:
// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

//CONVERTENDO DE MANEIRA SEGURA

//string a = "-";
//Para evitar casos assim em que o progarama seria parado, e avisar ao desenvolvedor sobre o erro, já prevendo possíveis irregularidades, assim não encerrando o programa.
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

//

// //OPERADORES DE ATRIBUIÇÃO
//UM ATALHO PARA COMENTAR CÓDIGOS É SELECIONAR O TEXTO E APERTAR CTRL + K + C;
// int a = 10;
// int b = 20;

// int c = a + b;

// //c = c + 5; // 30 + 5/ 
// //o operador de atribuição composto += 
// //é mais eficiente com o mesmo resultado.
// //Isso serve para todas as operações simples.

// c += 5;
// // c = c + 5;

// c -= 5;
// // c = c - 5;

// c *= 5;
// // c = c * 5;

// c /= 5;
// // c = c / 5;

//Console.WriteLine(c);

//ORDEM DOS OPERADORES
//O C# obedeçe a mesma ordem da matemática, realizando as operações na seguinte ordem:
// () > ^ > / e * > + e -.
//double a = 4  / (2 + 2);
//Para priorizar uma operção que normalmente não seria priorizada, basta por ela entre ().

//Console.WriteLine(a);

//


//OPERADORES CONDICIONAIS (IF, ELSE, SWITCH, CASE)
//O operador condicional possibilita mudar o fluxo de execução de seu código,
//indicando um caminho que ele deve percorrer. (SÃO COMO DECISÕES)


// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

//IF = CONDIÇÃO CORRESPONDIDA/ ELSE É CASO A CONDIÇÃO NÃO SEJA CUMPRIDA.
// >= É um operador de comparação./ IF = SIM, ELSE = NÃO.
//A condição fica entre os ().
//Criando uma variável bool com uma condição, é possível não precisar repetir a condição e aplicala onde for necessário, deixando o código mais limpo.
// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

//DEBUGANDO O OPERADOR CONDICIONAL
//Crie um ponto de interrupção (ponto de parada, que interrompe o código na linha do ponto. O programa pode ser continuado pressionando a tecla f10 ou no ícone do painel que aparecerá que exibirá o nome f10 ao passar o mouse em cima. Ao fazer isso o debug avançará para a próxima linha de código, assim debugando linha por linha, facilitando o processo.), e depois aperte f5, e assim o debug será ativado.
//Nesse modo, ao passar o mouse em cima das variáveis, é mostrado o valor atual delas.
//No painel que se abre ao lado, é possível acompanhar o valor atual delas e qual é seu tipo.
//Com isso é possível ver o que está ocorrendo no seu código, linha por linha, passo a passo.
//O código é executado linha por linha, e o resultado é mostrado no console.
//O código é executado até onde for necessário, não necessáriamente até o fim.
//Pra encerrar o modo é só apertar f5, ou o 1°/último botão do painel da parte de cima.

//IF ANINHADO
//Um if com mais de uma condição, e mais de dois caminhos a percorrer.

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

//Para alinhar dois IF´s formando um só if com 3 ou + caminhos, basta fazer o mostrado abaixo:
// == é um sinal de comparação de igualdade. E && é um operador de junção de duas ou mais condições (sinal de e).
//O else é opcional.

// if (quantidadeCompra == 0)
// {
// Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

//SWITCH CASE
//Estrutura condicional, mais conciso para verificações com muitos caminhos/condições possíveis.

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
//ReadLine é uma função que permite que o terminal espere por algum comando que você digita e aperta Enter.

//COMO FICARIA USANDO O IF:
// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }
//Com o if else se torna tudo muito repetitivo e custoso com o tempo.//

//UTILIZANDO O IF COM CASE:

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
//     {
//        Console.WriteLine("É uma vogal.");
//     }
// else
// {
//     Console.WriteLine("Não é uma vogal.");
// }
//Com case, o código fica mais limpo e legível.
// O sinal ||, é o sinal de ou. Ele faz uma verificação, descobrindo se um deles é verdadeiro e assim realizando o comando.

//UTILIZANDO O SWITCH CASE:
//O switch olha para uma variável, e você põe as condições. 
//Nele um case é equivalente a um if, e um default é equivalente a um else.

// switch (letra)
// {
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("É uma vogal.");
//        break;     
//    case "b":
//        Console.WriteLine("");
//        break;
//    default:
//        Console.WriteLine("Não é uma vogal.");
//        break;
// }
//break > para a execução e permite que você crie um novo bloco de condições,
//que caso sejam verdadeiras executarão seu própio bloco de código.
//O SWITCH É UMA ALTERNATIVA AO IF ANINHADO E AO IF COM CASE.
//O switch é mais elegante :>
//Se você tiver muitos else if, substitue pelo switch.


//OPERADORES LÓGICOS
//Verificação de condições. (Geralmente aplicados nos operadores condicionais.)
//1° > operador OR (Pipe, || ): Quando você possui 2 ou mais condições, 
//que culminam a mesma ação, desde que pelo menos uma das condições seja cumprida.
//É verdadeiro quando uma das condições é verdadeira.
//OPERADOR OR NA PRÁTICA:
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada.");
// }
//2° > operador AND (&&): É verdadeiro quando todas as condições forem verdadeira.
//OPERADOR AND NA PRÁTICA:
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }
//3° operador NOT (!):Ele nega um valor booleano. (Inverte os valores, true vira false e false vira true.)
//Uma condição ou uma sequência de condições falsas, se  torna true, e vice-versa.
//OPERADOR NOT NA PRÁTICA
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia.");
// }
//Inverte a lógica.

//OPERADORES ARITMÉTICOS E A CLASSE MATH
//OPERADORES ARITMETICOS
// + > Adição, adiciona 2 valores. Ex: x + y;
// - > Subtração, subtrai um valor do outro. Ex: x - y;
// * > Multiplicação, multiplica 2 valores. Ex: x * y;
// / > Divisão, divide um valor por outro. Ex: x / y;
// % > Módulo, retorna o resto da divisão entre 2 valores. Ex: x % y;
// ++ > Incremento, aumenta o valor de uma variável em 1. Ex: x++;
// -- > Decremento, diminui o valor de uma variável em 1. Ex: x--;

//CRIANDO A NOSSA CLASSE CALCULADORA

using EXEMPLO_FUNDAMENTOS.Models;
Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
//calc.Somar(Convert.ToInt32(Console.ReadLine())); > DEU ERRO
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

//USANDO POTÊNCIA
//calc.Potencia(3, 3);

//FUNÇÕES TRIGONOMÉTRICAS/ SENO/ COSSENO E TANGENTE
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

//INCREMENTO E DECREMENTO
//Incremento
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine($"incrementando o {numeroIncremento}");
// //numero = numero + 1;
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

//Decremento
// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);

// Console.WriteLine($"Decrementando o {numeroDecremento}");
//numeroDecremento = numeroDecremento - 1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

//CALCULANDO RAIZ QUADRADA
//calc.RaizQuadrada(9);


//INTRODUÇÃO ESTRUTURAs DE REPETIÇÃO: FOR, WHILE, DO WHILE.
//MUITO IMPORTANTE > LAÇO DE REPETIÇÃO.
//INTRODUÇÃO AO FOR
//ESTRUTURA PARA REPETIR UM PEDAÇO DE CÓDIGO.
//TABUADA
//int numero = 5;

//O for do contador recebe tês valores > Declaração da Variável, Condição de parada, Incremento(ação).
//for(int contador = 0; contador <= 10; contador++)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}
//Só para quando a condição é falsa, ou requer a parada.
//É possível debugar o For > Faça um break point, e aperte f5 > Aperte f10 para avançar nas linhas de código.
//No caso das estruturas de repetição, o debug vai executando a repetição, passo a passo, até o fim.

//INTRODUÇÃO AO WHILE
//WHILE = ENQUANTO./Enquanto uma condição for verdadeira, ele executa o bloco de código, linha por linha, na ordem..
//É necessário tomar cuidado pra não criar um loop infinito, com a condição sempre sendo verdadeira.
//FAZENDO UMA TABUADA

// int numero = 5;
// int contador = 1;


// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}* Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }
//O IF RECEBE 3 BLOCOS DE CÓDIGO, O WHILE APENAS 1 CONDIÇÃO, O WHILE EXIGE MAIS CUIDADO.

//É possível parar o loop antecipadamente ao atingir uma determinada condição.
//EX: if (contador == 5)
//    {
//        break;
//    }
//O break também funciona com o FOR

//DEBUGANDO O WHILE
//Semelhante ao FOR, é feito cada execução passo a passo, até o fim do loop.

//INTRODUÇÃO AO DO WHILE
//É uma extensão do WHILE, porém a condição fica no final do código.
//O código é executado indenpendente da condição.


//É possível declarar várias variáveis de mesmo tipo, na mesma linha.
//int soma = 0, numero = 0;

//do 
//{
//   Console.WriteLine("Digite um número (0 para parar) ");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;

//} while(numero != 0);
//A execução continua enquanto o número digitado for diferente de 0.

//Console.WriteLine($"Total da soma dos números digitados é: {soma}");

//DEBUGANDO O DO WHILE
//Se o ReadLine não funciona no Debug.
//Ver vídeo no youtube sobre.


//CONSTRUINDO UM MENU INTERATIVO >  utilizando o WHILE


// string opcao;


// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
        
//         default:
//              Console.WriteLine("Opção inválida");
//              break;
//     }
// }
// Console.WriteLine("O programa se encerrou");

//REFATORANDO O MENU > ser possível sair do loop, sem encerrar o códigp.

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;
        
//         default:
//              Console.WriteLine("Opção inválida");
//              break;
//     }
// }
// Console.WriteLine("O programa se encerrou");

//

//ARRAY E LISTAS
//Introdução Array
//O Array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.
//O Array é basicamente uma variável, que pode armazenar vários valores.
//Com isso, quando lhe é atribuido um novo(s) valor(es), seu(s) valor(es) anterior(es) é(são) apagado(s).
//EX DE FORMAS DE DECLARAR:
    //  tipo/nome da var/declaração
//1.    int[] array = new int [4];
//2.    int[] array = new int[] {42, 75, 74, 61};
//3.    string[] nomes = {"Jan, "Fev };

//Como acessar os valores de uma array > ÍNDICE
//ÍNDICE: É a posição de um determinado valor de um array, sempre começando com zero.
//VALORES > 42/75/74/61
//POSIÇÃO >  0/ 1/ 2/ 3
//1. int elemento = array[0];
//Atribuindo um número
//2. array[0] = 42;
//Se você tentar por uma posição que não existe no seu array, o proggrama vai quebrar.

//IMPLEMENTANDO UM ARRAY DE INTEIROS

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[4] = 1; > vai dar excessáo no código.

Console.WriteLine("Percorrendo um Array com o FOR");
//Percorrendo um Array com o FOR
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
}
//Acessando um índice inválido > impossível.
//arrayInteiros[3] = 1;

Console.WriteLine("Percorrendo um Array com o FOREACH");
//Percorrendo um Array com o FOREACH
int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} = {valor}");
    contadorForeach++;
}
//FOREACH = para cada. Para cada elemento no Array de inteiros, o valur foi jogado para variável valor.
//Após isso, eles foram imprimdos no console (os valores).
//A desvantagem do FOREACH é a sintaxe demasiadamente simplicizada, exigindo que para melhor controle se use meios externos.
//O FOREACH funciona apenas para Listas e Arrays.

//Debugando um Array
//1° > criar um ponto de interrupção. 2° > Apertar f5. 3° > Apertar f10 para avançar nas linhas de código, e executá-las.
//4° > Basicamente, é semelhante a Debugar o for.

//É possível percorrer a sua Array tanto com o FOR quanto com o FOREACH, ambos são seguros

//Redimensionando um Array















//


//TIPOS DE DADOS

//DateTime dataAtual = DateTime.Now.AddDays(0);
//Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm"));

//string apresentacao = "Olá, seja bem vindo.";

//int quantidade = 1;
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//quantidade = 10;
//Console.WriteLine("Valor da variável quantidade: " + quantidade);

//double altura = 1.80;

//decimal preco = 1.80M;

//bool condicao = true;


//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variável preco: " + preco);
//Console.WriteLine("Valor da variável condicao: " + condicao);

//USANDO CLASSES, ATRIBUTOS E MÉTODOS

//using System.Diagnostics.Contracts;
//using EXEMPLO_FUNDAMENTOS.Models;

//Pessoa desenvolvedora = new Pessoa();

//desenvolvedora.Nome = "Kyria";
//desenvolvedora.Idade = 13;
//desenvolvedora.Apresentar();

//Pessoa pessoa_FisicaRepresentacao = new Pessoa();
