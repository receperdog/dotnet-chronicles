// See https://aka.ms/new-console-template for more information
class Program
{
 static void Main(string[] args)
 {
    MyClass instanceClass = new MyClass();
    instanceClass.Test(2);
    // You can not react the NestedClass with instanceClass.NestedClass because its not a member of MyClass.
    MyClass.NestedClass nestedClass = new MyClass.NestedClass();
    // Above is just kind a categorization.
 }
}

/// <summary>
/// This is the test class for exploring behavior of the nested class.
/// </summary>
class MyClass{

    /// <summary>
    /// Method doc
    /// </summary>
    /// <param name="t">Explanation of the param</param>
    public void Test(int t){
        System.Console.WriteLine(t);
    }
    public class NestedClass{ // WHY ITS PUBLIC? Because; As a default inner class access modifies is PRIVATE! 
        // This is the seperated class but only defined in MyClass NOT a member of Myclass
    }
}
