﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

/**********************************************************
* USING NAMESPACES
**********************************************************/
using System;

namespace QuantConnect.Orders
{
    /******************************************************** 
    * ORDER CLASS DEFINITION
    *********************************************************/
    /// <summary>
    /// Market order type definition
    /// </summary>
    public class MarketOrder : Order
    {
        /// <summary>
        /// Added a default constructor for JSON Deserialization:
        /// </summary>
        public MarketOrder()
        {
            Type = OrderType.Market;
        }

        /// <summary>
        /// Value of the order at market price.
        /// </summary>
        public override decimal Value
        {
            get
            {
                return Convert.ToDecimal(Quantity) * Price;
            }
        }

        /// <summary>
        /// New market order constructor
        /// </summary>
        /// <param name="symbol">Symbol asset we're seeking to trade</param>
        /// <param name="type">Type of the security order</param>
        /// <param name="quantity">Quantity of the asset we're seeking to trade</param>
        /// <param name="time">Time the order was placed</param>
        /// <param name="tag">User defined data tag for this order</param>
        public MarketOrder(string symbol, int quantity, DateTime time, string tag = "", SecurityType type = SecurityType.Base) :
            base(symbol, quantity, OrderType.Market, time, 0, tag, type)
        {
            Type = OrderType.Market;
        }
    }

} // End QC Namespace:
