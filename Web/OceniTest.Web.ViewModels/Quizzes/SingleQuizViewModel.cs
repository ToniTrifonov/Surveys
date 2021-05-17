﻿namespace OceniTest.Web.ViewModels.Quizzes
{
    using System;
    using System.Collections.Generic;

    using OceniTest.Data.Models;

    public class SingleQuizViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int QuestionsCount { get; set; }

        public int SubmitsCount { get; set; }

        public IEnumerable<Question> Questions { get; set; }
    }
}