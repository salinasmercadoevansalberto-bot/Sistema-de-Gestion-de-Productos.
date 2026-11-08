# Sistema de Gestión de Productos

**Elaborado por:** Evans Alberto Salinas Mercado  
**Asignatura:** Programación II  
**Trabajo:** Tarea N.º 1

## 1. Descripción del proyecto

El Sistema de Gestión de Productos es una aplicación de escritorio desarrollada en C# mediante Windows Forms y conectada a una base de datos SQL Server.

Su propósito es facilitar el registro, consulta, búsqueda, modificación y eliminación de productos, así como la administración de sus categorías y el control del inventario.

## 2. Tecnologías utilizadas

- **Lenguaje de programación:** C#.
- **Entorno de desarrollo:** Visual Studio.
- **Interfaz gráfica:** Windows Forms.
- **Base de datos:** Microsoft SQL Server.
- **Conexión a la base de datos:** Microsoft.Data.SqlClient.

## 3. Funcionalidades principales

- Registrar nuevos productos.
- Consultar los productos registrados.
- Buscar productos por nombre.
- Evitar el registro de productos duplicados.
- Modificar la información de los productos.
- Eliminar productos con confirmación.
- Registrar y administrar categorías.
- Calcular el valor del inventario mediante el precio y la cantidad disponible.
- Registrar automáticamente la fecha de ingreso de los productos.

## 4. Base de datos

**Nombre de la base de datos:** `SistemaGestionProductos`

La base de datos está compuesta por dos tablas principales:

- **Categorias:** almacena la información de las categorías de los productos.
- **Productos:** almacena los productos, sus precios, existencias, fecha de registro y categoría correspondiente.

La tabla Productos utiliza una clave foránea para establecer la relación con la tabla Categorias.

## 5. Requisitos para ejecutar el proyecto

Antes de ejecutar el sistema, se necesita tener instalado:

- Sistema operativo Windows.
- Visual Studio con soporte para desarrollo de escritorio .NET.
- Microsoft SQL Server.
- SQL Server Management Studio (SSMS), recomendado para administrar la base de datos.
- Paquete NuGet `Microsoft.Data.SqlClient`.

## 6. Instalación y configuración

Para ejecutar el proyecto correctamente, se deben seguir estos pasos:

1. Abrir SQL Server Management Studio.
2. Ejecutar el script SQL de creación de la base de datos.
3. Verificar que se hayan creado correctamente las tablas y sus relaciones.
4. Abrir el proyecto en Visual Studio.
5. Revisar la cadena de conexión en la clase `ConexionBD`.
6. Confirmar que el nombre del servidor y de la base de datos coincidan con la configuración local.
7. Restaurar los paquetes NuGet si es necesario.
8. Compilar y ejecutar el proyecto desde Visual Studio.

## 7. Configuración de la conexión

La aplicación utiliza una conexión a SQL Server mediante la clase `ConexionBD`.

Durante el desarrollo se utilizó el siguiente servidor:

`Evans-PC\SQLEXPRESS`

El nombre del servidor puede variar dependiendo de la computadora donde se ejecute el proyecto. Por esta razón, es necesario revisar y modificar la cadena de conexión si se utiliza otro servidor.

La base de datos utilizada es:

`SistemaGestionProductos`

## 8. Uso del sistema

### Registro de productos

Permite ingresar nuevos productos, seleccionar una categoría, indicar el precio y establecer las existencias iniciales.

También permite consultar los productos existentes y realizar búsquedas por nombre para verificar si un producto ya se encuentra registrado.

### Administración de productos

Permite consultar los productos registrados y seleccionar uno directamente desde el DataGridView para cargar automáticamente su información en los campos correspondientes.

Desde esta pantalla se pueden modificar o eliminar productos.

### Administración de categorías

Permite gestionar las categorías que se utilizan para clasificar los productos dentro del sistema.

## 9. Estructura del proyecto

El proyecto utiliza formularios de Windows Forms para desarrollar la interfaz gráfica y clases independientes para manejar la información y la conexión con SQL Server.

La lógica de acceso a la base de datos se mantiene separada de los formularios, facilitando la organización, el mantenimiento y la comprensión del código.

## 10. Autoría

**Estudiante:** Evans Alberto Salinas Mercado  
**Asignatura:** Programación II  
**Trabajo académico:** Tarea N.º 1

## 11. Uso de inteligencia artificial (IA)

Durante la planificación y el desarrollo de este proyecto utilicé herramientas de inteligencia artificial, principalmente ChatGPT, como apoyo para comprender mejor los requerimientos y orientar el proceso de programación.

La utilicé para:

- Analizar los requerimientos del proyecto y comprender qué debía desarrollar.
- Obtener ideas para organizar las funcionalidades y la estructura del sistema.
- Aclarar dudas sobre programación en C#, Windows Forms y SQL Server.
- Recibir orientación sobre el diseño de la base de datos y las relaciones entre las tablas.
- Analizar posibles soluciones cuando encontraba dificultades durante la programación.
- Identificar y comprender errores en el código, así como buscar posibles formas de corregirlos.
- Mejorar la organización y comprensión del código mediante explicaciones y ejemplos.

La inteligencia artificial fue una herramienta de consulta y aprendizaje que me permitió avanzar con mayor claridad durante el desarrollo. Sin embargo, fui responsable de analizar las respuestas, adaptar las soluciones a los requerimientos del proyecto, realizar las modificaciones correspondientes y comprobar el funcionamiento del sistema.
