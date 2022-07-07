//crear objecto
Sale sale_1 = new Sale(17, 250, DateTime.Now);
Sale sale_2 = new Sale(18, 300, DateTime.Now);

sale_1.Show();
string info = sale_1.GetInfo();
Console.WriteLine(info);

Console.WriteLine(sale_2.GetInfo());

// crear clase
class Sale
{

    //propiedades
    int id;
    int total;
    DateTime date;

    //constructor (me sirve para que el ibjecto se inicialize con unas propiedades por defecto)
    public Sale(int id, int total,DateTime date)
    {
        this.id = id;
        this.total = total;
        this.date = date;
    }

    //metodos
    public void Show()
    {
        Console.WriteLine("Hola, soy una venta");
    }

    public string GetInfo() 
    {
        return id + " | " + "$ " + total + " | " + date.ToLongDateString();
    }
}
