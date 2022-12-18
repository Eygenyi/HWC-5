int[] Arrey(int[] ay)
{
    for (int i = 0; i < ay.Length; i++)
    {
        ay[i] = new Random().Next(1,10);
    }
    return ay;
}
void Ex(int[] ar)
{
    int j=0;
    if (ar.Length%2==0)
    {
        int [] arr2=new int [ar.Length/2];
    for (int i = 0; i < arr2.Length; i++)   
        {
            arr2[j]=(ar[i])*(ar[ar.Length-1-i]);
           Console.Write(" "+arr2[j]);
        }
    }
    else
    {
        int [] arr2=new int [ar.Length/2+1];
    for (int i = 0; i < arr2.Length; i++)   
        {
            if (i==arr2.Length-1)
            arr2[j]=ar[ar.Length-1-i];
            else
            arr2[j]=(ar[i])*(ar[ar.Length-1-i]);
           Console.Write(" "+arr2[j]);
        }
    }
}
void ShowArray(int[] arre)
{
    for (int i = 0; i < arre.Length; i++)
    {
        Console.Write(arre[i] + " ");
    }
}
Console.WriteLine("Input massive size: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int[] egog = Arrey(arr);
Console.Write("Your input arrey: ");
ShowArray(egog);
Console.WriteLine();
Console.Write("Your output arrey: ");
Ex(egog); 
