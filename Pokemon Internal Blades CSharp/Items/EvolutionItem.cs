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
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EvolutionItem()
        {
            base.SetName("Thunder Stone");
            base.SetHoldable(true);

        }

        // TODO: Create EvolutionItem Constructor that takes parameters.

        private Pokemon[] m_pokemonEvolves; // A list of Pokemon that the Evolution Item evolves.

        /// <summary>
        /// Evolves the Target. This should check to see if it can evolve the target first using target.CanEvolve();
        /// </summary>
        /// <param name="target">The target of the Evolution Item.</param>
        public void EvolveTarget(Pokemon target)
        {
            base.SetTarget(target);

            if (target.CanEvolve())
            {
                if (target.MethodOfEvolution() >= 28 && target.MethodOfEvolution() <= 36)
                {
                    target.Evolve();
                }
            }

        }
    }
}
