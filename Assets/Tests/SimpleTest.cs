using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;
using UnityEngine.TestTools;

public class SimpleTest
{
    [Test]
    public void NUnitTest()
    {
        NUnit.Framework.Assert.IsTrue(true);
    }

    [UnityTest]
    public IEnumerator UnityTest()
    {
        yield return null;

        UnityEngine.Assertions.Assert.IsTrue(true, "Unity Test Failed");
    }
}
