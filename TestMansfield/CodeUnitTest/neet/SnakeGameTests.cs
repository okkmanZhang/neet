//using AllChallenge.at;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ClassLibrary1;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AllChallenge.at.Tests
//{
//    [TestClass()]
//    public class SnakeGameTests
//    {
//        [TestMethod()]
//        public void MoveTest()
//        {
//            int width = 3;
//            int height = 2;
//            int[][] foods = new int[][] { new int[] { 1, 2 }, new int[] { 0, 1 } };
//            string[] moves = new string[] { "R", "D", "R", "U", "L", "U" };
//            int[] output = new int[] { 0, 0, 1, 1, 2, -1 };

//            SnakeGame game = new SnakeGame(width, height, foods);

//            for (int i = 0; i < moves.Length; i++)
//            {
//                if (output[i] != game.Move(moves[i]))
//                {
//                    Assert.Fail();
//                    break;
//                }
//            }

//        }


//        /*        [TestMethod()]
//                public void MoveTest2()
//                {
//                    int width = 3;
//                    int height = 3;
//                    int[][] foods = new int[][] { new int[] { 2, 0 }, new int[] { 0, 0 }, new int[] { 0, 2 }, new int[] { 0, 1 }, new int[] { 2, 2 } };
//                    string[] moves = new string[] { "D", "D", "R", "U", "U", "L", "D", "R", "R", "U", "L", "L", "D", "R", "U" };
//                    int[] output = new int[] { 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 4, 4, 4, 4, -1 };

//                    SnakeGame game = new SnakeGame(width, height, foods);

//                    for (int i = 0; i < moves.Length; i++)
//                    {
//                        if (output[i] != game.Move(moves[i]))
//                        {
//                            Assert.Fail();
//                            break;
//                        }
//                    }
//                }*/

//        /*        [TestMethod()]
//                public void MoveTest3()
//                {
//                    int width = 3;
//                    int height = 3;
//                    int[][] foods = new int[][] { new int[] { 2, 0 }, new int[] { 0, 0 }, new int[] { 0, 2 }, new int[] { 2, 2 } };
//                    string[] moves = new string[] { "D", "D", "R", "U", "U", "L", "D", "R", "R", "U", "L", "D" };
//                    int[] output = new int[] { 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };

//                    SnakeGame game = new SnakeGame(width, height, foods);

//                    for (int i = 0; i < moves.Length; i++)
//                    {
//                        if (output[i] != game.Move(moves[i]))
//                        {
//                            Assert.Fail();
//                            break;
//                        }
//                    }
//                }*/
//    }
//}