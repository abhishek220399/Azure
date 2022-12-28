// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support
{

    /// <summary>The kind of workbook. Only valid value is shared.</summary>
    public partial struct WorkbookUpdateSharedTypeKind :
        System.IEquatable<WorkbookUpdateSharedTypeKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind Shared = @"shared";

        /// <summary>
        /// the value for an instance of the <see cref="WorkbookUpdateSharedTypeKind" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WorkbookUpdateSharedTypeKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkbookUpdateSharedTypeKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WorkbookUpdateSharedTypeKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WorkbookUpdateSharedTypeKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WorkbookUpdateSharedTypeKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WorkbookUpdateSharedTypeKind && Equals((WorkbookUpdateSharedTypeKind)obj);
        }

        /// <summary>Returns hashCode for enum WorkbookUpdateSharedTypeKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WorkbookUpdateSharedTypeKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="WorkbookUpdateSharedTypeKind"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WorkbookUpdateSharedTypeKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WorkbookUpdateSharedTypeKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkbookUpdateSharedTypeKind" />.</param>

        public static implicit operator WorkbookUpdateSharedTypeKind(string value)
        {
            return new WorkbookUpdateSharedTypeKind(value);
        }

        /// <summary>Implicit operator to convert WorkbookUpdateSharedTypeKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WorkbookUpdateSharedTypeKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WorkbookUpdateSharedTypeKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind e1, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WorkbookUpdateSharedTypeKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind e1, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WorkbookUpdateSharedTypeKind e2)
        {
            return e2.Equals(e1);
        }
    }
}