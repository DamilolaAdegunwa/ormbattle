#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;


namespace OrmBattle.TelerikModel.PerformanceTest	
{
	public partial class Simplest
	{
		private long id;
		public virtual long Id 
		{ 
		    get
		    {
		        return this.id;
		    }
		    set
		    {
		        this.id = value;
		    }
		}
		
		private long value;
		public virtual long Value 
		{ 
		    get
		    {
		        return this.value;
		    }
		    set
		    {
		        this.value = value;
		    }
		}
		
	}
}