using Insight.Database;
using Ninject;
using System.Data.SqlClient;



namespace DM.Insight
{
     class DMInsight
    {
        [Inject]
        public static SqlConnection DefaultCnn(string connectionString)
        {

            SqlInsightDbProvider.RegisterProvider();
            return new SqlConnection(connectionString);
        }
    }
}
