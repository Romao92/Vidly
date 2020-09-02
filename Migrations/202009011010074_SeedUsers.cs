namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'67240a31-8a50-4d37-ab7c-8c4bb290c6db', N'romain_duval@hotmail.com', 0, N'AF9/TUqMztrLHaxY8tQT8TA6ODBgP6P+yVajb17GgB1GB3264xH3o5YHIwFA6OVawA==', N'859bcc57-a39a-41df-b803-f38f6071e0d0', NULL, 0, 0, NULL, 1, 0, N'romain_duval@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'add77567-3587-47b0-9e3b-0de84c84690e', N'guest@vidly.com', 0, N'AEP59hnNwF8D4nV+/NJTCVamr5rM5axaZ17Vp1N6TcEPeWdjrko/hh/vI2ZRD2gLyg==', N'3119359e-eaf8-4ba2-b7f4-8fecb88b155b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ec28eb75-d7da-4fcf-86b6-2477ab58ab8b', N'admin@vidly.com', 0, N'AJej3899pfBmDU29uDao2dO6hmucbfLiQ5RTFsoMlNTQdYhhU3rAtaqao5tWRQrJhw==', N'4ca020e2-9396-4752-bd45-a2837b89ad62', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8f5ebded-f314-4ccb-a5ce-434bf3994642', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ec28eb75-d7da-4fcf-86b6-2477ab58ab8b', N'8f5ebded-f314-4ccb-a5ce-434bf3994642')

");
        }
        
        public override void Down()
        {
        }
    }
}
