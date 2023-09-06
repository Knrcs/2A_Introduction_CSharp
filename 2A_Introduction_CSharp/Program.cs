
//Vars for Awawa function
int age = 21;
string name = "Mikey";
bool tired = true;
float grade = 2.1f;

//Vars for Calculator functions
int a = 7;
int b = 5;
float c = 9;
float d = 12;


Awawa(name);
AddCalculator(a, b);
MinusCalculator(a, b);
MultiplyCalculator(a, b);
DivideCalculator(c, d);
IsRich(50);


void Awawa(string textToSay)
{
    Console.WriteLine(textToSay);
}

void AddCalculator(int a, int b)
{
    int sum;
    sum = a + b;
    
    Console.WriteLine("[Add Calc] - Epic calcus between a and b equals " + sum);
}

void MinusCalculator(int a, int b)
{
    int sum;
    sum = a - b;
    
    Console.WriteLine("[Minus Calc] - Epic calcus between a and b equals " + sum);
}
void MultiplyCalculator(int a, int b)
{
    int sum;
    sum = a * b;
    
    Console.WriteLine("[Multiply Calc] - Epic calcus between a and b equals " + sum);
}
void DivideCalculator(float a, float b)
{
    float sum;
    sum = a / b;
    
    Console.WriteLine("[Devide Calc Calc] - Epic calcus between a and b equals " + sum);
}

void IsRich(int money)
{
    Console.WriteLine("You have " + money + " balance");
    if (money >= 100)
    {
        Console.WriteLine("you're able to buy GTA 6 woooo");

    }
    else if (money < 0)
    {
        Console.WriteLine("Pay your bread back!");

    }
    else
    {
        Console.WriteLine("You are a geringverdiener!");
    }
}