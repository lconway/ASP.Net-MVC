using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class RoomWithDoor: Room, IHasExteriorDoor
    {
        private string doorDescription;
        public string DoorDescription
            { get { return doorDescription; } }

        public Location DoorLocation { get; set; }

        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
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
