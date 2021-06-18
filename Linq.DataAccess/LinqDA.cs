using Linq.Common.Entities;
using Linq.Common.MethodParameters;
using Linq.DataAccess.Models;
using Linq.DataAccess.Utilities;
using Newtonsoft.Json;

namespace Linq.DataAccess
{
    public class LinqDA
    {
        public Result CreateData(CreateDataIn input)
        {
            Result output = Result.Error;
            string json = JsonConvert.SerializeObject(input);

            using (var dataContext = DataContextHelper.GetDataContext<LinqDataContext>())
            {
                var linqResult = dataContext.sp_createSimpleTable(input.data, json);
                if (linqResult >0)
                {
                    output = Result.Success;
                }
            }
            return output;
        }
    }
}
