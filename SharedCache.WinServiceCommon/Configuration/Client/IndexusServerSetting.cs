#region Copyright (c) Roni Schuetz - All Rights Reserved
// * --------------------------------------------------------------------- *
// *                              Roni Schuetz                             *
// *              Copyright (c) 2008 All Rights reserved                   *
// *                                                                       *
// * Shared Cache high-performance, distributed caching and    *
// * replicated caching system, generic in nature, but intended to         *
// * speeding up dynamic web and / or win applications by alleviating      *
// * database load.                                                        *
// *                                                                       *
// * This Software is written by Roni Schuetz (schuetz AT gmail DOT com)   *
// *                                                                       *
// * This library is free software; you can redistribute it and/or         *
// * modify it under the terms of the GNU Lesser General Public License    *
// * as published by the Free Software Foundation; either version 2.1      *
// * of the License, or (at your option) any later version.                *
// *                                                                       *
// * This library is distributed in the hope that it will be useful,       *
// * but WITHOUT ANY WARRANTY; without even the implied warranty of        *
// * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU      *
// * Lesser General Public License for more details.                       *
// *                                                                       *
// * You should have received a copy of the GNU Lesser General Public      *
// * License along with this library; if not, write to the Free            *
// * Software Foundation, Inc., 59 Temple Place, Suite 330,                *
// * Boston, MA 02111-1307 USA                                             *
// *                                                                       *
// *       THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE.        *
// * --------------------------------------------------------------------- *
#endregion 

// *************************************************************************
//
// Name:      IndexusServerSetting.cs
// 
// Created:   30-09-2007 Netcraft, rdayan: 
// Modified:  30-09-2007 Netcraft, rdayan: Creation
// Modified:  30-09-2007 SharedCache.com, rschuetz : added comments
// Modified:  24-02-2008 SharedCache.com, rschuetz : updated logging part for tracking, instead of using appsetting we use precompiler definition #if TRACE
// Modified:  28-01-2010 SharedCache.com, chrisme  : clean up code
// ************************************************************************* 


namespace SharedCache.WinServiceCommon.Configuration.Client
{
	/// <summary>
	/// Defines the config elements in config file (web.config / app.config)
	/// </summary>
	public class IndexusServerSetting : System.Configuration.ConfigurationElement
	{
		/// <summary>
		/// Returns the key value.
		/// </summary>
		[System.Configuration.ConfigurationProperty("key", IsRequired = true)]
		public string Key
		{
			[System.Diagnostics.DebuggerStepThrough]
			get
			{
				return this["key"] as string;
			}
		}

		/// <summary>
		/// Used to initialize a default set of values for the <see cref="T:System.Configuration.ConfigurationElement"></see> object.
		/// </summary>
		[System.Diagnostics.DebuggerStepThrough]
		protected override void InitializeDefault()
		{
			base.InitializeDefault();
		}
		/// <summary>
		/// Returns the setting value for the production environment.
		/// </summary>
		/// <value>The ip address.</value>
		[System.Configuration.ConfigurationProperty("ipaddress", IsRequired = true)]
		public string IpAddress
		{
			[System.Diagnostics.DebuggerStepThrough]
			get
			{
				return this["ipaddress"] as string;
			}
		}
		/// <summary>
		/// Returns the setting value for the development environment.
		/// </summary>
		/// <value>The port.</value>
		[System.Configuration.ConfigurationProperty("port", IsRequired = true)]
		public string Port
		{
			[System.Diagnostics.DebuggerStepThrough]
			get
			{
				return this["port"] as string;
			}
		}
	}
}
