using Microsoft.EntityFrameworkCore.Migrations;

namespace ToysManufacturingCompany.Migrations
{
    public partial class getaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE getAddress
                        @AddressId int
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                        SELECT * FROM Addresses WHERE AddressId=@AddressId
                    END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
