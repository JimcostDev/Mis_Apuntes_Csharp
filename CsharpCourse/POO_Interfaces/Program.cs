//Las interfaces permiten firmar un contrato el cual debe cumplirse siempre si la meta es implementar una interface.
//Implementar interfaces permite hacer Polimorfismo, poli (varios) + morfo (formas).

//Entonces, gracias a las interfaces se pueden crear diferentes formas que tienen comportamientos parecidos sintácticamente hablando.
//Es decir, es posible llamar diferentes objetos que son de diferentes clases pero pueden recibir las mismas órdenes sintácticas
//siempre y cuando ellos posean la misma interface.

//categorizar objectos


Shark[] sharks = new Shark[]
{
    new Shark("White Shark", 87),
    new Shark("Jaws", 78)
};

IFish[] fishes = new IFish[]
{
    new Whale(45),
    new Shark("Tiburonsin", 59)
};

ShowFish(sharks);
ShowFish(fishes);
ShowAnimal(sharks);

static void ShowFish(IFish[] fishes)
{
    Console.WriteLine("-- We show the fishes --");
    foreach (var fish in fishes)
    {
        Console.WriteLine(fish.Swim());
    }
}

static void ShowAnimal(IAnimal[] animals)
{
    Console.WriteLine("-- We show the animals --");
    foreach (var animal in animals)
    {
        Console.WriteLine(animal.Name);
    }
}


//clases
public class Shark : IAnimal, IFish
{
    //estamos implemetando las condciones del contrato
    public string Name { get; set; }
    public int Speed { get; set; }

    public Shark(string Name, int Speed)
    {
        this.Name = Name;
        this.Speed = Speed;
    }

    public string Swim()
    {
        return $"{ Name} swim {Speed} km/h";
    }
}

public class Whale : IFish
{
    public int Speed { get; set; }
    public Whale(int Speed)
    {
        this.Speed = Speed;
    }

    public string Swim()
    {
        return $"The whale swin to {Speed} km/h";
    }
}


// interfaces 
public interface IAnimal
{
    public string Name { get; set; }
}

public interface IFish
{
    public int Speed { get; set; }
    public string Swim();
}