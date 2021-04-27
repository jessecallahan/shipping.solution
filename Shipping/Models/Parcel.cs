using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }
    public double VolumeProp { get; set; }
    public double Total { get; set; }

    private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(double width, double height, double length)
    {
      Width = width;
      Height = height;
      Length = length;
      VolumeProp = Volume(this);
      Total = CostToShip(this);
      _instances.Add(this);
    }

    public static double Volume(Parcel parcel)
    {
      return parcel.Width * parcel.Height * parcel.Length;
    }

    public static double CostToShip(Parcel parcel)
    {
      if (parcel.VolumeProp < 1000)
      {
        return 10.00;
      }
      else
      {
        return 20.00;
      }

    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}