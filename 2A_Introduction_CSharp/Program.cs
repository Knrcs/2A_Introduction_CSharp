
//Vars for Awawa function
int age = 21;
string name = "Mikey";
bool tired = true;
float grade = 2.1f;

//Vars for Calculator functions
int a = 8;
int b = 9;
int c = 7;

//age calc
int currentYear = 2023;
int birthYear = 2002;


Awawa(name);
AddCalculator(a, b);
MinusCalculator(a, b);
MultiplyCalculator(a, b);
DivideCalculator(a, b);
IsRich(50);
HighestNumOfTwo(a, b);
HighestNumOfThree(a, b, c);
HalfNumber(32);
Percentage(30f, 50f);
ScorePlayer(7,2);
AgeCalc(currentYear, birthYear);
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
void DivideCalculator(int a, int b)
{
    float sum;
    sum = a / b;
    
    Console.WriteLine("[Devide Calc Calc] - Epic calcus between a and b equals " + sum);
}

void IsRich(int money)
{
    Console.WriteLine("[Is Richer] - You have " + money + " balance");
    if (money >= 100)
    {
        Console.WriteLine("[Is Richer] - you're able to buy GTA 6 woooo");

    }
    else if (money < 0)
    {
        Console.WriteLine("[Is Richer] - Pay your bread back!");

    }
    else
    {
        Console.WriteLine("[Is Richer] - You are a geringverdiener!");
    }
}

void HighestNumOfTwo(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine("[Highest Num of Two] - Number A is larger than B | A: " + a + " B: " + b);
    }
    else if (a == b)
    {
        Console.WriteLine("[Highest Num of Two] - Number A and B are the same | A: " + a + " B: " + b);
    }
    else
    {
        Console.WriteLine("[Highest Num of Two] - Number B is larger than A | A: " + a + " B: " + b);
    }
}

void HighestNumOfThree(int a, int b, int c)
{
    if (a > b && a > c)
    {
        Console.WriteLine(
            "[Highest Num of Three] - Number A is larger than B and C | A: " + a + " B: " + b + " C: " + c);
    }
    else if (b > a && b > c)
    {
        Console.WriteLine(
            "[Highest Num of Three] - Number B is larger than A and C | A: " + a + " B: " + b + " C: " + c);
    }
    else if (c > b && c > a)
    {
        Console.WriteLine(
            "[Highest Num of Three] - Number C is larger than A and B | A: " + a + " B: " + b + " C: " + c);
    }
    else if (a == b && a == c)
    {
        Console.WriteLine("[Highest Num of Three] - Number A, B and C are the same | A: " + a + " B: " + b + " C: " +
                          c);
    }
}

void HalfNumber(float num)
{
        float sum = num / 2;
        Console.WriteLine("[HalfNum] - The half of " + num + " is " + sum + ".");
}

void Percentage(float percentage, float num)
{
        float realPercentage = percentage / 100;
        float sum = realPercentage * num;

        Console.WriteLine("[Percentage] - " + percentage + "% of " + num + " is " + sum);
}

void ScorePlayer(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine("[Score Player] - Spieler 1 hat gewonnen");
    }
    else
    {
        Console.WriteLine("[Score Player] - Spieler 2 hat gewonnen");
    }
}

void AgeCalc(int a, int b)
{
    int age = a - b;
    
    Console.WriteLine("[Age calc] - You are " + age + " years old");
    
    
}