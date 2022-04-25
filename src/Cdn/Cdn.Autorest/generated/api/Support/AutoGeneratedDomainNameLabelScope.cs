// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>Indicates the endpoint name reuse scope. The default value is TenantReuse.</summary>
    public partial struct AutoGeneratedDomainNameLabelScope :
        System.IEquatable<AutoGeneratedDomainNameLabelScope>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope NoReuse = @"NoReuse";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope ResourceGroupReuse = @"ResourceGroupReuse";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope SubscriptionReuse = @"SubscriptionReuse";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope TenantReuse = @"TenantReuse";

        /// <summary>
        /// the value for an instance of the <see cref="AutoGeneratedDomainNameLabelScope" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="AutoGeneratedDomainNameLabelScope" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AutoGeneratedDomainNameLabelScope(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AutoGeneratedDomainNameLabelScope</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AutoGeneratedDomainNameLabelScope" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AutoGeneratedDomainNameLabelScope(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AutoGeneratedDomainNameLabelScope</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type AutoGeneratedDomainNameLabelScope (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AutoGeneratedDomainNameLabelScope && Equals((AutoGeneratedDomainNameLabelScope)obj);
        }

        /// <summary>Returns hashCode for enum AutoGeneratedDomainNameLabelScope</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AutoGeneratedDomainNameLabelScope</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AutoGeneratedDomainNameLabelScope</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AutoGeneratedDomainNameLabelScope" />.</param>

        public static implicit operator AutoGeneratedDomainNameLabelScope(string value)
        {
            return new AutoGeneratedDomainNameLabelScope(value);
        }

        /// <summary>Implicit operator to convert AutoGeneratedDomainNameLabelScope to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AutoGeneratedDomainNameLabelScope" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AutoGeneratedDomainNameLabelScope</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AutoGeneratedDomainNameLabelScope</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AutoGeneratedDomainNameLabelScope e2)
        {
            return e2.Equals(e1);
        }
    }
}