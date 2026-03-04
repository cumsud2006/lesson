//task1

//Console.Write("Birinci ədədi daxil edin: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("İkinci ədədi daxil edin: ");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine("Böyük ədəd: " + a);
//}
//else if (b > a)
//{
//    Console.WriteLine("Böyük ədəd: " + b);
//}
//else
//{
//    Console.WriteLine("Ədədlər bərabərdir.");
//}



//task2
//Console.Write("ededi daxil et: ");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 2 == 0)
//{
//    Console.WriteLine("qaliqsiz bolunur");
//}
//else
//{
//    Console.WriteLine("qaliqli bolunur");
//}



//task3

//Console.Write("ededi daxil et: ");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a>=100)
//{
//    Console.WriteLine("boyuk");
//}
//else
//{
//    Console.WriteLine("kicik");
//}




//task4


//Console.Write("yas daxil edin: ");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age>18)
//{
//    Console.WriteLine("Adult");
//}
//else
//{
//    Console.WriteLine("Child");
//}




//task5



//Console.Write("eded daxil edin");
//int eded = Convert.ToInt32(Console.ReadLine());
//if (eded>0)
//{
//    Console.WriteLine("musbet");
//}

//else if (eded == 0)
//{
//    Console.WriteLine("ne menfi. ne mwsbet");
//}

//else
//{
//    Console.WriteLine("menfidir");
//}



//task6

//Console.Write("eded daxil et: ");
//int number = Convert.ToInt32(Console.ReadLine());
//switch(number)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wensday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid day");
//        break;
//}




//task7

//Console.Write("ededi daxil edin: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Pow(a, 3));



//task8

//Console.Write("necenci ay oldugun qeyd et: ");
//int month = Convert.ToInt32(Console.ReadLine());
//switch(month)
//{
//    case 1:
//        Console.WriteLine("Yanvar " + 31);
//        break;
//    case 2:
//        Console.WriteLine("Fevral " + "28 or 29");
//        break;
//    case 3:
//        Console.WriteLine("Mart " + 31);
//        break;
//    case 4:
//        Console.WriteLine("Aprel " + 30);
//        break;
//    case 5:
//        Console.WriteLine("May " + 31);
//        break;
//    case 6:
//        Console.WriteLine("Iyun " + 30);
//        break;
//    case 7:
//        Console.WriteLine("Iyul " + 31);
//        break;
//    case 8:
//        Console.WriteLine("Avqust " + 31);
//        break;
//    case 9:
//        Console.WriteLine("Sentyabr " + 30);
//        break;
//    case 10:
//        Console.WriteLine("Oktyabr " + 31);
//        break;
//    case 11:
//        Console.WriteLine("Noyabr " + 30);
//        break;
//    case 12:
//        Console.WriteLine("Dekabr " + 31);
//        break;
//    default:
//        Console.WriteLine("Bele ay yoxdur");
//        break;
//}


//task9

//string[] fruits = { "alma", "banan", "portagal", "qarpiz","armud","kivi","naringi" };
//for (int i=0; i<fruits.Length; i++)
//{
//    Console.WriteLine(fruits[i]);
//}
//Console.Write ile yazsaq yanasi olaraq cap edecek


//task10,11


//string[] students = { "Cumsud", "Hemid", "Cavad", "Behram", "Yusif", "Huseyn", "Nergiz", "Melek", "Gunel", "Sevda" };
//for (int i = 0; i < students.Length; i++)
//{
//    Console.Write(students[i] + " ");
//}




//task12

//string[] students = { "Cumsud", "Hemid", "Cavad", "Behram", "Yusif", "Huseyn", "Nergiz", "Melek", "Gunel", "Sevda" };
//Console.WriteLine(students[4]);

//task13

//string[] travels = { "Ismayilli", "Gence", "Lerik", "Lenkeran", "Susa", "Agdam", "Bilesuvar", "Quba" };
//for( int i =0; i<travels.Length; i++)
//{
//    Console.WriteLine(travels[i]);
//}


//task14

//string[] numbers = { "20", "34", "21", "98", "45", "12", "34", "54", "30" };
//for(int i=0; i<numbers.Length;i++)
//{
//    if (i%3==0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//task15

//string[] numbers = { "20", "34", "21", "98", "45", "12", "34", "54", "30" };
//Array.Sort(numbers);
//Console.WriteLine(numbers[0] + " " + numbers[8] + " ");