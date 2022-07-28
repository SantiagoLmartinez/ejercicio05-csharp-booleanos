/*
 Imagine que necesita determinar rápidamente si la compra de un cliente es válida para un descuento promocional.
Si el importe de la venta es superior a 1000, el descuento de la compra es de 100 dólares. Si el importe es de 1000
o menos, solo se descuentan 50 dólares.
 */

int totalAPagar = 1001;

//aplicando operador ternario
int descuento = totalAPagar > 1000 ? 100 : 50;

Console.WriteLine($"Total sin Descuento : {totalAPagar} {Environment.NewLine}" +
    $"- Descuento por compra : {descuento} {Environment.NewLine}- Total a pagar: {totalAPagar - descuento}");


Console.WriteLine("---------2---------");
/*
 Paso 2: escribir código en el editor de .NET para mostrar el resultado del volteo de una moneda
Use la clase Random para generar un valor. Según el valor, use el operador condicional para mostrar heads o tails.

Debería haber una posibilidad del 50 % de que el resultado sea cara o cruz.

Debería lograr el resultado deseado en tres líneas de código o menos.
*/

Random moneda = new Random();
Console.WriteLine($"{ (moneda.Next(1, 3) == 1 ? "cara" : "cruz")}");

Console.WriteLine("---------3---------");
/*
 Para probar la lógica de la expresión booleana, use el código siguiente de datos de ejemplo.

    string permission = "Admin|Manager";
    int level = 55;

*  Para determinar si el valor de la variable Contains() contiene uno de los valores de permiso
*  que se van a comprobar en las "reglas de negocio", use el método auxiliar permission de una cadena.
*  jemplo: permission.Contains("Admin") devolvería true.

Paso 2: implementar reglas de negocio
    1- Si el usuario es administrador con un nivel superior a 55, se genera el mensaje:
    Welcome, Super Admin user.
    
    2- Si el usuario es administrador con un nivel inferior o igual a 55, se genera el mensaje:
    Welcome, Admin user.
    
    3-Si el usuario es director con un nivel superior a 20, se genera el mensaje:
    Contact an Admin for access.

    4-Si el usuario es director con un nivel inferior a 20, se genera el mensaje:
    You do not have sufficient privileges.

    5-Si el usuario no es ni administrador ni director, se genera el mensaje:
    You do not have sufficient privileges.
 */

Random lvl = new Random();
string[] permission = { "Admin", "Manager" };
string permissionAux =  "Admin|Manager";

int nivel = lvl.Next(15, 70);

//Solucion 1
foreach (string item in permission)
{
    if (item == "Admin" && nivel > 55)
    {
        Console.WriteLine($"Bienvenido, SuperAdmin lvl {nivel}");
    }
    if (item == "Admin" && nivel <= 55)
    {
        Console.WriteLine($"Bienvenido, Admin {nivel}");
    }
    if (item == "Manager" && nivel > 20)
    {
        Console.WriteLine($"Contacta a un administrador para obtener acceso");
    }
    if (item == "Manager" && nivel < 20)
    {
        Console.WriteLine($"No tenes suficientes privilegios de acceso tu nivel es {nivel}");
    }
    if (item != "Manager" && item != "Admin")
    {
        Console.WriteLine("No tenes suficientes privilegios de acceso");
    }
}


