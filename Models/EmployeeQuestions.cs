﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MIS4200Team5.Models
{
    public class EmployeeQuestions
    {
        public int EmployeeQuestionsID { get; set; }
        [DisplayName("What is your greatest strength?")]
        public string Q1 { get; set; }
        [DisplayName("What is your greatest weakness?")]
        public string Q2 { get; set; }
        [DisplayName("What do you like to do outside of work?")]
        public string Q3 { get; set; }
        [DisplayName("Where do you see yourself in 5 years?")]
        public string Q4 { get; set; }
        [DisplayName("Give us some more information about yourself, if you like.")]
        public string Q5 { get; set; }
        public ICollection<Profile> Profile { get; set; }
    }
}