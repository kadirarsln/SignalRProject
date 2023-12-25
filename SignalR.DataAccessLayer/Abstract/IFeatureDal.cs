using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IFeatureDal : IGenericDal<Feature>
    {
        // Feature entity'sine özel işlemler buraya eklenebilir
        // Örneğin: Feature'e özel sorgular, filtrelemeler, vb.
    }
}
