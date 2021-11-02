﻿namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Taikhoan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        Tendangnhap = c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false),
                        Matkhau = c.String(),
                    })
                .PrimaryKey(t => t.Tendangnhap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaiKhoans");
        }
    }
}
