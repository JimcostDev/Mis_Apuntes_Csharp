bool areYouHungry = true;
bool areYouHaveMoney = true;

if (areYouHungry && areYouHaveMoney && isOpenRestaurant("Restaurante 24 horas"))
{
    Console.WriteLine("Voy a comer afuera, en un restaurante");
}
else
{
    Console.WriteLine("No comes");
}


static bool isOpenRestaurant(string name, int hour = 0)
{
    if(name == "KFC" && hour > 8 && hour < 23)
    {
        return true;
    }
    else if (name == "Restaurante 24 horas")
    {
        return true;
    }
    else
    {
        return false;
    }
    
}
