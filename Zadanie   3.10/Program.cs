
//int x;

//Console.WriteLine( "Введите целое число");

//x = int.Parse(Console.ReadLine());

//if (x % 2 == 0)

//{
//    Console.WriteLine("Число четное");

//}

//else

//{

//    Console.WriteLine("Число  не четное");

//}
//int x;

//int value = 0;

//string card;
//int i;

//Console.WriteLine( "Введите количество карт");

//x = int.Parse(Console.ReadLine());

//for (i = 1; i < x; i++)

//{

//    Console.WriteLine($"Введите {i} ую карту ");

//    card = Console.ReadLine();


//    switch (card)

//    {

//        case "2":

//            {
//                value += 2;
//                break;
//            }
//        case "3":

//            {
//                value += 3;
//                break;
//            }
//        case "4":

//            {
//                value += 4;
//                break;
//            }
//        case "5":

//            {
//                value += 5;
//                break;
//            }
//        case "6":

//            {
//                value += 6;
//                break;
//            }
//        case "7":

//            {
//                value += 7;
//                break;
//            }
//        case "8":

//            {
//                value += 8;
//                break;
//            }
//        case "9":

//            {
//                value += 9;
//                break;
//            }
//        case "10":

//            {
//                value += 10;
//                break;
//            }
//        case "Q":

//            {
//                value += 10;
//                break;
//            }
//        case "J":

//            {
//                value += 10;
//                break;
//            }
//        case "K":

//            {
//                value += 10;
//                break;
//            }
//        case "A":

//            {
//                value += 10;
//                break;
//            }
//    }
//}          
//Console.WriteLine($"Общая сумма карт - { value}");
int x;

int i = 2;

bool tru = false;
int delit;

Console.WriteLine("Введите целое число");

x = int.Parse(Console.ReadLine());

while (i < x)

{
    delit = x % i;
    if (delit == 0)

    {

        tru = true;
        i++;
    }

    else

    {

        tru = false;

        i++;

    }
}
    Console.WriteLine($"Значение - {tru}");
