namespace ClassLib;

public interface ICobraSalario
{
    // decimal Salario { get; }
    void CobrarSalario();
    void CobrarSalario(decimal newSalario);
}
