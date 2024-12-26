using SCharpEgitimKampi301_501.Dtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpEgitimKampi301_501.Context
{
	public class DapperContext
	{
		private readonly string _connectionString;
		private readonly IDbConnection _connection;

		public DapperContext()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["DapperContext"].ConnectionString;

		}
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
