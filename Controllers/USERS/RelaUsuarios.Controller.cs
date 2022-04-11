using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISTA_RELACION_USUARIOS_OHR;

namespace MiApi.Controllers
{
    [Route("api/VISTA_RELACION_USUARIOS_OHR")]
    [ApiController]
    
    public class Users : ControllerBase
    {
        UsersContext intro = new UsersContext();
        // GET api/engineer
        // 

        // [HttpGet]

        // public dynamic GetN()
        // {
        //     return intro.VISTA_RELACION_USUARIOS.ToList();
        // }


        // GET api/values/5
        [HttpGet("{user_id}/{password}")]
       

        public dynamic GetU(string user_id, string password)
        {
            
            
            var retorna = intro.VISTA_RELACION_USUARIOS_OHR.Where(x => (x.USER_ID == user_id) && (x.PASSWORD == password)).ToList();  
            return retorna;
        }

        [HttpGet("{user_id}")]
        // [Route("ruta2")]
        public dynamic Get(string user_id)
        {
            return intro.VISTA_RELACION_USUARIOS_OHR.Where(x => (x.USER_ID == user_id)).ToList();
        }

        //  [HttpGet("{empleado}")]
        // public dynamic GetN(string empleado)
        // {
            
            
        //     return intro.VISTA_RELACION_USUARIOS_OHR.Where(x => (x.EMPLEADO == empleado)).ToList();     
        // }

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

          // PUT api/values/5
        [HttpPut("{id}")]
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
 