using System;
using System.Collections.Generic;

namespace bankProject.Models;

public partial class Sbtransaction
{
    public int? AccountNo { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public double? CurrentBalance { get; set; }
}
