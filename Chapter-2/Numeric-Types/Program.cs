Console.WriteLine("What is the length of the rectangle?");
string inputLength = Console.ReadLine();
double length = double.Parse(inputLength);

Console.WriteLine("What is the width of the rectangle?");
string inputWidth = Console.ReadLine();
double width = double.Parse(inputWidth);

double area = length * width;
Console.WriteLine("The area of this rectangle is " + area);



