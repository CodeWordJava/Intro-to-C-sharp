// the string keyword on line 3 tells the array what data type is expected, you then use the new keyword to create the array and specify how big to make it.

/*string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0]= "A123";
// fraudulentOrderIDs[1]= "B456";
// fraudulentOrderIDs[2]= "C678";
fraudulentOrderIDs[3] ="D000";*/

// you can also delcare it inline
string [] fraudulentOrderIDs = { "A123","B456","C789"};
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
