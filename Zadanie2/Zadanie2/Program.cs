class Program
{
    static void Main()
    {
        string connectionString = "YourConnectionString";

        DatabaseOperations dbOperations = new DatabaseOperations(connectionString);

        // Insert
        var personToInsert = new Person { Name = "John Doe", Age = 30, Email = "john.doe@example.com" };
        dbOperations.InsertPerson(personToInsert);

        // Read
        int personId = 1;
        var retrievedPerson = dbOperations.GetPersonById(personId);
        Console.WriteLine($"Retrieved Person - Id: {retrievedPerson.Id}, Name: {retrievedPerson.Name}, Age: {retrievedPerson.Age}, Email: {retrievedPerson.Email}");

        // Update
        retrievedPerson.Age = 31;
        dbOperations.UpdatePerson(retrievedPerson);

        // Delete
        // dbOperations.DeletePerson(personId);

        
        dbOperations.PrintAllPeople();
    }
}
