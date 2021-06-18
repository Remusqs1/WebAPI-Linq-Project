using Linq.Common.Entities;
using Linq.DataAccess.Models;
using Linq.DataAccess.Utilities;

namespace Linq.DataAccess
{
    public class LinqDA
    {
        public Result CreateData(string input)
        {
            Result output = Result.Error;
            using (var dataContext = DataContextHelper.GetDataContext<LinqDataContext>())
            {
                var linqResult = dataContext.sp_createSimpleTable(input);
                if (linqResult >0)
                {
                    output = Result.Success;
                }
            }
            return output;
        }
    }
}
