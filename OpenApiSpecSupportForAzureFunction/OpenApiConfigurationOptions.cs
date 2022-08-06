using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiSpecSupportForAzureFunction
{
    public class OpenApiConfigurationOptions : IOpenApiConfigurationOptions
    {
        OpenApiInfo IOpenApiConfigurationOptions.Info { get; set; } = new OpenApiInfo()
        { 
            Version = "1.0.0", //Your API version
            Title = "Your Api Title",
            Description = "Describe your API here",
            TermsOfService = new Uri("https://Link_to_your_tnc"),
            Contact = new OpenApiContact()
            {
                Name =  "Name of your contact persion or team.",
                Email = "Email ID of contact persion or team.",
                Url = new Uri("http://Link_to_your_teams_page")
            },
            License = new OpenApiLicense()
            {
                Name = "License Provider",
                Url = new Uri("https://Link_to_your_license_description")
            }
        };
        List<OpenApiServer> IOpenApiConfigurationOptions.Servers { get; set; } = new List<OpenApiServer>();
        OpenApiVersionType IOpenApiConfigurationOptions.OpenApiVersion { get; set; } = OpenApiVersionType.V3;
        bool IOpenApiConfigurationOptions.IncludeRequestingHostName { get; set; } = false;
        bool IOpenApiConfigurationOptions.ForceHttp { get; set; } = true;
        bool IOpenApiConfigurationOptions.ForceHttps { get; set; } = false;
        List<IDocumentFilter> IOpenApiConfigurationOptions.DocumentFilters { get; set; } = new();
    }
}
