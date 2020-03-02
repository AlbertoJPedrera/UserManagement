# UserManagement
    API Rest simple para la gestión de usuarios. La aplicación se crea con múltiples capas para que haya una distribución de funciones y si en algún momento es necesario cambiar alguna capa no afecta al resto.
    Como puede ver, la aplicación tiene 3 capas y la propia API.
     * UserMAnagement.API
        Donde se implementa la parte que administra la API, tenemos los controladores que son los puntos de acceso a la API. En este proyecto, se configura la conexión a la base de datos y Swagger, que nos servirá  para probar los end points de la API.
     * UserManagement.Core
        En este projecto están los modelos del API y las interfaces del repositorio y de los servicios.
     * UserManagement.Data
        En este proyecto se configura la conexión con la base de datos y donde se realizarán las acciones de extracción y guardado de los datos en la base de datos.
        En este proyecto también están las migraciones a la base de datos.
     * UserManagement.Services
        Aquí es donde se lleva a cabo la lógica de la aplicación.
## Configuración y ejecución.
    En esta aplicación se ha utilizado SQL Express para la persistencia de los datos. Se puede cambiar la base de datos sn que afecte a la aplicación ya que al estar la aplicación modulada si se cambia el ORM no afecrtaría al resto de las capas.
    Para configurar la Base de datos en el fichero *appsettings.development.json* está la connectionstring, cadena de conexión y en *startup.cs* se configura la conexión a la base de datos.

    Una vez configurada la base de datos se lanzarán las migraciones existentes para que los cambios se persistan en la base de datos. Existe un fichero de texto, llamado *Commands.txt*, en el que he guardado los camandos necesarios para generar nuevas migraciones, ejecutar las migraciones y la aplicación.
## Pruebas
    Una vez la aplicación en marcha se pondrá en la URL de un navegador la dirección *https://localhost:5001* y se podrán probar los distintos endpoints de la API.
## TODOs
    * Falta la validación de los datos.
    * Seguridad del API, con JWT por ejemplo.
    * Testeo del API.
