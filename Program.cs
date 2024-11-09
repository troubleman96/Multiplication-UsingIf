using System;

class Program{

    static void Main(string [] arg){

        Console.Write("Enter your first number: ");
        int firstNo = Convert.ToInt32(Console.ReadLine());
        

        Console.Write("Enter your second number: ");
        int secondNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int answer = firstNo * secondNo;

        Console.Write("The value of " + firstNo + " x " + secondNo + " is : ");
        int actualAnswer = Convert.ToInt32(Console.ReadLine());

        if(answer == actualAnswer){
            Console.WriteLine();
            Console.WriteLine("the answer " + answer +" is correct");
        }
        else{
            Console.WriteLine();
            Console.WriteLine("The answer is wrong, the correct answer is: " + answer);
        }

    }
}