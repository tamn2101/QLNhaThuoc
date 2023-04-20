namespace QLNhaThuoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DuocMyPhams",
                c => new
                    {
                        MaDMP = c.Int(nullable: false, identity: true),
                        TenDMP = c.String(maxLength: 255),
                        Hinh = c.String(maxLength: 200),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonViTinh = c.String(),
                        MaKhuVuc = c.Int(nullable: false),
                        XuatXu = c.String(),
                        CongDung = c.String(),
                    })
                .PrimaryKey(t => t.MaDMP)
                .ForeignKey("dbo.KhuVucLuuTrus", t => t.MaKhuVuc, cascadeDelete: true)
                .Index(t => t.MaKhuVuc);
            
            CreateTable(
                "dbo.KhuVucLuuTrus",
                c => new
                    {
                        MaKhuVuc = c.Int(nullable: false, identity: true),
                        TenKhuVuc = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.MaKhuVuc);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.ThietBiYTes",
                c => new
                    {
                        MaThietBi = c.Int(nullable: false, identity: true),
                        TenThietBi = c.String(maxLength: 255),
                        Hinh = c.String(maxLength: 200),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonViTinh = c.String(),
                        MaKhuVuc = c.Int(nullable: false),
                        XuatXu = c.String(),
                        CongDung = c.String(),
                    })
                .PrimaryKey(t => t.MaThietBi)
                .ForeignKey("dbo.KhuVucLuuTrus", t => t.MaKhuVuc, cascadeDelete: true)
                .Index(t => t.MaKhuVuc);
            
            CreateTable(
                "dbo.ThucPhamChucNangs",
                c => new
                    {
                        MaThucPham = c.Int(nullable: false, identity: true),
                        TenThucPham = c.String(maxLength: 255),
                        Hinh = c.String(maxLength: 200),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonViTinh = c.String(),
                        MaKhuVuc = c.Int(nullable: false),
                        XuatXu = c.String(),
                        CongDung = c.String(),
                    })
                .PrimaryKey(t => t.MaThucPham)
                .ForeignKey("dbo.KhuVucLuuTrus", t => t.MaKhuVuc, cascadeDelete: true)
                .Index(t => t.MaKhuVuc);
            
            CreateTable(
                "dbo.Thuocs",
                c => new
                    {
                        MaThuoc = c.Int(nullable: false, identity: true),
                        TenThuoc = c.String(maxLength: 255),
                        Hinh = c.String(maxLength: 200),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonViTinh = c.String(),
                        MaKhuVuc = c.Int(nullable: false),
                        CongDung = c.String(),
                    })
                .PrimaryKey(t => t.MaThuoc)
                .ForeignKey("dbo.KhuVucLuuTrus", t => t.MaKhuVuc, cascadeDelete: true)
                .Index(t => t.MaKhuVuc);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 255),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Thuocs", "MaKhuVuc", "dbo.KhuVucLuuTrus");
            DropForeignKey("dbo.ThucPhamChucNangs", "MaKhuVuc", "dbo.KhuVucLuuTrus");
            DropForeignKey("dbo.ThietBiYTes", "MaKhuVuc", "dbo.KhuVucLuuTrus");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.DuocMyPhams", "MaKhuVuc", "dbo.KhuVucLuuTrus");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Thuocs", new[] { "MaKhuVuc" });
            DropIndex("dbo.ThucPhamChucNangs", new[] { "MaKhuVuc" });
            DropIndex("dbo.ThietBiYTes", new[] { "MaKhuVuc" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.DuocMyPhams", new[] { "MaKhuVuc" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Thuocs");
            DropTable("dbo.ThucPhamChucNangs");
            DropTable("dbo.ThietBiYTes");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.KhuVucLuuTrus");
            DropTable("dbo.DuocMyPhams");
        }
    }
}
