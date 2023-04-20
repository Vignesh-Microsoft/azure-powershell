// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support
{

    /// <summary>
    /// Sets the routing preference of the SAP monitor. By default only RFC1918 traffic is routed to the customer VNET.
    /// </summary>
    public partial struct RoutingPreference :
        System.IEquatable<RoutingPreference>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference Default = @"Default";

        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference RouteAll = @"RouteAll";

        /// <summary>the value for an instance of the <see cref="RoutingPreference" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RoutingPreference</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RoutingPreference" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RoutingPreference(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RoutingPreference</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RoutingPreference (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RoutingPreference && Equals((RoutingPreference)obj);
        }

        /// <summary>Returns hashCode for enum RoutingPreference</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RoutingPreference"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RoutingPreference(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RoutingPreference</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RoutingPreference</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RoutingPreference" />.</param>

        public static implicit operator RoutingPreference(string value)
        {
            return new RoutingPreference(value);
        }

        /// <summary>Implicit operator to convert RoutingPreference to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RoutingPreference" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RoutingPreference</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference e1, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RoutingPreference</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference e1, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.RoutingPreference e2)
        {
            return e2.Equals(e1);
        }
    }
}