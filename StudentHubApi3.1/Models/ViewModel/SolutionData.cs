﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHubApi1.Models.ViewModel
{
    public class SolutionData
    {
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid QuestionId { get; set; }
        public List<ImageData> Images { get; set; }
    }
}
