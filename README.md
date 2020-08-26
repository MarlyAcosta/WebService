# WebService "RECETA"
 Repositorio para el reto del primer corte de la materia de servicios web

## Requisitos
- Debe tener Visual Studio instalado
- Debe tener Xampp instalado

### Instalar el proyecto
1. Clone este repositorio
2. La estructuración del proyecto esta realizada como:
  - `Cliente` la cual es la carpeta del proyecto.
  - `Base de datos` donde se encuentra el sql.
  - `Documento` donde se encuentra la documentacón de como se realizo el proyecto.
3. Crear una base de datos con el nombre de "world".
   - En caso de asignarle una contraseña al usuario root o a la base de datos en sí, debe modificar el archivo *IService1* el cual se encuentra ubicadoe en *SOAPService*, la parte que debe editar es la clase de BdConnection la cual se encuentra al final.
   -Importar el archivo sql.
4. Para exportar los datos a Excel se debera configurar la ruta que se encuentra en *Form1.cs* en las acciones que hacen los botones *Exportar a excel* y *Exportar pagina a excel*  ya que son rutas fisicas y deben ser modificadas para que funcione.
