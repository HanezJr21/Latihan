using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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
            return new SqlConnection(_configuration.GetConnectionString("Default"));
        }
    }
}
