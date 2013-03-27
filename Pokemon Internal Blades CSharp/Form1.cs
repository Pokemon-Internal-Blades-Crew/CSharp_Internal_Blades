using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pokemon_Internal_Blades_CSharp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// NONE should be used only when the program is asking for a second type and the pokemon does not technically have one.
        /// </summary>
        const int NONE = 0;
        /// <summary>
        /// Normal Type
        /// Supereffective Against:			N/A
        /// Half Damage Dealt:				Fighting
        /// No Damage to:					Ghost
        /// No Damage from:					Ghost
        /// </summary>
        const int NORMAL = 1;
        /// <summary>
        /// Fighting Type
        /// Supereffective Against:			Normal, Ice, Rock, Dark, Steel
        /// Half Damage Dealt:				Poison, Flying, Psychic, Bug
        /// No Damage to:					Ghost
        /// No Damage from:					N/A
        /// </summary>
        const int FIGHTING = 2;
        /// <summary>
        /// Fire Type
        /// Supereffective Against:			Grass, Ice, Steel, Bug		
        /// Half Damage Dealt:				Fire, Water, Rock, Dragon
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int FIRE = 3;
        /// <summary>
        /// Water Type
        /// Supereffective Against:			Fire, Ground, Rock	
        /// Half Damage Dealt:				Water, Grass, Dragon
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int WATER = 4;
        /// <summary>
        /// Ice Type
        /// Supereffective Against:			Grass, Flying, Ground, Dragon	
        /// Half Damage Dealt:				Fire, Water, Ice, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int ICE = 5;
        /// <summary>
        /// Grass Type
        /// Supereffective Against:			Water, Ground, Rock		
        /// Half Damage Dealt:				Fire, Grass, Poison, Flying, Bug, Dragon, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int GRASS = 6;
        /// <summary>
        /// Bug Type
        /// Supereffective Against:			Psychic, Dark, Grass		
        /// Half Damage Dealt:				Fire, Fighting, Poison, Fighting, Ghost, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int BUG = 7;
        /// <summary>
        /// Poison Type
        /// Supereffective Against:			Grass		
        /// Half Damage Dealt:				Poison, Ground, Rock, Ghost
        /// No Damage to:					Steel
        /// No Damage from:					N/A
        /// </summary>
        const int POISON = 8;
        /// <summary>
        /// Flying Type
        /// Supereffective Against:			Bug, Grass, Fighting		
        /// Half Damage Dealt:				Electric, Rock, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Ground
        /// </summary>
        const int FLYING = 9;
        /// <summary>
        /// Psychic Type
        /// Supereffective Against:			Fighting, Poison		
        /// Half Damage Dealt:				Psychic, Steel
        /// No Damage to:					Dark
        /// No Damage from:					N/A
        /// </summary>
        const int PSYCHIC = 10;
        /// <summary>
        /// Ghost Type
        /// Supereffective Against:			Psychic, Ghost		
        /// Half Damage Dealt:				Dark, Steel
        /// No Damage to:					Normal
        /// No Damage from:					Normal, Fighting
        /// </summary>
        const int GHOST = 11;
        /// <summary>
        /// Dark Type
        /// Supereffective Against:			Psychic, Ghost		
        /// Half Damage Dealt:				Fighting, Dark, Steel
        /// No Damage to:					N/A
        /// No Damage from:					Psychic
        /// </summary>
        const int DARK = 12;
        /// <summary>
        /// Ground Type
        /// Supereffective Against:			Fire, Electric, Poison, Rock, Steel		
        /// Half Damage Dealt:				Water, Grass, Ice
        /// No Damage to:					Flying
        /// No Damage from:					Electric
        /// </summary>
        const int GROUND = 13;
        /// <summary>
        /// Steel Type
        /// Supereffective Against:			Ice, Bug		
        /// Half Damage Dealt:				Fire, Ice, Ground
        /// No Damage to:					N/A
        /// No Damage from:					Poison
        /// </summary>
        const int STEEL = 14;
        /// <summary>
        /// Rock Type
        /// Supereffective Against:			Fire, Ice, Flying, Bug		
        /// Half Damage Dealt:				Fighting, Ground, Steel
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int ROCK = 15;
        /// <summary>
        /// Electric Type
        /// Supereffective Against:			Water, Flying		
        /// Half Damage Dealt:				Electric, Grass, Dragon
        /// No Damage to:					Ground
        /// No Damage from:					N/A
        /// </summary>
        const int ELECTRIC = 16;
        /// <summary>
        /// Dragon Type
        /// Supereffective Against:			Dragon		
        /// Half Damage Dealt:				Dragon, Ice
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int DRAGON = 17;
        /// <summary>
        /// Shadow Type
        /// Supereffective Against:			All but Shadow		
        /// Half Damage Dealt:				Shadow
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int SHADOW = 18;
        /// <summary>
        /// ??? Type
        /// Supereffective Against:			N/A
        /// Double Damage taken:			N/A
        /// Half Damage Dealt:				N/A
        /// No Damage to:					N/A
        /// No Damage from:					N/A
        /// </summary>
        const int UNKNOWN = 19;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void TestPokeballFormula(int iterations, double statusMod, int catchRate, int currentHP, int level)
        {
            richTextBox1.Clear();
            Pokemon eevee = new Pokemon("Eevee", "the Mutation Pokemon", NORMAL, NONE, true, 5, 1);
            eevee.SetBaseStats(55, 55, 45, 50, 65, 55);
            Player player = new Player("Kyle", 0, eevee);

            Pokeball pokeball = new Pokeball();
            Pokeball greatBall = new Pokeball("Greatball", 300, 1.5);
            Pokeball ultraBall = new Pokeball("Ultraball", 1000, 2.0);

            for (int i = 0; i < iterations; i++)
            {
                
                Pokemon starly = new Pokemon("Starly", "the Bird Pokemon", NORMAL, FLYING, false, level, catchRate);
                starly.SetBaseStats(40, 55, 30, 30, 30, 60);
                starly.SetCurrentHP(currentHP);

                int number = 1;// Pokemon.GetRandom(1, 3);
                //richTextBox1.AppendText(((int)pokeball.TestCaptureValue(starly, 1.5)).ToString() + "\n");
                
                if (number == 1)
                {
                    richTextBox1.AppendText("POKEBALL GO!\n\n");
                    pokeball.Catch(player, starly);
                    richTextBox1.AppendText(pokeball.m_test4);
                }/*
                else if (number == 2)
                {
                    richTextBox1.AppendText("GREATBALL GO!\n\n");
                    greatBall.Catch(player, starly);
                    richTextBox1.AppendText(greatBall.m_test4);
                }
                else
                {
                    richTextBox1.AppendText("ULTRABALL GO!\n\n");
                    ultraBall.Catch(player, starly);

                    richTextBox1.AppendText(ultraBall.m_test4);
                }*/
                
            }
        }

        public void TestPokeballFormula(double statusMod, int catchRate, int currentHP, double ballMod, int level)
        {
            richTextBox1.Clear();
            Pokemon eevee = new Pokemon("Eevee", "the Mutation Pokemon", NORMAL, NONE, true, 5, 1);
            eevee.SetBaseStats(55, 55, 45, 50, 65, 55);
            Player player = new Player("Kyle", 0, eevee);

            Pokeball pokeball = new Pokeball();
            pokeball.SetBallMod(ballMod);
            Pokemon starly = new Pokemon("Starly", "the Bird Pokemon", NORMAL, FLYING, false, level, catchRate);
            starly.SetBaseStats(40, 55, 30, 30, 30, 60);
            starly.SetCurrentHP(currentHP);

            richTextBox1.AppendText(((int)pokeball.TestCaptureValue(starly, statusMod)).ToString() + "\n\n");
            richTextBox1.AppendText(((int)pokeball.TestCaptureFormula2(starly, statusMod)).ToString() + "\n\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double statusMod = (double)numericUpDown1.Value;
            int catchRate = (int)numericUpDown2.Value;
            int currentHP = (int)numericUpDown3.Value;
            double ballMod = (double)numericUpDown4.Value;
            TestPokeballFormula(statusMod, catchRate, currentHP, ballMod, (int)numericUpDown6.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestPokeballFormula((int)numericUpDown5.Value, (double)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown6.Value);
        }
    }
}
