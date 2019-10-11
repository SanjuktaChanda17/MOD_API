using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MOD_BAL;
using MOD_DAL;

namespace MOD_TEST
{
    [TestFixture]
    public class TestUser
    {
        [Test]
        public void GetById()
        {
            user user = new user();
            UserDtl user1 = user.getUserById(6);
            Assert.IsNotNull(user1);
        }

        [Test]
        public void Register()
        {
            user user = new user();
            UserDtl user1 = new UserDtl()
            {
                firstName = "Purohit",
                lastName = "Purohit",
                userName = "Pu",
                password = "1234",
                email = "purohit@gmail.com",
                contactNumber = 9876350324,
                linkedinUrl = "www.linkedin1.com",
                yearOfExperience = 2,
                trainerTechnology = "Machine Learning",
                active = true,
                role = 2,
            };
            user.saveUser(user1);
            UserDtl user2 = user.getUserById(1003);
            Assert.IsNotNull(user2);
        }

        [Test]
        public void GetAllUser()
        {
            user user = new user();
            IList<UserDtl> p = user.getAllRegistered();
            Assert.IsNotNull(p);
        }

        [Test]
        public void BlockUser()
        {
            user user = new user();
            user.blockById(9);
            UserDtl user1 = user.getUserById(9);
            Assert.IsTrue(user1.active == false);

        }

        [Test]
        public void UnBlockUser()
        {
            user user = new user();
            user.unBlockById(9);
            UserDtl user1 = user.getUserById(9);
            Assert.IsTrue(user1.active == true);
        }


        [Test]
        public void getSkillById()
        {
            user user = new user();
            SkillDtl p = user.getSkillById(4);
            Assert.IsNotNull(p);
        }

        /*[Test]
        public void delete()
        {
            user user = new user();
            user.DeleteSkillById(1);
            SkillDtl sk = user.getSkillById(1002);
            Assert.IsTrue(sk == null);
        }
        */



    }
}
