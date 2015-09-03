﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.TeamFoundation.Authentication.Test
{
    /// <summary>
    /// A class to test <see cref="Configuration"/>.
    /// </summary>
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void ParseGitConfig_Simple()
        {
            const string input = @"
[core]
    autocrlf = false
";
            var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            using (var sr = new StringReader(input))
            {
                Configuration.ParseGitConfig(sr, values);
            }

            Assert.AreEqual("false", values["core.autocrlf"]);
        }
    }
}
