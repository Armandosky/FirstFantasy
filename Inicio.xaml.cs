using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (cbxCharacter.Text == "Cleric")
            {
                txtCharacter.Text = "The cleric knows that God forgives bad people, so it is his job to send his enemies to God." + "\n" + "Damage of Cleric = 700";
            }
            else
            {
                if (cbxCharacter.Text == "Fighter")
                {
                    txtCharacter.Text = "The fighter will always look for a way to fight, even if he falls, he will always get back up" + "\n" + "Damage of Fighter = 750";
                }
                else
                {
                    if (cbxCharacter.Text == "Rogue")
                    {
                        txtCharacter.Text = "The rogue will always use his cunning to get closer to the enemy and cause more damage."+"\n"+"Damage of Rogue = 680";
                    }
                    else
                    {
                        if (cbxCharacter.Text == "Wizard")
                        {
                            txtCharacter.Text = "The wizard can do great damage to the enemy, almost like magic." + "\n" + "Damage of Wizard = 730";
                        }
                    }
                }
            }
            if (cbxWeapon.Text == "Axe")
            {
                txtWeapon.Text = "Damage of Axe = 90";
            }
            else
            {
                if(cbxWeapon.Text == "Potion")
                {
                    txtWeapon.Text = "Damage of Potion = 80";
                }
                else
                {
                    if(cbxWeapon.Text == "Sword")
                    {
                        txtWeapon.Text = "Damage of Sword = 100";
                    }
                }
            }
        }
    }
}
