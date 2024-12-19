using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musicshare_API.Migrations
{
    public partial class Your_MigratonName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Genre_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre_list", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Release_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Release_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    regdate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Band_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    genre = table.Column<int>(type: "int", nullable: false),
                    lang = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band_list", x => x.id);
                    table.ForeignKey(
                        name: "FK__Band_list__count__46E78A0C",
                        column: x => x.country,
                        principalTable: "Countries",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Band_list__genre__44FF419A",
                        column: x => x.genre,
                        principalTable: "Genre_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Band_list__lang__45F365D3",
                        column: x => x.lang,
                        principalTable: "Languages",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Band_members",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pseudonym = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    band_id = table.Column<int>(type: "int", nullable: true),
                    is_in_band = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Band_members", x => x.id);
                    table.ForeignKey(
                        name: "FK__Band_memb__band___534D60F1",
                        column: x => x.band_id,
                        principalTable: "Band_list",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Release_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    band = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    song_ammount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Release_list", x => x.id);
                    table.ForeignKey(
                        name: "FK__Release_l__genre__4AB81AF0",
                        column: x => x.genre,
                        principalTable: "Genre_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Release_li__band__49C3F6B7",
                        column: x => x.band,
                        principalTable: "Band_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Release_li__type__4BAC3F29",
                        column: x => x.type,
                        principalTable: "Release_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Band_members_bands",
                columns: table => new
                {
                    member_id = table.Column<int>(type: "int", nullable: false),
                    band_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Band_mem__FE73863EA405A083", x => new { x.member_id, x.band_id });
                    table.ForeignKey(
                        name: "FK__Band_memb__band___571DF1D5",
                        column: x => x.band_id,
                        principalTable: "Band_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Band_memb__membe__5629CD9C",
                        column: x => x.member_id,
                        principalTable: "Band_members",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Song_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    band = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<int>(type: "int", nullable: false),
                    song_release_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_list", x => x.id);
                    table.ForeignKey(
                        name: "FK__Song_list__band__4E88ABD4",
                        column: x => x.band,
                        principalTable: "Band_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Song_list__genre__4F7CD00D",
                        column: x => x.genre,
                        principalTable: "Genre_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Song_list__song___5070F446",
                        column: x => x.song_release_id,
                        principalTable: "Release_list",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "User_favorite",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    band_id = table.Column<int>(type: "int", nullable: false),
                    release_id = table.Column<int>(type: "int", nullable: false),
                    song_id = table.Column<int>(type: "int", nullable: false),
                    review = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User_fav__63F33842C5125F83", x => new { x.user_id, x.band_id, x.release_id, x.song_id });
                    table.ForeignKey(
                        name: "FK__User_favo__band___656C112C",
                        column: x => x.band_id,
                        principalTable: "Band_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__User_favo__relea__66603565",
                        column: x => x.release_id,
                        principalTable: "Release_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__User_favo__song___6754599E",
                        column: x => x.song_id,
                        principalTable: "Song_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__User_favo__user___6477ECF3",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Band_list_country",
                table: "Band_list",
                column: "country");

            migrationBuilder.CreateIndex(
                name: "IX_Band_list_genre",
                table: "Band_list",
                column: "genre");

            migrationBuilder.CreateIndex(
                name: "IX_Band_list_lang",
                table: "Band_list",
                column: "lang");

            migrationBuilder.CreateIndex(
                name: "IX_Band_members_band_id",
                table: "Band_members",
                column: "band_id");

            migrationBuilder.CreateIndex(
                name: "IX_Band_members_bands_band_id",
                table: "Band_members_bands",
                column: "band_id");

            migrationBuilder.CreateIndex(
                name: "IX_Release_list_band",
                table: "Release_list",
                column: "band");

            migrationBuilder.CreateIndex(
                name: "IX_Release_list_genre",
                table: "Release_list",
                column: "genre");

            migrationBuilder.CreateIndex(
                name: "IX_Release_list_type",
                table: "Release_list",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "IX_Song_list_band",
                table: "Song_list",
                column: "band");

            migrationBuilder.CreateIndex(
                name: "IX_Song_list_genre",
                table: "Song_list",
                column: "genre");

            migrationBuilder.CreateIndex(
                name: "IX_Song_list_song_release_id",
                table: "Song_list",
                column: "song_release_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_favorite_band_id",
                table: "User_favorite",
                column: "band_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_favorite_release_id",
                table: "User_favorite",
                column: "release_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_favorite_song_id",
                table: "User_favorite",
                column: "song_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Band_members_bands");

            migrationBuilder.DropTable(
                name: "User_favorite");

            migrationBuilder.DropTable(
                name: "Band_members");

            migrationBuilder.DropTable(
                name: "Song_list");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Release_list");

            migrationBuilder.DropTable(
                name: "Band_list");

            migrationBuilder.DropTable(
                name: "Release_type");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genre_list");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
