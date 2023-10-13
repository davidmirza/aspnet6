using Microsoft.AspNetCore.Mvc;
using testwebapi.Models;

namespace testwebapi.Base
{
    public interface IBuyer
    {
        Task<List<Contact>> GetContacts();
      //  Task<ActionResult<Contact>> GetContact(string FirstName);
        Task<ActionResult<Contact>> postContact(Contact ctx);
        Task<ActionResult<dynamic>> InsertBuyer(Buyer byr);
        Task<ActionResult<dynamic>> test(string? Name = null);
    }
}
