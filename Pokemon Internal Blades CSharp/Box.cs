using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace Pokemon_Internal_Blades_CSharp
{

    public class Box
    {
        private ArrayList m_box = new ArrayList(30);
        private static int m_boxCounter = 0;

        public Box()
        {
        }

        /// <summary>
        /// Adds the Pokemon target to the Box
        /// </summary>
        /// <param name="target">Pokemon to add to the Box</param>
        public void AddPokemonToBox(Pokemon target)
        {
            m_box.Add(target);
            m_boxCounter++;
        }

        /// <summary>
        /// Removes pokemon from the Box if it finds it.
        /// </summary>
        /// <param name="pokemon">Pokemon to search for.</param>
        /// <returns>A Pokemon object</returns>
        public Pokemon WithdrawPokemonBox(Pokemon pokemon)
        {
            try
            {
                int index = m_box.IndexOf(pokemon);

                Pokemon target = (Pokemon)m_box[index];
                m_box.RemoveAt(index);
                m_boxCounter--;

                return target;
            }
            catch
            {
                Console.WriteLine("Error: Pokemon Not in Box.");
                return pokemon;
            }
        }

        /// <summary>
        /// Returns the Counter of the Box
        /// </summary>
        /// <returns></returns>
        public int GetCounter()
        {
            return m_boxCounter;
        }

        public ArrayList GetBox()
        {
            return m_box;
        }

    }

    public class BoxSystem
    {
        private Box[] m_boxSystem;
        private static int m_boxSystemCounter = 0;

        public BoxSystem()
        {
            m_boxSystem = new Box[20];
        }

        /// <summary>
        /// Adds the Pokemon to a Box somewhere
        /// </summary>
        /// <param name="target">Pokemon to be added to a box</param>
        public void AddPokemonToBoxSystem(Pokemon target)
        {
            for (int index = 0; index < 20; index++)
            {
                if (m_boxSystem[index].GetCounter() <= 50)
                {
                    m_boxSystem[m_boxSystemCounter].AddPokemonToBox(target);
                    break;
                }
            }
            
        }

        /// <summary>
        /// Searches for a pokemon and returns it if it is found.
        /// </summary>
        /// <param name="name">Pokemon to search for</param>
        /// <returns>A Pokemon</returns>
        public Pokemon WithdrawPokemonBoxSystem(Pokemon pokemon)
        {
            Pokemon targ = pokemon;
            for (int index = 0; index < m_boxSystem.Length; index++)
            {
                if (m_boxSystem[index].GetBox().Contains(pokemon))
                {
                    targ = m_boxSystem[index].WithdrawPokemonBox(pokemon);
                }
            }
            return targ;
        }

    }

}
