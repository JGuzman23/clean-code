namespace ConsoleApp.Contracts.BL
{
    public interface IHelperService
    {
        bool ValidarSiEsNumerico(string value);
        bool ValidarSiNumeroEsMayorCero(double value);
    }
}
