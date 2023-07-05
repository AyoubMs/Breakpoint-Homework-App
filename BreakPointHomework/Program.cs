

static void Runs100Times()
{
    for (int i = 0; i < 100; i++)
    {
        if (i == 73)
        {
            throw new Exception($"The counter is {i}");
        }
    }
}

try
{
    Runs100Times();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}