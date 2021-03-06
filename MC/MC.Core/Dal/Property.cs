
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MC.Core.Dal
{

using System;
    using System.Collections.Generic;
    
public partial class Property
{

    public Property()
    {

        this.PropertyRates = new HashSet<PropertyRate>();

    }


    public System.Guid Id { get; set; }

    public string Name { get; set; }

    public Nullable<double> Latitude { get; set; }

    public Nullable<double> Longitude { get; set; }

    public System.Guid ClientId { get; set; }



    public virtual Client Client { get; set; }

    public virtual ICollection<PropertyRate> PropertyRates { get; set; }

}

}
