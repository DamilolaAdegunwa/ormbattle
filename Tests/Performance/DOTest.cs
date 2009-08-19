// Copyright (C) 2009 ORMBattle.net
// All rights reserved.
// For conditions of distribution and use, see license.
// Created by: Alexis Kochetov
// Created:    2009.07.29

using System;
using System.Linq;
using OrmBattle.DOModel;
using NUnit.Framework;
using Xtensive.Core.Disposing;
using Xtensive.Storage;
using Xtensive.Storage.Configuration;
using Xtensive.Storage.Rse;

namespace OrmBattle.Tests.Performance
{
  public class DOTest : TestBase
  {
    protected Domain domain;
    private SessionConsumptionScope sessionScope;
    private Session session;

    protected override void SetUp()
    {
      var config = DomainConfiguration.Load("mssql2005");
      config.Sessions.Add(new SessionConfiguration("Default"));
      // config.Sessions.Default.CacheType = SessionCacheType.LruWeak;
      config.Sessions.Default.CacheType = SessionCacheType.Infinite;
      config.Types.Register(typeof(Simplest).Assembly, typeof(Simplest).Namespace);
      domain = Domain.Build(config);
      using (Session.Open(domain))
      using (var ts = Transaction.Open()) {
        var query = Query.Execute(() => Query<Simplest>.All);
        foreach (var o in query)
          o.Remove();
        ts.Complete();
      }

      Console.Out.WriteLine();
      Console.Out.WriteLine("DataObjects.Net");
    }

    protected override void TearDown()
    {
      using (Session.Open(domain))
      using (var ts = Transaction.Open()) {
        var query = Query.Execute(() => Query<Simplest>.All);
        foreach (var o in query)
          o.Remove();
        ts.Complete();
      }
      domain.DisposeSafely();
    }

    protected override void OpenSession()
    {
      sessionScope = Session.Open(domain);
      session = sessionScope.Session;
    }

    protected override void CloseSession()
    {
      sessionScope.DisposeSafely();
    }

    protected override void InsertMultipleTest(int count)
    {
      using (var ts = Transaction.Open()) {
        for (int i = 0; i < count; i++)
          new Simplest(i, i);
        ts.Complete();
      }
      instanceCount = count;
    }

    protected override void UpdateMultipleTest()
    {
      using (var ts = Transaction.Open()) {
        var query = Query.Execute(() => Query<Simplest>.All);
        foreach (var o in query)
          o.Value++;
        ts.Complete();
      }
    }

    protected override void DeleteMultipleTest()
    {
      using (var ts = Transaction.Open()) {
        var query = Query.Execute(() => Query<Simplest>.All);
        foreach (var o in query)
          o.Remove();
        ts.Complete();
      }
    }

    protected override void InsertSingleTest(int count)
    {
      using (var ts = Transaction.Open()) {
        for (int i = 0; i < count; i++) {
          new Simplest(i, i);
          session.Persist();
        }
        ts.Complete();
      }
      instanceCount = count;
    }

    protected override void UpdateSingleTest()
    {
      using (var ts = Transaction.Open()) {
        var query = Query.Execute(() => Query<Simplest>.All);
        foreach (var o in query) {
          o.Value++;
          session.Persist();
        }
        ts.Complete();
      }
    }

    protected override void DeleteSingleTest()
    {
      using (var ts = Transaction.Open()) {
        var query = Query.Execute(() => Query<Simplest>.All);
        foreach (var o in query) {
          o.Remove();
          session.Persist();
        }
        ts.Complete();
      }
    }

    protected override void FetchTest(int count)
    {
      long sum = (long)count * (count - 1) / 2;
      using (var ts = Transaction.Open()) {
        for (int i = 0; i < count; i++) {
          var id = (long) i % instanceCount;
          var o = Query<Simplest>.SingleOrDefault(id);
          sum -= o.Id;
        }
        ts.Complete();
      }
      if (count <= instanceCount)
        Assert.AreEqual(0, sum);
    }

    protected override void LinqQueryTest(int count)
    {
      using (var ts = Transaction.Open()) {
        for (int i = 0; i < count; i++) {
          var id = i%instanceCount;
          var query = Query<Simplest>.All.Where(o => o.Id == id);
          foreach (var simplest in query) {
            // Doing nothing, just enumerate
          }
        }
        ts.Complete();
      }
    }

    protected override void CompiledLinqQueryTest(int count)
    {
      using (var ts = Transaction.Open()) {
        for (int i = 0; i < count; i++) {
          var id = i % instanceCount;
          var query = Query.Execute(() => Query<Simplest>.All.Where(o => o.Id == id));
          foreach (var simplest in query) {
            // Doing nothing, just enumerate
          }
        }
        ts.Complete();
      }
    }

    protected override void NativeQueryTest(int count)
    {
      var primaryIndex = session.Domain.Model.Types[typeof(Simplest)].Indexes.PrimaryIndex;
      long id = 0;
      var recordSet = primaryIndex.ToRecordSet().Filter(t => t.GetValueOrDefault<long>(0) == id);
      using (var ts = Transaction.Open()) {
        for (int i = 0; i < count; i++) {
          id = i % instanceCount;
          foreach (var simplest in recordSet.ToEntities<Simplest>(0)) {
            // Doing nothing, just enumerate
          }
        }
        ts.Complete();
      }
    }

    protected override void LinqMaterializeTest(int count)
    {
      using (var ts = Transaction.Open()) {
        int i = 0;
        while (i < count)
          foreach (var o in Query.Execute(() => Query<Simplest>.All.Where(s => s.Id > 0)))
            if (++i >= count)
              break;
        ts.Complete();
      }
    }

    protected override void NativeMaterializeTest(int count)
    {
      var primaryIndex = session.Domain.Model.Types[typeof(Simplest)].Indexes.PrimaryIndex;
      var simplests = primaryIndex.ToRecordSet().ToEntities<Simplest>(0);
      using (var ts = Transaction.Open()) {
        int i = 0;
        while (i < count) {
          foreach (var o in simplests)
            if (++i >= count)
              break;
        }
        ts.Complete();
      }
    }
  }
}