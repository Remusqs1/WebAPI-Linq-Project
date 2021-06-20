using Linq.Common.Entities;
using Linq.Common.MethodParameters;
using Linq.DataAccess.Models;
using Linq.DataAccess.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;

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

        public GetDataOut GetData()
        {
            GetDataOut output = new GetDataOut() { result = Result.Error };
            output.linqDataList = new List<LinqData>();
            using (var dataContext = DataContextHelper.GetDataContext<LinqDataContext>())
            {
                var linqResult = dataContext.sp_getSimpleTable();
                foreach (var item in linqResult)
                {
                    LinqData linqData = new LinqData()
                    {
                        lqID = (int)item.lqID,
                        lq_data = item.lq_data,
                        lq_fullInput = new FullInput()
                        {
                            data = item.lq_fullInput
                        },
                        lq_response = item.lq_response,
                        lq_creaDate = item.lq_creaDate,
                    };
                    
                    output.linqDataList.Add(linqData);
                }
                if (output.linqDataList.Count > 0) output.result = Result.Success;
            }
            return output;
        }

        public GetDataByIDOut GetDataByID(int input)
        {
            GetDataByIDOut output = new GetDataByIDOut() { result = Result.Error };
            using (var dataContext = DataContextHelper.GetDataContext<LinqDataContext>())
            {
                var linqResult = dataContext.sp_getSimpleTableByID(input);
                foreach (var item in linqResult)
                {
                    LinqData linqData = new LinqData()
                    {
                        lqID = (int)item.lqID,
                        lq_data = item.lq_data,
                        lq_fullInput = new FullInput()
                        {
                            data = item.lq_fullInput
                        },
                        lq_response = item.lq_response,
                        lq_creaDate = item.lq_creaDate,
                        lq_status = !item.lq_status,
                        status = item.lq_status == false ? "ENABLE" : "DISABLED"
                    };
                   
                    output.linqData = linqData;
                    output.result = Result.Success;
                }
            }
            return output;
        }

        public Result DeleteData(int input)
        {
            Result output = Result.Error;
            using (var dataContext = DataContextHelper.GetDataContext<LinqDataContext>())
            {
                var linqResult = dataContext.sp_deleteSimpleTable(input);
                if (linqResult == 1) { output = Result.Success; }
            }
            return output;
        }

        public Result UpdateData(UpdateDataIn input)
        {
            Result output = Result.Error;
            using (var dataContext = DataContextHelper.GetDataContext<LinqDataContext>())
            {
                string json = JsonConvert.SerializeObject(input);
                var linqResult = dataContext.sp_updateSimpleTable(input.lqID, input.lq_data, json);
                if (linqResult == 1) { output = Result.Success; }
            }
            return output;
        }

    }
}
