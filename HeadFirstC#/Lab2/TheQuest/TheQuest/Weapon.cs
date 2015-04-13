using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon: Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location)
            : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius,
                                    int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (enemy.Nearby(target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }

    class Sword : Weapon
    {

        public Sword(Game game, Point location)
            : base(game, location) { }

        public override string Name
        {
            get { return "Sword";  }
        }

        public override void Attack(Direction direction, Random random)
        {
            Direction attackRight = Direction.Up;
            Direction attackLeft = Direction.Up;
            switch (direction)
            {
                case Direction.Up:
                    attackRight = Direction.Right;
                    attackLeft = Direction.Left;
                    break;
                case Direction.Right:
                    attackRight = Direction.Down;
                    attackLeft = Direction.Up;
                    break;
                case Direction.Down:
                    attackRight = Direction.Left;
                    attackLeft = Direction.Right;
                    break;
                case Direction.Left:
                    attackRight = Direction.Up;
                    attackLeft = Direction.Down;
                    break;
            }
            if (DamageEnemy(direction, 10, 3, random))
                return;
            if (!DamageEnemy(attackRight, 10, 3, random))
                return;
            if (!DamageEnemy(attackLeft, 10, 3, random))
                return;
        }
    }

    class Bow : Weapon
    {

        public Bow(Game game, Point location)
            : base(game, location) { }

        public override string Name
        {
            get { return "Bow"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 30, 1, random);
        }
    }

    class Mace : Weapon
    {

        public Mace(Game game, Point location)
            : base(game, location) { }

        public override string Name
        {
            get { return "Mace"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            for (int i = 0; i < 4; i++)
                DamageEnemy((Direction)i, 30, 1, random);
        }
    }

    interface IPotion
    {
        bool Used { get; }
    }

    class BluePotion : Weapon, IPotion
    {
        public bool Used { get; private set; }

        public BluePotion(Game game, Point location)
            : base(game, location)
        {
            Used = false;
        }

        public override string Name
        {
            get { return "Blue Potion"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }

    class RedPotion : Weapon, IPotion
    {
        public bool Used { get; private set; }

        public RedPotion(Game game, Point location)
            : base(game, location)
        {
            Used = false;
        }

        public override string Name
        {
            get { return "Red Potion"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            Used = true;
        }
    }
}
