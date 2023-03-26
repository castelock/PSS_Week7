
using Binding;

Console.WriteLine("The options for this program are: {0} 1- Early binding. {0} " +
                "2- Late binding. {0} ", Environment.NewLine);
Console.WriteLine("Insert one of the previous options: ");
String option = Console.ReadLine();


switch (option)
{
    case "1":
        // creating object of Student class
        Student g = new Student();

        // Calling the method of Student class
        g.details("Ankita", "C#");

        // Calling "mymethod()" gives error
        // because this method does not 
        // belong to class Student or compiler 
        // does not know mymethod() at compile time
        // g.mymethod();
        break;
    case "2":
        // Dynamic objects
        dynamic obj = 4;
        dynamic obj1 = 5.678;

        // Display the type of objects
        Console.WriteLine("The type of the objects are :");

        // GetType() method is 
        // used to get the type
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj1.GetType());
        break;
    default:
        Console.WriteLine("The option is not valid.");
        break;
}
