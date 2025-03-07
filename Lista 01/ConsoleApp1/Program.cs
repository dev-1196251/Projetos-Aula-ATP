
Console.WriteLine("Qual exercício você quer executar ?");
Console.WriteLine("Digite o número correspondente ao exercício da lista :");
double entradaSwitch = double.Parse(Console.ReadLine());

Console.Clear();
switch (entradaSwitch)
{
    case 1:

        //01. Leia uma velocidade em km/h (quilômetros por hora) e apresente convertida em m/s (metros
        //por segundo). A fórmula de conversão é M = K / 3.6, sendo K a velocidade em km / h e M em m/ s.                                    

        Console.WriteLine("Digite a velocidade em Km/h para conversão:");
        double velocidade = double.Parse(Console.ReadLine());

        velocidade = velocidade * 3.6;

        Console.WriteLine("Valor em M/s :" + velocidade + "m/s");

        break;

    case 2:

        //02.Escreva um programa que leia o lado de um quadrado e imprima o seu perímetro, área e
        //diagonal.

        Console.WriteLine("Insira o tamanho do lado do quadrado:");
        double lado = double.Parse(Console.ReadLine());

        double perimetro = 4 * lado;
        double area = Math.Pow(lado, 2);
        double diagonal = lado * Math.Sqrt(2);

        Console.WriteLine("O lado do quadrado é : " + lado);
        Console.WriteLine("Seu perímetro é : " + perimetro);
        Console.WriteLine("Sua área é : " + area);
        Console.WriteLine("O valor da diagonal é : " + diagonal.ToString("N3"));

        break;
    case 3:

        //03.Escreva um programa que leia a base e a altura de um retângulo e imprima o seu perímetro, área e diagonal.

        Console.WriteLine("Digite o valor da base e da altura do triângulo respectivamente :");
        double baseTriangulo = double.Parse(Console.ReadLine());
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double perimetroTriangulo = 2 * (baseTriangulo + alturaTriangulo);
        double areaTriangulo = baseTriangulo * alturaTriangulo;
        double diagonalTriangulo = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        Console.Clear();
        Console.WriteLine("O valor da base e altura do triangulo são respectivamente " + baseTriangulo + " e " + alturaTriangulo +
            "\nSeu  perímetro é : " + perimetroTriangulo +
            "\nSua área é " + areaTriangulo +
            "\nSua diagonal é " + diagonalTriangulo.ToString("N3"));


        break;
    case 4:

        //04.Escreva um programa que leia uma temperatura em graus Fahrenheit, calcule e mostre-a convertida em graus Celsius.

        Console.WriteLine("Digite o valor da temperatura em Fahrenheit :");
        double tempFahrenheit = double.Parse(Console.ReadLine());

        double tempCelsius = (5 * (tempFahrenheit - 32)) / 9;

        Console.WriteLine("A temperatura em Fahrengeit é " + tempFahrenheit + "°" +
            "\ne sua conversão para Celsius fica em " + tempCelsius.ToString("N0") + "°");
        break;
    case 5:

        //05.Escreva um programa que leia a quantidade de eleitores de um município, o número de votos brancos, nulos e válidos.
        //Calcule e imprima o percentual de votos brancos, nulos e válidos

        string[] calculoVotos = new string[6]; // array que vai receber os votos do município

        Console.WriteLine("Escreva o nome do seu município :");
        calculoVotos[0] = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de eleitores no município :");
        calculoVotos[1] = Console.ReadLine();
        Console.WriteLine("Digite o número de votos brancos :");
        calculoVotos[2] = Console.ReadLine();
        Console.WriteLine("Digite o número de votos nulos :");
        calculoVotos[3] = Console.ReadLine();
        Console.WriteLine("Digite o número de votos válidos :");
        calculoVotos[4] = Console.ReadLine();

        /*Vou usar arrays em string e suas posições que forem numeros vou fazer o calculo dos voto 
        * e da porcentagem de seus respectivos valores com base a quantidade de votos*/

        string[] porcentagemVotos = new string[2]; // array que vai receber os valores de porcentagem dos votos

        /*Nessa linha eu vou convertendo cada voto do array calculoVotos 
        * vão ser somados e o valor total vai para array [1] do porcentagemVotos*/
        calculoVotos[5] = (double.Parse(calculoVotos[2]) + double.Parse(calculoVotos[3]) + double.Parse(calculoVotos[4])).ToString(); // array [6] está recebendo o valor total de votos
        calculoVotos[6] = (double.Parse(calculoVotos[1]) - double.Parse(calculoVotos[5])).ToString(); // array [7] recebe o valor de eleitores que não votaram

        /*Nessa linha eu vou converter os valores dos reséctivos locais do array e fazer o calculo votos / numeroVotos total x 100 para saber a porentagem e vou alocar no array de porcentagens */
        double valor = double.Parse(calculoVotos[2]) / double.Parse(calculoVotos[5]) * 100; // array [1] vai receber a porcentagem de votos brancos 
        porcentagemVotos[1] = (((double.Parse(calculoVotos[3])) / (double.Parse(calculoVotos[5]))) * 100).ToString(); // array [2] vai receber a porcentagem de votos nulos 
        porcentagemVotos[2] = (((double.Parse(calculoVotos[4])) / (double.Parse(calculoVotos[5]))) * 100).ToString(); // array [3] vai receber a porcentagem de votos válidos 

        Console.WriteLine("O Município " + calculoVotos[0] + " teve cerca de " + calculoVotos[1] + " votos");
        Console.WriteLine("A porcentagem de votos branco, nulos e válidos são respectivamente :" +
        porcentagemVotos[0] + "%" + porcentagemVotos[1] + "%" + porcentagemVotos[3] + "%");
        break;
    case 6:

        break;
    case 7:

        break;
    case 8:

        break;
    case 9:

        break;
    case 10:

        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}



