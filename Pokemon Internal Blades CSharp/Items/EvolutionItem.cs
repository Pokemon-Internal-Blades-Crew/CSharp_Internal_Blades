using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp.Items
{
    /// <summary>
    /// Evolution Item class
    /// </summary>
    public class EvolutionItem : Item
    {
        const int I_FIRE_STONE = 28;
        const int I_WATER_STONE = 29;
        const int I_THUNDERSTONE = 30;
        const int I_LEAF_STONE = 31;
        const int I_MOON_STONE = 32;
        const int I_SUN_STONE = 33;
        const int I_DAWN_STONE = 34;
        const int I_DUSK_STONE = 35;
        const int I_SHINY_STONE = 36;


        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EvolutionItem()
        {
            base.SetName("Fire Stone");
            SetStone();
            base.SetHoldable(true);
            base.SetValue(5000);
        }

        /// <summary>
        /// Constructor for an Evolution Item
        /// </summary>
        /// <param name="name">Name of the Evolution Item</param>
        /// <param name="value">Value of the Evolution Item</param>
        public EvolutionItem(string name, long value)
        {
            base.SetName(name);
            SetStone();
            base.SetHoldable(true);
            base.SetValue(Math.Abs(value));
        }


        private int m_stone;

        /// <summary>
        /// Evolves the Target. This should check to see if it can evolve the target first using target.CanEvolve();
        /// </summary>
        /// <param name="target">The target of the Evolution Item.</param>
        public void EvolveTarget(Pokemon target)
        {
            base.SetTarget(target);

            if (target.CanEvolve())
            {
                if (target.MethodOfEvolution() == m_stone)
                {
                    target.Evolve();
                }
            }

        }

        /// <summary>
        /// Sets the Stone Type for the Method EvolveTarget(Pokemon target);
        /// </summary>
        private void SetStone()
        {
            switch (base.GetName())
            {
                case "Water Stone":
                    m_stone = I_WATER_STONE;
                    break;
                case "Fire Stone":
                    m_stone = I_FIRE_STONE;
                    break;
                case "Thunderstone":
                    m_stone = I_THUNDERSTONE;
                    break;
                case "Leaf Stone":
                    m_stone = I_LEAF_STONE;
                    break;
                case "Moon Stone":
                    m_stone = I_MOON_STONE;
                    break;
                case "Sun Stone":
                    m_stone = I_SUN_STONE;
                    break;
                case "Shiny Stone":
                    m_stone = I_SHINY_STONE;
                    break;
                case "Dawn Stone":
                    m_stone = I_DAWN_STONE;
                    break;
                case "Dusk Stone":
                    m_stone = I_DUSK_STONE;
                    break;
                default:
                    m_stone = I_FIRE_STONE;
                    break;
            }
        }

    }
}
