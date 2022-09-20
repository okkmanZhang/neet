using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at
{
    public class SnakeGame
    {
        private readonly int _screenWidth = 0;
        private readonly int _screenHeight = 0;
        private readonly Queue<Position> _foods = new Queue<Position>();
        private Position _headPosition;
        private Position _foodPosition;
        private int _score = 0;
        private Queue<Position> _snakeBody = new Queue<Position>();

        public SnakeGame(int width, int height, int[][] food)
        {
            _screenWidth = width;
            _screenHeight = height;
            _headPosition = new Position() { RowIndex = 0, ColumnIndex = 0 };            

            foreach (var iFood in food)
            {
                _foods.Enqueue(new Position() { RowIndex = iFood[0], ColumnIndex = iFood[1] });
            }

            _foodPosition = _foods.Dequeue();
        }

        public int Move(string direction)
        {
            if (!GetPosition(direction)) return -1;

            return _score;
        }

        private bool GetPosition(string direction)
        {
            bool hitFood = false;            

            switch (direction)
            {
                case "R":
                    if (_headPosition.ColumnIndex == _screenWidth - 1) return false;                    
                    _headPosition.ColumnIndex++;
                    break;
                case "L":
                    if (_headPosition.ColumnIndex == 0) return false;                    
                    _headPosition.ColumnIndex--;
                    break;
                case "U":
                    if (_headPosition.RowIndex == 0) return false;                    
                    _headPosition.RowIndex--;
                    break;
                case "D":
                    if (_headPosition.RowIndex == _screenHeight - 1) return false;
                    _headPosition.RowIndex++;
                    break;
                default:
                    break;
            }

            hitFood = HitFood(_headPosition.RowIndex, _headPosition.ColumnIndex);

            //not hit food and has body
            if (!hitFood && _snakeBody.Count > 0)
            {
                //remove tail
                _snakeBody.Dequeue();
            }

            //if head runs into body
            if (_snakeBody.Any(p => p.RowIndex == _headPosition.RowIndex 
                && p.ColumnIndex == _headPosition.ColumnIndex))
            {
                return false;
            }
            
            //add new occupied block to body
            _snakeBody.Enqueue(new Position() { 
                RowIndex=_headPosition.RowIndex,
                ColumnIndex=_headPosition.ColumnIndex});

            return true;

        }

        private bool HitFood(int top, int left)
        {

            if (_foodPosition != null && top == _foodPosition.RowIndex && left == _foodPosition.ColumnIndex)
            {
                _score++;
                //next food.
                _foodPosition = _foods.Count == 0 ? null : _foods.Dequeue();

                return true;
            }
            else
            {
                return false;
            }
        }

        private class Position
        {
            public int RowIndex { get; set; }
            public int ColumnIndex { get; set; }
        }
    }
}
