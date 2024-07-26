using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;


int[] numbers = [1, 2, 3, 4, 5];

numbers.Square();  // must return [1, 4, 9, 16, 25]
numbers.Cube();    // must return [1, 8, 27, 64, 125]
numbers.Average(); // must return 3
numbers.Sum();     // must return 15
numbers.Even();    // must return [2, 4]
numbers.Odd();     // must return [1, 3, 5]

static class Extensions
{
    public static int[] Square(this int[] numbers)
    {
        int[] square_numbers = new int[numbers.Length];

        for(int i=0; i<square_numbers.Length; i++)
            square_numbers[i] = numbers[i]*numbers[i];

        return square_numbers; 
    }

    public static int[] Cube(this int[] numbers)
    {
        int[] cube_numbers = new int[numbers.Length];

        for(int i=0; i<cube_numbers.Length; i++)
            cube_numbers[i] = numbers[i]*numbers[i]*numbers[i];

        return cube_numbers;
    }

    public static int Sum(this int[] numbers)
    {
        int sum_numbers = 0;

        for(int i=0; i<numbers.Length; i++)
            sum_numbers += numbers[i];

        return sum_numbers;
    }

    public static double Average(this int[] numbers)
    {
        double average_numbers = 0;

        for(int i=0; i<numbers.Length; i++)
            average_numbers += numbers[i];

        if(numbers.Length == 0)
            return double.NaN;

        return average_numbers/numbers.Length;
    }

    public static int[] Even(this int[] numbers)
    {
        List<int> even_numbers = new List<int>();

        for(int i=0; i<numbers.Length; i++)
            if(numbers[i]%2 == 0)
                even_numbers.Add(numbers[i]);

        return even_numbers.ToArray();
    }

    public static int[] Odd(this int[] numbers)
    {
        List<int> odd_numbers = new List<int>();

        for(int i=0; i<numbers.Length; i++)
            if(numbers[i]%2 == 1)
                odd_numbers.Add(numbers[i]);

        return odd_numbers.ToArray();
    }
}