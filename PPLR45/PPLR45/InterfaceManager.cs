using System.Drawing;
using System.Windows.Forms;

namespace интерфЛР1
{
    public class InterfaceManager
    {
        public void DrawHorizontalTabControl(TabControl tabControl, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush;

            Rectangle endTabRect = tabControl.GetTabRect(1);
            RectangleF filledRectF = new RectangleF( -1,
                //устанавливаем границы закрашиваемой области по Х
            20, //по У
           700, 484);
            RectangleF filledRectL = new RectangleF(endTabRect.X,
                //устанавливаем границы закрашиваемой области по Х
            0, //по У
           600, 20);
            //высота и ширина области +600, чтобы при развертывании окна закрашивалась вся область
            
            using (Brush backBrush = new SolidBrush(tabControl.Parent.BackColor))
            {
                e.Graphics.FillRectangle(backBrush, filledRectF); //область под вкладками
                e.Graphics.FillRectangle(backBrush, filledRectL);
                endTabRect = tabControl.GetTabRect(0); //изменяем параметры
                filledRectF = new RectangleF(endTabRect.X - 3, endTabRect.Y - 3,
                5, endTabRect.Height * tabControl.TabPages.Count + 3);
                e.Graphics.FillRectangle(backBrush, filledRectF); //возле кнопок
                endTabRect = tabControl.GetTabRect(1); //изменяем параметры
                filledRectF = new RectangleF(endTabRect.X - 3, endTabRect.Y - 3,
                5, endTabRect.Height * tabControl.TabPages.Count + 3);
                e.Graphics.FillRectangle(backBrush, filledRectF); //возле кнопок
            }

            TabPage tabPage = tabControl.TabPages[e.Index]; //текущая вкладка
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);
            tabPage.BackColor = Color.White; //фона текущей вкладки
            if (e.State == DrawItemState.Selected) //если это Выбранная вкладка
            {
                brush = new SolidBrush(Color.DarkCyan);
                g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }
            else
            {
                brush = new System.Drawing.SolidBrush(Color.White);
                //цвет НЕ выбранной вкладки остается старым
                g.FillRectangle(new SolidBrush(Color.DarkCyan), e.Bounds);
                //зарисовываем НЕ выбранную вкладку другим цветом
            }

            Font _TabFont = new Font("Segoe UI", 13, GraphicsUnit.Pixel); //шрифт для надписи
            StringFormat strFormat = new StringFormat(); // надпись по центру
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(tabPage.Text, _TabFont, brush, tabBounds, new StringFormat(strFormat));
            //рисуем саму надпись с уже установленным ранее Браш
        }


    }
}

