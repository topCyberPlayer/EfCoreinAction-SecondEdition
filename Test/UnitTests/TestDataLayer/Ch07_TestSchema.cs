﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Test.Chapter07Listings;
using TestSupport.EfHelpers;
using Xunit;
using Xunit.Abstractions;
using Xunit.Extensions.AssertExtensions;

namespace Test.UnitTests.TestDataLayer
{
    public class Ch07_TestSchema
    {
        private readonly ITestOutputHelper _output;

        public Ch07_TestSchema(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestUpdatedOnQueryWithLogsOk()
        {
            //SETUP
            var logs = new List<string>();
            var options = this.CreateUniqueClassOptionsWithLogTo<Chapter07DbContext>(log => logs.Add(log));
            using (var context = new Chapter07DbContext(options))
            {
                //ATTEMPT
                context.Database.EnsureClean();

                //VERIFY
                logs.Any(x => x.Contains("EXEC(N'CREATE SCHEMA [Schema1];")).ShouldBeTrue();
                logs.Any(x => x.Contains("EXEC(N'CREATE SCHEMA [Schema2];")).ShouldBeTrue();
                foreach (var log in logs)
                {
                    _output.WriteLine(log);
                }
            }
        }
    }
}