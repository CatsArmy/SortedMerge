static int[] SortedMerge(int[] arr1, int[] arr2)
{
    bool debug = false;
    int mLength = arr1.Length + arr2.Length;
    int[] mergedArr = new int[mLength];
    int arr1I = 0;
    int arr2I = 0;
    for (int i = 0; i < mLength; i++)
    {
        if (arr1I == arr1.Length)
        {
            mergedArr[i] = arr2[arr2I];
            arr2I++;
            if (debug)
            {
                Console.WriteLine("case1 arr1I == arr1.Length");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
        else if (arr2I == arr2.Length)
        {
            mergedArr[i] = arr1[arr1I];
            arr1I++;
            if (debug)
            {
                Console.WriteLine("case2 arr2I == arr2.Length");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
        else if (arr1[arr1I] > arr2[arr2I])
        {
            mergedArr[i] = arr2[arr2I];
            arr2I++;
            if (debug)
            {
                Console.WriteLine("case3 arr1[arr1I] > arr2[arr2I]");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
        else
        {
            mergedArr[i] = arr1[arr1I];
            arr1I++;
            if (debug)
            {
                Console.WriteLine("case4 arr1[arr1I] < arr2[arr2I]");
                Console.WriteLine($"mArr[{i}] = {mergedArr[i]} \n arr1I = {arr1I} arr2I = {arr2I}");
            }
        }
    }
    Console.Write("mergedArr = ");
    for (int i = 0; i < mergedArr.Length; i++)
    {
        Console.Write($"{mergedArr[i]}, ");
    }
    return BubbleSort(mergedArr);
}
//using BubbleSort
static int[] BubbleSort(int[] bubble)
{
    int TempSort;
    int tempIndx;
    for (int i = 0; i < bubble.Length - 1; i++)
    {
        for (int j = 0; j < bubble.Length - 1; j++)
        {//brute force go brrrrrrrrrrr
            tempIndx = j + 1;
            TempSort = bubble[j];
            if (bubble[tempIndx] < bubble[j])
            {
                bubble[j] = bubble[tempIndx];
                bubble[tempIndx] = TempSort;
            }
        }
    }
    return bubble;
}
int[] arr1 = new int[4];
arr1[0] = 3;
arr1[1] = 4;
arr1[2] = 9;
arr1[3] = 11;
int[] arr2 = new int[2];
arr2[0] = 2;
arr2[1] = 7;
SortedMerge(arr1, arr2);