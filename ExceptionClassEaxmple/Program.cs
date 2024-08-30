using ExceptionClassEaxmple;

class Program
{ 
    static void Main(string[] args)
    {
		try
		{
			Find();
		}
		catch (RecordNotFoundException exception)
		{
			Console.WriteLine(exception.Message);
		}
		Console.ReadLine();
    }


private static void Find()
{
    List<string> students = new List<string> { "Elif","Derin","Serap"};
    if (!students.Contains("Ahmet"))
    { throw new RecordNotFoundException("Record Not Found!!"); }

}

}
