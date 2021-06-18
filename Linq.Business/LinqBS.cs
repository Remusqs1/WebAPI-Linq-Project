using Linq.Common.Entities;
using Linq.Common.MethodParameters;
using Linq.DataAccess;

namespace Linq.Business
{
    public class LinqBS
    {
        public Result CreateData(CreateDataIn input)
        {
            Result output = Result.Error;
            LinqDA dataAccess = new LinqDA();
            var result = dataAccess.CreateData(input);
            if (result == Result.Success) output = Result.Success;
            return output;
        }
    }
}
