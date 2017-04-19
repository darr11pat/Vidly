namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'21a1b2df-57c6-4a2f-99fa-b5e1ce3308d2', N'admin@vidly.com', 0, N'ANd4oqtY9hbPMFyWfPZhtSwHyQOIzSr3EFV4hpfqgJXjtIbIOTZ+Bv+ctyvxI86+/A==', N'3bc57678-d491-4558-8a8c-26415c18a0b3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'506965a4-9848-4bd5-9bbe-8a7045254118', N'guest@vidly.com', 0, N'AIjsgcFVxWoLmTTrEGRDTZSsytp8/gZyXDx77yryu9+SYjA8vtVSwhX8oHnIxa/i2w==', N'f86a8be1-c5dc-42d6-a391-6ba8c0f5a123', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'684cac63-5352-4899-92c4-485cb702aaed', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'21a1b2df-57c6-4a2f-99fa-b5e1ce3308d2', N'684cac63-5352-4899-92c4-485cb702aaed')

             ");
        }
        
        public override void Down()
        {
            
        }
    }
}
