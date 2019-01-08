public class StartUp
{
    static void Main()
    {
        var testArray = new ReversedList<int>();

        testArray.Add(1);
        testArray.Add(2);
        testArray.Add(3);
        testArray.Add(4);
        testArray.Add(5);


        testArray[1] = 10;
        System.Console.WriteLine(testArray[1]);
    }
}