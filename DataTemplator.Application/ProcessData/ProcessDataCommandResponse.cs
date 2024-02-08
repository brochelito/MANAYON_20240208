using DataTemplator.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplator.Application.ProcessData
{
    public class ProcessDataCommandResponse : BaseResponse
    {
        public ProcessDataCommandResponse() : base()
        {
        }
        public string TextReport  { get; set; } = default!;      
    }
}
