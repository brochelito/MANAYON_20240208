using MediatR;
using System.Text;

namespace DataTemplator.Application.ProcessData
{
    public class ProcessDataCommandHandler : IRequestHandler<ProcessDataCommand, ProcessDataCommandResponse>
    {
        public ProcessDataCommandHandler()
        {          
        }
        public async Task<ProcessDataCommandResponse> Handle(ProcessDataCommand request, CancellationToken cancellationToken)
        {
            var processDataCommandResponse = new ProcessDataCommandResponse();

            var validator = new ProcessDataCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                processDataCommandResponse.Success = false;
                processDataCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    processDataCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (processDataCommandResponse.Success)
            {
                string filePath = request.TemplateFileName;             
                string fileContent = File.ReadAllText(filePath);

                var processedData = ProcessTemplate(request.ProcessDataRequests, fileContent);
                processDataCommandResponse.TextReport = processedData;
            }

            return processDataCommandResponse;
        }

        private static string ProcessTemplate(List<ProcessDataRequest> jsonData, string template)
        {
            return jsonData
                .Select(dataRow =>
                    typeof(ProcessDataRequest).GetProperties()
                        .Aggregate(new StringBuilder(template),
                            (builder, property) =>
                            {
                                var tagName = $"<field-{property.Name.ToLower()}>";
                                var tagValue = property.GetValue(dataRow)?.ToString() ?? string.Empty;
                                return builder.Replace(tagName, tagValue);
                            },
                            builder => builder.Append("\n<template-row>\n").Append("</template-row>\n")))
                .Aggregate(new StringBuilder(), (finalBuilder, resultBuilder) => finalBuilder.Append(resultBuilder))
                .ToString();
        }
    }
}
