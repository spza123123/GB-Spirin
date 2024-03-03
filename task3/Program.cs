void Main()
{
    int[] array = [1, 5, 76, 2, 9, 3];
    var str = string.Join(" ", array);
    System.Console.WriteLine(str);
    System.Console.WriteLine();
    int i = 0;
    asd(array, i);
}
Main();

void asd (int [] array,int i)
{
    System.Console.WriteLine(array[array.Length -1 - i]);
    i++;
    if( i >= array.Length)
    {
        return;
    }
    asd(array, i);
    
    

}