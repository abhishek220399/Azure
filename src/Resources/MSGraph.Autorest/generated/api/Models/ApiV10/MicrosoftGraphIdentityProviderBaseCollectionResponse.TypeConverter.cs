// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell;

    /// <summary>
    /// A PowerShell PSTypeConverter to support converting to an instance of <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse"
    /// />
    /// </summary>
    public partial class MicrosoftGraphIdentityProviderBaseCollectionResponseTypeConverter : global::System.Management.Automation.PSTypeConverter
    {

        /// <summary>
        /// Determines if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType"
        /// /> parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <paramref name="sourceValue"/> parameter to the <paramref name="destinationType"
        /// /> parameter, otherwise <c>false</c>.
        /// </returns>
        public override bool CanConvertFrom(object sourceValue, global::System.Type destinationType) => CanConvertFrom(sourceValue);

        /// <summary>
        /// Determines if the converter can convert the <paramref name="sourceValue"/> parameter to the <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse"/>
        /// type.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object" /> instance to check if it can be converted to the <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse"
        /// /> type.</param>
        /// <returns>
        /// <c>true</c> if the instance could be converted to a <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse" />
        /// type, otherwise <c>false</c>
        /// </returns>
        public static bool CanConvertFrom(dynamic sourceValue)
        {
            if (null == sourceValue)
            {
                return true;
            }
            global::System.Type type = sourceValue.GetType();
            if (typeof(global::System.Management.Automation.PSObject).IsAssignableFrom(type))
            {
                // we say yest to PSObjects
                return true;
            }
            if (typeof(global::System.Collections.IDictionary).IsAssignableFrom(type))
            {
                // we say yest to Hashtables/dictionaries
                return true;
            }
            try
            {
                if (null != sourceValue.ToJsonString())
                {
                    return true;
                }
            }
            catch
            {
                // Not one of our objects
            }
            try
            {
                string text = sourceValue.ToString()?.Trim();
                return true == text?.StartsWith("{") && true == text?.EndsWith("}") && Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode.Parse(text).Type == Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonType.Object;
            }
            catch
            {
                // Doesn't look like it can be treated as JSON
            }
            return false;
        }

        /// <summary>
        /// Determines if the <paramref name="sourceValue" /> parameter can be converted to the <paramref name="destinationType" />
        /// parameter
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <paramref name="sourceValue" /> parameter to the <paramref name="destinationType"
        /// /> parameter, otherwise <c>false</c>
        /// </returns>
        public override bool CanConvertTo(object sourceValue, global::System.Type destinationType) => false;

        /// <summary>
        /// Converts the <paramref name="sourceValue" /> parameter to the <paramref name="destinationType" /> parameter using <paramref
        /// name="formatProvider" /> and <paramref name="ignoreCase" />
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>
        /// an instance of <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse" />, or <c>null</c> if there is no suitable
        /// conversion.
        /// </returns>
        public override object ConvertFrom(object sourceValue, global::System.Type destinationType, global::System.IFormatProvider formatProvider, bool ignoreCase) => ConvertFrom(sourceValue);

        /// <summary>
        /// Converts the <paramref name="sourceValue" /> parameter into an instance of <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse"
        /// />
        /// </summary>
        /// <param name="sourceValue">the value to convert into an instance of <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse"
        /// />.</param>
        /// <returns>
        /// an instance of <see cref="MicrosoftGraphIdentityProviderBaseCollectionResponse" />, or <c>null</c> if there is no suitable
        /// conversion.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentityProviderBaseCollectionResponse ConvertFrom(dynamic sourceValue)
        {
            if (null == sourceValue)
            {
                return null;
            }
            global::System.Type type = sourceValue.GetType();
            if (typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentityProviderBaseCollectionResponse).IsAssignableFrom(type))
            {
                return sourceValue;
            }
            try
            {
                return MicrosoftGraphIdentityProviderBaseCollectionResponse.FromJsonString(typeof(string) == sourceValue.GetType() ? sourceValue : sourceValue.ToJsonString());;
            }
            catch
            {
                // Unable to use JSON pattern
            }
            if (typeof(global::System.Management.Automation.PSObject).IsAssignableFrom(type))
            {
                return MicrosoftGraphIdentityProviderBaseCollectionResponse.DeserializeFromPSObject(sourceValue);
            }
            if (typeof(global::System.Collections.IDictionary).IsAssignableFrom(type))
            {
                return MicrosoftGraphIdentityProviderBaseCollectionResponse.DeserializeFromDictionary(sourceValue);
            }
            return null;
        }

        /// <summary>NotImplemented -- this will return <c>null</c></summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>will always return <c>null</c>.</returns>
        public override object ConvertTo(object sourceValue, global::System.Type destinationType, global::System.IFormatProvider formatProvider, bool ignoreCase) => null;
    }
}