using DataAccessLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IWorkOrdersDal : IGenericDal<Tbl_Orders>
    {
         List<WorkOrderDto> GetAllDetail();
    }
}
