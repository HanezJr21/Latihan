using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Latihan.Repository
{
    public class RepositoryBase
    {
        private readonly IConfiguration _configuration;

        public RepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetDbConnection()
        {
            var connectionString = _configuration.GetConnectionString("Mysql");
            return new MySqlConnection(connectionString);
        }
    }
}
