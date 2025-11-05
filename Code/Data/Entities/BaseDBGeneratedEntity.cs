using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    /// <summary>
    /// Holds key DB base fields for all DB entities
    /// </summary>
    public class BaseDBGeneratedEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the project
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual Guid Id { get; set; }
    }
}