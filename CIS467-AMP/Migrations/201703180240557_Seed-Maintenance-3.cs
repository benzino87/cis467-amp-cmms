namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMaintenance3 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MaintenanceIssueIndexes ON");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (0, 0, 0)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (1, 0, 1)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (2, 0, 2)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (3, 1, 0)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (4, 1, 1)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (5, 1, 2)");
            Sql("INSERT INTO MaintenanceIssueIndexes (Id, MaintenanceClassOfIssueId, MaintenanceIssueId) VALUES (6, 2, 2)");
            Sql("SET IDENTITY_INSERT MaintenanceIssueIndexes OFF");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrders ON");
            Sql("INSERT INTO MaintenanceWorkOrders (Id, CreatorId, CreatedDateTime, MaintenanceStatusId, LastStatusDateTime, Priority, SupervisorId, LeadWorkerId,  AssetInventoryId, JobPlanId, MaintenanceIssueId, ShortDesc, LongDesc ) " +
                "VALUES (0, 0, 02/25/2017,  0, 02/26/2017, 5, 4, 2, 0, 0, 0, 'Seal leak', 'Seal Leak - Repair')");
            Sql("INSERT INTO MaintenanceWorkOrders (Id, CreatorId, CreatedDateTime, MaintenanceStatusId, LastStatusDateTime, Priority, SupervisorId, LeadWorkerId,  AssetInventoryId, JobPlanId, MaintenanceIssueId, ShortDesc, LongDesc ) " +
                "VALUES (1, 1, 02/26/2017,  1, 02/28/2017, 5, 4, 1, 2, 1, 0, 'Seal leaker', 'Seal Leaker - Repair')");
            Sql("INSERT INTO MaintenanceWorkOrders (Id, CreatorId, CreatedDateTime, MaintenanceStatusId, LastStatusDateTime, Priority, SupervisorId, LeadWorkerId,  AssetInventoryId, JobPlanId, MaintenanceIssueId, ShortDesc, LongDesc ) " +
                "VALUES (2, 3, 02/27/2017, 3 , 02/28/2017, 5, 4, 0, 3, 2, 0, 'Seal leaked', 'Seal Leaked - Repair')");
            Sql("SET IDENTITY_INSERT MaintenanceWorkOrders OFF");
        }
        
        public override void Down()
        {
        }
    }
}
