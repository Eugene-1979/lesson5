// See https://aka.ms/new-console-template for more information


using System.Text;


static int Max(params int [] mas) {
	int max=int.MinValue;
	foreach (var item in mas)
	{
		max = item > max ? item : max;
	}
    return max;
}
static int Min(params int[] mas)
{
    int min = int.MaxValue;
    foreach (var item in mas)
    {
        min = item < min ? item : min;
    }
    return min;
}
static bool TrySumIfOdd(int x1,int x2) {

    return (x1 + x2) % 2 != 0;

}

static string Repeat (string str ,int x) {
StringBuilder sb=new StringBuilder();

    for (int i = 0; i < x; i++)
    {
        sb.Append(str);
    }
    return sb.ToString();


}
Console.WriteLine(Repeat("qwe", 3));
Console.WriteLine(Max(-2,-100,2,100)  );
Console.WriteLine(Min(-2,-100,2,100)  );
