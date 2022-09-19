string Choice()
{
    string answ = "";
    Console.Write("Would you like to input your own array of strings (press y). If not, my array will be used. ");
    answ = Console.ReadLine();
    return answ;
}

string[] FillArray()
{
    Console.Write("Please input size of your string array: ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    string[] arrTemp = new string[sizeArr];
    for (int ind = 0; ind < sizeArr; ind++)
    {
        Console.Write("Please input your string array #: " + (ind + 1) + " ");
        arrTemp[ind] = Console.ReadLine();
    }
    return arrTemp;
}

string[] FillArray2()
{
    Console.WriteLine("You chose my array of strings: ");
    string[] arr2 = { "Sepulka", "is", "a", "prominent", "element", "of", "the", "civilization", "of", "Ardrites", "from", "the", "planet", "of", "Enteropia" };
    return arr2;
}

void CreateNewArray(string[] arrOld)
{
    Console.Write("Please input max length of a string element in our new array: ");
    int wordLen = Convert.ToInt32(Console.ReadLine());

    int count = 0;
    string[] arrNew;
    for (int i = 0; i < arrOld.Length; i++)
        if (arrOld[i].Length <= wordLen) count++;
    Console.WriteLine();
    Console.WriteLine($"New array contains {count} string elements (with {wordLen} and less symbols length):");

    int j = 0;
    arrNew = new string[count];
    for (int i = 0; i < arrOld.Length; i++)
    {
        if (arrOld[i].Length <= wordLen)
        {
            arrNew[j] = arrOld[i];
            if (arrNew[j] == "") Console.Write("NULL, ");
            else Console.Write(arrNew[j] + " ");
            j++;
        }
    }
}

string answer = Choice();
string[] arr;

if (answer == "y") arr = FillArray();
else arr = FillArray2();

for (int ind = 0; ind < arr.Length; ind++)
    Console.Write(arr[ind] + " ");

Console.WriteLine();
Console.WriteLine();
CreateNewArray(arr);