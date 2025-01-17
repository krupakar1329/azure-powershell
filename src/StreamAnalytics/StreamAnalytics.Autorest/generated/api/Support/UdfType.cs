// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support
{

    /// <summary>The function type.</summary>
    public partial struct UdfType :
        System.IEquatable<UdfType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType Scalar = @"Scalar";

        /// <summary>the value for an instance of the <see cref="UdfType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UdfType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UdfType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UdfType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UdfType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UdfType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UdfType && Equals((UdfType)obj);
        }

        /// <summary>Returns hashCode for enum UdfType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UdfType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UdfType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UdfType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UdfType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UdfType" />.</param>

        public static implicit operator UdfType(string value)
        {
            return new UdfType(value);
        }

        /// <summary>Implicit operator to convert UdfType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UdfType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UdfType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UdfType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.UdfType e2)
        {
            return e2.Equals(e1);
        }
    }
}