using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data
{
    public class Restarant
    {
        /*If a new type is made, "Alt + ." will move it to its own
         .cs file and keep it all clean...*/

        /* this is the restarant type */

        public int ID { get; set; }

        [Required, StringLength(40)] /*Validation.*/
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}


