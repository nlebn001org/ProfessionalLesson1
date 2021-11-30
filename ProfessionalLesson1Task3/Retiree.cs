using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson1Task3
{
    class Retiree : Citizen
    {

        int passNum;

        public Retiree(int passNum)
        {
            this.passNum = passNum;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType()) return false;
            Retiree r = obj as Retiree;
            return r.passNum == this.passNum ? true : false;
        }

        public override int GetHashCode()
        {
            return passNum * 5 + 24;
        }

        public override string ToString()
        {
            return $"Retiree with passNo: {passNum}";
        }
    }
}
