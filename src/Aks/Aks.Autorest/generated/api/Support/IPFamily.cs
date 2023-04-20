// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Support
{

    /// <summary>The IP version to use for cluster networking and IP assignment.</summary>
    public partial struct IPFamily :
        System.IEquatable<IPFamily>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily IPv4 = @"IPv4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily IPv6 = @"IPv6";

        /// <summary>the value for an instance of the <see cref="IPFamily" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to IPFamily</summary>
        /// <param name="value">the value to convert to an instance of <see cref="IPFamily" />.</param>
        internal static object CreateFrom(object value)
        {
            return new IPFamily(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type IPFamily</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type IPFamily (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is IPFamily && Equals((IPFamily)obj);
        }

        /// <summary>Returns hashCode for enum IPFamily</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="IPFamily"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private IPFamily(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for IPFamily</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to IPFamily</summary>
        /// <param name="value">the value to convert to an instance of <see cref="IPFamily" />.</param>

        public static implicit operator IPFamily(string value)
        {
            return new IPFamily(value);
        }

        /// <summary>Implicit operator to convert IPFamily to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="IPFamily" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum IPFamily</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum IPFamily</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.IPFamily e2)
        {
            return e2.Equals(e1);
        }
    }
}