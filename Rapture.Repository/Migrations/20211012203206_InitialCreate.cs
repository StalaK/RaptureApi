using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rapture.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Raptures",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Predictor = table.Column<string>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: false),
                    WhoGotRaptured = table.Column<string>(type: "TEXT", nullable: true, defaultValue: ""),
                    MonthOnly = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    YearOnly = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raptures", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 1, "Predicted the world would end this year", "Tynnetta Muhammad", new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 76, "The world ends with the arrival of 16 million space ships and a host of angels.", "Sheldan Nidle", new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 75, "Camping's fourth rapture prediction, following the failure of his previous three.", "Harold Camping", new DateTime(1995, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 74, "Camping's third rapture prediction, following the failure of his previous two.", "Harold Camping", new DateTime(1994, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 73, "Camping's next rapture predicting, following the failure of his first.", "Harold Camping", new DateTime(1994, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 72, "Camping predicted the rapture would take place.", "Harold Camping", new DateTime(1994, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 71, "New York City would be destroyed by a nuclear bomb on the 23rd of March 1994, with the Battle of Armageddon taking place on the 2nd of May 1994.", "Neal Chase", new DateTime(1994, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 70, "The Second Coming takes place this year", "David Berg", new DateTime(1993, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 69, "The rapture occurs on this day", "Lee Jang Rim", new DateTime(1992, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 68, "The rapture begins", "Rollen Stewart", new DateTime(1992, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 67, "The Gulf War would be the War of Armageddon which is the final war", "Louis Farrakhan", new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 77, "A spacecraft was trailing the Hale-Bopp comet and suicide was the only way to evacuate Earth the souls could board the spacecraft and be taken to a level of exitence above human.", "Marshall Applewhite", new DateTime(1997, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "38 of Applewhite's followers commited suicide. It's unknown as to whether or not their souls reached the spacecraft." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 66, "The Messiah would arrive at the start of the Jewish New Year", "Menachem Mendel Schneerson", new DateTime(1991, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 64, "Whisenant's revised prediction of the rapture of the Christian Church, following the failed September prediction.", "Edgar C. Whisenant", new DateTime(1988, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 63, "Rapture of the Christian Church.", "Edgar C. Whisenant", new DateTime(1988, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 62, "Predicted that Halley's Comet would be pulled into Earth's orbit.", "Leland Jensen", new DateTime(1986, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 61, "Predicted the world ends in 1985.", "Lester Sumrall", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 60, "Predicted the world would end this year on his 700 Club TV programme.", "Pat Robertson", new DateTime(1982, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 59, "Placed advertisements in the Los Angeles Times stating that the second coming would occur in June with the Maitreya (World Teacher) announcing it on worldwide TV.", "Benjamin Creme", new DateTime(1982, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 58, "Declared \"Christ is now here!\" in newspaper advertisements and claimed he would make himself known \"within the next two months \"", true, "Tara Centers", new DateTime(1982, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 57, "Believed the gravitational force of the aligned planets would cause a number of catastrophes, including earthquakes across the San Andreas Fault.", "John Gribbin, Stephen Plagemann", new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 56, "The generation of 1948 is the last generation and the world ends in 1981.", "Chuck Smith", new DateTime(1981, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 55, "Nuclear disaster, followed by two decades of conflict culminating in God's Kingdom being established on Earth.", "Leland Jensen", new DateTime(1980, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 65, "A nuclear war starts on this day and lasts for 12 years.", "Elizabeth Clare Prophet", new DateTime(1990, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 54, "Led a commune into the Quebec wilderness to form a new society during God's 1000 year reign followed by Armageddon.", "Roch Thériault", new DateTime(1979, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 78, "This date is 6000 years since the creation, and therefore the end of the world.", "James Ussher", new DateTime(1997, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 80, "A King of Terror would come from the sky in \"1999 and seven months\".", true, "Nostradamus", new DateTime(1999, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 102, "The birth date of the Antichrist and the end of the universe.", "Aggai", new DateTime(1997, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 101, "Whisenant's revised prediction of the rapture of the Christian Church, following failure of his two previous predictions.", "Edgar C. Whisenant", new DateTime(1989, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 100, "Armageddon would heppen unless 144,000 people gathered in specifc places on Earth and meditated at the same time, which became known as Harmonic Convergence.", "José Argüelles", new DateTime(1987, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 99, "Christ's 1000 year reign would begin in the year 2000", "Jonathan Edwards", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 98, "Predicted the end of the world in his book \"I Predict 2000\"", "Lester Sumrall", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 97, "Predicted the end of the world in his book \"The End: Why Jesus Could Return by A.D. 2000\"", "Ed Dobson", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 96, "The Kingdom of Heaven would be established in 2000", "Sun Myung Moon", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 95, "The Second Coming would occur in the year 2000", "Edgar Cayce", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 94, "The Earth's axis would shift and the Antichrist would reveal himself", "Ruth Montgomery", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 93, "The planetary lineup would cause a \"star holocaust\", pulling all the planets into the sun.", "Nuwaubian Nation", new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 79, "God will arrive at Earth at 10am on this date in a flying saucer.", "Hon-Ming Chen", new DateTime(1998, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 92, "The Second Coming of Christ occurs on this day", "James Harmston", new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 90, "The Y2K bug would trigger global economic chaos, causing the Antichrist to rise to power. They changed their minds about this prediction as the date drew closer.", "Tim LaHaye & Jerry B. Jenkins", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 89, "God pours his judgment upon the world", "Jerry Falwell", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 88, "Apocalypse", "Movement for the Restoration of the Ten Commandments of God", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody, but 778 followers of this movement died in a fire and a series of poisonings and killings, either as a form of group suicide or orchestrated mass murder by the group leaders after the failed prediction." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 87, "The last judgment would occur before 2000.", "Nazim Al-Haqqani", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 86, "Christ's Millennium starting by 2000.", "Timothy Dwight IV", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 85, "The great tribulation would begin before 2000.", "James Gordon Lindsay", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 84, "A nuclear holocaust would destroy Europe and Asia.", "Hon-Ming Chen", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 83, "The world would end this year, maybe by nuclear devastation, asteroid impact, pole shift or other Earth changes.", "Charles Berlitz", new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 82, "A ball of fire will descend, destroying almost all of mankind, all vegetation and all forms of life.", "Philip Berg", new DateTime(1999, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 81, "This psychic, well known for predictions, predicted the end of the world on this date", "The Amazing Criswell", new DateTime(1999, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 91, "The Y2K bug would crash many computers at midnight on the 1st of January, causing malfuntions which lead to major catastrophies worldwide, causing society to stop functioning.", "Various", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody, but there were some reported malfunctions with some technologies." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 53, "Armageddon occurs no later than 1977.", "William M. Branham", new DateTime(1977, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 52, "Armageddon.", "John Wroe", new DateTime(1977, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 51, "Armageddon where Brahma Kumari leaders will be purified whilst the rest of the world is killed by nuclear or civil wars, sinking all continents except India.", "Brahma Kumaris", new DateTime(1976, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "YearOnly" },
                values: new object[] { 23, "The messiah will come within 6000 years of the creation of Adam, with the destruction of the world happening 1000 years later.", "Talmud, Orthodox Judaism", new DateTime(3239, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2239, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "YearOnly" },
                values: new object[] { 22, "An abjad interpretation of a hadith expects the world's end to occur in 2129.", "Said Nursî", new DateTime(2129, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2129, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "YearOnly" },
                values: new object[] { 21, "The world ends due to an asteroid colliding with Earth", "Messiah Foundation International", new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "YearOnly" },
                values: new object[] { 20, "Second coming of Jesus, with the rapture being in 2021 at the latest.", "F. Kenton Beshore", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "YearOnly" },
                values: new object[] { 19, "Armageddon takes place.", "Jeane Dixon", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 18, "Jesus returns.", "Ronald Weinland", new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 17, "The rapture takes place and the world ends.", "David Meade", new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 16, "Nibiru would become visible in the sky and soon destroy the Earth.", "David Meade", new DateTime(2017, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 15, "The Blood Moon Prophecy. The tetrad (four lunar eclipses over two years) represents the beginning of the Messianic End Times.", true, "John Hagee & Mark Biltz", new DateTime(2015, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 14, "A storm would take place and fire destroys most life on land. Jesus returns to comfort those in distress.", "Grigori Rasputin", new DateTime(2013, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "YearOnly" },
                values: new object[] { 24, "Predicts the world will end this year following reaseach of the Qu'ran.", "Rashad Khalifa", new DateTime(2280, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2280, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 13, "The end of the Mesoamerican Long Count Calendar (Mayan Calendar). Predicted apocalypses include: the earth being destroyed by the asteroid Nibiru or some other interplanetary object, an alien invation or a supernova.", "Various", new DateTime(2012, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 11, "Revised date of Jesus' return following his failed 2011 prediction", "Ronald Weinland", new DateTime(2012, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 10, "Rapture and end of the world following the spiritual judgment in May", "Harold Camping", new DateTime(2011, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 9, "Jesus returns", "Ronald Weinland", new DateTime(2011, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 8, "Spiritual judgment and devastating earthquakes", "Harold Camping", new DateTime(2011, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 7, "Predicted the world would end.", "Hermetic Order of the Golden Dawn", new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 6, "Apocalypse. 31 Adults and 4 children hid in a cave to escape it. Kuznetsov was not one of them.", true, "Pyotr Kuznetsov", new DateTime(2008, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 adults died in the cave. Kuznetsov was committed." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 5, "Predicted the Earth's destruction in his book The New Millennium.", "Pat Robertson", new DateTime(2007, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 4, "World is destroyed by nuclear war beginning 12th of September 2006.", "House of Yahweh", new DateTime(2006, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 3, "World is destroyed by nuclear war.", "Aum Shinrikyo", new DateTime(2003, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 2, "Aliens in the Zeta Reticuli star system sent Lieder messages via a brain implant that a planet would enter the solar system and cause a pole shift.", "Nancy Lieder", new DateTime(2003, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody" });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 12, "The world's governments and economies collapse and followers of Luis de Jesús would undergo a transformation to be able to fly and walk through walls", "José Luis de Jesús", new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody. No reported supernatural abilities." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 25, "Jesus would return before the last of the 12 founding members of the church died. The last member died in 1901.", "Catholic Apostolic Church", new DateTime(1901, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1901, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 26, "Apocalypse", "Michael Paget Baxter", new DateTime(1908, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1908, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 27, "Halleys Comet would destroy all life on the planet. Comet Pills were sold to prevent against toxic gasses.", "Camille Flammarion", new DateTime(1910, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1910, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 50, "1975 is 6000 years since the creation of man and the end of the armageddon.", "Jehovah's Witnesses", new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 49, "The third and final revision of Armstrong's predicted Rapture.", "Herbert W. Armstrong", new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 48, "Doomsday heralded by Comet Kohoutek", true, "David Berg", new DateTime(1974, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1974, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 47, "The second revised date after his 1943 prediction failed.", "Herbert W. Armstrong", new DateTime(1972, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 46, "Helter Skelter, an apocalyptic race war, occurs.", "Charles Manson", new DateTime(1969, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody outside of the Manson Family murders." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 45, "The Second Coming of Christ occurs on this day", "George Williams", new DateTime(1969, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 44, "Nuclear holocaust would happen this year", "Jim Jones", new DateTime(1967, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 43, "Van Tassel channeled an alien named Ashtar who told him the third woe of the Apocalypse begins where the southeastern US is destroyed in a Soviet nuclear attack.", "George Van Tassel", new DateTime(1967, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 42, "A planetary alignment will bring destruction to the world.", "Jeane Dixon", new DateTime(1962, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1962, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody, but mass prayer meetings were held in India." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 41, "The second prophet of the Branch Davidians predicted the apocalypse foretold in the Book of Revelation occurrs on this date.", "Florence Houteff", new DateTime(1959, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody, but the Branch Davidians split into several subsects." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 40, "The world is destroyed by flooding", "Dorothy Martin", new DateTime(1954, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1954, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 39, "The destruction of all nations and the beginning of post-apocalyptic anarchy", "John Ballou Newbrough", new DateTime(1947, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1947, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 38, "Revised date of the previous rapture.", "Herbert W. Armstrong", new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1943, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 37, "Prediction of the end", "Jehovah's Witnesses", new DateTime(1941, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1941, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 36, "Rapture.", "Herbert W. Armstrong", new DateTime(1936, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1936, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 35, "The world is going to go puff and disappear", true, "Wilbur Glenn Voliva", new DateTime(1935, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1935, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 34, "The world is growing near apocalypse due to rampant immorality in Europe.", "Spencer Perceval", new DateTime(1926, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1926, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 33, "The angel Gabriel appeared before Rowen and told her that the world would end at midnight on this date.", "Margaret Rowen", new DateTime(1925, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1925, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 32, "God destroys churches and church members by the millions. Governments disappear with anarchy prevailing.", true, "International Bible Students Association", new DateTime(1920, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1920, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 31, "Christendom shall be cut off and glorification of the Little Flock (The Church) in the Spring of 1918", true, "International Bible Students Association", new DateTime(1918, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1918, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 30, "Predicted the Millennium would begin this year", "John Chilembwe", new DateTime(1915, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1915, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "MonthOnly", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 29, "The close of the battle of the great day of God Almighty.", true, "Charles Taze Russell", new DateTime(1914, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1874, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 28, "Predicted the Second Coming, based off of the dimensions of the Great Pyramid of Giza.", "Charles Piazzi Smyth", new DateTime(1911, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1911, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured" },
                values: new object[] { 103, "God will arrive at Earth at 10am on this date in a flying saucer.", "Hon-Ming Chen", new DateTime(1998, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody." });

            migrationBuilder.InsertData(
                table: "Raptures",
                columns: new[] { "ID", "Details", "Predictor", "EndDate", "StartDate", "WhoGotRaptured", "YearOnly" },
                values: new object[] { 104, "The Antichrist who came to power between 1300 and 1340 would perform the Last Judgment in 2000", "Peter Olivi", new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobody.", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Raptures");
        }
    }
}
