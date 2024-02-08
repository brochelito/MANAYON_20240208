using DataTemplator.Application.Responses;

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
