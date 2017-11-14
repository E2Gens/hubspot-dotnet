using System.Dynamic;

namespace HubSpot.Core.Interfaces
{
    public interface IHubSpotEntity
    {
        bool IsNameValue { get; }

        void ToHubSpotDataEntity(ref dynamic dataEntity);

        void FromHubSpotDataEntity(dynamic hubspotData);
    }
}
