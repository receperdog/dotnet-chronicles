// See https://aka.ms/new-console-template for more information
using OopBasics;

#region PROP
    /* 
    - If you are not manipulation field in get or set method PROP is the finest way to get and set
    field.
    - It provides ENCAPSULATION. PROP generates the field in COMPILE TIME!
    - In the PROP property field can be read only but CAN NOT BE WRITE ONLY!
    */
    // Following is the example of PROP PROPERTY
    Car car = new Car();
    car.color = "BLACK";
    car.brand = "BIRD";
    System.Console.WriteLine(car.color);
    System.Console.WriteLine(car.brand);
#endregion



#region FULL-PROPERTY
    /*
    - Full Propery can be useful if you want to manipulate model fields.
    - As a convention if field name is name PROPERTY NAME should be Name
    - value is a feature from C#
    */
    Person person = new Person();
    person.Name = "John";
    System.Console.WriteLine(person.Name);
#endregion

