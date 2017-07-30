using System;
using System.Drawing;
using System.Windows.Forms;

namespace App7
{

    class Escape
    {

        int x; int y;       // Cursor (x, y)
        int h; int w;       // Object (height, width)
        int fx; int fy;     // Field (fx, fy)
        int bx; int by;     // Object top-left point (x, y)

        int step = 25;

        Button runner;
        PictureBox background;

        public Escape(Button objRunner, PictureBox objField)
        {
            runner = objRunner;
            background = objField;

            h = runner.Size.Height;
            w = runner.Size.Width;

            fx = background.Size.Width;
            fy = background.Size.Height;

            checkCursor();
        }

        public string[] moveObj()
        {
            checkCursor();
            checkObj();

            Random rnd = new Random();
            string quadrantLabelText;
            string directionLabelText;

            do
            {
                double newDirection = rnd.Next(5000, 44999);
                newDirection = Math.Round(newDirection / 10000);

                char directionChar = '?';

                switch (newDirection)
                {
                    case 1:
                        if (checkPossibility(bx + step, by))
                        {
                            bx += step;
                            directionChar = '\u25BA';
                        }
                        break;
                    case 2:
                        if (checkPossibility(bx - step, by))
                        {
                            bx -= step;
                            directionChar = '\u25C4';
                        }
                        break;
                    case 3:
                        if (checkPossibility(bx, by + step))
                        {
                            by += step;
                            directionChar = '\u25BC';
                        }
                        break;
                    case 4:
                        if (checkPossibility(bx, by - step))
                        {
                            by -= step;
                            directionChar = '\u25B2';
                        }
                        break;
                }

                runner.Location = new Point(bx, by);

                quadrantLabelText  = "Квадрант: " + checkQuadrant();
                directionLabelText = "Направление: " + directionChar;

            } while (checkHit());

            string[] answer = new string[2];
            answer[0] = quadrantLabelText;
            answer[1] = directionLabelText;

            return answer;
        }

        //*** CHECKBOX

        private void checkCursor()
        {
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
        }

        public int checkQuadrant()
        {
            if (0 <= (bx + w / 2) && (bx + w / 2) <= fx / 2)
            {
                if (0 <= (by + h / 2) && (by + h / 2) <= fy / 2)
                { return 2; }
                else { return 3; }
            }
            else
            {
                if (0 <= (by + h / 2) && (by + h / 2) <= fy / 2)
                { return 1; }
                else { return 4; }
            }
        }

        private void checkObj()
        {
            bx = runner.Location.X;
            by = runner.Location.Y;
        }

        private bool checkHit()
        {
            if ((bx >= x) && x <= (bx + w) && (by >= y) && y <= (by + h))
            { return true; }
            else
            { return false; }
        }

        private bool checkHit(int newX, int newY)
        {
            if ((newX >= x) && x <= (newX + w) && (newY >= y) && y <= (newY + h))
            { return true; }
            else
            { return false; }
        }

        private bool checkPossibility(int newX, int newY)
        {
            if (
                (0 <= newX) &&
                (newX + w < fx) &&
                (0 <= newY) &&
                (newY + h < fy) &&
                !checkHit(newX, newY)
            )
            { return true; }
            else
            { return false; }
        }

    }
}
