using Microsoft.Data.SqlClient;

string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    await connection.OpenAsync();

   

    string CreateProduct = "CREATE TABLE Product" +
        "(Id INT PRIMARY KEY IDENTITY," +
        "Name NVARCHAR(50))";

    string CreateCategory = "CREATE TABLE Category" +
       "(Id INT PRIMARY KEY IDENTITY," +
       "Name NVARCHAR(50))";

    string CreateCategoryProduct = "CREATE TABLE CategoryProduct" +
      "(ProductId INT FOREIGN KEY REFERENCES Product(Id)," +
      "CategoryId INT FOREIGN KEY REFERENCES Category(Id)," +
      "Id INT PRIMARY KEY IDENTITY)";
      


    SqlCommand commandProduct = new SqlCommand(CreateProduct,connection);
    commandProduct.CommandText += "INSERT INTO Product ( Name) VALUES ('Milk')" +
        "INSERT INTO Product (Name) VALUES ('Butter')" +
        "INSERT INTO Product (Name) VALUES ('Yogurt')" +
        "INSERT INTO Product (Name) VALUES ('Kefir')" +
        "INSERT INTO Product (Name) VALUES ('Beer')" +
        "INSERT INTO Product (Name) VALUES ('Wine')" +
        "INSERT INTO Product (Name) VALUES ('Vodka')" +
        "INSERT INTO Product (Name) VALUES ('Fish')"+
        "INSERT INTO Product (Name) VALUES ('Rice')"+
        "INSERT INTO Product (Name) VALUES ('Water')"+
        "INSERT INTO Product (Name) VALUES ('Apple')";

    
    SqlCommand commandCategory = new SqlCommand(CreateCategory, connection);
    commandCategory.CommandText += "INSERT INTO Category ( Name) VALUES ('Dairy')" +
     "INSERT INTO Category (Name) VALUES ('Alcohol')";
   
    SqlCommand commandCategoryProduct = new SqlCommand(CreateCategoryProduct, connection);
    commandCategoryProduct.CommandText += "INSERT INTO CategoryProduct ( ProductId,CategoryId) VALUES (1,1)" +
   "INSERT INTO CategoryProduct (ProductId,CategoryId) VALUES (2,1)" +
   "INSERT INTO CategoryProduct (ProductId,CategoryId) VALUES (3,1)" +
   "INSERT INTO CategoryProduct (ProductId,CategoryId) VALUES (4,1)" +
   "INSERT INTO CategoryProduct (ProductId,CategoryId) VALUES (5,2)" +
   "INSERT INTO CategoryProduct (ProductId,CategoryId) VALUES (6,2)" +
   "INSERT INTO CategoryProduct (ProductId,CategoryId) VALUES (7,2)";
    await commandProduct.ExecuteNonQueryAsync();
    await commandCategory.ExecuteNonQueryAsync();
    await commandCategoryProduct.ExecuteNonQueryAsync();

    Console.WriteLine("Таблицы  созданы");

    string sqlExpression = "SELECT  Product.Name AS Product,Category.Name AS Category FROM Product " +
        "LEFT JOIN CategoryProduct ON Product.Id=CategoryProduct.ProductId LEFT JOIN Category ON CategoryProduct.CategoryId=Category.Id";
    
    SqlCommand command = new SqlCommand(sqlExpression, connection);
    using (SqlDataReader reader = await command.ExecuteReaderAsync())
    {

        if (reader.HasRows)
        {

            string columnName1 = reader.GetName(0);
            string columnName2 = reader.GetName(1);


            Console.WriteLine($"\t\t\t{columnName1}\t\t\t\t\t\t{columnName2}");
            while (await reader.ReadAsync())
            {
                object productName = reader.GetValue(0);
                object categoryName = reader.GetValue(1);
                Console.WriteLine($"\t\t\t{productName}\t\t\t\t\t\t{categoryName} ");
            }

        }
    }



}