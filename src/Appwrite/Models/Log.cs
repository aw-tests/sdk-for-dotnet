
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Log
    {
        [JsonProperty("event")]
        public string Event { get; private set; }

        [JsonProperty("userId")]
        public string UserId { get; private set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; private set; }

        [JsonProperty("userName")]
        public string UserName { get; private set; }

        [JsonProperty("mode")]
        public string Mode { get; private set; }

        [JsonProperty("ip")]
        public string Ip { get; private set; }

        [JsonProperty("time")]
        public string Time { get; private set; }

        [JsonProperty("osCode")]
        public string OsCode { get; private set; }

        [JsonProperty("osName")]
        public string OsName { get; private set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; private set; }

        [JsonProperty("clientType")]
        public string ClientType { get; private set; }

        [JsonProperty("clientCode")]
        public string ClientCode { get; private set; }

        [JsonProperty("clientName")]
        public string ClientName { get; private set; }

        [JsonProperty("clientVersion")]
        public string ClientVersion { get; private set; }

        [JsonProperty("clientEngine")]
        public string ClientEngine { get; private set; }

        [JsonProperty("clientEngineVersion")]
        public string ClientEngineVersion { get; private set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; private set; }

        [JsonProperty("deviceBrand")]
        public string DeviceBrand { get; private set; }

        [JsonProperty("deviceModel")]
        public string DeviceModel { get; private set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; private set; }

        [JsonProperty("countryName")]
        public string CountryName { get; private set; }

        public Log(
            string xevent,
            string userId,
            string userEmail,
            string userName,
            string mode,
            string ip,
            string time,
            string osCode,
            string osName,
            string osVersion,
            string clientType,
            string clientCode,
            string clientName,
            string clientVersion,
            string clientEngine,
            string clientEngineVersion,
            string deviceName,
            string deviceBrand,
            string deviceModel,
            string countryCode,
            string countryName
        ) {
            Event = xevent;
            UserId = userId;
            UserEmail = userEmail;
            UserName = userName;
            Mode = mode;
            Ip = ip;
            Time = time;
            OsCode = osCode;
            OsName = osName;
            OsVersion = osVersion;
            ClientType = clientType;
            ClientCode = clientCode;
            ClientName = clientName;
            ClientVersion = clientVersion;
            ClientEngine = clientEngine;
            ClientEngineVersion = clientEngineVersion;
            DeviceName = deviceName;
            DeviceBrand = deviceBrand;
            DeviceModel = deviceModel;
            CountryCode = countryCode;
            CountryName = countryName;
        }

        public static Log From(Dictionary<string, object> map) => new Log(
            xevent: (string)map["event"],
            userId: (string)map["userId"],
            userEmail: (string)map["userEmail"],
            userName: (string)map["userName"],
            mode: (string)map["mode"],
            ip: (string)map["ip"],
            time: (string)map["time"],
            osCode: (string)map["osCode"],
            osName: (string)map["osName"],
            osVersion: (string)map["osVersion"],
            clientType: (string)map["clientType"],
            clientCode: (string)map["clientCode"],
            clientName: (string)map["clientName"],
            clientVersion: (string)map["clientVersion"],
            clientEngine: (string)map["clientEngine"],
            clientEngineVersion: (string)map["clientEngineVersion"],
            deviceName: (string)map["deviceName"],
            deviceBrand: (string)map["deviceBrand"],
            deviceModel: (string)map["deviceModel"],
            countryCode: (string)map["countryCode"],
            countryName: (string)map["countryName"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "event", Event },
            { "userId", UserId },
            { "userEmail", UserEmail },
            { "userName", UserName },
            { "mode", Mode },
            { "ip", Ip },
            { "time", Time },
            { "osCode", OsCode },
            { "osName", OsName },
            { "osVersion", OsVersion },
            { "clientType", ClientType },
            { "clientCode", ClientCode },
            { "clientName", ClientName },
            { "clientVersion", ClientVersion },
            { "clientEngine", ClientEngine },
            { "clientEngineVersion", ClientEngineVersion },
            { "deviceName", DeviceName },
            { "deviceBrand", DeviceBrand },
            { "deviceModel", DeviceModel },
            { "countryCode", CountryCode },
            { "countryName", CountryName }
        };
    }
}