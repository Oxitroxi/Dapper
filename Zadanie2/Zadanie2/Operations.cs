using System;
using System.Data.SqlClient;

using System.Linq;
using Dapper;

public class DatabaseOperations
{
    private readonly string connectionString;

    public DatabaseOperations(string connectionString)
    {
        this.connectionString = connectionString;
        SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLServer);
    }

    public void InsertPerson(Person person)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Insert(person);
        }
    }

    public Person GetPersonById(int id)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            return connection.Get<Person>(id);
        }
    }

    public void UpdatePerson(Person person)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Update(person);
        }
    }

    public void DeletePerson(int id)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Delete<Person>(id);
        }
    }

    public void PrintAllPeople()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var people = connection.Query<Person>("SELECT * FROM People");
            foreach (var person in people)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}, Email: {person.Email}");
            }
        }
    }
}