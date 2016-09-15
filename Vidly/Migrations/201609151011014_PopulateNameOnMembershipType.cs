namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateNameOnMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Pay as You Go' where Id = 1");
            Sql("update MembershipTypes set Name = 'Monthly' where Id = 2");
            Sql("update MembershipTypes set Name = 'Quaterly' where Id = 3");
            Sql("update MembershipTypes set Name = 'Annualy' where Id = 4");
        }

        public override void Down()
        {
        }
    }
}
