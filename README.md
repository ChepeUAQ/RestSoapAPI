# Refaccionaria_API
Esta API está diseñada para gestionar clientes y piezas en una refaccionaria, ofreciendo un conjunto de operaciones CRUD (Crear, Leer, Actualizar y Eliminar) para ambas entidades.

> [!IMPORTANT]
> Solo funciona SOAP

- Entidades<br>
  - 🛠️ Piezas
    - Producto: Nombre del producto.
    - Categoria: Categoría a la que pertenece el producto.
    - Precio: Precio del producto.
    - Descripcion: Descripción detallada del producto.
    - Codigo: Código único del producto.
    - Marca: Marca del producto.
    - Stock: Estado de disponibilidad del producto (por ejemplo, "Disponible", "Agotado").
    - ModelosVehiculos: Lista de modelos de vehículos compatibles con la pieza.
  - 👤 Clientes
    - Nombre: Nombre completo del cliente.
    - Correo: Correo electrónico del cliente.
    - Telefono: Número de teléfono del cliente.
    - ProductosComprados: Lista de IDs de los productos que ha comprado el cliente.
      
El sistema está optimizado con características avanzadas como paginación, búsqueda por categorías y almacenamiento en caché para un mejor rendimiento.

## Tecnologías🖥️
Este proyecto ha sido desarrollado con las siguientes tecnologías:
- ⚙️ Node.js - Entorno de ejecución de JavaScript.
- 🟦 TypeScript - Superconjunto de JavaScript.
- 🐳 Docker - Contenedorización del proyecto.
- 📦 pnpm - Gestor de paquetes.
- 🍃 MongoDB - Base de datos NoSQL.
- 🚀 Express - Framework para construir la API.
- 📜 Swagger - Documentación de API.

## Requisitos📋
- [x] 🐳 Docker - Contenedorización del proyecto.
- [x] ⚓ Kubernetes - Gestionador de clusters.
      
## Instalación 🔧
- ⚙️ Configuración inicial<br>
      1. Clonar el repositorio en el directorio de tu preferencia.<br>
         ``git clone https://github.com/ChepeUAQ/RestSoapAPI.git``<br>
      2. Una vez que haya clonado el repositorio, dirígete a la terminal y ejecuta el siguiente comando.<br>
         ``pnpm install``<br>
         
- ⚓ Configuración de Clusters
- Ejecuta los comandos que se encuentran en el siguiente documento:
  
  https://docs.google.com/document/d/1ROVZTJjCaO7IpfuQxl21IqnyU92zHjF3sKQX6Vvt8Ig/edit?usp=sharing 
 
