using System.Data;
using System.Data.SqlClient;

public class DatabaseManager
{

    private readonly string _connectionString;

    public DatabaseManager(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<DataTable> ExecuteQueryAsync(string query, List<SqlParameter> parameters)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters.ToArray()); // Add the parameters to the command

            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                dataTable.Load(reader);
            }
        }
        return dataTable;
    }

    // Add methods for executing queries, updating data, etc.
}