int [] Arrey(int [] ay)
{
    
    
    for (int i = 0; i < ay.Length; i++)
    {
        ay[i] = new Random().Next(1,20);
    } 
    return ay;
}

void SumArr (int [] ar)
{
    int temp=0;
        for (int i = 1; i < ar.Length; i=i+2)
    {
        temp=temp+ar[i];

    } 
Console.WriteLine();
Console.WriteLine("Sum of elements 1,3,5...etc is: "+temp);
} 

void ShowArray (int [] arre)
{
for (int i = 0; i < arre.Length; i++)
    
    {
        Console.Write(arre[i]+" ");

    } 
}
Console.WriteLine("Input massive size: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr  = new int [n];
int [] egog =Arrey(arr);
ShowArray (egog);
SumArr(egog);

