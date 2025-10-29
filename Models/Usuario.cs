using System;
using System.Collections.Generic;

namespace ASPNET.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public string Clave { get; set; } = null!;
}
