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


namespace OrmBattle.TelerikModel.Northwind	
{
	public partial class Order
	{
		private int orderID;
		public virtual int Id 
		{ 
		    get
		    {
		        return this.orderID;
		    }
		    set
		    {
		        this.orderID = value;
		    }
		}
		
		private string customerID;
		public virtual string CustomerID 
		{ 
		    get
		    {
		        return this.customerID;
		    }
		    set
		    {
		        this.customerID = value;
		    }
		}
		
		private int? employeeID;
		public virtual int? EmployeeID 
		{ 
		    get
		    {
		        return this.employeeID;
		    }
		    set
		    {
		        this.employeeID = value;
		    }
		}
		
		private DateTime? orderDate;
		public virtual DateTime? OrderDate 
		{ 
		    get
		    {
		        return this.orderDate;
		    }
		    set
		    {
		        this.orderDate = value;
		    }
		}
		
		private DateTime? requiredDate;
		public virtual DateTime? RequiredDate 
		{ 
		    get
		    {
		        return this.requiredDate;
		    }
		    set
		    {
		        this.requiredDate = value;
		    }
		}
		
		private DateTime? shippedDate;
		public virtual DateTime? ShippedDate 
		{ 
		    get
		    {
		        return this.shippedDate;
		    }
		    set
		    {
		        this.shippedDate = value;
		    }
		}
		
		private int? shipVia;
		public virtual int? ShipVia 
		{ 
		    get
		    {
		        return this.shipVia;
		    }
		    set
		    {
		        this.shipVia = value;
		    }
		}
		
		private decimal freight;
		public virtual decimal Freight 
		{ 
		    get
		    {
		        return this.freight;
		    }
		    set
		    {
		        this.freight = value;
		    }
		}
		
		private string shipName;
		public virtual string ShipName 
		{ 
		    get
		    {
		        return this.shipName;
		    }
		    set
		    {
		        this.shipName = value;
		    }
		}
		
		private string shipAddress;
		public virtual string ShipAddress 
		{ 
		    get
		    {
		        return this.shipAddress;
		    }
		    set
		    {
		        this.shipAddress = value;
		    }
		}
		
		private string shipCity;
		public virtual string ShipCity 
		{ 
		    get
		    {
		        return this.shipCity;
		    }
		    set
		    {
		        this.shipCity = value;
		    }
		}
		
		private string shipRegion;
		public virtual string ShipRegion 
		{ 
		    get
		    {
		        return this.shipRegion;
		    }
		    set
		    {
		        this.shipRegion = value;
		    }
		}
		
		private string shipPostalCode;
		public virtual string ShipPostalCode 
		{ 
		    get
		    {
		        return this.shipPostalCode;
		    }
		    set
		    {
		        this.shipPostalCode = value;
		    }
		}
		
		private string shipCountry;
		public virtual string ShipCountry 
		{ 
		    get
		    {
		        return this.shipCountry;
		    }
		    set
		    {
		        this.shipCountry = value;
		    }
		}
		
		private Customer customer;
		public virtual Customer Customer 
		{ 
		    get
		    {
		        return this.customer;
		    }
		    set
		    {
		        this.customer = value;
		    }
		}
		
		private Employee employee;
		public virtual Employee Employee 
		{ 
		    get
		    {
		        return this.employee;
		    }
		    set
		    {
		        this.employee = value;
		    }
		}
		
		private Shipper shipper;
		public virtual Shipper Shipper 
		{ 
		    get
		    {
		        return this.shipper;
		    }
		    set
		    {
		        this.shipper = value;
		    }
		}
		
		private IList<OrderDetail> orderDetails = new List<OrderDetail>();
		public virtual IList<OrderDetail> OrderDetails 
		{ 
		    get
		    {
		        return this.orderDetails;
		    }
		}
		
	}
}