
using Soap.Dtos;
using Soap.Infraestructure.Entities;
using Soap.Models;

namespace Soap.Mappers
{
    public static class PiezaMapper
    {
        // Mapea de entidad a modelo
        public static PiezaModel ToModel(this PiezaEntity pieza)
        {
            if (pieza is null)
            {
                return null;
            }

            return new PiezaModel
            {
                Id = (Guid)pieza.id,
                producto = pieza.producto,
                categoria = pieza.categoria,
                precio = pieza.precio,
                descripcion = pieza.descripcion,
                codigo = pieza.codigo,
                marca = pieza.marca,
                stock = pieza.stock,
                modelosvehiculos = pieza.modelosvehiculos
            };
        }

        // Mapea de modelo a DTO de respuesta
        public static PiezaResponseDto ToDto(this PiezaModel pieza)
        {
            return new PiezaResponseDto
            {
                Id = pieza.Id,
                producto = pieza.producto,
                categoria = pieza.categoria,
                precio = pieza.precio,
                descripcion = pieza.descripcion,
                codigo = pieza.codigo,
                marca = pieza.marca,
                stock = pieza.stock,
                modelosvehiculos = pieza.modelosvehiculos
            };
        }

        // Mapea de modelo a entidad
        public static PiezaEntity ToEntity(this PiezaModel pieza)
        {
            return new PiezaEntity
            {
                id = pieza.Id,
                producto = pieza.producto,
                categoria = pieza.categoria,
                precio = pieza.precio,
                descripcion = pieza.descripcion,
                codigo = pieza.codigo,
                marca = pieza.marca,
                stock = pieza.stock,
                modelosvehiculos = pieza.modelosvehiculos
            };
        }

        // Mapea de DTO de creación a modelo
        public static PiezaModel ToModel(this PiezaCreateRequestDto pieza)
        {
            return new PiezaModel
            {
                producto = pieza.producto,
                categoria = pieza.categoria,
                precio = pieza.precio,
                descripcion = pieza.descripcion,
                codigo = pieza.codigo,
                marca = pieza.marca,
                stock = pieza.stock,
                modelosvehiculos = pieza.modelosvehiculos ?? Array.Empty<string>()
            };
        }
    }
}
