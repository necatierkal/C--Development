int a = 100;
int b = a;

a = 50;

Console.WriteLine("a={0}", a);
Console.WriteLine("b={0}", b);


int[] aArray = { 100, 200, 300 };
int[] bArray = aArray;

aArray[0] = 10_000_000;
bArray[1] = 2000;

Console.WriteLine("aArray={0}", string.Join(",", aArray));
Console.WriteLine("bArray={0}", string.Join(",", bArray));
