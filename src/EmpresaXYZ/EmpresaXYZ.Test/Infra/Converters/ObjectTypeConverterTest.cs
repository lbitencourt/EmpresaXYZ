using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EmpresaXYZ.Infra.Converters;

namespace EmpresaXYZ.Test.Infra.Converters
{
    [TestFixture(Category = UnitTestCategory.INFRA)]
    public class ObjectTypeConverterTest
    {
        [Test]
        public void DeveConverterParaNumeroInteiro()
        {
            var strNumero = "1";
            Assert.AreEqual(1, strNumero.ToInt32());
        }

        [Test]
        public void DeveConverterParaDateTime()
        {
            var strData = "11/11/1981";
            Assert.AreEqual(new DateTime(1981, 11, 11), strData.ToDateTime());
        }
    }
}
