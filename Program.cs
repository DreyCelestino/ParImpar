Console.Clear();

string input = "null";
double output;

Console.WriteLine("Escreva um número para saber se é par ou impar!");
input = Console.ReadLine()!;

while(!(int.TryParse(input, out int teste))){
    Console.WriteLine("Não é número! Tente novamente.");
    input = Console.ReadLine()!;
}

output = Convert.ToInt32(input)%2;

if(output == 0){
    Console.Write(input);
    Console.WriteLine(" é par!");
} 

else{
    Console.Write(input);
    Console.WriteLine(" é impar!");
}