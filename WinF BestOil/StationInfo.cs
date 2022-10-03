using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinF_BestOil;

internal class StationInfo
{
    public Fuel FuelType { get; set; }

    public bool PerLiter { get; set; }

    public double PerLiterRate { get; set; } 
    
    public double PerCostRate { get; set; }
    
    public Dictionary<string, decimal>  MiniCafe { get; set; }

    public double Total { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"      ~ Fuel Station ~      ");
        if(PerLiter)
            sb.Append($"{FuelType.Name} - {FuelType.Price} - {PerLiterRate} Liter - {PerLiterRate * FuelType.Price} ₼");
        else
            sb.Append($"{FuelType.Name} - {FuelType.Price} - {PerCostRate} ₼ - {Math.Round(PerCostRate / FuelType.Price)} Liter");

        sb.Append($"      ~ Mini - Cafe ~      ");
        foreach (var item in MiniCafe)
        {
            sb.Append($"{item.Key} - Quantity:{item.Value} ");
        }
        sb.AppendLine($"TOTAL: {Total}");
        sb.AppendLine("GOOD BYE!");
        
        return sb.ToString();
    }
}
