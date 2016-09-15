namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
