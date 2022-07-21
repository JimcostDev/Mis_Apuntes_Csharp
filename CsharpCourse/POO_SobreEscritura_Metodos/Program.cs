// la sobrescritura (cambiar el comportamiento de un método) funciona con la herencia (heredar los metodos y propiedades de una clase padre) 
// con la sobrescritura le damos una funcionalidad distinta a los metodos que estamos heredando.


// a diferencia de la sobrecarga que se realiza sobre la misma clase, la sobreescritura se realiza sobre la herencia o el polimorfismo.
// utilizamos "virtual" y "override" para realizar la sobreescritura

B b = new B();
Console.WriteLine(b.Hi());


Sale sale = new Sale(5);
sale.AddItems(10);
sale.AddItems(16);
Console.WriteLine(sale.GetTotal());


SaleWithTax saleTax = new SaleWithTax(5,0.19m);
saleTax.AddItems(10);
saleTax.AddItems(16);
Console.WriteLine(saleTax.GetTotal());

public class A
{
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}

public class B : A
{
    // sobreescritura
    public override string Hi()
    {
        return base.Hi() + ", Hola soy B";
    }
}

public class Sale
{
    private decimal[] _amounts;
    private int _n;
    private int _end;

    public Sale(int n)
    {
        _amounts = new decimal[n];
        _n = n;
        _end = 0;
    }

    public void AddItems(decimal amount)
    {
        if(_end < _n)
        {
            _amounts[_end] = amount;
            _end++;
        }
    }

    public virtual decimal GetTotal()
    {
        decimal result = 0;
        int i = 0;
        while (i < _amounts.Length)
        {
            result += _amounts[i];
            i++;
        }
        return result;
    }
}

public class SaleWithTax : Sale
{
    private decimal _tax;
    public SaleWithTax(int n, decimal tax) : base(n)
    {
        _tax = tax;
    }

    // sobreescribimos el metodo
    public override decimal GetTotal()
    {
        return base.GetTotal() * _tax;
    }
}
