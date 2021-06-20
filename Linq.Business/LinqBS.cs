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

        public GetDataOut GetData()
        {
            LinqDA dataAccess = new LinqDA();
            return dataAccess.GetData();
        }

        public GetDataByIDOut GetDataByID(int input)
        {
            LinqDA dataAccess = new LinqDA();
            return dataAccess.GetDataByID(input);
        }

        public Result DeleteData(int input)
        {
            LinqDA dataAccess = new LinqDA();
            return dataAccess.DeleteData(input);
        }

        public Result UpdateData(UpdateDataIn input)
        {
            LinqDA dataAccess = new LinqDA();
            return dataAccess.UpdateData(input);
        }
    }
}
