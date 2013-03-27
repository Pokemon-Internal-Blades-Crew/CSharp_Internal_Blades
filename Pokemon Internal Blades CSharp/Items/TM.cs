using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Internal_Blades_CSharp.Items
{
    /// <summary>
    /// Technical Machine Class. TM is a subclass of Item.
    /// </summary>
    public class TM : Item
    {

        // The Move the TM holds.
        private Move m_moveTeaches; 
        
        // Determines TM or HM status. TMs are not reusable while HMs are.
        private bool m_isReusable;  

        /// <summary>
        /// Default Constructor
        /// Sets the name of the item to " ", holdable to false, Move to tackle, and reusable to false
        /// </summary>
        public TM()
        {
            base.SetName(" ");
            base.SetHoldable(false);
            SetMove(new Move());
            m_isReusable = false;
            base.SetSellable(true);
            base.SetValue(1000);
        }

        /// <summary>
        /// Technical Machine main constructor
        /// </summary>
        /// <param name="name">Name of the TM: This will typically be the same as the Move name</param>
        /// <param name="tm_move">The Move the TM teaches</param>
        /// <param name="isReusable">Determines TM or HM status</param>
        /// <param name="value">Value of the TM</param>
        public TM(string name, Move tm_move, bool isReusable, long value)
        {
            base.SetName(name);
            base.SetSellable(true);
            SetMove(tm_move);
            m_isReusable = isReusable;
            if (value > 0)
                base.SetValue(value);
            else if (value == 0)
                base.SetSellable(false);
            else
                base.SetValue(value *= -1);
            
        }

        /// <summary>
        /// Teaches the TM move to the target.
        /// </summary>
        /// <param name="target">The target of the Move held within the TM.</param>
        public void TeachMove(Pokemon target)
        {
            base.SetTarget(target);
        }

        /// <summary>
        ///  Sets the Move the TM holds. May change to private later.
        /// </summary>
        /// <param name="tm_move">Changes the Move the TM holds.</param>

        public void SetMove(Move tm_move)
        {
            m_moveTeaches = tm_move;
        }

        /// <summary>
        ///  Allows the TM to become reusable. This is useful, especially in the case of HMs
        /// </summary>
        /// <param name="isReusable">Sets TM or HM status. HMs are reusable, TMs are not.</param>
        
        public void SetReusable(bool isReusable)
        {
            m_isReusable = isReusable;
        }

    }
}
