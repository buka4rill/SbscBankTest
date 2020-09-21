using System;

namespace SbscBankTest.Models
{
    public class WorkforcePlanningOfficer
    {
        public string Name { get; set; }

        public string CurrentSkillLevel { get; set; } // Basic, Mid, Senior

        public string DesiredSkillLevel { get; set; }

        public string Department { get; set; }
    }
}