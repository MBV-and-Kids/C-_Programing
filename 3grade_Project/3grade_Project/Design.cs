using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3grade_Project
{
    internal static class Design
    {
        public static void Header(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control.Name == "gridControlMeasure" && control is DataGridView gridControlMeasure)
                {
                    int gridX = gridControlMeasure.Location.X;   // 그리드컨트롤의 시작 X 좌표
                    int gridY = gridControlMeasure.Location.Y;   // 그리드컨트롤의 시작 Y 좌표

                    // 그리드컨트롤의 너비 계산
                    int newGridWidth = parentControl.Width - (gridX * 2 + 20);
                    if (newGridWidth > 0)
                        gridControlMeasure.Width = newGridWidth;
                    else
                        gridControlMeasure.Width = 0;

                    // 그리드컨트롤의 높이 계산
                    int newGridHeight = parentControl.Height - gridY - 80;
                    if (newGridHeight > 0)
                        gridControlMeasure.Height = newGridHeight;
                    else
                        gridControlMeasure.Height = 0;

                    break;  // 필요한 컨트롤을 찾았으면 반복문을 종료
                }
            }
        }
    }
}
