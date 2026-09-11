using System.Transactions;
using Tyuiu.LeksikovKA.Sprint0.Task6.V0.Lib;

    class Programs
{

    void Main(string[] args)
    {

        int[] numsArrey = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArrey));
        Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(numsArrey));
        Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArrey));

        Console.ReadKey();















    }


















}


















