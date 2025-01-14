// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the OS configuration. </summary>
    public partial class OSConfiguration
    {
        /// <summary> Initializes a new instance of OSConfiguration. </summary>
        public OSConfiguration()
        {
        }

        /// <summary> Initializes a new instance of OSConfiguration. </summary>
        /// <param name="osType"> The OS Type. </param>
        internal OSConfiguration(OSType osType)
        {
            OSType = osType;
        }

        /// <summary> The OS Type. </summary>
        internal OSType OSType { get; set; }
    }
}
