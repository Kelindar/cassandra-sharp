﻿// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
// limitations under the License.
namespace CassandraSharp.Config
{
    using System.Xml.Serialization;
    using Apache.Cassandra;

    public class BehaviorConfig : IBehaviorConfig
    {
        public BehaviorConfig()
        {
            ReadConsistencyLevel = ConsistencyLevel.QUORUM;
            WriteConsistencyLevel = ConsistencyLevel.QUORUM;
        }

        [XmlAttribute("keyspace")]
        public string KeySpace { get; set; }

        [XmlAttribute("readCL")]
        public ConsistencyLevel ReadConsistencyLevel { get; set; }

        [XmlAttribute("ttl")]
        public int TTL { get; set; }

        [XmlAttribute("writeCL")]
        public ConsistencyLevel WriteConsistencyLevel { get; set; }

        [XmlAttribute("maxRetries")]
        public int MaxRetries { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }

        [XmlAttribute("retryOnNotFound")]
        public bool RetryOnNotFound { get; set; }

        [XmlAttribute("retryOnTimeout")]
        public bool RetryOnTimeout { get; set; }

        [XmlAttribute("retryOnUnavailable")]
        public bool RetryOnUnavailable { get; set; }

        [XmlAttribute("user")]
        public string User { get; set; }
    }
}