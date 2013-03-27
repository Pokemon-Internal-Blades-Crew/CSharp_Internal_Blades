using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pokemon_Internal_Blades_CSharp.Items
{
    /// <summary>
    /// KeyItem class: Subclass of Item class
    /// </summary>
    public class KeyItem : Item
    {
        /// <summary>
        /// KeyItem Default Constructor
        /// </summary>
        public KeyItem()
        {
            base.SetName(" ");
            base.SetHoldable(false);
            base.SetValue(0);
        }

        // TODO: Create KeyItem constructor that takes parameters.

        public KeyItem(string name)
        {
            base.SetName(name);
            base.SetHoldable(false);
            base.SetValue(0);
        }
    }
}
