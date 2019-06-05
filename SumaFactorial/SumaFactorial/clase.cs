class operaciones
{
    private static operaciones Instancia;

    private static int factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return factorial(n - 1) * n;
    }
    private static int sumatoria(int n)
    {
        if (n == 0)
            return 0;
        else
            return sumatoria(n - 1) + n;
    }
    public static operaciones getInstancia() //singleton
    {
        if (Instancia == null)
        {
            Instancia = new operaciones();
        }
        return Instancia;
    }
}