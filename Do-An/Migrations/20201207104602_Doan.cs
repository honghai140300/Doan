using Microsoft.EntityFrameworkCore.Migrations;

namespace Do_An.Migrations
{
    public partial class Doan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    IdCTHD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHoaDon = table.Column<int>(nullable: false),
                    idSanPham = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.IdCTHD);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IdHoaDon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(nullable: false),
                    NgayLap = table.Column<int>(nullable: false),
                    TongTien = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdHoaDon);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    IdLoaiSp = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.IdLoaiSp);
                });

            migrationBuilder.CreateTable(
                name: "LoaiUser",
                columns: table => new
                {
                    idLoaiUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiUser", x => x.idLoaiUser);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    IdSanPham = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLoaiSp = table.Column<int>(nullable: false),
                    TenSanPham = table.Column<string>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiaNhap = table.Column<float>(nullable: false),
                    GiaBan = table.Column<float>(nullable: false),
                    Mota = table.Column<string>(maxLength: 100, nullable: false),
                    HinhAnh = table.Column<string>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    LoaiSanPhamIdLoaiSp = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSanPhamIdLoaiSp",
                        column: x => x.LoaiSanPhamIdLoaiSp,
                        principalTable: "LoaiSanPham",
                        principalColumn: "IdLoaiSp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    PassWord = table.Column<string>(maxLength: 12, nullable: false),
                    AnhDaiDien = table.Column<string>(nullable: false),
                    MoTa = table.Column<string>(maxLength: 50, nullable: true),
                    NgayLap = table.Column<int>(nullable: false),
                    IdLoaiUser = table.Column<int>(nullable: false),
                    LoaiUseridLoaiUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_User_LoaiUser_LoaiUseridLoaiUser",
                        column: x => x.LoaiUseridLoaiUser,
                        principalTable: "LoaiUser",
                        principalColumn: "idLoaiUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamIdLoaiSp",
                table: "SanPham",
                column: "LoaiSanPhamIdLoaiSp");

            migrationBuilder.CreateIndex(
                name: "IX_User_LoaiUseridLoaiUser",
                table: "User",
                column: "LoaiUseridLoaiUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "LoaiUser");
        }
    }
}
