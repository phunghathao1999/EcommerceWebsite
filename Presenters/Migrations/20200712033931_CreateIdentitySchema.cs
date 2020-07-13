using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Presenters.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cart",
                columns: table => new
                {
                    IDcart = table.Column<string>(nullable: false),
                    createday = table.Column<DateTime>(type: "date", nullable: true),
                    totalprice = table.Column<decimal>(type: "money", nullable: true),
                    IDaccount = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cart__4581138DCE425A7E", x => x.IDcart);
                });

            migrationBuilder.CreateTable(
                name: "classify",
                columns: table => new
                {
                    IDclassify = table.Column<string>(nullable: false),
                    nameclassify = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__classify__1FB14F2BD4F85462", x => x.IDclassify);
                });

            migrationBuilder.CreateTable(
                name: "complain",
                columns: table => new
                {
                    IDcomplain = table.Column<string>(nullable: false),
                    IDaccount = table.Column<string>(maxLength: 450, nullable: true),
                    IDcartdetail = table.Column<string>(maxLength: 450, nullable: true),
                    createday = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__complain__9289DDF5FBC9B005", x => x.IDcomplain);
                });

            migrationBuilder.CreateTable(
                name: "notification",
                columns: table => new
                {
                    IDnotification = table.Column<string>(nullable: false),
                    IDaccount = table.Column<int>(nullable: true),
                    content = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__notifica__36098EECB40032C1", x => x.IDnotification);
                });

            migrationBuilder.CreateTable(
                name: "promotion",
                columns: table => new
                {
                    IDpromotion = table.Column<string>(nullable: false),
                    content = table.Column<string>(maxLength: 255, nullable: true),
                    linkIMG = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    status = table.Column<string>(maxLength: 50, nullable: true),
                    createday = table.Column<DateTime>(type: "date", nullable: true),
                    linkimgpromotion = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    IDlaptop = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__promotio__53DC425E87CDD7D3", x => x.IDpromotion);
                });

            migrationBuilder.CreateTable(
                name: "trademark",
                columns: table => new
                {
                    IDtrademark = table.Column<string>(nullable: false),
                    trademark = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__trademar__9120D53811A52407", x => x.IDtrademark);
                });

            migrationBuilder.CreateTable(
                name: "userinformation",
                columns: table => new
                {
                    IdUser = table.Column<string>(nullable: false),
                    NameUser = table.Column<string>(maxLength: 255, nullable: true),
                    gender = table.Column<string>(maxLength: 50, nullable: true),
                    address = table.Column<string>(maxLength: 255, nullable: true),
                    numberphone = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userinfo__B7C926384607B758", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cartdetail",
                columns: table => new
                {
                    IDcartdetail = table.Column<string>(nullable: false),
                    IDcart = table.Column<string>(maxLength: 450, nullable: true),
                    IDproduct = table.Column<string>(maxLength: 450, nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    price = table.Column<decimal>(type: "money", nullable: true),
                    note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cartdeta__6431700507C70DC7", x => x.IDcartdetail);
                    table.ForeignKey(
                        name: "FK__cartdetai__IDcar__7F2BE32F",
                        column: x => x.IDcart,
                        principalTable: "cart",
                        principalColumn: "IDcart",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "laptop",
                columns: table => new
                {
                    IDlaptop = table.Column<string>(nullable: false),
                    namelaptop = table.Column<string>(maxLength: 255, nullable: true),
                    description = table.Column<string>(maxLength: 255, nullable: true),
                    price = table.Column<decimal>(type: "money", nullable: true),
                    linkIMG = table.Column<string>(unicode: false, fixedLength: true, maxLength: 255, nullable: true),
                    count = table.Column<int>(nullable: true),
                    IDclassify = table.Column<string>(maxLength: 450, nullable: true),
                    IDtrademark = table.Column<string>(maxLength: 450, nullable: true),
                    status = table.Column<string>(maxLength: 50, nullable: true),
                    priceselling = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__laptop__F8074072FBDEE2CC", x => x.IDlaptop);
                    table.ForeignKey(
                        name: "FK__laptop__IDclassi__7D439ABD",
                        column: x => x.IDclassify,
                        principalTable: "classify",
                        principalColumn: "IDclassify",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__laptop__IDtradem__7E37BEF6",
                        column: x => x.IDtrademark,
                        principalTable: "trademark",
                        principalColumn: "IDtrademark",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_cartdetail_IDcart",
                table: "cartdetail",
                column: "IDcart");

            migrationBuilder.CreateIndex(
                name: "IX_laptop_IDclassify",
                table: "laptop",
                column: "IDclassify");

            migrationBuilder.CreateIndex(
                name: "IX_laptop_IDtrademark",
                table: "laptop",
                column: "IDtrademark");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "cartdetail");

            migrationBuilder.DropTable(
                name: "complain");

            migrationBuilder.DropTable(
                name: "laptop");

            migrationBuilder.DropTable(
                name: "notification");

            migrationBuilder.DropTable(
                name: "promotion");

            migrationBuilder.DropTable(
                name: "userinformation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropTable(
                name: "classify");

            migrationBuilder.DropTable(
                name: "trademark");
        }
    }
}
