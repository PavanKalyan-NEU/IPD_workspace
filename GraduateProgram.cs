﻿namespace Northeastern_Personal_Workspace.Models
{
    public class GraduateProgram
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string DegreeLevel { get; set; }
        public string DegreeType { get; set; }
        public int TotalCourses { get; set; }
        public int Required { get; set; }
        public int Elective { get; set; }
        public int Capstone { get; set; }
        public decimal ComplexityScore { get; set; }
        public int Level4Topics { get; set; }
        public string AcademicDomain { get; set; }
        public bool IsCertificate { get; set; }
        public bool IsPhd { get; set; } // Added PhD support
        public string BinKey { get; set; }
        public string BoxSizeCategory { get; set; }
        public int BoxHeight { get; set; } = 45;
        public int BoxWidth { get; set; } = 150;
        public string BoxColor { get; set; }

    }
}