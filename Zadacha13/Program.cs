int GetNumber()
{
    Console.WriteLine("введите произвольное число");    
    
    try
    {
        int N = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine($"Ввели число {N}");
        return N;    
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Ввели не число!!!");
        throw;
    }       
}

int N =  GetNumber();
if(N >= 100 )
{
    char[] arr = (N.ToString()).ToArray();
   
    Console.WriteLine($"Третья цифра {arr[2]}");
 }
 else
 {
    Console.WriteLine("3-ей цифры нет");
 }
 
    

