using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            shiftNumber = 0;
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            // Loop through all of the workers
            for (int i = 0; i < workers.Length; i++)
            {
                // Can this worker do this job?
                if (workers[i].DoThisJob(job, shifts))
                    return true;                // A worker was found to do this job
            }
            return false;           // No worker was found to do this job
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string reportStr = "Report for shift #" + shiftNumber + "\r\n";
            // Loop through all of the workers
            for (int i = 0; i < workers.Length; i++)
            {
                reportStr += "Worker #" + i;
                if (workers[i].DidYouFinish())
                {
                    reportStr += " finished the job";
                }
                else
                {
                    if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    {
                        reportStr += " is not working";
                    }
                    else
                    {
                        if (workers[i].ShiftsLeft == 0)
                        {
                            reportStr += " will be done with " + workers[i].CurrentJob + " after this shift";
                        }
                        else
                        {
                            reportStr += " is doing " + workers[i].CurrentJob + " for " + workers[i].ShiftsLeft + " more shifts";
                        }
                    }
                }
                reportStr += "\r\n";
            }

            return reportStr;
        }
    }
}
