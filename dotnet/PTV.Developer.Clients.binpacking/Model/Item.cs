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
    /// Item
    /// </summary>
    [DataContract(Name = "Item")]
    public partial class Item : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="id">User provided ID for this item. Must be unique. (required).</param>
        /// <param name="dimensions">dimensions (required).</param>
        /// <param name="weight">Weight of this item in [g]. (required).</param>
        /// <param name="maximumSurfaceLoads">maximumSurfaceLoads.</param>
        /// <param name="allowedOrientations">Enumerates possible orientations. If not given all orientations will be allowed. * &#x60;ORIGINAL&#x60; - Item is not re-oriented. Dimensions stay (x,y,z). * &#x60;X&#x60; - Item is rotated around x-axis (widthwise) by +/-90 degrees compared to the original orientation. Dimensions are (x,z,y). * &#x60;Y&#x60; - Item is rotated around y-axis (heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,y,x). * &#x60;Z&#x60; - Item is rotated around z-axis (lengthwise) by +/-90 degrees compared to the original orientation. Dimensions are (y,x,z). * &#x60;XZ&#x60; - Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y). * &#x60;YZ&#x60; - Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y)..</param>
        /// <param name="numberOfInstances">Number of instances of this item that should be packed. (default to 1).</param>
        public Item(string id = default(string), BoxDimensions dimensions = default(BoxDimensions), int? weight = default(int?), ItemSurfaceLoads maximumSurfaceLoads = default(ItemSurfaceLoads), List<AllowedOrientation> allowedOrientations = default(List<AllowedOrientation>), int? numberOfInstances = 1)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Item and cannot be null");
            }
            this.Id = id;
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new ArgumentNullException("dimensions is a required property for Item and cannot be null");
            }
            this.Dimensions = dimensions;
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new ArgumentNullException("weight is a required property for Item and cannot be null");
            }
            this.Weight = weight;
            this.MaximumSurfaceLoads = maximumSurfaceLoads;
            this.AllowedOrientations = allowedOrientations;
            // use default value if no "numberOfInstances" provided
            this.NumberOfInstances = numberOfInstances ?? 1;
        }

        /// <summary>
        /// User provided ID for this item. Must be unique.
        /// </summary>
        /// <value>User provided ID for this item. Must be unique.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", IsRequired = true, EmitDefaultValue = true)]
        public BoxDimensions Dimensions { get; set; }

        /// <summary>
        /// Weight of this item in [g].
        /// </summary>
        /// <value>Weight of this item in [g].</value>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or Sets MaximumSurfaceLoads
        /// </summary>
        [DataMember(Name = "maximumSurfaceLoads", EmitDefaultValue = false)]
        public ItemSurfaceLoads MaximumSurfaceLoads { get; set; }

        /// <summary>
        /// Enumerates possible orientations. If not given all orientations will be allowed. * &#x60;ORIGINAL&#x60; - Item is not re-oriented. Dimensions stay (x,y,z). * &#x60;X&#x60; - Item is rotated around x-axis (widthwise) by +/-90 degrees compared to the original orientation. Dimensions are (x,z,y). * &#x60;Y&#x60; - Item is rotated around y-axis (heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,y,x). * &#x60;Z&#x60; - Item is rotated around z-axis (lengthwise) by +/-90 degrees compared to the original orientation. Dimensions are (y,x,z). * &#x60;XZ&#x60; - Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y). * &#x60;YZ&#x60; - Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y).
        /// </summary>
        /// <value>Enumerates possible orientations. If not given all orientations will be allowed. * &#x60;ORIGINAL&#x60; - Item is not re-oriented. Dimensions stay (x,y,z). * &#x60;X&#x60; - Item is rotated around x-axis (widthwise) by +/-90 degrees compared to the original orientation. Dimensions are (x,z,y). * &#x60;Y&#x60; - Item is rotated around y-axis (heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,y,x). * &#x60;Z&#x60; - Item is rotated around z-axis (lengthwise) by +/-90 degrees compared to the original orientation. Dimensions are (y,x,z). * &#x60;XZ&#x60; - Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y). * &#x60;YZ&#x60; - Item is rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y).</value>
        /// <example>[&quot;ORIGINAL&quot;,&quot;XZ&quot;]</example>
        [DataMember(Name = "allowedOrientations", EmitDefaultValue = false)]
        public List<AllowedOrientation> AllowedOrientations { get; set; }

        /// <summary>
        /// Number of instances of this item that should be packed.
        /// </summary>
        /// <value>Number of instances of this item that should be packed.</value>
        [DataMember(Name = "numberOfInstances", EmitDefaultValue = true)]
        public int? NumberOfInstances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  MaximumSurfaceLoads: ").Append(MaximumSurfaceLoads).Append("\n");
            sb.Append("  AllowedOrientations: ").Append(AllowedOrientations).Append("\n");
            sb.Append("  NumberOfInstances: ").Append(NumberOfInstances).Append("\n");
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
            // Weight (int?) maximum
            if (this.Weight > (int?)80000000)
            {
                yield return new ValidationResult("Invalid value for Weight, must be a value less than or equal to 80000000.", new [] { "Weight" });
            }

            // Weight (int?) minimum
            if (this.Weight < (int?)0)
            {
                yield return new ValidationResult("Invalid value for Weight, must be a value greater than or equal to 0.", new [] { "Weight" });
            }

            // NumberOfInstances (int?) maximum
            if (this.NumberOfInstances > (int?)10000)
            {
                yield return new ValidationResult("Invalid value for NumberOfInstances, must be a value less than or equal to 10000.", new [] { "NumberOfInstances" });
            }

            // NumberOfInstances (int?) minimum
            if (this.NumberOfInstances < (int?)1)
            {
                yield return new ValidationResult("Invalid value for NumberOfInstances, must be a value greater than or equal to 1.", new [] { "NumberOfInstances" });
            }

            yield break;
        }
    }

}
