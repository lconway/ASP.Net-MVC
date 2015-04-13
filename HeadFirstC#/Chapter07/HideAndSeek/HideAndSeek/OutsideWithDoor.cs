using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    class OutsideWithDoor: Outside, IHasExteriorDoor
    {
        private string doorDescription;
        public string DoorDescription
            { get { return doorDescription; } }

        public Location DoorLocation { get; set; }

        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + doorDescription
                    + ".";
            }
        }
    }
}
