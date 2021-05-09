using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Response
    {
        public bool Signal { get; set; }
        public object PrijavljeniKorisnik { get; set; }
        public object Object{ get; set; }
        public Message Message { get; set; }
    }

    public enum Message
    {
        VecUlogovan
    }
}
