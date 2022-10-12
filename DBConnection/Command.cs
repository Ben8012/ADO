using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    public class Command
    {
        public Command(string query, bool isStireProcedure)
        {
            Query = query;
            IsStireProcedure = isStireProcedure;
            Parameters = new Dictionary<string, object> ();
            
        }

        internal string Query { get; init; }
        internal bool IsStireProcedure { get; init; }
        internal Dictionary<string,object> Parameters { get; init; }

        
        public void AddParameter(string parameterName, object? value)
        {
            Parameters.Add(parameterName, value ?? DBNull.Value)  ;
        }
    }
}
