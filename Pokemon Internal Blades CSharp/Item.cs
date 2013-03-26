using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp
{
    public class Item
    {
		private Pokemon m_target;
        private string m_name;		// Name of the item
        private bool     m_isHoldable;    

		// Default Constructor. Sets m_name to nothing.
        public Item()
        {
            m_name = "";
            m_isHoldable = true;
        }
		// Real Constructor.  Sets m_name to name.
        public Item(string name)
        {
            m_name = name;
            m_isHoldable = true;
        }
			
		// returns the name of the item
        public string GetName()
        {
            return m_name;
        }

		// Sets the target of the item
        public void SetTarget(Pokemon target)
        {
            m_target = target;
        }

		// Gets the target of the item
        public Pokemon GetTarget()
        {
            return m_target;
        }

		// Sets the name of the item to 'name'
        public void SetName(string name)
        {
            m_name = name;
        }

        public void SetHoldable(bool isBoolean)
        {
            m_isHoldable = isBoolean;
        }

        public bool GetHoldable()
        {
            return m_isHoldable;
        }

    }
}
