using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    internal class SavePhoto
    {
        public Bitmap ParametorsPhoto(DataGridView dataGridView)
        {
            try
            {
                if (dataGridView.Rows.Count == 0 || dataGridView.Columns.Count == 0)
                {
                    throw new ArgumentException("Таблица данных пуста.");
                }

                int totalWidth = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
                int totalHeight = dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

                Bitmap img = new Bitmap(totalWidth, totalHeight);

                using (Graphics g = Graphics.FromImage(img))
                {
                    g.Clear(Color.White);

                    int currentHeight = 0;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Visible)
                        {
                            int currentWidth = 0;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Visible)
                                {
                                    DataGridViewTextBoxCell textBoxCell = cell as DataGridViewTextBoxCell;
                                    if (textBoxCell != null)
                                    {
                                        using (SolidBrush brush = new SolidBrush(cell.Style.BackColor))
                                        {
                                            g.FillRectangle(brush, new Rectangle(currentWidth, currentHeight, cell.Size.Width, cell.Size.Height));
                                            g.DrawRectangle(Pens.Black, new Rectangle(currentWidth, currentHeight, cell.Size.Width, cell.Size.Height));
                                        }

                                        g.DrawString(textBoxCell.Value?.ToString(), dataGridView.Font, Brushes.Black, new PointF(currentWidth, currentHeight));
                                    }

                                    currentWidth += cell.Size.Width;
                                }
                            }

                            currentHeight += row.Height;
                        }
                    }
                }

                return img;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // или выполняйте другие действия в зависимости от вашей логики
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Необработанная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // или выполняйте другие действия в зависимости от вашей логики
            }
        }

        public SaveFileDialog SavePicture()
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Сохранить картинку как...";
            sd.OverwritePrompt = true;
            sd.CheckPathExists = true;
            sd.Filter = "Image Files(*.BMP)|*.BMP|ImageFiles(*.JPG) | *.JPG | Image Files(*.GIF) | *.GIF | Image Files(*.PNG) | *.PNG | All files(*.*) | *.* ";
            sd.ShowHelp = true;
            return sd;
        }
    }


}
