namespace polimorfismo_11;

class Program
{
    static void Main(string[] args)
    {
        //instancia gerente
        Imposto obj_Gerente = new Gerente();
        obj_Gerente.valeAlimentacao(5000);
        obj_Gerente.valeTransporte(2000);
        Console.WriteLine("=============================\n");
        //instancia atendente
        Imposto obj_atendente = new Atendente();
        obj_atendente.valeAlimentacao(3000);
        obj_atendente.valeTransporte(2000);
        Console.WriteLine("=============================\n");
        //instancia estagiario
        Imposto obj_estagiario = new Estagiario();
        obj_estagiario.valeAlimentacao(1000);
        obj_estagiario.valeTransporte(200);
        Console.WriteLine("=============================\n");
    }
}
