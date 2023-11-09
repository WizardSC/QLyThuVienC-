using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangCapDTO
    {
        private int maBangCap;
        private string tenBangCap;

        public BangCapDTO() { }

        public BangCapDTO(int maBangCap, string tenBangCap)
        {
            this.MaBangCap = maBangCap;
            this.TenBangCap = tenBangCap;
        }

        public int MaBangCap { get => maBangCap; set => maBangCap = value; }
        public string TenBangCap { get => tenBangCap; set => tenBangCap = value; }
    }
}
