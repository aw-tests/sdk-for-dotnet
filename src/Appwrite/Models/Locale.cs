
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Locale
    {
        [JsonProperty("ip")]
        public string Ip { get; private set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; private set; }

        [JsonProperty("country")]
        public string Country { get; private set; }

        [JsonProperty("continentCode")]
        public string ContinentCode { get; private set; }

        [JsonProperty("continent")]
        public string Continent { get; private set; }

        [JsonProperty("eu")]
        public bool Eu { get; private set; }

        [JsonProperty("currency")]
        public string Currency { get; private set; }

        public Locale(
            string ip,
            string countryCode,
            string country,
            string continentCode,
            string continent,
            bool eu,
            string currency
        ) {
            Ip = ip;
            CountryCode = countryCode;
            Country = country;
            ContinentCode = continentCode;
            Continent = continent;
            Eu = eu;
            Currency = currency;
        }

        public static Locale From(Dictionary<string, object> map) => new Locale(
            ip: (string)map["ip"],
            countryCode: (string)map["countryCode"],
            country: (string)map["country"],
            continentCode: (string)map["continentCode"],
            continent: (string)map["continent"],
            eu: (bool)map["eu"],
            currency: (string)map["currency"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "ip", Ip },
            { "countryCode", CountryCode },
            { "country", Country },
            { "continentCode", ContinentCode },
            { "continent", Continent },
            { "eu", Eu },
            { "currency", Currency }
        };
    }
}