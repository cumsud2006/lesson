//task1

//Console.Write("Ededi daxil edin: ");
//int n = Convert.ToInt32(Console.ReadLine());
//bool isPrime = false;
//for (int i =2 ; i<n; i++)
//{
//    if (n % i == 0) { isPrime = false; break; }
//    else isPrime = true;
//}
//if (!isPrime) Console.WriteLine("prime deyil");
//else Console.WriteLine("primedir");


//task3
//Console.Write("Birinci ededi daxil edin: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Emeliyyati daxil edin (+, -, *, /, %, ^): ");
//string op = Console.ReadLine();

//Console.Write("Ikinci ededi daxil edin: ");
//double b = Convert.ToDouble(Console.ReadLine());

//double result = 0;

//switch (op)
//{
//    case "+":
//        result = a + b;
//        break;

//    case "-":
//        result = a - b;
//        break;

//    case "*":
//        result = a * b;
//        break;

//    case "/":
//        if (b != 0)
//            result = a / b;
//        else
//        {
//            Console.WriteLine("0-a bolmek olmaz!");
//            return;
//        }
//        break;

//    case "%":
//        result = a % b;
//        break;

//    case "^":
//        result = Math.Pow(a, b);
//        break;

//    default:
//        Console.WriteLine("Yanlis emeliyyat daxil etdiniz.");
//        return;
//}

//Console.WriteLine("Netice: " + result);


//task2

//int[] numbers = { 23, 68, 12, 43, 56, 100, 23, 43, 21, 36, 72 };
//for (int i=0; i<numbers.Length; i++)
//{
//    if (numbers[i] % 6==0)
//    {
//        Console.WriteLine(numbers[i]);
//    }


//task4

//double[] prices = { 100.0, 1300.50, 259.99, 430.30, 160.99, 320.0 };
//for (int i=0; i<prices.Length; i++)
//{
//    Console.WriteLine(prices[i] * 0.2);
//}


//task5

//int[] age = { 23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57 };
//for (int i=0; i<age.Length; i++)
//{
//    if (age[i]>=65)
//    {
//        Console.WriteLine("teqaud dusur");
//    }
//    else
//    {
//        Console.WriteLine("teqaud dusmur");
//    }
//}



//task6

//Console.Write("a tərəfini daxil edin: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("b tərəfini daxil edin: ");
//double b = Convert.ToDouble(Console.ReadLine());

//Console.Write("c tərəfini daxil edin: ");
//double c = Convert.ToDouble(Console.ReadLine());

//if (a + b > c && a + c > b && b + c > a)
//{
//    if (a == b && b == c)
//        Console.WriteLine("Bu beraberterefli ucbucaqdir");
//    else if (a == b || a == c || b == c)
//        Console.WriteLine("Bu beraber yanli ucbucaqdir");
//    else
//        Console.WriteLine("Bu muxtelif terefli ucbucaqdir");
//}
//else
//{
//    Console.WriteLine("Bu tereflerle ucbucaq qurmaq olmaz");
//}



//task7

//Random random = new Random();
//int secretNumber = random.Next(1, 101); // 1-100 arası
//int attempts = 5;

//Console.WriteLine("1 ile 100 arasinda reqemi tapin!");

//for (int i = 1; i <= attempts; i++)
//{
//    Console.Write($"Cehd {i}/5 - Reqemi daxil edin: ");
//    int guess = Convert.ToInt32(Console.ReadLine());

//    if (guess == secretNumber)
//    {
//        Console.WriteLine("You won!");
//        return;
//    }
//    else if (guess < secretNumber)
//    {
//        Console.WriteLine("Boyuk reqem daxil edin.");
//    }
//    else
//    {
//        Console.WriteLine("Kicik reqem daxil edin.");
//    }
//}

//Console.WriteLine("You lose!");
//Console.WriteLine($"Dogru reqem: {secretNumber}");


//task8

//// Kvadrat
//Console.Write("Kvadratin terefini daxil edin: ");
//double teref = Convert.ToDouble(Console.ReadLine());
//double kvadratSahe = teref * teref;
//Console.WriteLine("Kvadratin sahesi: " + kvadratSahe);

//// Duzbucaqlı
//Console.Write("\nDuzbucaqlinin uzunlugunu daxil edin: ");
//double uzunluq = Convert.ToDouble(Console.ReadLine());

//Console.Write("Duzbucaqlinin enini daxil edin: ");
//double en = Convert.ToDouble(Console.ReadLine());

//double duzbucaqliSahe = uzunluq * en;
//Console.WriteLine("Duzbucaqlinin sahesi: " + duzbucaqliSahe);

//// Ucbucaq
//Console.Write("\nUcbucagin esasini daxil edin: ");
//double esas = Convert.ToDouble(Console.ReadLine());

//Console.Write("Ucbucagin hundurluyunu daxil edin: ");
//double hundurluk = Convert.ToDouble(Console.ReadLine());

//double ucbucaqSahe = (esas * hundurluk) / 2;
//Console.WriteLine("Ucbucagin sahesi: " + ucbucaqSahe);

//task9


//Console.Write("Ededi daxil edin: ");
//int num = int.Parse(Console.ReadLine());

//int original = num;
//int reversed = 0;

//while (num > 0)
//{
//    int digit = num % 10;
//    reversed = reversed * 10 + digit;
//    num = num / 10;
//}

//if (original == reversed)
//    Console.WriteLine("Eded polindromdur.");
//else
//    Console.WriteLine("Eded polindrom deyil.");