//String para armazenar texto

//Atalho de comentario: Ctrl + K + C
string nome = "Laura Santos";

// Tipo de variavelpara alores inteiros: 1,2 e etc
int idade = 16;

//tipo de variavel para valores decimais: 1.5, 2.5 e etc
float altura = 1.65f; //não serve para coisas precisas
double preco = 17.5;
decimal saldo = 1000.50m;

// Tipo de variavel para valores lógicos: true or false
bool estudante = true;

// Tipo de variavel para valores únicos: 'A', 'B' e etc
char genero = 'F';

// Tipo de variavel para valores constantes: PI = 3.14
const double pi = 3.14;

//Forma 1
Console.WriteLine(nome);

//Forma 2 - Interpolação de string
Console.WriteLine($"A {nome} tem {idade} anos");

//Forma 3 -  Concatenação de string
Console.WriteLine("A " + nome + " tem " + idade + " anos. ");

//Utilizando \n  para pular uma linha
//Semelhante ao <br> do HTML 
Console.WriteLine($"\n O valor de pi é:{pi}");


