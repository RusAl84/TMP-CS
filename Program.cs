// See https://aka.ms/new-console-template for more information
using TMP_CS;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

Queue tmp = new Queue();
tmp.Push(10);
tmp.Push(20);
tmp.Push(30);
tmp.Push(40);

tmp.Print();

Console.WriteLine(tmp.Get(3));
Console.WriteLine("---------");

tmp.Print();

Console.WriteLine("----------------------");

tmp.Set(2, 5);
tmp.Print();


//Пузырьковая сортировка
for (int i = 0; i < tmp.Count(); ++i)
    for (int j = 0; j < tmp.Count() - 1; ++j)
        if (tmp.Get(j) > tmp.Get(j + 1))
        {
            int tempValue = tmp.Get(j);
            tmp.Set(j, tmp.Get(j + 1));
            tmp.Set(j + 1, tempValue);
        }

tmp.Print();