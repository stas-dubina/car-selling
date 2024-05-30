using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Domain
{
    public interface IModelRepository
    {
        List<Model> GetAll();

        List<Model> GetAllByBrand(int brandId);
    }
}
