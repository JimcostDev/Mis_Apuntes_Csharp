int i = 0;
while (i < 10) {
    Console.WriteLine("Iteración de i " + i);
    i++;
}


bool run = false;
do
{
    Show();
} while (run);


static void Show()
{
    Console.WriteLine("Entro una vez y ya");
}