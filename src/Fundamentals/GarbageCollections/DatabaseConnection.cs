using Microsoft.Data.SqlClient;

namespace Fundamentals.GarbageCollections
{

    public class DatabaseConnection : IDisposable
    {
        private SqlConnection _connection;
        private bool _disposed = false;

        public DatabaseConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public void ExecuteQuery(string query)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(DatabaseConnection), "Cannot execute query on a disposed object.");
            }

            using (var command = new SqlCommand(query, _connection))
            {
                // Execute the query
                command.ExecuteNonQuery();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    _connection?.Dispose();
                }

                // Dispose unmanaged resources
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DatabaseConnection()
        {
            Dispose(false);
        }
    }
}