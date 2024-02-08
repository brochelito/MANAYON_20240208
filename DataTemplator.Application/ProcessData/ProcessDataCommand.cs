using MediatR;

namespace DataTemplator.Application.ProcessData
{
    public class ProcessDataCommand : IRequest<ProcessDataCommandResponse>
    {
        public List<ProcessDataRequest> ProcessDataRequests { get; set; } = [];
        public string TemplateFileName { get; set; } = string.Empty;
         
    }

 
}
