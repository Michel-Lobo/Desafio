using System;

public class Cliente: BaseEntity
{
    public int IDCliente { get; set; }
    public string NomeCliente { get; set; }
    public int IDPorteEmpresa { get; set; }
    public PorteEmpresa PorteEmpresa { get; set; }
}
