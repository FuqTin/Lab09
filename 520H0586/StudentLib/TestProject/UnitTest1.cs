using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score10_LetterA()
        {
            Student s = new Student();
            s.Score = 10;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score9_LetterA()
        {
            Student s = new Student();
            s.Score = 9;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score8_LetterA()
        {
            Student s = new Student();
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score7_LetterB()
        {
            Student s = new Student();
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score10_Dont_ThrownExcep()
        {
            Student s = new Student();
            s.Score = 10;
            Assert.IsTrue(s.Score >= 0 && s.Score <= 10);
        }

        [TestMethod]
        public void ScoreLessThan0_ThrownExcep()
        {
            Student s = new Student();
            s.Score = -1;
            Assert.IsTrue(s.Score >= 0 && s.Score <= 10);
        }

        [TestMethod]
        public void ScoreGreaterThan10_ThrownExcep()
        {
            Student s = new Student();
            s.Score = 11;
            Assert.IsTrue(s.Score >= 0 && s.Score <= 10);
        }

        [TestMethod]
        public void Null_AnException_Thrown()
        {
            StudentService sv = new StudentService();
            Student s = null;
            bool hasException = false;

            try
            {
                sv.addStudent(s);
            }
            catch (NullReferenceException e)
            {
                hasException = true;
            }

            Assert.IsTrue(hasException);
        }

    }
}
