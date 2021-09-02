using System.Collections;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public interface IListofcarsItem
    {
        string title { get; set; }
        IList<IShowCars> carlist { get; set; }
    }

    public interface IShowCars
    {
        string brand { get; set; }
        string model { get; set; }
        string year { get; set; }
    }
}