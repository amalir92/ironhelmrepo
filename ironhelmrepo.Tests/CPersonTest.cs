using System;
using Iron_helm_order_mgt;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iron_helm_order_mgt.Tests
{
    /// <summary>This class contains parameterized unit tests for CPerson</summary>
    [TestClass]
    [PexClass(typeof(CPerson))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CPersonTest
    {
    }
}
