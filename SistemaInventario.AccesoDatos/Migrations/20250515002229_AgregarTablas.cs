using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodegaProducto_Bodegas_BodegaId",
                table: "BodegaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaProducto_Producto_ProductoId",
                table: "BodegaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompra_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompra_Producto_ProductoId",
                table: "CarroCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compania_AspNetUsers_ActualizadoPorId",
                table: "Compania");

            migrationBuilder.DropForeignKey(
                name: "FK_Compania_AspNetUsers_CreadoPorId",
                table: "Compania");

            migrationBuilder.DropForeignKey(
                name: "FK_Compania_Bodegas_BodegaVentaId",
                table: "Compania");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_AspNetUsers_UsuarioAplicacionId",
                table: "Inventario");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_Bodegas_BodegaId",
                table: "Inventario");

            migrationBuilder.DropForeignKey(
                name: "FK_InventarioDetalle_Inventario_InventarioId",
                table: "InventarioDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_InventarioDetalle_Producto_ProductoId",
                table: "InventarioDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_KardexInventario_AspNetUsers_UsuarioAplicacionId",
                table: "KardexInventario");

            migrationBuilder.DropForeignKey(
                name: "FK_KardexInventario_BodegaProducto_BodegaProductoId",
                table: "KardexInventario");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_AspNetUsers_UsuarioAplicacionId",
                table: "Orden");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalle_Orden_OrdenId",
                table: "OrdenDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalle_Producto_ProductoId",
                table: "OrdenDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_CategoriaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Marca_MarcaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Producto_PadreId",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenDetalle",
                table: "OrdenDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orden",
                table: "Orden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marca",
                table: "Marca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KardexInventario",
                table: "KardexInventario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventarioDetalle",
                table: "InventarioDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventario",
                table: "Inventario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compania",
                table: "Compania");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarroCompra",
                table: "CarroCompra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodegaProducto",
                table: "BodegaProducto");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "OrdenDetalle",
                newName: "OrdenDetalles");

            migrationBuilder.RenameTable(
                name: "Orden",
                newName: "Ordenes");

            migrationBuilder.RenameTable(
                name: "Marca",
                newName: "Marcas");

            migrationBuilder.RenameTable(
                name: "KardexInventario",
                newName: "KardexInventarios");

            migrationBuilder.RenameTable(
                name: "InventarioDetalle",
                newName: "InventarioDetalles");

            migrationBuilder.RenameTable(
                name: "Inventario",
                newName: "Inventarios");

            migrationBuilder.RenameTable(
                name: "Compania",
                newName: "Companias");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameTable(
                name: "CarroCompra",
                newName: "CarroCompras");

            migrationBuilder.RenameTable(
                name: "BodegaProducto",
                newName: "BodegasProductos");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_PadreId",
                table: "Productos",
                newName: "IX_Productos_PadreId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_MarcaId",
                table: "Productos",
                newName: "IX_Productos_MarcaId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_CategoriaId",
                table: "Productos",
                newName: "IX_Productos_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalle_ProductoId",
                table: "OrdenDetalles",
                newName: "IX_OrdenDetalles_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalle_OrdenId",
                table: "OrdenDetalles",
                newName: "IX_OrdenDetalles_OrdenId");

            migrationBuilder.RenameIndex(
                name: "IX_Orden_UsuarioAplicacionId",
                table: "Ordenes",
                newName: "IX_Ordenes_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_KardexInventario_UsuarioAplicacionId",
                table: "KardexInventarios",
                newName: "IX_KardexInventarios_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_KardexInventario_BodegaProductoId",
                table: "KardexInventarios",
                newName: "IX_KardexInventarios_BodegaProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_InventarioDetalle_ProductoId",
                table: "InventarioDetalles",
                newName: "IX_InventarioDetalles_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_InventarioDetalle_InventarioId",
                table: "InventarioDetalles",
                newName: "IX_InventarioDetalles_InventarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventario_UsuarioAplicacionId",
                table: "Inventarios",
                newName: "IX_Inventarios_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventario_BodegaId",
                table: "Inventarios",
                newName: "IX_Inventarios_BodegaId");

            migrationBuilder.RenameIndex(
                name: "IX_Compania_CreadoPorId",
                table: "Companias",
                newName: "IX_Companias_CreadoPorId");

            migrationBuilder.RenameIndex(
                name: "IX_Compania_BodegaVentaId",
                table: "Companias",
                newName: "IX_Companias_BodegaVentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Compania_ActualizadoPorId",
                table: "Companias",
                newName: "IX_Companias_ActualizadoPorId");

            migrationBuilder.RenameIndex(
                name: "IX_CarroCompra_UsuarioAplicacionId",
                table: "CarroCompras",
                newName: "IX_CarroCompras_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_CarroCompra_ProductoId",
                table: "CarroCompras",
                newName: "IX_CarroCompras_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaProducto_ProductoId",
                table: "BodegasProductos",
                newName: "IX_BodegasProductos_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaProducto_BodegaId",
                table: "BodegasProductos",
                newName: "IX_BodegasProductos_BodegaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenDetalles",
                table: "OrdenDetalles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KardexInventarios",
                table: "KardexInventarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventarioDetalles",
                table: "InventarioDetalles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventarios",
                table: "Inventarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companias",
                table: "Companias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarroCompras",
                table: "CarroCompras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodegasProductos",
                table: "BodegasProductos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BodegasProductos_Bodegas_BodegaId",
                table: "BodegasProductos",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BodegasProductos_Productos_ProductoId",
                table: "BodegasProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompras",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompras_Productos_ProductoId",
                table: "CarroCompras",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companias_AspNetUsers_ActualizadoPorId",
                table: "Companias",
                column: "ActualizadoPorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companias_AspNetUsers_CreadoPorId",
                table: "Companias",
                column: "CreadoPorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companias_Bodegas_BodegaVentaId",
                table: "Companias",
                column: "BodegaVentaId",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioDetalles_Inventarios_InventarioId",
                table: "InventarioDetalles",
                column: "InventarioId",
                principalTable: "Inventarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioDetalles_Productos_ProductoId",
                table: "InventarioDetalles",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventarios_AspNetUsers_UsuarioAplicacionId",
                table: "Inventarios",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventarios_Bodegas_BodegaId",
                table: "Inventarios",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KardexInventarios_AspNetUsers_UsuarioAplicacionId",
                table: "KardexInventarios",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KardexInventarios_BodegasProductos_BodegaProductoId",
                table: "KardexInventarios",
                column: "BodegaProductoId",
                principalTable: "BodegasProductos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalles_Ordenes_OrdenId",
                table: "OrdenDetalles",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalles_Productos_ProductoId",
                table: "OrdenDetalles",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_AspNetUsers_UsuarioAplicacionId",
                table: "Ordenes",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Productos_PadreId",
                table: "Productos",
                column: "PadreId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodegasProductos_Bodegas_BodegaId",
                table: "BodegasProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegasProductos_Productos_ProductoId",
                table: "BodegasProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompras");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompras_Productos_ProductoId",
                table: "CarroCompras");

            migrationBuilder.DropForeignKey(
                name: "FK_Companias_AspNetUsers_ActualizadoPorId",
                table: "Companias");

            migrationBuilder.DropForeignKey(
                name: "FK_Companias_AspNetUsers_CreadoPorId",
                table: "Companias");

            migrationBuilder.DropForeignKey(
                name: "FK_Companias_Bodegas_BodegaVentaId",
                table: "Companias");

            migrationBuilder.DropForeignKey(
                name: "FK_InventarioDetalles_Inventarios_InventarioId",
                table: "InventarioDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_InventarioDetalles_Productos_ProductoId",
                table: "InventarioDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventarios_AspNetUsers_UsuarioAplicacionId",
                table: "Inventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventarios_Bodegas_BodegaId",
                table: "Inventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_KardexInventarios_AspNetUsers_UsuarioAplicacionId",
                table: "KardexInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_KardexInventarios_BodegasProductos_BodegaProductoId",
                table: "KardexInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalles_Ordenes_OrdenId",
                table: "OrdenDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenDetalles_Productos_ProductoId",
                table: "OrdenDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_AspNetUsers_UsuarioAplicacionId",
                table: "Ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Productos_PadreId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ordenes",
                table: "Ordenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenDetalles",
                table: "OrdenDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KardexInventarios",
                table: "KardexInventarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventarios",
                table: "Inventarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventarioDetalles",
                table: "InventarioDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companias",
                table: "Companias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarroCompras",
                table: "CarroCompras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodegasProductos",
                table: "BodegasProductos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "Ordenes",
                newName: "Orden");

            migrationBuilder.RenameTable(
                name: "OrdenDetalles",
                newName: "OrdenDetalle");

            migrationBuilder.RenameTable(
                name: "Marcas",
                newName: "Marca");

            migrationBuilder.RenameTable(
                name: "KardexInventarios",
                newName: "KardexInventario");

            migrationBuilder.RenameTable(
                name: "Inventarios",
                newName: "Inventario");

            migrationBuilder.RenameTable(
                name: "InventarioDetalles",
                newName: "InventarioDetalle");

            migrationBuilder.RenameTable(
                name: "Companias",
                newName: "Compania");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameTable(
                name: "CarroCompras",
                newName: "CarroCompra");

            migrationBuilder.RenameTable(
                name: "BodegasProductos",
                newName: "BodegaProducto");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_PadreId",
                table: "Producto",
                newName: "IX_Producto_PadreId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_MarcaId",
                table: "Producto",
                newName: "IX_Producto_MarcaId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CategoriaId",
                table: "Producto",
                newName: "IX_Producto_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ordenes_UsuarioAplicacionId",
                table: "Orden",
                newName: "IX_Orden_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalles_ProductoId",
                table: "OrdenDetalle",
                newName: "IX_OrdenDetalle_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenDetalles_OrdenId",
                table: "OrdenDetalle",
                newName: "IX_OrdenDetalle_OrdenId");

            migrationBuilder.RenameIndex(
                name: "IX_KardexInventarios_UsuarioAplicacionId",
                table: "KardexInventario",
                newName: "IX_KardexInventario_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_KardexInventarios_BodegaProductoId",
                table: "KardexInventario",
                newName: "IX_KardexInventario_BodegaProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventarios_UsuarioAplicacionId",
                table: "Inventario",
                newName: "IX_Inventario_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventarios_BodegaId",
                table: "Inventario",
                newName: "IX_Inventario_BodegaId");

            migrationBuilder.RenameIndex(
                name: "IX_InventarioDetalles_ProductoId",
                table: "InventarioDetalle",
                newName: "IX_InventarioDetalle_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_InventarioDetalles_InventarioId",
                table: "InventarioDetalle",
                newName: "IX_InventarioDetalle_InventarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Companias_CreadoPorId",
                table: "Compania",
                newName: "IX_Compania_CreadoPorId");

            migrationBuilder.RenameIndex(
                name: "IX_Companias_BodegaVentaId",
                table: "Compania",
                newName: "IX_Compania_BodegaVentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Companias_ActualizadoPorId",
                table: "Compania",
                newName: "IX_Compania_ActualizadoPorId");

            migrationBuilder.RenameIndex(
                name: "IX_CarroCompras_UsuarioAplicacionId",
                table: "CarroCompra",
                newName: "IX_CarroCompra_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_CarroCompras_ProductoId",
                table: "CarroCompra",
                newName: "IX_CarroCompra_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegasProductos_ProductoId",
                table: "BodegaProducto",
                newName: "IX_BodegaProducto_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegasProductos_BodegaId",
                table: "BodegaProducto",
                newName: "IX_BodegaProducto_BodegaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orden",
                table: "Orden",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenDetalle",
                table: "OrdenDetalle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marca",
                table: "Marca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KardexInventario",
                table: "KardexInventario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventario",
                table: "Inventario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventarioDetalle",
                table: "InventarioDetalle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compania",
                table: "Compania",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarroCompra",
                table: "CarroCompra",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodegaProducto",
                table: "BodegaProducto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaProducto_Bodegas_BodegaId",
                table: "BodegaProducto",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaProducto_Producto_ProductoId",
                table: "BodegaProducto",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompra_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompra",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompra_Producto_ProductoId",
                table: "CarroCompra",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compania_AspNetUsers_ActualizadoPorId",
                table: "Compania",
                column: "ActualizadoPorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compania_AspNetUsers_CreadoPorId",
                table: "Compania",
                column: "CreadoPorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compania_Bodegas_BodegaVentaId",
                table: "Compania",
                column: "BodegaVentaId",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_AspNetUsers_UsuarioAplicacionId",
                table: "Inventario",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_Bodegas_BodegaId",
                table: "Inventario",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioDetalle_Inventario_InventarioId",
                table: "InventarioDetalle",
                column: "InventarioId",
                principalTable: "Inventario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioDetalle_Producto_ProductoId",
                table: "InventarioDetalle",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KardexInventario_AspNetUsers_UsuarioAplicacionId",
                table: "KardexInventario",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KardexInventario_BodegaProducto_BodegaProductoId",
                table: "KardexInventario",
                column: "BodegaProductoId",
                principalTable: "BodegaProducto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_AspNetUsers_UsuarioAplicacionId",
                table: "Orden",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalle_Orden_OrdenId",
                table: "OrdenDetalle",
                column: "OrdenId",
                principalTable: "Orden",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenDetalle_Producto_ProductoId",
                table: "OrdenDetalle",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_CategoriaId",
                table: "Producto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Marca_MarcaId",
                table: "Producto",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Producto_PadreId",
                table: "Producto",
                column: "PadreId",
                principalTable: "Producto",
                principalColumn: "Id");
        }
    }
}
