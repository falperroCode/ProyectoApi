ProyectoApi – Sistema de Gestión de Biblioteca
Aplicación compuesta por API REST en .NET 9 y Cliente WinForms
Descripción General
ProyectoApi es una solución completa diseñada para gestionar libros y autores dentro de una biblioteca digital.
El sistema está formado por varios módulos independientes que trabajan de manera coordinada:

Una API REST desarrollada en ASP.NET Core 9.

Un cliente de escritorio construido con Windows Forms.

Una capa de dominio (Core) con los modelos principales.

Una capa de datos (Data) que gestiona la persistencia mediante Entity Framework Core.

El proyecto está estructurado para ser modular, mantenible y escalable, ideal tanto para aprendizaje como para proyectos reales.

Además, la solución está configurada para que, al ejecutar el proyecto desde Visual Studio, la API y el cliente WinForms se inicien automáticamente de forma simultánea, permitiendo probar el sistema completo sin pasos adicionales.

Arquitectura de la Solución
La solución se divide en cuatro proyectos, cada uno con una responsabilidad clara:

1. BiblioDAM.Api – API REST
Este módulo expone los servicios que permiten gestionar libros y autores.
Incluye controladores, DTOs, configuración de la aplicación y la integración con la capa de datos.
La API ofrece operaciones de consulta, creación y eliminación, y está documentada mediante Swagger.

2. BiblioDAM.Cliente – Aplicación WinForms
Es la interfaz gráfica del sistema.
Permite consultar libros, buscar por criterios, eliminar registros y navegar entre formularios.
Incluye un cliente HTTP propio que gestiona la comunicación con la API y un conjunto de formularios diseñados para facilitar la interacción.
El proyecto está configurado para iniciarse automáticamente junto con la API.

3. BiblioDAM.Core – Modelos de Dominio
Contiene las clases que representan las entidades principales del sistema, como libros y autores.
Estas clases son independientes de la infraestructura y definen la estructura lógica del dominio.

4. BiblioDAM.Data – Capa de Datos
Gestiona la comunicación con la base de datos mediante Entity Framework Core.
Incluye el contexto de datos, las entidades mapeadas y la configuración necesaria para la persistencia.

Tecnologías Utilizadas
ASP.NET Core 9 para la API REST

Windows Forms (.NET 9) para la aplicación de escritorio

Entity Framework Core como ORM

SQL Server como base de datos

Swagger / OpenAPI para documentación

C# 13 como lenguaje principal

Funcionalidades Principales
API
Consulta de libros y autores

Búsqueda por título o autor

Creación de nuevos registros

Eliminación de libros mediante ISBN

Cliente WinForms
Visualización de libros en una interfaz gráfica

Búsqueda por distintos criterios

Eliminación de registros desde la propia aplicación

Lectura de catálogos desde ficheros de texto

Navegación entre formularios

Inicio automático junto con la API al ejecutar la solución

Ejecución del Proyecto
Ejecución conjunta
La solución está configurada para que, al pulsar “Iniciar” en Visual Studio, se ejecuten automáticamente tanto la API como el cliente WinForms.
Esto permite probar el sistema completo sin necesidad de lanzar manualmente cada proyecto.

Para ejecutar la API por separado
Abrir el proyecto BiblioDAM.Api

Configurar la cadena de conexión

Crear la base de datos si es necesario

Ejecutar la API

Acceder a la documentación mediante Swagger

Para ejecutar el Cliente WinForms por separado
Abrir el proyecto BiblioDAM.Cliente

Verificar la URL de la API

Ejecutar la aplicación

Posibles Mejoras Futuras
Autenticación y autorización

Edición de libros y autores desde el cliente

Paginación en las consultas

Validaciones avanzadas

Contenedorización mediante Docker

Implementación de pruebas unitarias

Autor
Proyecto desarrollado por José Fernandez Gonzalez (Github=falperroCode)  
Trabajo académico para la asignatura de Acceso a Datos.
