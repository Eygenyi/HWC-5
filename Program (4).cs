double[] Arrey(double[] ay)
{
    for (int i = 0; i < ay.Length; i++)
    {
        ay[i] = new Random().NextDouble()*10;
    }
    return ay;
}

double Max(double[] ar)
{
    double max = 0;
    for (int i = 0; i < ar.Length; i++)
    {

        if (max < ar[i])
            max = ar[i];
    }
    return Math.Round(max, 3);
}
double Min(double[] ar)
{
    double min=0;
    for ( int i = 0; i < ar.Length; i++)
    { 
        if (min == 0)
            min = ar[i];
            else
            if (min>ar[i])
            min = ar[i];
    }
    return Math.Round(min, 3);
}
void ShowArray(double[] arre)
{
    for (int i = 0; i < arre.Length; i++)
    {
        Console.Write(Math.Round(arre[i], 3) + " ");
    }
}
Console.WriteLine("Input massive size: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
double[] egog = Arrey(arr);
ShowArray(egog);
double max=Max(egog);
double min=Min(egog);
Console.WriteLine();
Console.Write("max: "+max+" - "+" min: "+min+" = "+Math.Round((max-min),3) );