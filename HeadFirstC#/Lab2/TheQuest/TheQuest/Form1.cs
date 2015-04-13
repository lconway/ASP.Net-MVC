using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void SetInventoryBorders()
        {
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
        }

        private void SetAttackForPotion()
        {
            attackUp.Text = "Drink";
            attackRight.Visible = false;
            attackDown.Visible = false;
            attackLeft.Visible = false;
        }

        private void ResetAttackButtons()
        {
            attackUp.Text = "↑";
            attackRight.Visible = true;
            attackDown.Visible = true;
            attackLeft.Visible = true;
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                if (game.WeaponInRoom.Name == "Sword" &&
                    game.WeaponInRoom.PickedUp)
                {
                    game.Equip("Sword");
                    SetInventoryBorders();
                    inventorySword.BorderStyle = BorderStyle.FixedSingle;
                    ResetAttackButtons();
                }
            }
        }

        private void inventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                if (game.WeaponInRoom.Name == "Bow" &&
                    game.WeaponInRoom.PickedUp)
                {
                    game.Equip("Bow");
                    SetInventoryBorders();
                    inventoryBow.BorderStyle = BorderStyle.FixedSingle;
                    ResetAttackButtons();
                }
            }
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                if (game.WeaponInRoom.Name == "Mace" &&
                    game.WeaponInRoom.PickedUp)
                {
                    game.Equip("Mace");
                    SetInventoryBorders();
                    inventoryMace.BorderStyle = BorderStyle.FixedSingle;
                    ResetAttackButtons();
                }
            }
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                if (game.WeaponInRoom.Name == "Red Potion" &&
                    game.WeaponInRoom.PickedUp)
                {
                    game.Equip("Red Potion");
                    SetInventoryBorders();
                    inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
                    SetAttackForPotion();
                }
            }
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                if (game.WeaponInRoom.Name == "Blue Potion" &&
                    game.WeaponInRoom.PickedUp)
                {
                    game.Equip("Blue Potion");
                    SetInventoryBorders();
                    inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
                    SetAttackForPotion();
                }
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            // Update the players location and stats
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            // Update each enemies location and hit points
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
                if (!showBat)
                {
                    bat.Visible = false;
                    batHitPoints.Text = "0";
                }
                else bat.Visible = true;
                if (!showGhost)
                {
                    ghost.Visible = false;
                    ghostHitPoints.Text = "0";
                }
                else ghost.Visible = true;
                if (!showGhoul)
                {
                    ghoul.Visible = false;
                    ghoulHitPoints.Text = "0";
                }
                else ghoul.Visible = true;
            }

            // Update the Weapon PictureBoxes
            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            bluePotion.Visible = false;
            redPotion.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Mace":
                    weaponControl = mace; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
            }
            weaponControl.Visible = true;

            // Set Visible property on each Inventory Icon PictureBox
            inventoryBluePotion.Visible = false;
            inventoryBow.Visible = false;
            inventoryMace.Visible = false;
            inventoryRedPotion.Visible = false;
            inventorySword.Visible = false;
            if (game.CheckPlayerInventory("Sword"))
                inventorySword.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                inventoryBow.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                inventoryMace.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                inventoryBluePotion.Visible = true;
            if (game.CheckPlayerInventory("Red Potion"))
                inventoryRedPotion.Visible = true;

            // If the weapon in the room has been picked up, make it invisible
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            // Have all enemies been defeated?
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
            else if (game.PlayerIsHit && game.PlayerHitPoints > 0)
            {
                MessageBox.Show("You have " + game.PlayerHitPoints + " hit points");
                game.ResetPlayerLocation();
            }
            // Has the player died?
            else if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
        }
    }
}
