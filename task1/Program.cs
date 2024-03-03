
void Task1(int M, int N)
{
   
   // int N = 8;
    if( M > N)
    {
        
        return;
    } 
    System.Console.WriteLine(M);
    Task1(M + 1, N + 0);

}
//Task1(5, 7);




System.Console.Write("Введите число  M: ");
int one = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите число N: ");
int two = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

    
Task1(one, two);
    


