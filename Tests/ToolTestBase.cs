// Copyright (C) 2009-2010 ORMBattle.NET.
// All rights reserved.
// For conditions of distribution and use, see license.
// Created by: Alex Yakunin
// Created:    2009.08.28

using System;
using NUnit.Framework;
using Xtensive.Core;

namespace OrmBattle.Tests
{
    [TestFixture]
    public abstract class ToolTestBase
    {
        [SetUp]
        public virtual void BaseSetup()
        {
            Console.WriteLine("  Testing: {0} ({1})", ToolName, ShortToolName);
            Setup();
        }

        [TearDown]
        public virtual void BaseTearDown()
        {
            TearDown();
            if (Scorecard == null)
                Console.WriteLine();
        }

        public const string Unit = "Unit";
        public Scorecard Scorecard { get; set; }

        public abstract string ToolName { get; }
        public abstract string ShortToolName { get; }

        protected abstract void Setup();
        protected abstract void TearDown();

        protected void LogResult(string test, object result, string unit)
        {
            if (Scorecard != null)
            {
                Scorecard.Add(ShortToolName, test, result);
                Scorecard.Set(Unit, test, unit);
            }
            else
            {
                if (!test.IsNullOrEmpty())
                    Console.WriteLine("{0}: {1} {2}", test, result, unit);
            }
        }
    }
}