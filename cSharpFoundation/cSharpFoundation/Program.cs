OperatorExamples();

void OperatorExamples()
{
    //declare width & set to 3
    int width = 3;

    //add 1
    width++;

    //declare more variables
    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);


    while (area < 50)
    {
        height++;
        area = width * height;
    }
    do
    {
        width--;
        area = width * height;
    } while (area > 25);

    //next statements declare string variables
    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result);

    //boolean value:
    bool truthVal = true;
    Console.WriteLine(truthVal);
}



TryAnIf();
TrySomeLoops();
TryAnIfElse();

void TryAnIf()
{
    int someValue = 4;
    string name = "Bobbo Jr.";
    if ((someValue == 3) && (name == "Joe"))
    {
        Console.WriteLine("x is 3 and the name is Joe");
    }
    Console.WriteLine("this line runs no matter what");
}

void TryAnIfElse()
{
    int x = 5;
    if (x == 10)
    {
        Console.WriteLine("x must be 10");
    }
    else
    {
        Console.WriteLine("x isn’t 10");
    }
}

void TrySomeLoops()
{
    int count = 0;

    while (count < 10)
    {
        count = count + 1;
    }

    for (int i = 0; i < 5; i++)
    {
        count = count - 1;
    }

    Console.WriteLine("The answer is " + count);
}