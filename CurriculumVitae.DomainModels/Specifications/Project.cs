﻿using System;

namespace CurriculumVitae.DomainModels.Specifications
{
    public class Project
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
    }
}