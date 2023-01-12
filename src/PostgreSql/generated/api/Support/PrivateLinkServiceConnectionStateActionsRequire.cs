// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support
{

    /// <summary>The actions required for private link service connection.</summary>
    public partial struct PrivateLinkServiceConnectionStateActionsRequire :
        System.IEquatable<PrivateLinkServiceConnectionStateActionsRequire>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire None = @"None";

        /// <summary>
        /// the value for an instance of the <see cref="PrivateLinkServiceConnectionStateActionsRequire" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Conversion from arbitrary object to PrivateLinkServiceConnectionStateActionsRequire
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateLinkServiceConnectionStateActionsRequire"
        /// />.</param>
        internal static object CreateFrom(object value)
        {
            return new PrivateLinkServiceConnectionStateActionsRequire(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PrivateLinkServiceConnectionStateActionsRequire</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type PrivateLinkServiceConnectionStateActionsRequire (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PrivateLinkServiceConnectionStateActionsRequire && Equals((PrivateLinkServiceConnectionStateActionsRequire)obj);
        }

        /// <summary>Returns hashCode for enum PrivateLinkServiceConnectionStateActionsRequire</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PrivateLinkServiceConnectionStateActionsRequire"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PrivateLinkServiceConnectionStateActionsRequire(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>
        /// Returns string representation for PrivateLinkServiceConnectionStateActionsRequire
        /// </summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Implicit operator to convert string to PrivateLinkServiceConnectionStateActionsRequire
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateLinkServiceConnectionStateActionsRequire"
        /// />.</param>

        public static implicit operator PrivateLinkServiceConnectionStateActionsRequire(string value)
        {
            return new PrivateLinkServiceConnectionStateActionsRequire(value);
        }

        /// <summary>
        /// Implicit operator to convert PrivateLinkServiceConnectionStateActionsRequire to string
        /// </summary>
        /// <param name="e">the value to convert to an instance of <see cref="PrivateLinkServiceConnectionStateActionsRequire" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PrivateLinkServiceConnectionStateActionsRequire</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PrivateLinkServiceConnectionStateActionsRequire</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire e2)
        {
            return e2.Equals(e1);
        }
    }
}