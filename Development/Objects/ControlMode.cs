﻿//
// --------------------------------------------------------------------------
//  Gurux Ltd
// 
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License 
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
//
// More information of Gurux products: http://www.gurux.org
//
// This code is licensed under the GNU General Public License v2. 
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

namespace Gurux.DLMS.Objects
{
    /// <summary>
    /// Configures the behaviour of the disconnect control object for all
    /// triggers, i.e. the possible state transitions.
    /// </summary>
    public enum ControlMode
    {
        /// <summary>
        /// The disconnect control object is always in 'connected' state,
        /// </summary>
        None,
        /// <summary>
        /// Disconnection: Remote (b, c), manual (f), local (g) 
        /// Reconnection: Remote (d), manual (e).
        /// </summary>
        Mode1,
        /// <summary>
        /// Disconnection: Remote (b, c), manual (f), local (g) 
        /// Reconnection: Remote (a), manual (e).
        /// </summary>
        Mode2,
        /// <summary>
        /// Disconnection: Remote (b, c), manual (-), local (g) 
        /// Reconnection: Remote (d), manual (e).
        /// </summary>
        Mode3,
        /// <summary>
        /// Disconnection: Remote (b, c), manual (-), local (g) 
        /// Reconnection: Remote (a), manual (e)
        /// </summary>
        Mode4,
        /// <summary>
        /// Disconnection: Remote (b, c), manual (f), local (g) 
        /// Reconnection: Remote (d), manual (e), local (h),
        /// </summary>
        Mode5,
        /// <summary>
        ///Disconnection: Remote (b, c), manual (-), local (g) 
        ///Reconnection: Remote (d), manual (e), local (h)
        /// </summary>
        Mode6,
    }
}
