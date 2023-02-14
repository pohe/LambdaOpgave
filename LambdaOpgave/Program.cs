// See https://aka.ms/new-console-template for more information


List<int> integers = new List<int>() { 1, 3, -10, 6, 83, 4, 17, 25, -43, 6, 9, 83, 100 };

//Find summen af alle tal over 9

//Lav en iterativ udgave
int sum =0;
foreach(int i in integers)
{
    if (i>9)
    {
        sum = sum + i;
    }
}

Console.WriteLine($"Iterativ sum af tal over 9 {sum}");

//Lav en udgave der anvender predicate/lambda udtryk
//bool noNine(int n)
//{
//    return n > 9;
//}
//List<int> overNine = integers.FindAll( n => n>9  );

int sumAllAboveNine = integers.FindAll(n => n > 9).Sum();

Console.WriteLine($"sumAllAboveNine : {sumAllAboveNine}");




//Find summen af alle ikke lige tal


//Lav en iterativ udgave

int sum1 = 0;
foreach(int i in integers)
{
    if (i%2!=0)
    
        sum1 += i;
    
}
Console.WriteLine($"Sum af alle ikke lige tal iterativt {sum1}");

//Lav en udgave der anvender predicate/lambda udtryk


int sumAllUnEqual = integers.FindAll(n=> n%2!=0).Sum();

Console.WriteLine($"sumAllUnEqual : {sumAllUnEqual}");


//Find gennemsnittet af alle tal der er større end 0 og mindre end 20

//Lav en iterativ udgave

double tal = 0;
int count = 0;
double gen = 0;
foreach (int item in integers)
{
    if (  item > 0 && item < 20)
    {
        tal += item; 
        count++;
    }
}
gen = tal / count;
Console.WriteLine("Gennemsnit af alle tal større end 0 og mindre end 20 " + gen);

//Lav en udgave der anvender predicate/lambda udtryk

double averageAllNumbersGreaterThan0AndLessThan20 =integers.FindAll(n=> n>0 && n <20).Average();

Console.WriteLine($"averageAllNumbersGreaterThan0AndLessThan20 : {averageAllNumbersGreaterThan0AndLessThan20}");

//Find det højest ikke lige tal

if ( integers.Count>0)
{
    int num = findFirstUnequalNUmber();
    if (num!= 0)
    {
        foreach (int i in integers)
        {
            if (i % 2 != 0 && i > num)
            {
                num = i;
            }
        }
        Console.WriteLine("Højeste ikke lige tal " + num);
    }
}

int findFirstUnequalNUmber()
{
    foreach (int item in integers)
    {
        if (item % 2 != 0)
            return item;

    }
    return 0;
}



//Lav en iterativ udgave
//Lav en udgave der anvender predicate/lambda udtryk
//integers.Sort();
//integers.Reverse();
//int maxUnEqualNumber = integers.Find(x=> x%2!=0);


int maxUnEqualNumber = integers.FindAll(x => x % 2 != 0).Max();
Console.WriteLine($"maxUnEqualNumber : {maxUnEqualNumber}");

//Udskriv alle ulige tal sorteret

List<int> listeSorteret = integers.FindAll( a=> a % 2 != 0);
listeSorteret.Sort();
foreach(int item in listeSorteret)
    Console.Write(item + " ");

