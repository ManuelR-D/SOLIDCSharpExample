using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal class PersonDAOMySQL : ICrudDAO<IPersonDTO>
    {
        private string connectionString;
        private SqlConnection connection;
        private const string TABLE = "person";
        public PersonDAOMySQL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        ~PersonDAOMySQL()
        {
            this.disconnect();
        }
        public void connect()
        {
            this.connection = new SqlConnection(connectionString);
        }

        public void disconnect()
        {
            this.connection.Close();
        }
        public bool deleteById(int id)
        {
            connection.Open();
            String query = "DELETE FROM " + TABLE + " WHERE id = (@id)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
            cmd.Parameters["@id"].Value = id;
            return cmd.ExecuteNonQuery() > 0;
        }

        public IPersonDTO getById(int id)
        {
            int? personId = 0;
            string? name = "";
            int? age = 0;
            char? gender = '?';
            connection.Open();
            String query = "SELECT * FROM " + TABLE + " WHERE id = (@id)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
            cmd.Parameters["@id"].Value = id;
            SqlDataReader registers = cmd.ExecuteReader();
            registers.Read();
            if (registers != null && registers.HasRows)
            {
                personId = Int32.Parse(registers["id"].ToString());
                name = registers["name"].ToString();
                age = Int32.Parse(registers["age"].ToString());
                gender = Char.Parse(registers["gender"].ToString());

            }
            return new Person(personId, name, age, gender);
        }

        public IPersonDTO save(IPersonDTO entity)
        {
            connection.Open();
            String query = "INSERT INTO person(name,age,gender) OUTPUT inserted.id VALUES (@name,@age,@gender)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@age", System.Data.SqlDbType.Int, 50);
            cmd.Parameters.Add("@gender", System.Data.SqlDbType.Char);
            cmd.Parameters["@name"].Value = entity.Name;
            cmd.Parameters["@age"].Value = entity.Age;
            cmd.Parameters["@gender"].Value = entity.Gender;
            int newId = Convert.ToInt32(cmd.ExecuteScalar());
            Person p = new Person(newId, entity.Name, entity.Age, entity.Gender);
            return p;
        }

        public bool update(IPersonDTO entity)
        {
            connection.Open();
            String query = "UPDATE person SET name = @name, age = @age, gender = @gender WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.BigInt);
            cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@age", System.Data.SqlDbType.Int, 50);
            cmd.Parameters.Add("@gender", System.Data.SqlDbType.Char);
            cmd.Parameters["@id"].Value = entity.Id;
            cmd.Parameters["@name"].Value = entity.Name;
            cmd.Parameters["@age"].Value = entity.Age;
            cmd.Parameters["@gender"].Value = entity.Gender;
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}
