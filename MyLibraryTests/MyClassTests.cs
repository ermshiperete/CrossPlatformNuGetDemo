// Copyright (c) 2015 SIL International
// This software is licensed under the MIT License (http://opensource.org/licenses/MIT)
using System;
using NUnit.Framework;
using MyLibrary;

namespace MyLibraryTests
{
	[TestFixture]
	public class MyClassTests
	{
		[Test]
		public void GetOne_ReturnsOne()
		{
			Assert.That(MyClass.GetOne(), Is.EqualTo(1));
		}
	}
}

