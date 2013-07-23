namespace GiveIT.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class volunteer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Charity", "Id", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.UserProfile", "Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.UserProfile", "ConfirmPassword", c => c.String(nullable: false));
            AddColumn("dbo.UserProfile", "StreetAddress", c => c.String(maxLength: 80));
            AddColumn("dbo.UserProfile", "StreetAddress2", c => c.String(maxLength: 80));
            AddColumn("dbo.UserProfile", "City", c => c.String(maxLength: 30));
            AddColumn("dbo.UserProfile", "State", c => c.String(maxLength: 20));
            AddColumn("dbo.UserProfile", "ZipCode", c => c.String(maxLength: 10));
            AddColumn("dbo.UserProfile", "ConfirmEmailAddress", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.UserProfile", "VolunteerHours", c => c.Int());
            AddColumn("dbo.UserProfile", "SkillSet", c => c.String(maxLength: 200));
            AddColumn("dbo.UserProfile", "Discriminator", c => c.String(maxLength: 128));
            AlterColumn("dbo.Charity", "CharityName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Charity", "EIN", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.UserProfile", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.UserProfile", "ContactFirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.UserProfile", "ContactLastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.UserProfile", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.UserProfile", "EmailAddress", c => c.String(nullable: false, maxLength: 100));
            DropPrimaryKey("dbo.Charity", new[] { "CharityId" });
            AddPrimaryKey("dbo.Charity", "Id");
            DropPrimaryKey("dbo.UserProfile", new[] { "UserId" });
            AddPrimaryKey("dbo.UserProfile", "Id");
            AddForeignKey("dbo.Charity", "Id", "dbo.UserProfile", "Id");
            CreateIndex("dbo.Charity", "Id");
            DropColumn("dbo.Charity", "CharityId");
            DropColumn("dbo.Charity", "StreetAddress");
            DropColumn("dbo.Charity", "StreetAddress2");
            DropColumn("dbo.Charity", "City");
            DropColumn("dbo.Charity", "State");
            DropColumn("dbo.Charity", "ZipCode");
            DropColumn("dbo.UserProfile", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "UserId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Charity", "ZipCode", c => c.String(maxLength: 10));
            AddColumn("dbo.Charity", "State", c => c.String(maxLength: 20));
            AddColumn("dbo.Charity", "City", c => c.String(maxLength: 30));
            AddColumn("dbo.Charity", "StreetAddress2", c => c.String(maxLength: 80));
            AddColumn("dbo.Charity", "StreetAddress", c => c.String(maxLength: 80));
            AddColumn("dbo.Charity", "CharityId", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.Charity", new[] { "Id" });
            DropForeignKey("dbo.Charity", "Id", "dbo.UserProfile");
            DropPrimaryKey("dbo.UserProfile", new[] { "Id" });
            AddPrimaryKey("dbo.UserProfile", "UserId");
            DropPrimaryKey("dbo.Charity", new[] { "Id" });
            AddPrimaryKey("dbo.Charity", "CharityId");
            AlterColumn("dbo.UserProfile", "EmailAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserProfile", "PhoneNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.UserProfile", "ContactLastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.UserProfile", "ContactFirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.UserProfile", "UserName", c => c.String());
            AlterColumn("dbo.Charity", "EIN", c => c.String(maxLength: 10));
            AlterColumn("dbo.Charity", "CharityName", c => c.String(maxLength: 100));
            DropColumn("dbo.UserProfile", "Discriminator");
            DropColumn("dbo.UserProfile", "SkillSet");
            DropColumn("dbo.UserProfile", "VolunteerHours");
            DropColumn("dbo.UserProfile", "ConfirmEmailAddress");
            DropColumn("dbo.UserProfile", "ZipCode");
            DropColumn("dbo.UserProfile", "State");
            DropColumn("dbo.UserProfile", "City");
            DropColumn("dbo.UserProfile", "StreetAddress2");
            DropColumn("dbo.UserProfile", "StreetAddress");
            DropColumn("dbo.UserProfile", "ConfirmPassword");
            DropColumn("dbo.UserProfile", "Password");
            DropColumn("dbo.UserProfile", "Id");
            DropColumn("dbo.Charity", "Id");
        }
    }
}
