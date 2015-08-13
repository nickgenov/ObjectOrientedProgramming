using System;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Project : IProject
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
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Name", "Project name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }

        public DateTime StartDate { get; set; }

        public string Details { get; set; }

        public ProjectState State { get; set; }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            string output = string.Format("Project name: {0}, start: {1}, details: {2}, state: {3}", this.Name, this.State, this.Details, this.State);
            return output;
        }
    }
}