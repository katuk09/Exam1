
void CreateNewArray(string[] arrOld, int wordSize, int len)
{
    int j = 0;
    string[] arrNew = new string[len];
    for (int i = 0; i < arrOld.Length; i++)
    {
        if (arrOld[i].Length <= wordSize) arrNew[j] = arrOld[i];
        Console.Write(arrNew[j] + " ");
    }
}


Console.Write("Please input size of your string array: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input max length of a string element in our new array: ");
int wordLen = Convert.ToInt32(Console.ReadLine());

string[] arr = new string[sizeArr];
int count = 0;
for (int ind = 0; ind < sizeArr; ind++)
{
    Console.Write("Please input your string array #: " + (ind + 1) + " ");
    arr[ind] = Console.ReadLine();
    if (arr[ind].Length < wordLen) count++;
}

for (int ind = 0; ind < sizeArr; ind++)
    Console.Write(arr[ind] + " ");

Console.WriteLine();
Console.WriteLine($"New array of max {wordLen} symbols contains {count} string elements");

CreateNewArray(arr[], wordLen, count);