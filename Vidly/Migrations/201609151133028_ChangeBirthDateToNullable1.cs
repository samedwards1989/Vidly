namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ChangeBirthDateToNullable1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: true));
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
