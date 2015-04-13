using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Enemy: Mover
    {
        private const int NearPlayerDistance = 25;

        public int HitPoints { get; private set; }
        public bool Dead
        {
            get
            {
                if (HitPoints <= 0) return true;
                else return false;
            }
        }

        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location)
        {
            HitPoints = hitPoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDirection(Point playerLocation, Random random)
        {
            //Direction directionToMove = (Direction)random.Next((int)Direction.Left, (int)Direction.Down);
            Direction directionToMove;
            if (playerLocation.X > location.X)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X)
                directionToMove = Direction.Left;
            else if (playerLocation.Y > location.Y)
                directionToMove = Direction.Down;
            else
                directionToMove = Direction.Up;

            return directionToMove;
        }
    }

    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }

        public override void Move(Random random)
        {
            if (HitPoints < 1)
            {
                return;
            }
            else 
            {
                Direction direction = Direction.Up;
                // 50% chance Bat will move toward player
                if (random.Next(1, 2) == 2)
                {
                    direction = FindPlayerDirection(game.PlayerLocation,random);
                }
                else
                {
                    // Bat moves in random direction
                    switch (random.Next(1,4))
                    {
                        case 1:
                            direction = Direction.Up;
                            break;
                        case 2:
                            direction = Direction.Down;
                            break;
                        case 3:
                            direction = Direction.Left;
                            break;
                        case 4:
                            direction = Direction.Right;
                            break;
                    }
                }
                base.location = Move(direction, game.Boundaries);
                if (NearPlayer())
                   game.HitPlayer(2, random);
            }
        }
    }

    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        { }

        public override void Move(Random random)
        {
            if (HitPoints < 1)
                return;
            else
                // 1 in 3 chance Ghost will move toward player
                if (random.Next(1, 3) == 1)
                {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation, random), game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(3, random);
                }
        }
    }

    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }

        public override void Move(Random random)
        {
            if (HitPoints < 1)
                return;
            else
                // 2 in 3 chance Ghoul will move toward player
                if (random.Next(1, 3) != 1)
                {
                    base.location = Move(FindPlayerDirection(game.PlayerLocation, random), game.Boundaries);
                    if (NearPlayer())
                        game.HitPlayer(4, random);
                }
        }
    }
}
