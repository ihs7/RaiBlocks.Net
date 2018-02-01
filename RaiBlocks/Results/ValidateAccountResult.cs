using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Results
{
    public class ValidateAccountResult
    {
        [JsonProperty("valid")]
        public Int16 Valid { get; set; }

        public bool IsValid()
        {
            return Valid.Equals(1);
        }
    }
}
