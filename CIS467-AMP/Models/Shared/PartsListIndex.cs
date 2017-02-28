﻿namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Parts list index - indexes parts to a particular variant
    /// 
    /// PartListID - Id for entry
    /// partID - ID of part
    /// VariantID - ID of asset Variant
    /// </summary>
    public class PartsListIndex
    {
        public int Id { get; set; }
        public Part Part { get; set; }
        public Variant Variant { get; set; }
    }
}