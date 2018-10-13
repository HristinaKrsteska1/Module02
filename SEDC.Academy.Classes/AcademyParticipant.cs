using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Academy.Classes
{
    public abstract class AcademyParticipant
    {
        public string FullName { get; set; }

        public abstract ParticipantType ParticipantTypeEnum { get; }
    }
}
