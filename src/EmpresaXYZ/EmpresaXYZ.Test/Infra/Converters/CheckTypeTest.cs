using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EmpresaXYZ.Infra.Converters;

namespace EmpresaXYZ.Test.Infra.Converters
{
    [TestFixture(Category = UnitTestCategory.INFRA)]
    public class CheckTypeTest
    {
        [Test]
        public void DeveRetornarTrueParaTipoInteiroComValorValido()
        {
            var strInteiro = "1";
            Assert.IsTrue(strInteiro.IsInteger());
        }

        [Test]
        public void DeveRetonarFalseParaTipoInterioComValorDecimal()
        {
            var strInteiroComDecimal = "1,5";
            Assert.IsFalse(strInteiroComDecimal.IsInteger());
        }
       
        [Test]
        public void DeveRetonarFalseParaTipoInterioComValorContendoChar()
        {
            var strInteiroComChar = "1xxxx,5xx";
            Assert.IsFalse(strInteiroComChar.IsInteger());
        }

        [Test]
        public void DeveRetornarTrueParaTipoDateTimeComDataValida()
        {
            var strData = "11/11/1981";
            Assert.IsTrue(strData.IsDateTime());
        }
        [Test]
        public void DeveRetornarFalseParaTipoDateTimeComDataInvalida()
        {
            var strData = "11/45/1981";
            Assert.IsFalse(strData.IsDateTime());
        }
    }
}
