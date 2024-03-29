﻿using NUnit.Framework;
using sortName;
using System.Linq;
using System;
using System.Collections.Generic;

namespace UnitTests
{
	public class Tests
	{


		/// The only test:
		/// Read the given file and check that each name is lexically after the previous.
		[Test]
		public void TestSortName()
		{
			string[] names = { "Vane Bruce", "Emma Alice", "Kent Clark" };
			var name = Program.sortedNames(names);
			Assert.AreEqual("Emma Alice", name[0]);
			Assert.AreEqual("Vane Bruce", name[1]);
			Assert.AreEqual("Kent Clark", name[2]);

		}

		[Test]
		public void TesttheLastToFirst()
		{
			string example = "Kent Clark";
			string newName = Program.theLastToFirst(example);
			Assert.IsTrue(newName.Equals("Clark Kent"));

		}

	}
}
