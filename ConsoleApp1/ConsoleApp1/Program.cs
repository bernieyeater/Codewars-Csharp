// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    // Uncomment the following line to resolve.
    static void Main() {
		int a = 1;
		int b = 2;
		int c = 3;
		int outValue = 0;
		if ((a * b + c) > outValue) { outValue = a * b + c; }
		if ((a * b * c) > outValue) { outValue = a * b * c; }
		if ((a + b * c) > outValue) { outValue = a + b * c; }
		if ((a + b + c) > outValue) { outValue = a + b + c; }
		Console.WriteLine(outValue);
	}
}
/*
 * Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained (Read the notes for more detail about it)
*/