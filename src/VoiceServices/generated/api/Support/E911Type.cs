// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support
{

    /// <summary>The method for terminating emergency calls to the PSTN.</summary>
    public partial struct E911Type :
        System.IEquatable<E911Type>
    {
        /// <summary>Emergency calls are routed directly to the ESRP</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type DirectToEsrp = @"DirectToEsrp";

        /// <summary>Emergency calls are not handled different from other calls</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type Standard = @"Standard";

        /// <summary>the value for an instance of the <see cref="E911Type" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to E911Type</summary>
        /// <param name="value">the value to convert to an instance of <see cref="E911Type" />.</param>
        internal static object CreateFrom(object value)
        {
            return new E911Type(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="E911Type"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private E911Type(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type E911Type</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type E911Type (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is E911Type && Equals((E911Type)obj);
        }

        /// <summary>Returns hashCode for enum E911Type</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for E911Type</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to E911Type</summary>
        /// <param name="value">the value to convert to an instance of <see cref="E911Type" />.</param>

        public static implicit operator E911Type(string value)
        {
            return new E911Type(value);
        }

        /// <summary>Implicit operator to convert E911Type to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="E911Type" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum E911Type</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type e1, Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum E911Type</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type e1, Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Support.E911Type e2)
        {
            return e2.Equals(e1);
        }
    }
}