using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplator.Application.ProcessData
{
    public class ProcessDataCommand : IRequest<ProcessDataCommandResponse>
    {
        public List<ProcessDataRequest> ProcessDataRequests { get; set; } = [];
        public string TemplateFileName { get; set; } = string.Empty;
         
    }

 
}
