using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MTIBASETEST9;


namespace MiApi.Controllers
{
    [Route("api/PART_SHIPPING")]
    [ApiController]
    
    public class PART_SHIPPINGController : ControllerBase
    {
        MTIBASETEST9Context intro = new MTIBASETEST9Context();
        // GET api/engineer
         [HttpGet]
        public dynamic Get()
        {
            

            return intro.PART_SHIPPING.ToList();
        }

        // GET api/values/5
        [HttpGet("{part}/{package}/{customer}")]
        public dynamic Get(string part, string package, string customer)
        {
            
            
            // var retorna = intro.PART_SHIPPING.Where(x => (x.PART_ID == part) && (x.PACKAGE_TYPE == package)).FirstOrDefault();  
            // return retorna;
            return intro.PART_SHIPPING.Where(x => (x.PART_ID == part) && (x.PACKAGE_TYPE == package) && (x.CUSTOMER_ID == customer)).FirstOrDefault();
        }

       
        

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

          // PUT api/values/5
        //[HttpPut("{id}")]
        // public PICK_LIST Put(int id, [FromBody] PICK_LIST value)
        // {
        //     if(value.STATUS == "C")
        //     {
        //         value.DEL_DATE = DateTime.Now;
        //         MegaEntity.Entry(value).State = EntityState.Modified;
        //         MegaEntity.SaveChanges();
        //     }
        //     else
        //     {
        //         MegaEntity.Entry(value).State = EntityState.Modified;
        //         MegaEntity.SaveChanges();
        //     }
        //     return value;
        // }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}
 