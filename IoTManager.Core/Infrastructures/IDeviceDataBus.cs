using System.Collections.Generic;
using IoTManager.Model;
using IoTManager.Utility.Serializers;

namespace IoTManager.Core.Infrastructures
{
    public interface IDeviceDataBus
    {
        List<DeviceDataSerializer> GetAllDeviceData();
    }
}