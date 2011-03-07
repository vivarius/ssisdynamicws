using System;
using System.Collections.Generic;

namespace SSISWebServiceTask100
{
    internal static class NamedStringMembers
    {
        public const string SERVICE_URL = "ServiceUrl";
        public const string SERVICE = "Service";
        public const string WEBMETHOD = "WebMethod";
        public const string MAPPING_PARAMS = "MappingParams";
        public const string RETURNED_VALUE = "ReturnedValue";
    }


    [Serializable]
    public class MappingParam
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }

    [Serializable]
    public class MappingParams : List<MappingParam>
    {

    }

}
