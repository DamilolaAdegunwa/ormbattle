﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 10.08.2009 14:49:00
namespace OrmBattle.EFModel
{
    
    /// <summary>
    /// There are no comments for PerformanceTestEntities in the schema.
    /// </summary>
    public partial class PerformanceTestEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new PerformanceTestEntities object using the connection string found in the 'PerformanceTestEntities' section of the application configuration file.
        /// </summary>
        public PerformanceTestEntities() : 
                base("name=PerformanceTestEntities", "PerformanceTestEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new PerformanceTestEntities object.
        /// </summary>
        public PerformanceTestEntities(string connectionString) : 
                base(connectionString, "PerformanceTestEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new PerformanceTestEntities object.
        /// </summary>
        public PerformanceTestEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "PerformanceTestEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Simplest in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Simplest> Simplest
        {
            get
            {
                if ((this._Simplest == null))
                {
                    this._Simplest = base.CreateQuery<Simplest>("[Simplest]");
                }
                return this._Simplest;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Simplest> _Simplest;
        /// <summary>
        /// There are no comments for Simplest in the schema.
        /// </summary>
        public void AddToSimplest(Simplest simplest)
        {
            base.AddObject("Simplest", simplest);
        }
    }
    /// <summary>
    /// There are no comments for PerformanceTestModel.Simplest in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="PerformanceTestModel", Name="Simplest")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Simplest : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Simplest object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="value">Initial value of Value.</param>
        public static Simplest CreateSimplest(long id, long value)
        {
            Simplest simplest = new Simplest();
            simplest.Id = id;
            simplest.Value = value;
            return simplest;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private long _Id;
        partial void OnIdChanging(long value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public long Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this.ReportPropertyChanging("Value");
                this._Value = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Value");
                this.OnValueChanged();
            }
        }
        private long _Value;
        partial void OnValueChanging(long value);
        partial void OnValueChanged();
    }
}
