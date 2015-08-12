using System;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Classes
{
    public class Project
    {
        private string name;

        public Project(string name, DateTime startDate, string details, ProjectState state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Name", "Project name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }

        public DateTime StartDate { get; private set; }

        public string Details { get; set; }

        public ProjectState State { get; private set; }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }
    }
}