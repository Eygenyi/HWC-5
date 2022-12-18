int [] Arrey(int [] ay)
{
    
    
    for (int i = 0; i < ay.Length; i++)
    {
        ay[i] = new Random().Next(100,1000);
    } 
    return ay;
}

void ShowArray (int [] arre)
{
int temp=0;
for (int i = 0; i < arre.Length; i++)
    {
        
       Console.Write(arre[i]+" ");
    if (arre[i]%2==0)
    temp=temp+1;
    } 
Console.WriteLine("Amount of even elements is: " +temp);
}
Console.WriteLine("Input massive size: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr  = new int [n];
ShowArray (Arrey(arr));

