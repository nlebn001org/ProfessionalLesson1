using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson1Task3
{
    class Student : Citizen
    {


        int passNum;

        public Student(int passNum)
        {
            this.passNum = passNum;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType()) return false;
            Student s = obj as Student;
            return s.passNum == this.passNum ? true : false;
        }

        public override int GetHashCode()
        {
            return passNum * 45 + 34;
        }

        public override string ToString()
        {
            return $"Student with passNo: {passNum}";
        }

    }
}
