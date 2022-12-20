using Insight.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.AccesoDM
{
    public class DMAcceso<T>
    {
        public IList<T> ConsultarList(string sp, object entity,string connectionString) 
        {
            IList<T> response = Insight.DMInsight.DefaultCnn(connectionString).Query<T>(sp, entity, commandTimeout: 1000000); 
        
            return response;
        }

        public T Operar(string sp, T entity, string connectionString)
        {

            T res = Insight.DMInsight.DefaultCnn(connectionString).Insert<T>(sp, entity, commandTimeout: 1000000);
            return res;
        }

        public T Consultar(string sp, object entity, string connectionString)
        {

            T response = Insight.DMInsight.DefaultCnn(connectionString).ExecuteScalar<T>(sp, entity);

            return response;
        }


    }
}
