using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "John", "Jackson" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Jesse", "Cailari" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DateOfBirth", "DoctorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Vlad", "Zahriichuk" },
                    { 2, new DateTime(2003, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vitalii", "Havryliuk" },
                    { 3, new DateTime(2000, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nyx", "Ting" },
                    { 4, new DateTime(1995, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Andrii", "Vytak" },
                    { 5, new DateTime(1990, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bohdan", "Balytskii" }
                });

            migrationBuilder.InsertData(
                table: "SicknessHistories",
                columns: new[] { "Id", "Date", "Description", "DoctorId", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "Headache", 2, 1 },
                    { 2, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), "Tsyroz", 1, 2 },
                    { 3, new DateTime(2022, 7, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "Strange thing", 2, 3 },
                    { 4, new DateTime(2022, 11, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), "Insomnia", 2, 4 },
                    { 5, new DateTime(2022, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), "Broken arm", 1, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SicknessHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SicknessHistories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SicknessHistories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SicknessHistories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SicknessHistories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
