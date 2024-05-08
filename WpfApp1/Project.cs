using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Project
    {
        public int ProjectId {  get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public ICollection<Developer> Developers { get; set; }
        public Project(int projectId, string name, DateTime startTime, DateTime endTime)
        {
            ProjectId = projectId;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Developers = new List<Developer>();
        }
        public Project(int projectId, string name, DateTime startTime, DateTime endTime,ICollection<Developer> developers)
        {
            ProjectId = projectId;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Developers = developers;
        }
    }
}
