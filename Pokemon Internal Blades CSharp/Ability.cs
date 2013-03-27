using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pokemon_Internal_Blades_CSharp
{
    public class Ability
    {
		private string m_name;			// m_name is the name of the Ability
		private string m_description;	// m_description is the description of the Ability
		private string m_effect;		// m_effect is the effect of the Ability
		private bool m_isHidden;		// Boolean value that tells if it is a hidden ability


		/// <summary>
		/// Default Constructor.  Sets name, description, and effect to " ".
		/// </summary>
		public Ability()
        {
            m_name = " ";				// Sets name to nothing
            m_description = " ";		// Sets description to nothing
            m_effect = " ";			    // Sets effect to nothing
            m_isHidden = false;			// Sets hidden to false
        }
        

        /// <summary>
        /// Constructor for new abilities. It is probably better not to use in favor of the next constructor.
        /// </summary>
        /// <param name="name">Name of the Ability.</param>
        /// <param name="desc">Description of the ability.</param>
        /// <param name="effect">Effect of the ability.</param>
        public Ability(string name, string desc, string effect) 
		{
            m_name = name;
            m_description = desc;
            m_effect = effect;
			m_isHidden = false;	// sets hidden to false.
		}


        /// <summary>
        /// Constructor for creating Hidden Abilities
        /// </summary>
        /// <param name="name">Name of the Ability</param>
        /// <param name="desc">Description of the Ability</param>
        /// <param name="effect">Effect of the Ability</param>
        /// <param name="hidden">Is the ability a hidden ability or not?</param>
		public Ability(string name, string desc, string effect, bool hidden) 
		{
            m_name = name;
            m_description = desc;
            m_effect = effect;
			m_isHidden = hidden;
		}

        /// <summary>
        /// Setter for the name.
        /// </summary>
        /// <param name="name">name of the ability.</param>
        public void SetName(string name)
        {
            m_name = name;
        }	

    }
}
