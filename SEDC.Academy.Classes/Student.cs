using SEDC.Academy.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Academy.Classes
{
    public class Student : IStudentParticipation, IAcademyParticipation
    {
        public string FullName { get; set; }

        public string AttendClass(string className)
        {
           return $"Student: \"{this.FullName}\" attended classes: \"{className}\"";
        }

        public string DoLabExercise(string labName)
        {
            return $"Student: \"{this.FullName}\" finished laboratory exercise: \"{labName}\"";

        }
    }
}
