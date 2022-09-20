using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.at.Test1
{
    /*
    [input]
    screen: height width
    snake: (0,0), snake grow 1 after eating a food, score = score + 1
    food: (ri, ci)[]

    height 2, width 3
    0 0 0
    0 1 X

    0 1 0
    0 X X

    R
    0 1 0
    X X 0

    U
    X 1 0
    X 0 0

    [output]
    int Move(string direction)
        return -1 hits wall or runs in body
                score

     */

    public class Position
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class SnakeGameTest
    {
        private readonly int _height;
        private readonly int _width;
        private int _score = 0;
        private Position _headPosition;
        private Position _foodPosition;
        private readonly Queue<Position> _foods = new Queue<Position>();
        private readonly Queue<Position> _snakebody = new Queue<Position>();

        public SnakeGameTest(int height, int width, List<int[]> foods)
        {
            _height = height;
            _width = width;
            _headPosition = new Position() { RowIndex = 0, ColumnIndex = 0 };
            foreach (var food in foods)
            {
                _foods.Enqueue(new Position() { RowIndex = food[0], ColumnIndex = food[1] });
            }
            _foodPosition = _foods.Dequeue();            
        }    

        //just move and check if hit the wall
        public int Move(string direction)
        {
            switch(direction)
            {
                case "L":
                    _headPosition.ColumnIndex--;
                    break;
                case "R":
                    _headPosition.ColumnIndex++;
                    break;
                case "D":
                    _headPosition.RowIndex++;
                    break;
                case "U":
                    _headPosition.RowIndex--;
                    break;
                default:
                    break;
            }

            //if hit the wall
            if (_headPosition.RowIndex < 0
                || _headPosition.RowIndex > _height - 1
                || _headPosition.ColumnIndex < 0
                || _headPosition.ColumnIndex > _width - 1
                )
            {
                return -1;
            }

            //if hit the food
            if (_foodPosition != null
                && _headPosition.ColumnIndex == _foodPosition.ColumnIndex
                && _headPosition.RowIndex == _foodPosition.RowIndex                
                )
            {
                _score++;
                _foodPosition = _foods.Count > 0 ? _foods.Dequeue() : null;
            } 
            else
            {
                if (_snakebody.Count > 0)
                    _snakebody.Dequeue();
            }

            //if hit it's body
            if (_snakebody.Any(p => p.ColumnIndex == _headPosition.ColumnIndex && p.RowIndex == _headPosition.RowIndex))
            {
                return -1;
            }

            //change body
            _snakebody.Enqueue(new Position()
            {
                RowIndex = _headPosition.RowIndex,
                ColumnIndex = _headPosition.ColumnIndex
            });

            return _score;
        }
    }
}
