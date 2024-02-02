


Sale mySale = new Sale(10, DateTime.Now);
mySale.Total = -120;
Console.WriteLine(mySale.Total);
Console.WriteLine(mySale.Date);


class Sale
{

    //propiedades & modificadores de acceso
    private int total;
    private DateTime date;

    public int Total
    {
        // consultar - obtener valor
        get { return total; } 

        // editar valor
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            total = value;
        }
    }

    public string Date
    {
        get { return date.ToLongDateString(); }
    }

    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }
}
