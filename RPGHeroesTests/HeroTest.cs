using RPGHeroes.Hero.Subclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroesTests
{
    public class HeroTest
    {
        [Fact]
        public void Hero_CreateHero_ShouldReturnCorrectName()
        {
            Ranger ranger = new Ranger("testRanger");

            string expected = "testRanger";
            string actual = ranger.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_LevelUp_ShouldReturnCorrectLevel()
        {
            Ranger ranger = new Ranger("testRanger");
            ranger.LevelUp();

            int expected = 2;
            int actual = ranger.Level;

            Assert.Equal(expected, actual);

        }
    }
}
