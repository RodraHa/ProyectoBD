## Proyecto usando la base de datos DvdRental
### Integrantes
- Rodrigo Haro
- Emilio Jácome
- Miguel Mendosa
- Michael Trocellier
### Utilización
Para su uso se necesita cambiar el usuario y la contraseña en ```Login.cs``` de modo que coincidan con las credenciales con la que se restauró la base de datos
```{C#}
    public partial class Login : Form
    {
        public static String user = "postgres";
        public static String password = "";
        public static String connectionString = $"Server=localhost;Port=5432;User Id={user};Password={password};Database=dvdrental";
```
Una vez iniciado el programa existen dos tipos de acceso. 
1. El primero se realiza por medio de los correos electrónicos de los clientes registrados en la base de datos, por ejemplo ```mary.smith@sakilacustomer.org```, el cual permite realizar las operaciones de: Ver el historial del cliente, Alquilar DVD, Devolver DVD, Pagar por el alquiler y hacer un listado de las películas por director y género.
2. El segundo tipo de acceso se realiza con el correo electrónico del personal de las tiendas, por ejemplo ```Mike.Hillyer@sakilastaff.com```, el cual permite realizar las operaciones de: Ingresar película, Ingresar DVD, Eliminar DVD
