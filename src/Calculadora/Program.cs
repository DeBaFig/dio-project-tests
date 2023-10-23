using Calculadora.Services;

Console.WriteLine("Digite o primeiro número inteiro para fazer os calculos:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número inteiro para fazer os calculos:");
int num2 = Convert.ToInt32(Console.ReadLine());

new Calculator().ShowResults(num1, num2);

Console.Read();


