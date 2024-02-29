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
