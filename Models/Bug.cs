using System;

namespace DnTinder.Models
{
    public class Bug
    {
        public Int64 Id {get; set;}
        public String ReproductionSteps{get; set;}
        public String ExpectedBehaviour{get; set;}
        public String ObservedBehaviour{get; set;}
        

    }
}