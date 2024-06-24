using System.Data;

namespace LemonTree.Pipeline.Tools.Database
{
    public interface IEADatabase
    {
        void SetModel(string model);

        bool Compact(string source, string destination);

        int RunSQLnonQuery(string sqlQuery);

        long RunSQLQueryScalar(string sqlQuery);

        /// <summary>
        /// run SQL and return result table
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns>dataTable with result table or null</returns>
        DataTable RunSql(string sqlQuery);

        string GetExtension();
        string GetWildcard();
    }
}
