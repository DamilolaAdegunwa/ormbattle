using System;
using System.Collections.Generic;

namespace OrmBattle.TelerikModel.PerformanceTest
{
  // Generated by Telerik OpenAccess
  // Used template: c:\program files\telerik\openaccess orm\sdk\IDEIntegrations\templates\PCClassGeneration\cs\templates\classgen\class\partialuserdefault.vm
  // NOTE: Field declarations and 'Object ID' class implementation are added to the 'designer' file.
  //       Changes made to the 'designer' file will be overwritten by the wizard.  	
  public partial class Simplest
  {
    //The 'no-args' constructor required by OpenAccess. 
    public Simplest()
    {
    }

    public Simplest(long id, long value)
    {
      this.id = id;
      this.value = value;
    }

    [Telerik.OpenAccess.FieldAlias("id")]
    public long Id
    {
      get { return id; }
      set { this.id = value; }
    }

    [Telerik.OpenAccess.FieldAlias("value")]
    public long Value
    {
      get { return value; }
      set { this.value = value; }
    }


  }
}