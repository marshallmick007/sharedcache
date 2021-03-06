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
// Name:      IndexusServerProviderCollection.cs
// 
// Created:   31-12-2007 SharedCache.com, rschuetz
// Modified:  31-12-2007 SharedCache.com, rschuetz : Creation
// Modified:  31-12-2007 SharedCache.com, rschuetz : same as the client but element names are differnt
// Modified:  24-02-2008 SharedCache.com, rschuetz : updated logging part for tracking, instead of using appsetting we use precompiler definition #if TRACE
// Modified:  28-01-2010 SharedCache.com, chrisme  : clean up code
// ************************************************************************* 


using System;
using System.Configuration.Provider;

namespace SharedCache.WinServiceCommon.Provider.Server
{
	/// <summary>
	/// Represents a collection of provider objects that inherit from System.Configuration.Provider.ProviderCollection
	/// </summary>
	public class IndexusServerProviderCollection : ProviderCollection
	{
		/// <summary>
		/// Gets the <see cref="SharedCache.WinServiceCommon.Provider.Cache.IndexusProviderBase"/> with the specified name.
		/// </summary>
		/// <value></value>
		public new IndexusServerProviderBase this[string name]
		{
			get
			{
				return (IndexusServerProviderBase)base[name];
			}
		}

		/// <summary>
		/// Adds a provider to the collection.
		/// </summary>
		/// <param name="provider">The provider to be added.</param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Configuration.Provider.ProviderBase.Name"></see> of provider is null.- or -The length of the <see cref="P:System.Configuration.Provider.ProviderBase.Name"></see> of provider is less than 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">provider is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
		/// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
		public override void Add(ProviderBase provider)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("IndexusProviderBase");
			}

			if (!(provider is IndexusServerProviderBase))
			{
				throw new ArgumentException("Invalid provider type", "IndexusProviderBase");
			}

			base.Add(provider);
		}
	}
}
