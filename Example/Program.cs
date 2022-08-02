
DatabaseAccess.CreateAndOpenDb();
var customers = DatabaseAccess.GetCustomers();

foreach (var customer in customers)
{
    Console.WriteLine("{0} {1}",customer.FirstName, customer.LastName);
}