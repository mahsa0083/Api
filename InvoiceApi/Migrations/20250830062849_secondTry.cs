using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApi.Migrations
{
    /// <inheritdoc />
    public partial class secondTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceItems_invoices_Id",
                table: "invoiceItems");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "invoiceItems",
                newName: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceItems_invoices_ItemId",
                table: "invoiceItems",
                column: "ItemId",
                principalTable: "invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceItems_invoices_ItemId",
                table: "invoiceItems");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "invoiceItems",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceItems_invoices_Id",
                table: "invoiceItems",
                column: "Id",
                principalTable: "invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
