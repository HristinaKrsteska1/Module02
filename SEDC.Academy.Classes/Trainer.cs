using SEDC.Academy.Interfaceses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Academy.Classes
{
    public class Trainer : IAcademyParticipation, ITrainerParticipation
    {
        public string FullName { get; set; }

        public string AttendClass(string className)
        {
            return $"Trainer: \"{this.FullName}\" attended class: \"{className}\"";
        }

        public string PrepareCourseMaterials(string courseName)
        {
            return $"Student: \"{this.FullName}\" finished laboratory exercise: \"{courseName}\"";
        }
    }
}
