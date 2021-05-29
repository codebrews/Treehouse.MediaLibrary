#Media Library

-This is a C# practice project built from a series of coding challenges following a C# objects course taught by Treehouse and Code Louisville.

-Following are the series of challenges and tasks completed.

-I also tinkered just a bit with the FindItem method and then wrote out some silly stuff to the console that shows how the program works. 



##Practice Creating Classes in C#

###1st Challenge
--------------------------------------------------

1. Add at least two classes to your program—one class for each type of item—or media type—that can be added to your media library.
  a) Define each class using the `class` keyword within its own C# code file. 
  b) Use "Treehouse.MediaLibrary" for the namespace.

2. Add at least two public fields to each media type class that you added in step #1.
  a) Each field definition should include an access modifier, a data type, and a name.

Media Type Examples

* Album media type, with `Title` and `Artist` fields
* Book media type, with `Title` and `Author` fields
* Movie media type, with `Title` and `Director` fields

###2nd Challenge
--------------------------------------------------

1. In the Program.cs file `Main()` method, use the `new` keyword to create at least one instance of each of your media type classes.

2. For each of the objects that you create, set each field to an appropriate value.

###3rd Challenge
--------------------------------------------------

1. Add a constructor to each of your media type classes.

2. Define a constructor parameter for each of the media type's required fields and use those parameter values to initialize its fields.

3. Update the Program.cs file `Main()` method in order for your program to successfully compile.






##Practice Inheritance in C#
--------------------------------------------------

###1st Challenge
--------------------------------------------------

1. Add a MediaType base class to your program.
  a) Add a public field named `Title` of type `string`.
  b) Add a constructor to the MediaType class.
    * Define a parameter named `title` of type `string`.
    * Initialize the `Title` field using the `title` parameter.

2. Update your existing media type classes to inherit from the MediaType base class.
  a) Call the base class' constructor from each of the media type subclasses.

3. Review your media type subclasses and remove any `Title` field definitions from those classes.
  a) Remove any constructor initialization code related to the removed `Title` fields.

###2nd Challenge
--------------------------------------------------

1. Move the `Loan()` and `Return()` methods and the `Loanee` and `OnLoan` fields from the Album subclass to the MediaType base class.

2. Add a `GetDisplayText()` method to any media type subclass that currently doesn't define that method.

3. To test your changes...
  a) Ensure that you're instantiating an instance of each of your media type subclasses in the Program.cs `Main()` method.
  b) Call the `Loan()` and `Return()` methods on each media type subclass instance.
  c) Call the `GetDisplayText()` method (on each media type subclass instance) after calling the `Loan()` and `Return()` methods.

###3rd Challenge
--------------------------------------------------

1. In the Program.cs file, create a static method named `DetectMediaType()`.
  a) Define a parameter named `item` that's of type `MediaType`.

2. In the `DetectMediaType()` method body, use a series of conditional statements and the C# `is` operator to identity which particular media type subclass (i.e. Album, Book, Movie, etc.) the `item` parameter is an instance of.
  a) Once the media type item's subclass type has been determined, output a message to the console that identifies that type.
  b) For example, if the `item` parameter is of type "Album" and its `Title` field is set to the value "Yellow Submarine", write the message "Yellow Submarine is an album!" to the console.

3. To test your changes, pass each media type subclass instance into a call to the `DetectMediaType()` method.

###4th Challenge
--------------------------------------------------

1. In the MediaType.cs file...
  a) Throw an exception in the MediaType class constructor if the `title` parameter is set to `null` or an empty string.
    * Set the exception's message to "A media type must have a title."

2. In the Program.cs file...
  a) Throw an exception in the `DetectMediaType()` helper method when an unexpected media subtype is encountered.
    * Set the exception's message to "Unexpected media subtype encountered."
  b) Wrap the code in the `Main()` method in a `try/catch` statement.
    * Define a parameter in the `catch` clause in order to get a reference to the caught exception.
    * Write the exception's `Message` property to the console.






##Practice Encapsulation and Arrays in C#

###1st Challenge
--------------------------------------------------

1. Declare a variable for an array of type MediaType.

2. Initialize the array with the existing media type subclass instances.
  a) Feel free to add additional media type subclass instances!

3. Update the calls to the `DetectMediaType()` method.

4. Comment out any code past the calls to the `DetectMediaType()` method.

###2nd Challenge
--------------------------------------------------

1. Encapsulate the array of media type items inside of a class.
  a) Create a class named "MediaLibrary".

2. In the MediaLibrary class...
  a) Define a private array field of type MediaType named `_items`.
  b) Initialize the array via a constructor method that accepts an array of media type items.
  c) Add a method named `GetItemAt()` that accepts an index value and returns the media type item at the provided index.

3. In the Program.cs file `Main()` method...
  a) Instantiate an instance of the MediaLibrary class.
    * Pass into the constructor the existing collection of items.
  b) Update the rest of the code to use the `GetItemAt()` method to retrieve items from the media library.

###3rd Challenge
--------------------------------------------------

1. In the MediaLibrary class, update the `GetItemAt()` method to gracefully handle a bad index.
  a) Use the array's `Length` property to determine if an index is available before attempting to access it.
  b) Return `null` if the provided index isn't available in the array of items.

2. In the Program.cs file, update the `Display()` and `DetectMediaType()` methods to handle a null `item` parameter value.






##Practice Properties in C#

###1st Challenge
--------------------------------------------------

1. In the MediaType base class and Album, Book, and Movie subclasses, replace each public class field with a property.
  a) Use either the regular C# property syntax or the more concise auto-implemented property syntax.
  b) Use private setters for fields that should be readonly and initialize those properties via the constructor.

2. In the MediaType base class, initialize the `Loanee` and `OnLoan` properties inline to an empty string (i.e. `""` or `string.Empty`) and `false` respectively.

###2nd Challenge
--------------------------------------------------

1. In each media type subclass, replace the `GetDisplayText()` method with a `DisplayText` computed property.
  a) Use either the regular C# property syntax or the more concise expression-bodied property syntax.

2. In the MediaLibrary class, add a `NumberOfItems` computed property that returns an integer representing the number of items in the media library.

3. Update the Program.cs file as needed.
  a) Also add code to the `Main()` method in order to test the new MediaLibrary `NumberOfItems` computed property.






##Practice Loops in C#

###1st Challenge
--------------------------------------------------

1. Add a method named `DisplayItems()` to the MediaLibrary class.
  a) Use a `for` loop to loop through the items array contained within the MediaLibrary class.
  b) Cast each item to its subtype and access its `DisplayText` property, passing the property's value to a `Console.WriteLine()` method call.

2. In the Program.cs file, replace the calls to the `Display()` method with a single call to the `DisplayItems()` method.

###2nd Challenge
--------------------------------------------------

1. Add a method named `FindItem()` to the MediaLibrary class.
  a) The method should return a MediaType item and define a parameter of type `string` named `criteria`.
  b) Use a `foreach` loop to loop through the items array contained within the MediaLibrary class.
  c) Return the item whose `Title` property contains the provided `criteria` string parameter value.

2. In the Program.cs file, search the media library for an item by calling the `FindItem()` method.
  a) If an item is found, pass it into a call to the static MediaLibrary `DisplayItem()` method.
  b) If an item isn't found, write the message "Item not found!" to the console.

