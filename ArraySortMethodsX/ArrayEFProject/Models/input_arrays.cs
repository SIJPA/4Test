//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArrayEFProject.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
    
    public partial class input_arrays
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public input_arrays()
        {
            this.sorted_arrays = new HashSet<sorted_arrays>();
        }
    
		[Key]
        public int array_id { get; set; }
        public int number_of_rows { get; set; }
        public int number_of_columns { get; set; }
		[Required]
        public string array_content { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sorted_arrays> sorted_arrays { get; set; }
    }
}