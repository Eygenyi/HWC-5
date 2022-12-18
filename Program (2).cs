int [] Arrey(int [] ay)
{
    
    
    for (int i = 0; i < ay.Length; i++)
    {
        ay[i] = new Random().Next(1,200);
    } 
    return ay;
}

void ShowArray (int [] arre)
{
int temp=0;
for (int i = 0; i < arre.Length; i++)
    {
    Console.Write(arre[i]+"*");
    if (arre[i]>=10 && arre[i]<=99)
    
    temp=temp+1;
    
    }
Console.WriteLine();
Console.WriteLine("Amount of 10-99 elements is: " +temp);
}
int [] arr  = new int [123];
ShowArray (Arrey(arr));
