//const int num = 10;

//string[] name = new string [num];


string[] name = new string[10];
int i = 0;
for (i = 0; i < 10; i++)
{
    Console.WriteLine("Enter the Name of Student {0}", i + 1);
    name[i] = Console.ReadLine();
}

foreach (string nm in name)
{
    Console.WriteLine("Name of Student {0}", nm);
}

//for (i = 0; i < name.Length; i++)
//{
//    Console.WriteLine("Name of Student {0} is {1}", i + 1, name[i]);
//}

//for (i = 0; i < num; i++)
//{
//    Console.WriteLine("Name of Student {0} is {1}", i + 1, name[i]);
//}




//int num1 = 5;

//int [] arr2 = new int[num1];
//arr2[0] = 1;
//arr2[1] = 2;
//arr2[2] = 3;
//arr2[3] = 4;
//arr2[4] = 5;

////Array.Clear(arr2);

//Console.WriteLine("arr2 - Length {0}", arr2.Length);
//Console.WriteLine("MaxLength {0}", Array.MaxLength);
//Console.WriteLine("arr2 - Rank {0}", arr2.Rank);


//foreach (int i in arr2)
//    Console.WriteLine(i);
//Console.WriteLine();

//int[] marks = new int[10];

//// Declare and set array element values.
//int[] marks1 = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8,10 };

//int[] marks2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(marks[i]);
//}
//Console.WriteLine();
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(marks1[i]);
//}
//Console.WriteLine();
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(marks2[i]);
//}


