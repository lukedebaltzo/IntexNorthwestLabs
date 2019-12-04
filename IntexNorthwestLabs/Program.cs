using Dapper;
using IntexNorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IntexNorthwestLabs
{
    public class Program
    {

        //GET api/aircraft
        [HttpGet]
        public async Task<IEnumerable<Assay>> Get(string model)
        {
            IEnumerable<Assay> Assay_Catalog;

            using (var connection = new SqlConnection(@"Data Source=DESKTOP-5G1FALG\SQLEXPRESS;Initial Catalog=NorthWestLabs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                await connection.OpenAsync();

                Assay_Catalog = await connection.QueryAsync<Assay>("Assay_Catalog",
                                new { Model = model },
                                commandType: CommandType.StoredProcedure);
            }
            
            return Assay_Catalog;

        }
    }
}