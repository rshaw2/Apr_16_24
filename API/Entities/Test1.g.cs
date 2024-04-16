using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Apr1624.Entities
{
    /// <summary> 
    /// Represents a test1 entity with essential details
    /// </summary>
    public class Test1
    {
        /// <summary>
        /// Id of the Test1 
        /// </summary>
        public Guid? Id { get; set; }
        /// <summary>
        /// Name of the Test1 
        /// </summary>
        public string? Name { get; set; }
    }
}