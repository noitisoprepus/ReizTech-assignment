using System.Collections.Generic;

namespace ReizTech_Assignment
{
    public class Branch
    {
        public List<Branch> branches { get; set; }

        public Branch()
        {
            branches = new List<Branch>();
        }

    }
}
