using System;
namespace APPDB{

public class G_NPI_CAMBIOS_STATUS
    {
        public int ROWID { get; set; }
        public string SO { get; set; }
        public string LINE { get; set; }
        
        public string ANTERIOR { get; set; }
        public string NUEVO { get; set; }
        public string RAZON { get; set; }
        public string USUARIO { get; set; }
        public Nullable<DateTime> FECHA { get; set; }
        // public List<Post> Posts { get; set; }
    }

}
