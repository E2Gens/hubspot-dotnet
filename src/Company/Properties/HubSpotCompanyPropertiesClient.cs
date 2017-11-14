using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RapidCore.Network;
using HubSpot.Core;
using HubSpot.Core.Interfaces;
using HubSpot.Core.Requests;

namespace HubSpot.Company.Properties
{
    public class HubSpotCompanyPropertiesClient : HubSpotBaseClient
    {
        /// <summary>
        /// Mockable and container ready constructor
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="logger"></param>
        /// <param name="serializer"></param>
        /// <param name="hubSpotBaseUrl"></param>
        /// <param name="apiKey"></param>
        public HubSpotCompanyPropertiesClient(
            IRapidHttpClient httpClient,
            ILogger<HubSpotCompanyClient> logger,
            RequestSerializer serializer,
            string hubSpotBaseUrl,
            string apiKey)
            : base(httpClient, logger, serializer, hubSpotBaseUrl, apiKey)
        {
        }

        /// <summary>
        /// Create a new instance of the HubSpotCompanyPropertiesClient with default dependencies
        /// </summary>
        /// <remarks>
        /// This constructor creates a HubSpotCompanyPropertiesClient using "real" dependencies that will send requests 
        /// via the network - if you wish to have support for functional tests and mocking use the "eager" constructor
        /// that takes in all underlying dependecies
        /// </remarks>
        /// <param name="apiKey">Your API key</param>
        public HubSpotCompanyPropertiesClient(string apiKey)
        : base(
              new RealRapidHttpClient(new HttpClient()), 
              NoopLoggerFactory.Get(), 
              new RequestSerializer(new RequestDataConverter(NoopLoggerFactory.Get<RequestDataConverter>())),
              "https://api.hubapi.com", 
              apiKey)
        { }
    }
}