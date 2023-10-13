using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testwebapi.Models;

namespace testwebapi.Base
{
    public class BuyerManager : IBuyer
    {
        private readonly ContactCtx _contactctx;
        public BuyerManager(ContactCtx contactCtx)
        {
            _contactctx = contactCtx;
        }
        //public async  GetContact(string FirstName)
        //{
        //    try
        //    {
        //        if (_contactctx.Contacts == null)
        //        {
        //            return null;
        //        }
        //        return _contactctx.Contacts.ToList();
        //    }
        //    catch(Exception ex)
        //    {
        //        return null;
        //    }
        //}

        public async Task<List<Contact>> GetContacts()
        {
            try
            {
                if(_contactctx.Contacts == null)
                {
                    return null;
                }

                return await _contactctx.Contacts.ToListAsync();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Task<ActionResult<dynamic>> InsertBuyer(Buyer byr)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Contact>> postContact(Contact ctx)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<dynamic>> test(string? Name = null)
        {
            throw new NotImplementedException();
        }
    }
}
