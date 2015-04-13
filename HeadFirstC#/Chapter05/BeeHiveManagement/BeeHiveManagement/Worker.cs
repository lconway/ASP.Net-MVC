using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Worker
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private string currentJob;
        public string CurrentJob
        {
            get { return currentJob; }
        }
        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int shifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;           // Worker is already doing a job
                // Loop through all of the jobs this worker can do
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    // Found a match
                    currentJob = job;
                    shiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            // This worker can't do this job
            return false;
        }

        public bool DidYouFinish()
        {
            // Is this worker currently working a job?
            if (!string.IsNullOrEmpty(currentJob))
            {
                // This worker is working a job.
                shiftsWorked++;
                if (shiftsWorked > shiftsToWork)
                {
                    // Job is completed during this shift
                    shiftsToWork = 0;
                    shiftsWorked = 0;
                    currentJob = "";
                    return true;
                }
            }
            // Either worker not currently working or 
            // is working but hasn't finished yet
            return false;
        }
    }
}
