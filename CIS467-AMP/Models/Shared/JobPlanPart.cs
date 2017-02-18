﻿namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Listing of parts for specific job plan
    /// 
    /// JobPlanIndexID - ID for entry
    /// JobPlanID - id of job plan
    /// PartID - part ID for part required
    /// </summary>
    public class JobPlanPart
    {
        public int Id { get; set; }
        public JobPlan JobPlanId { get; set; }
        public Part PartId { get; set; }

    }
}