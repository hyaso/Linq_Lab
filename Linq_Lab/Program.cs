using System.Linq;

public static class LinqLab
{
    public static void Main()
    {
        int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523683 };

        //Find Minimum value
        int minValue = nums.Min();
        Console.WriteLine(minValue);
        Console.WriteLine("------");

        //Find Maximum value
        int maxValue = nums.Max();
        Console.WriteLine(maxValue);
        Console.WriteLine("------");

        //Find maximum value less than 10 k
        var lessThan10K = nums.Where((x) => x < 10000).ToArray();
        var max10K = lessThan10K.Max();
        Console.WriteLine(max10K);
        Console.WriteLine("------");

        //Find all values between 10 and 100
        var btw10and100 = nums.Where((x) => (x < 10000) && (x > 10)).ToArray();
        //Order in ascending order
        var sortedBtw10and100 = btw10and100.OrderBy((x) => x);
        foreach (var num in sortedBtw10and100)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("------");

        //Find all the Values between 100000 and 999999 inclusive
        var Hundk = nums.Where((x) => (x >= 100000) && (x <= 999999)).ToArray();
        var sortedHundK = Hundk.OrderBy((x) => x);
        foreach (var num in sortedHundK)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("------");

        //Count all the even numbers
        var evenNO = nums.Where((x) => (x % 2 == 0)).ToArray();
        var sortEvenNo = evenNO.OrderBy((x) => x);
        foreach (var num in sortEvenNo)
        {
            Console.WriteLine(num);
        }
    }
}


