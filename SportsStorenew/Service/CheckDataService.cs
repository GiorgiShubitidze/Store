using SportsStoreNew.Domain.DB;
using SportsStoreNew.Models;
using SportsStoreNew.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.Service
{
    public class CheckDataService : ICheckDataService
    {
        SportsStoreDbContext _dbContext;
        public CheckDataService(SportsStoreDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public bool Check(CheckoutViewModel model)
        {
            var Chackout = new CheckoutViewModel();
            Chackout.Address = model.Address;
            Chackout.Email = model.Email;
            Chackout.Name = model.Name;
            Chackout.Note = model.Note;
            Chackout.Surname = model.Surname;

            _dbContext.CheckoutViewModels.Add(Chackout);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                if(ex!=null)
                {
                    return false;
                }
            }
            return true;
            
        }

       
    }
}
