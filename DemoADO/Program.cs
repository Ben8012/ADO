
// connexionString
// aller dans le server sur la base de données dans les propriétes => chaine de connection
// Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=ADO;Integrated Security=True; // a supprimer Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
// Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=ADO;Integrated Security=True;
// type float en sql est real en C# et inversement



using DemoADO.Models;
using System.Data;
using System.Data.SqlClient;
using DBConnection;

using (SqlConnection c = new SqlConnection())
{
    Console.WriteLine("récuperer le premier lastname de student");
    c.ConnectionString = "Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=ADO;Integrated Security=True;";


    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    cmd.CommandText = "SELECT LastName FROM Student WHERE id = 1";
    //    c.Open();
    //    string lastName = (string)cmd.ExecuteScalar();
    //    c.Close();
    //    Console.WriteLine(lastName);

    //}
    //Console.WriteLine();
    //Console.WriteLine("récuperer les lastname et firstname de student");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    cmd.CommandText = "SELECT LastName, FirstName FROM Student ";
    //    c.Open();
    //    using (SqlDataReader reader = cmd.ExecuteReader())
    //    {
    //        while (reader.Read())
    //        {
    //            Console.WriteLine($"Nom : {(string)reader["LastName"]}, Prénom : {(string)reader["FirstName"]}");
    //        }
    //    }
    //    c.Close();
    //}

    //Console.WriteLine();
    //Console.WriteLine("Exercice 1 : Afficher l’« ID », le « Nom », le « Prenom » de chaque étudiant depuis la vue «V_Student » en utilisant la méthode connectée");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    cmd.CommandText = "SELECT Id, LastName, FirstName FROM V_Student";
    //    c.Open();
    //    using (SqlDataReader reader = cmd.ExecuteReader())
    //    {
    //        while (reader.Read())
    //        {
    //            Console.WriteLine($"id : {(int)reader["Id"]:D2}, Nom : {(string)reader["LastName"]}, Prénom : {(string)reader["FirstName"]}");
    //        }
    //    }
    //    c.Close();
    //}

    //Console.WriteLine();
    //Console.WriteLine("Exercice 2 :  Afficher l’« ID », le « Nom » de chaque section en utilisant la méthode déconnectée");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    cmd.CommandText = "SELECT Id, SectionName FROM Section";
    //    using (SqlDataAdapter adapter = new SqlDataAdapter())
    //    {
    //        adapter.SelectCommand = cmd;
    //        DataSet dataSet = new DataSet();
    //        DataTable dataTable = new DataTable();
    //        adapter.Fill(dataSet); // ouvre la connection analyse le resultat , fetch toutes les lignes et les inclut dans dataSet
    //        adapter.Fill(dataTable);
    //        Console.WriteLine("Avec DataSet :");
    //        if (dataSet.Tables.Count > 0)
    //        {
    //            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
    //            {
    //                Console.WriteLine($"{(int)dataRow["Id"]} {(string)dataRow["SectionName"]} ");
    //            }
    //        }

    //        Console.WriteLine();
    //        Console.WriteLine("Avec DataTable: ");
    //        foreach (DataRow dataRow in dataTable.Rows)
    //        {
    //            Console.WriteLine($"{(int)dataRow["Id"]} {(string)dataRow["SectionName"]} ");
    //        }

    //    } ;


    //}

    //Console.WriteLine();
    //Console.WriteLine("Ex 3 : Afficher la moyenne annuelle des étudiants");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    cmd.CommandText = "SELECT AVG(CONVERT(FLOAT,YearResult)) AS Moyenne FROM Student ";
    //    c.Open();
    //    Console.WriteLine($"La moyenn est de : {(double)cmd.ExecuteScalar()}");
    //    c.Close();

    //}

    //Console.WriteLine();
    //Console.WriteLine("Ex 4 : Instanciez un objet de type « Student » contenant vos informations, Insérez votre objet en base de données en récupérant son « ID » au passage");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    Student student = new Student()
    //    {
    //        FirstName = "Benjamin",
    //        LastName = "Sterckx",
    //        BirthDate = new DateTime(1980, 12, 10),
    //        YearResult = 20,
    //        SectionId = 1010
    //    };


    //    string sqlFormattedDate = student.BirthDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
    //    //Console.WriteLine(sqlFormattedDate);
    //    cmd.CommandText = $"INSERT INTO Student(FirstName, LastName, BirthDate, YearResult , SectionId ) output inserted.*  Values('{student.FirstName}','{student.LastName}','{sqlFormattedDate}',{student.YearResult},{student.SectionId}) ";
    //    c.Open();
    //    //int rows = cmd.ExecuteNonQuery();
    //    //int student.id = (int)cmd.ExecuteScalar();
    //    //Console.WriteLine($"L'id inseré est : {id}");

    //    using (SqlDataReader reader = cmd.ExecuteReader())
    //    {
    //        if (reader.Read())
    //        {
    //            int insertedId = (int)reader["Id"];
    //            string insertedLastName = (string)reader["LastName"];
    //            string insertedFirstName = (string)reader["FirstName"];
    //            Console.WriteLine($"{insertedFirstName} {insertedLastName} a été inseré dans la table Student");
    //            Console.WriteLine($"L'id inseré est : {insertedId}");
    //        }

    //    }
    //    c.Close();
    //}


    //Console.WriteLine();
    //Console.WriteLine("Ex 5 : Instanciez un objet de type « Student » contenant les informations de votre voisin(e), Insérez votre objet en base de données en utilisant les requêtes paramétrées");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    Student student = new Student()
    //    {
    //        FirstName = "Corine",
    //        LastName = "Latour",
    //        BirthDate = new DateTime(1982, 8, 21),
    //        YearResult = 15,
    //        SectionId = 1010
    //    };


    //    string sqlFormattedDate = student.BirthDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
    //    //Console.WriteLine(sqlFormattedDate);
    //    cmd.CommandText = $"INSERT INTO Student(FirstName, LastName, BirthDate, YearResult , SectionId ) output inserted.*  Values(@prenom,@nom,@anneeNaiss,@resultatAnnee,@sectionId) ";
    //    cmd.Parameters.AddWithValue("prenom", student.FirstName);
    //    cmd.Parameters.AddWithValue("nom", student.LastName);
    //    cmd.Parameters.AddWithValue("anneeNaiss", sqlFormattedDate);
    //    cmd.Parameters.AddWithValue("resultatAnnee", student.YearResult);
    //    cmd.Parameters.AddWithValue("sectionId", student.SectionId);

    //    c.Open();
    //    //int rows = cmd.ExecuteNonQuery();
    //    //int student.id = (int)cmd.ExecuteScalar();
    //    //Console.WriteLine($"L'id inseré est : {id}");

    //    using (SqlDataReader reader = cmd.ExecuteReader())
    //    {
    //        if (reader.Read())
    //        {
    //            int insertedId = (int)reader["Id"];
    //            string insertedLastName = (string)reader["LastName"];
    //            string insertedFirstName = (string)reader["FirstName"];
    //            Console.WriteLine($"{insertedFirstName} {insertedLastName} a été inseré dans la table Student");
    //            Console.WriteLine($"L'id inseré est : {insertedId}");
    //        }

    //    }
    //    c.Close();
    //}



    //Console.WriteLine();
    //Console.WriteLine("Ex 6 : Appelez la procédure pour changer de « Section » l’étudiant vous représentant");
    //using (SqlCommand cmd = c.CreateCommand())
    //{
    //    cmd.CommandText = "SELECT Id,YearResult FROM Student WHERE FirstName = 'Benjamin' AND LastName = 'Sterckx'";
    //    int id = 0;
    //    int yearResult = 0;
    //    c.Open();
    //    using (SqlDataReader reader = cmd.ExecuteReader())
    //    {
    //        if (reader.Read())
    //        {
    //            id = (int)reader["Id"];
    //            yearResult = (int)reader["YearResult"];
    //        }

    //    }

    //    cmd.CommandText = "UpdateStudent";
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.Parameters.AddWithValue("Id", id);
    //    cmd.Parameters.AddWithValue("SectionId", 1010);
    //    cmd.Parameters.AddWithValue("YearResult", yearResult);

    //    cmd.ExecuteNonQuery();

    //}



    //Console.WriteLine();
    //Console.WriteLine("Ex 7 :  Appelez la procédure pour supprimer votre voisin de la base de données,Vérifiez que le champs « Active » est bien passé à 0");
    //using (SqlCommand cmd = c.CreateCommand())
    //{

    //    cmd.CommandText = "SELECT Id FROM Student WHERE FirstName = 'Corine' AND LastName = 'Latour'";
    //    c.Open();
    //    int id = (int)cmd.ExecuteScalar();

    //    cmd.CommandText = "DeleteStudent";
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    cmd.Parameters.AddWithValue("Id", id);
    //    cmd.ExecuteNonQuery();

    //}

    Console.WriteLine();
    Console.WriteLine($"Ex8 : page 127");

    Connexion connection = new Connexion(c.ConnectionString);
    Command command = new Command($"INSERT INTO Student(FirstName, LastName, BirthDate, YearResult, SectionId) Values(@FirstName, @LastName, @BirthDate, @YearResult, @SectionId) ;",false);
    command.AddParameter("FirstName", "Toto");
    command.AddParameter("LastName", "Doe");
    command.AddParameter("BirthDate", DateTime.Now);
    command.AddParameter("YearResult", 1);
    command.AddParameter("SectionId", 1010);

    connection.ExecuteNonQuery(command);



}