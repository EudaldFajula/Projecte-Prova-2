using Prova_Practica2;

/*
 * Classes d'equivalencia:
 * Contrasenya.Length = {6--15}
 * Contrasenya.Values = {a-z,A-Z,0-9}
 * Contrasenya.Value = {H9ola, Ho9la, Hol9a}
 * Valors limit:
 * Constrasenya.Length = {5--16}
 * Contrasenya.Values = {+,*,@,/,\, etc..}
 * Contrasenya.Value = {9Hola, Hola9}
 * Casos de prova:
 * Constrasenya.Lenght:
 * Prova1
 * Valor introduit -> 6 
 * Valor esperat -> True
 * Prova2
 * Valor introduit -> 15
 * Valor esperat -> True
 * Prova3 
 * Valor introduit -> 10
 * Valor esperat -> True
 * Prova4
 * Valor introduit -> 5
 * Valor esperat -> False
 * Prova5
 * Valor introduit -> 16
 * Valor esperat -> False
 * Contrasenya.Values:
 * Prova1
 * Valor introduit -> As3ssd
 * Valor esperat -> True
 * Prova2
 * Valor introduit -> *@^|/\
 * Valor esperat -> False
 * Contrasenya.Value:
 * Prova1
 * Valor introduit -> H9olas
 * Valor esperat -> True
 * Prova2 
 * Valor introduit -> 9Holas
 * Valor esperat -> False
 */


namespace TestAct6
{
    [TestClass]
    public class ValidateContrasenyaLenght
    {
        [TestMethod]
        public void ValidateContrasenyaLenght6()
        {
            //Arrange
            string password = "iiiiii";
            //Act
            bool result = Activitat6.ContrasenyaLength(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateContrasenyaLenght15()
        {
            //Arrange
            string password = "iiiiiiiiiiiiiii";
            //Act
            bool result = Activitat6.ContrasenyaLength(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateContrasenyaLenght10()
        {
            //Arrange
            string password = "iiiiiiiiii";
            //Act
            bool result = Activitat6.ContrasenyaLength(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateContrasenyaLenght5()
        {
            //Arrange
            string password = "iiiii";
            //Act
            bool result = Activitat6.ContrasenyaLength(password);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidateContrasenyaLenght16()
        {
            //Arrange
            string password = "iiiiiiiiiiiiiiii";
            //Act
            bool result = Activitat6.ContrasenyaLength(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
    [TestClass]
    public class ValidateContrasenyaValues
    {
        [TestMethod]
        public void ValidateContrasenyaValues1()
        {
            //Arrange
            string password = "As3sss";
            //Act
            bool result = Activitat6.ContrasenyaValues(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateContrasenyaValues2()
        {
            //Arrange
            string password = "Hola/que";
            //Act
            bool result = Activitat6.ContrasenyaValues(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
    [TestClass]
    public class ValidateContrasenyaValue
    {
        [TestMethod]
        public void ValidateContrasenyaValue1()
        {
            //Arrange
            string password = "H9olas";
            //Act
            bool result = Activitat6.ContrasenyaValue(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateContrasenyaValue2()
        {
            //Arrange
            string password = "9Holas";
            //Act
            bool result = Activitat6.ContrasenyaValue(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
