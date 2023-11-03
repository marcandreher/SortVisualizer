using System.Xml.Schema;

int[] array = GenerateRandomIntArray(120, 29);

SortVisualizer sv = new SortVisualizer(array);

BubbleSortWithUpdate(array);


void BubbleSortWithUpdate(int[] arr)
{
    int n = arr.Length;
    bool swapped;

    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;

        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;

                swapped = true;
            }
        }
        sv.UpdateVisualizer();
        Thread.Sleep(150);
        if (!swapped)
            break;
    }

    Console.ReadKey();
}


int[] GenerateRandomIntArray(int length, int maxValue)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(maxValue + 1);
    }

    return array;
}