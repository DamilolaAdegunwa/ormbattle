﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace OrmBattle.NHibernateModel.Northwind
{
	[Serializable]
	public class AbstractTerritory
	{
		public virtual string Id { get; set; }

		public virtual string TerritoryDescription { get; set; }

		public virtual IList<Employee> Employees { get; set; }

		public virtual Region Region { get; set; }
	}

	[Serializable]
	public class Territory : AbstractTerritory
	{
	}
}