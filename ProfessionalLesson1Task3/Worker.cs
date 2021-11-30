using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson1Task3
{
    class Worker : Citizen
    {

        int passNum;

        public Worker(int passNum)
        {
            this.passNum = passNum;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType()) return false;
            Worker w = obj as Worker;
            return w.passNum == this.passNum ? true : false;
        }

        public override int GetHashCode()
        {
            return passNum * 98 + 25;
        }

        public override string ToString()
        {
            return $"Worker with passNo: {passNum}";
        }

    }
}
