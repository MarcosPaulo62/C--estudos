//::::: DESAFIO 01 ::::::::://

// double A, B, C;
// A = double.Parse(Console.ReadLine());
// B = double.Parse(Console.ReadLine());
// C = double.Parse(Console.ReadLine());
// //TODO: Complete os espaços em branco com uma possível solução para o desafio
// double media = (A * 2 + B * 3 + C * 5) / 10;


// Console.WriteLine($"MEDIA = {media.ToString("F1")}");//1 casa decimal
// Console.ReadKey();



//::::: DESAFIO 02 ::::::::://

// double pi, raio, volume;
//     pi = 3.14159;
//  //TODO: Complete os espaços em branco com uma possível solução para o desafio     
//     raio = double.Parse(Console.ReadLine());
//     volume = pi * (4/3.0) * Math.Pow( raio , 3 );
    
//     Console.WriteLine($"VOLUME = {volume.ToString("F3")}");



//::::: DESAFIO 03 ::::::::://

// string[] v = Console.ReadLine().Split();
// Console.WriteLine(int.Parse(v[0]) * int.Parse(v[1]));



//::::: DESAFIO 03 ::::::::://

int n;
int maior = 0;
int posicao = 0;
for(int i = 1; i <= 100 ; i++)
{
    n = Convert.ToInt32(Console.ReadLine());
    if(n > maior)
    {
        maior = n;
        posicao = i;     
    } 
}
Console.WriteLine(maior);
Console.WriteLine(posicao);