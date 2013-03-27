using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pokemon_Internal_Blades_CSharp
{
    public class Item
    {
		private Pokemon m_target;
        private string m_name;		// Name of the item
        private bool     m_isHoldable;
        private long m_value;
        private bool m_isSellable;

        /// <summary>
        /// Default Constructor. Sets m_name to nothing.
        /// </summary>
        public Item()
        {
            m_name = "";
            m_isHoldable = true;
            m_value = 50;
        }

		/// <summary>
		/// Constructor. Sets m_name to name. Defaults to IsHoldable
		/// </summary>
		/// <param name="name">Name of the Item</param>
        /// <param name="value">Value of the Item</param>
        public Item(string name, long value)
        {
            m_name = name;
            m_isHoldable = true;
            m_value = value;
        }
			
		/// <summary>
		/// Used to return the name of the item
		/// </summary>
		/// <returns>m_name</returns>
        public string GetName()
        {
            return m_name;
        }

		/// <summary>
		/// Sets the target of the item
		/// </summary>
		/// <param name="target">The target of the item.</param>
        public void SetTarget(Pokemon target)
        {
            m_target = target;
        }

		/// <summary>
		/// Returns the target of the item.
		/// </summary>
		/// <returns>m_target</returns>
        public Pokemon GetTarget()
        {
            return m_target;
        }

		/// <summary>
		/// Used to set the name of the item
		/// </summary>
		/// <param name="name">Sets the name of the item</param>
        public void SetName(string name)
        {
            m_name = name;
        }

        /// <summary>
        /// Used to make the item holdable. Primarily used by subclasses.
        /// </summary>
        /// <param name="isBoolean">True: isHoldable   False: isNotHoldable</param>
        public void SetHoldable(bool isBoolean)
        {
            m_isHoldable = isBoolean;
        }

        /// <summary>
        /// Returns the holdability of the item
        /// </summary>
        /// <returns>m_isHoldable</returns>
        public bool GetHoldable()
        {
            return m_isHoldable;
        }

        /// <summary>
        /// Sets the Value of the Item
        /// </summary>
        /// <param name="value">The value of the Item</param>
        public void SetValue(long value)
        {
            if (value > 0)
                m_value = value;
            else if (value < 0)
                m_value = -value;
            else
            {
                m_value = 0;
                SetSellable(false);
            }
        }

        /// <summary>
        /// Returns the value of the item.
        /// </summary>
        /// <returns>long m_value</returns>
        public long GetValue()
        {
            return m_value;
        }

        /// <summary>
        /// Sets the status of the sellability of the Item to bool sellable
        /// </summary>
        /// <param name="sellable">True is sellable, false if not.</param>
        public void SetSellable(bool sellable)
        {
            m_isSellable = sellable;
        }

        /// <summary>
        /// Returns the sellability of the Item
        /// </summary>
        /// <returns>bool m_isSellable</returns>
        public bool IsSellable()
        {
            return m_isSellable;
        }

    }
}
