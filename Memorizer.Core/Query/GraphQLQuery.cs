using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Memorizer.Api.Query
{
    public class GraphQLQuery
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
