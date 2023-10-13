using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testwebapi.Models;
using Microsoft.EntityFrameworkCore;
using Abp.Web.Models;
using Abp.UI;
using testwebapi.Base;

namespace testwebapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
       
        private readonly IBuyer _ibuyer;

        public ContactController(IBuyer Ibuyer)
        {
            
            _ibuyer = Ibuyer;
        }
        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContacts()
        {
            var result = await _ibuyer.GetContacts();
            if (result == null)
                return NotFound();

            return result;
        }
        [HttpGet]
        public async Task<ActionResult<Contact>> GetContact(string FirstName)
        {
            //if (_contactCtx.Contacts == null)
            //{
            //    return NotFound();
            //}
            ////  var contact = await _contactCtx.Contacts.FindAsync(FirstName);
            //var contact =  _contactCtx.Contacts.FirstOrDefault(a => a.FirstName == FirstName);
            ////var contact =  _contactCtx.Contacts.Where<>
            //if(contact== null)
            //{
            //    return NotFound();
            //}
            //return contact;
            return null;
        }
        [HttpPost]
        public async Task<ActionResult<Contact>> postContact(Contact ctx)
        {
            //_contactCtx.Contacts.Add(ctx);
            //await _contactCtx.SaveChangesAsync();

            //return CreatedAtAction(nameof(GetContact), new { FirstName = ctx.FirstName }, ctx);
            return null;
        }
        [HttpPost]
        public async Task<ActionResult<dynamic>> InsertBuyer(Buyer byr)
        {
            return true;
            //Result rst = new Result();
            //rst.success = false;
            //try
            //{
                
            //    Buyer inByr = new Buyer();
            //    inByr.rowguid = Guid.NewGuid();
            //    inByr.isActive = 1;
            //    inByr.Email = byr.Email;
            //    inByr.ID_Product = byr.ID_Product;
            //    inByr.Total = byr.Total;
            //    _contactCtx.Buyers.Add(inByr);
            //    try
            //    {
            //       var hasil =  await _contactCtx.SaveChangesAsync();
            //        rst.success = true;
            //        rst.Message = inByr;
            //        return rst;
            //    }
            //    catch(DbUpdateException ex)
            //    {
            //        rst.Message = ex.Message;
            //        return rst;
            //    }
                     
                
            //}
            //catch(UserFriendlyException uf)
            //{
            //    rst.Message = uf.Message;
            //    return rst;
            //}
        }
        //[HttpGet]
        //public async Task<dynamic> GetBuyer(string? Email = "")
        //{

        //}
        [HttpGet]
        public async Task<ActionResult<dynamic>> test(string? Name = null )
        {
            List<DtTest> tmpResult = new List<DtTest>();
            var Result = new AjaxResponse();
            try
            {
                if (Name == null)
                {
                    Result = new AjaxResponse(new { success = false, data = "Kosong", message = "data empty" });
                    return Result;
                }
                else
                {
                    if (Name.Trim().Length > 0)
                    {
                        string tmpHuruf = "";
                        for(int x = 0; x < Name.Trim().Length; x++)
                        {
                            var TrimData = Name.Trim();
                            string CurrHuruf = Name.Trim().Substring(x, 1);
                            DtTest tmp = new DtTest();
                            tmp.Huruf = CurrHuruf;
                            if (tmpHuruf == CurrHuruf)
                            {
                               int len = tmpResult.Count() - 1 ;
                                tmpResult[len].Jumlah += 1;
                            }
                            else
                            {
                                tmp.Jumlah = 1;
                                tmpResult.Add(tmp);
                            }
                            tmpHuruf = CurrHuruf;
                        }
                        Result = new AjaxResponse(new { success = true, data = Name, message = tmpResult });
                    }
                    else
                    {
                        Result = new AjaxResponse(new { success = true, data = Name, message = "" });
                    }
                    return Result;
                }
            }
            catch(UserFriendlyException ef)
            {
                 Result = new AjaxResponse(new { success = false, message = "data empty" });
                return Result;
            }
        }
    }

    public class DtTest
    {
        public int Jumlah { get; set; }
        public string Huruf { get; set; }
    }
    public class Result
    {
        public bool success { get; set; }
        public Object Message { get; set; }
    }
   
}

