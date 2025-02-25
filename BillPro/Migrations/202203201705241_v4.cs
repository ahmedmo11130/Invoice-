﻿namespace BillPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "percentageDiscount", c => c.String());
            AlterColumn("dbo.Invoices", "valueDiscount", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoices", "valueDiscount", c => c.Double(nullable: false));
            AlterColumn("dbo.Invoices", "percentageDiscount", c => c.Double(nullable: false));
        }
    }
}
