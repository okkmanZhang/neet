//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AllChallenge.at.Test1;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AllChallenge.at.Tests
//{
//    [TestClass()]
//    public class SnakeGameTestTests
//    {
//        /*
//             height 2, width 3
//            X 0 0
//            0 1 0

//            0 0 0
//            X 1 0   0

//            0 1 0
//            X X 0   1

//            0 X 0
//            X X 0    2

//            0 X X
//            0 X 0

//            D, 0
//            R, 1
//            U, 2
//            R, 2
//            R, -1            

//         */
//        [TestMethod()]
//        public void MoveTest()
//        {
//            SnakeGameTest game = new SnakeGameTest(2, 3, new List<int[]>
//            {
//                new int[]{1,1},
//                new int[]{0,1},
//            });

//            Assert.AreEqual(0, game.Move("D"));
//            Assert.AreEqual(1, game.Move("R"));
//            Assert.AreEqual(2, game.Move("U"));
//            Assert.AreEqual(2, game.Move("R"));
//            Assert.AreEqual(-1, game.Move("R"));

//        }
//    }
//}