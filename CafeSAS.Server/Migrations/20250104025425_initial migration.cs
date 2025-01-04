using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeSAS.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    ID_Admin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.ID_Admin);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    ID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.ID_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "sesion",
                columns: table => new
                {
                    ID_Sesion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraEntrada = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraBreak = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraSalidaBreak = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraSalida = table.Column<TimeSpan>(type: "time", nullable: false),
                    HorasTotales = table.Column<int>(type: "int", nullable: false),
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sesion", x => x.ID_Sesion);
                });

            migrationBuilder.CreateTable(
                name: "tienda",
                columns: table => new
                {
                    ID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdminID_Admin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Admin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tienda", x => x.ID_Tienda);
                    table.ForeignKey(
                        name: "FK_tienda_admin_AdminID_Admin",
                        column: x => x.AdminID_Admin,
                        principalTable: "admin",
                        principalColumn: "ID_Admin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    ID_Menu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriasID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.ID_Menu);
                    table.ForeignKey(
                        name: "FK_menu_categorias_CategoriasID_Categoria",
                        column: x => x.CategoriasID_Categoria,
                        principalTable: "categorias",
                        principalColumn: "ID_Categoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    ID_Producto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioCompra = table.Column<int>(type: "int", nullable: false),
                    PrecioCompraUnidad = table.Column<int>(type: "int", nullable: true),
                    PrecioVenta = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadTotal = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriasID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Categoria = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.ID_Producto);
                    table.ForeignKey(
                        name: "FK_producto_categorias_CategoriasID_Categoria",
                        column: x => x.CategoriasID_Categoria,
                        principalTable: "categorias",
                        principalColumn: "ID_Categoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caja",
                columns: table => new
                {
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Permiso = table.Column<bool>(type: "bit", nullable: false),
                    TiendaID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_caja_tienda_TiendaID_Tienda",
                        column: x => x.TiendaID_Tienda,
                        principalTable: "tienda",
                        principalColumn: "ID_Tienda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Hiredate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<int>(type: "int", nullable: false),
                    TiendaID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.ID_Empleado);
                    table.ForeignKey(
                        name: "FK_empleado_tienda_TiendaID_Tienda",
                        column: x => x.TiendaID_Tienda,
                        principalTable: "tienda",
                        principalColumn: "ID_Tienda");
                });

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Permiso = table.Column<bool>(type: "bit", nullable: false),
                    TiendaID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_inventario_tienda_TiendaID_Tienda",
                        column: x => x.TiendaID_Tienda,
                        principalTable: "tienda",
                        principalColumn: "ID_Tienda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produccion",
                columns: table => new
                {
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Permiso = table.Column<bool>(type: "bit", nullable: false),
                    TiendaID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Tienda = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_produccion_tienda_TiendaID_Tienda",
                        column: x => x.TiendaID_Tienda,
                        principalTable: "tienda",
                        principalColumn: "ID_Tienda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpleadoSesion",
                columns: table => new
                {
                    EmpleadosID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SesionsID_Sesion = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoSesion", x => new { x.EmpleadosID_Empleado, x.SesionsID_Sesion });
                    table.ForeignKey(
                        name: "FK_EmpleadoSesion_empleado_EmpleadosID_Empleado",
                        column: x => x.EmpleadosID_Empleado,
                        principalTable: "empleado",
                        principalColumn: "ID_Empleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpleadoSesion_sesion_SesionsID_Sesion",
                        column: x => x.SesionsID_Sesion,
                        principalTable: "sesion",
                        principalColumn: "ID_Sesion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    ID_Venta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    Hora = table.Column<TimeOnly>(type: "time", nullable: false),
                    EmpleadoID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Empleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta", x => x.ID_Venta);
                    table.ForeignKey(
                        name: "FK_venta_empleado_EmpleadoID_Empleado",
                        column: x => x.EmpleadoID_Empleado,
                        principalTable: "empleado",
                        principalColumn: "ID_Empleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_Venta",
                columns: table => new
                {
                    ID_DetalleVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<int>(type: "int", nullable: false),
                    VentasID_Venta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Venta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductoID_Producto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Producto = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_Venta", x => x.ID_DetalleVenta);
                    table.ForeignKey(
                        name: "FK_detalle_Venta_producto_ProductoID_Producto",
                        column: x => x.ProductoID_Producto,
                        principalTable: "producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalle_Venta_venta_VentasID_Venta",
                        column: x => x.VentasID_Venta,
                        principalTable: "venta",
                        principalColumn: "ID_Venta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_caja_TiendaID_Tienda",
                table: "caja",
                column: "TiendaID_Tienda");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_Venta_ProductoID_Producto",
                table: "detalle_Venta",
                column: "ProductoID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_Venta_VentasID_Venta",
                table: "detalle_Venta",
                column: "VentasID_Venta");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_TiendaID_Tienda",
                table: "empleado",
                column: "TiendaID_Tienda");

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoSesion_SesionsID_Sesion",
                table: "EmpleadoSesion",
                column: "SesionsID_Sesion");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_TiendaID_Tienda",
                table: "inventario",
                column: "TiendaID_Tienda");

            migrationBuilder.CreateIndex(
                name: "IX_menu_CategoriasID_Categoria",
                table: "menu",
                column: "CategoriasID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_produccion_TiendaID_Tienda",
                table: "produccion",
                column: "TiendaID_Tienda");

            migrationBuilder.CreateIndex(
                name: "IX_producto_CategoriasID_Categoria",
                table: "producto",
                column: "CategoriasID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_tienda_AdminID_Admin",
                table: "tienda",
                column: "AdminID_Admin");

            migrationBuilder.CreateIndex(
                name: "IX_venta_EmpleadoID_Empleado",
                table: "venta",
                column: "EmpleadoID_Empleado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caja");

            migrationBuilder.DropTable(
                name: "detalle_Venta");

            migrationBuilder.DropTable(
                name: "EmpleadoSesion");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "produccion");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "sesion");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "tienda");

            migrationBuilder.DropTable(
                name: "admin");
        }
    }
}
