/*
 * Loading Optimization
 *
 * With the Bin Packing service you can pack a number of items of various types into a number of bins of various types.
 *
 * The version of the OpenAPI document: 1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PTV.Developer.Clients.binpacking.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.binpacking.Model
{
    /// <summary>
    /// Allows customization of the bin packing operation.
    /// </summary>
    [DataContract(Name = "BinPackingOptions")]
    public partial class BinPackingOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinPackingOptions" /> class.
        /// </summary>
        /// <param name="unloadingSequence">Specifies the sequence of items or group of items to be unloaded. The first element of this sequence will be unloaded first (and loaded last). By default items of a stop will not be stacked on top of items of the subsequent stop. This may be useful when unloading all items of a stop with a hand truck. To change this behavior specify &#39;stackOnTopOfNextStops&#39;. Please note that this option can only be used the case a single bin is defined..</param>
        /// <param name="stackingOptions">stackingOptions.</param>
        public BinPackingOptions(List<Stop> unloadingSequence = default(List<Stop>), StackingOptions stackingOptions = default(StackingOptions))
        {
            this.UnloadingSequence = unloadingSequence;
            this.StackingOptions = stackingOptions;
        }

        /// <summary>
        /// Specifies the sequence of items or group of items to be unloaded. The first element of this sequence will be unloaded first (and loaded last). By default items of a stop will not be stacked on top of items of the subsequent stop. This may be useful when unloading all items of a stop with a hand truck. To change this behavior specify &#39;stackOnTopOfNextStops&#39;. Please note that this option can only be used the case a single bin is defined.
        /// </summary>
        /// <value>Specifies the sequence of items or group of items to be unloaded. The first element of this sequence will be unloaded first (and loaded last). By default items of a stop will not be stacked on top of items of the subsequent stop. This may be useful when unloading all items of a stop with a hand truck. To change this behavior specify &#39;stackOnTopOfNextStops&#39;. Please note that this option can only be used the case a single bin is defined.</value>
        [DataMember(Name = "unloadingSequence", EmitDefaultValue = false)]
        public List<Stop> UnloadingSequence { get; set; }

        /// <summary>
        /// Gets or Sets StackingOptions
        /// </summary>
        [DataMember(Name = "stackingOptions", EmitDefaultValue = false)]
        public StackingOptions StackingOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BinPackingOptions {\n");
            sb.Append("  UnloadingSequence: ").Append(UnloadingSequence).Append("\n");
            sb.Append("  StackingOptions: ").Append(StackingOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
