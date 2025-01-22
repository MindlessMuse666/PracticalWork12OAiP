namespace PracticalWork12OAiP;

public class PracticalWork12OAiP
{
    public static void Main(string[] args)
    {
        // Задание 1
        // var intList = CreateIntList([1, 2, 3, 4, 5]);
        
        // foreach (var item in intList)
        //     Console.WriteLine(item);


        // Задание 2
        // var stringList = CreateStringList(["apple", "banana", "cherry"]);
        // bool isHaveBanana = stringList.Contains("banana");

        // Console.WriteLine(isHaveBanana);


        // Задание 3
        // var intList1 = CreateIntList([10, 20, 30, 40, 50, 60]);
        // intList1.Remove(30);

        // foreach (var item in intList1)
        //     Console.WriteLine(item.ToString());


        // Задание 4
        // var stringList1 = CreateStringList(["red", "green", "blue"]);
        // stringList1[2] = "yellow";

        // foreach (var item in stringList1)
        //     Console.WriteLine(item);


        // Задание 5
        var stringList2 = CreateStringList(["apple", "banana", "apple", "cherry"]);
        string wordToFind = "apple";
        int counter = 0;

        foreach (var item in stringList2)
            if (item == wordToFind)
                counter++; 

        Console.WriteLine($"Слово {wordToFind} встречается {counter} раз.");
        
    }


    private static List<int> CreateIntList(int[] listNumbers)
    {
        var list = new List<int>();

        for (var i = 1; i < listNumbers.Length; i++)
            list.Add(listNumbers[i]);

        return list;
    }

    private static List<string> CreateStringList(string[] listStrings)
    {
        var list = new List<string>();

        for (var i = 0; i < listStrings.Length; i++)
            list.Add(listStrings[i]);

        return list;
    }
}