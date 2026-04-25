using Programming_WinFormsApp.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_WinFormsApp.Veiw.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private Model.Geometry.Rectangle[] _rectanglesTab;
        private Model.Geometry.Rectangle _currentRectangleTab;
        private List<Panel> _rectanglePanels;


        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectanglesTab();
            this.ButtPlus.Click += ButtPlus_Click;
            this.ButtMinus.Click += ButtMinus_Click;
            this.RectanListBox.SelectedIndexChanged += RectanListBox_SelectedIndexChanged;
            this.XBox.TextChanged += XBox_TextChanged;
            this.YBox.TextChanged += YBox_TextChanged;
            this.WidthBox.TextChanged += WidthBox_TextChanged;
            this.HeightBox.TextChanged += HeightBox_TextChanged;
        }

        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglesTab.Length; i++)
            {
                for (int j = 0; j < _rectanglesTab.Length; j++)
                {
                    if (i == j) continue;

                    if (CollisionManager.IsCollision(_rectanglesTab[i], _rectanglesTab[j]))
                    {
                        if (i < _rectanglePanels.Count)
                            _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);

                        if (j < _rectanglePanels.Count)
                            _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        /// <summary>
        /// Создание прямоугольников для вкладки Rectangles
        /// </summary>
        private void InitializeRectanglesTab()
        {
            // Сбрасываем счетчик для вкладки Rectangles
            Model.Geometry.Rectangle.ResetRectanglesTabCount();

            _rectanglesTab = new Model.Geometry.Rectangle[0];

            RectanListBox.Items.Clear();

            if (_rectanglePanels != null)
            {
                foreach (var panel in _rectanglePanels)
                {
                    if (RecPanel.Controls.Contains(panel))
                        RecPanel.Controls.Remove(panel);
                    panel.Dispose();
                }
                _rectanglePanels.Clear();
            }
            else
            {
                _rectanglePanels = new List<Panel>();
            }
        }
        private void RectanListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_rectanglesTab == null || _rectanglesTab.Length == 0)
            {
                RectanListBox.Items.Clear();

                // Очищаем поля
                HeightBox.Text = "";
                WidthBox.Text = "";
                XBox.Text = "";
                YBox.Text = "";
                IdBox.Text = "";
                _currentRectangleTab = null;
                return;
            }

            // Проверка индекса
            if (RectanListBox.SelectedIndex < 0 || RectanListBox.SelectedIndex >= _rectanglesTab.Length)
            {
                HeightBox.Text = "";
                WidthBox.Text = "";
                XBox.Text = "";
                YBox.Text = "";
                IdBox.Text = "";
                _currentRectangleTab = null;
                return;
            }

            int selectedIndex = RectanListBox.SelectedIndex;
            _currentRectangleTab = _rectanglesTab[selectedIndex];

            HeightBox.Text = _currentRectangleTab.Length.ToString();
            WidthBox.Text = _currentRectangleTab.Width.ToString();
            XBox.Text = _currentRectangleTab.Center.X.ToString();
            YBox.Text = _currentRectangleTab.Center.Y.ToString();
            IdBox.Text = (selectedIndex + 1).ToString();
        }


        /// <summary>
        /// Создание панели в канве и добавление прямоугольников
        /// </summary>
        /// <param name="rectangleIndex"></param>
        private void CreatePanelForRectangle(int rectangleIndex)
        {
            var rect = _rectanglesTab[rectangleIndex];

            // Размеры канвы
            int canvasWidth = RecPanel.Width;    // 522
            int canvasHeight = RecPanel.Height;  // 548

            float scaleX = canvasWidth / 400f;
            float scaleY = canvasHeight / 400f;

            int panelX = (int)((rect.Center.X - rect.Width / 2) * scaleX);
            int panelY = (int)((rect.Center.Y - rect.Length / 2) * scaleY);

            int panelWidth = Math.Max(5, (int)(rect.Width * scaleX));
            int panelHeight = Math.Max(5, (int)(rect.Length * scaleY));

            if (panelX < 0) panelX = 0;
            if (panelY < 0) panelY = 0;
            if (panelX + panelWidth > canvasWidth) panelX = canvasWidth - panelWidth;
            if (panelY + panelHeight > canvasHeight) panelY = canvasHeight - panelHeight;

            Panel newPanel = new Panel();
            newPanel.Location = new Point(panelX, panelY);
            newPanel.Size = new Size(panelWidth, panelHeight);
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Tag = rectangleIndex;

            Label panelLabel = new Label
            {
                Text = $"#{rectangleIndex + 1}",
                Location = new Point(2, 2),
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 6, FontStyle.Bold)
            };
            newPanel.Controls.Add(panelLabel);

            // Добавляем на канву
            RecPanel.Controls.Add(newPanel);
            _rectanglePanels.Add(newPanel);
            newPanel.BringToFront();

            FindCollisions();
        }

        /// <summary>
        /// Обновление позиций прямоугольников на панели
        /// </summary>
        /// <param name="index"></param>
        private void UpdatePanelPosition(int index)
        {
            if (index >= _rectanglePanels.Count || index >= _rectanglesTab.Length) return;

            var rect = _rectanglesTab[index];
            var panel = _rectanglePanels[index];

            int canvasWidth = RecPanel.Width;
            int canvasHeight = RecPanel.Height;

            // Масштаб 0.25
            float scaleX = canvasWidth / 400f;
            float scaleY = canvasHeight / 400f;

            int panelX = (int)((rect.Center.X - rect.Width / 2) * scaleX);
            int panelY = (int)((rect.Center.Y - rect.Length / 2) * scaleY);
            int panelWidth = Math.Max(5, (int)(rect.Width * scaleX));
            int panelHeight = Math.Max(5, (int)(rect.Length * scaleY));

            if (panelX < 0) panelX = 0;
            if (panelY < 0) panelY = 0;
            if (panelX + panelWidth > canvasWidth) panelX = canvasWidth - panelWidth;
            if (panelY + panelHeight > canvasHeight) panelY = canvasHeight - panelHeight;

            panel.Location = new Point(panelX, panelY);
            panel.Size = new Size(panelWidth, panelHeight);

            if (panel.Controls.Count > 0 && panel.Controls[0] is Label label)
            {
                if (!label.Text.StartsWith($"#{index + 1}"))
                {
                    label.Text = $"#{index + 1}";
                }
            }
        }

        /// <summary>
        /// Добавление нового прямоугольника
        /// </summary>
        private void ButtPlus_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" };

            double length = rand.Next(1, 101);
            double width = rand.Next(1, 101);
            string color = colors[rand.Next(colors.Length)];
            double centerX = Math.Round(rand.NextDouble() * 350, 1);
            double centerY = Math.Round(rand.NextDouble() * 350, 1);

            Model.Geometry.Rectangle[] newRectangles = new Model.Geometry.Rectangle[_rectanglesTab.Length + 1];

            for (int i = 0; i < _rectanglesTab.Length; i++)
            {
                newRectangles[i] = _rectanglesTab[i];
            }

            newRectangles[_rectanglesTab.Length] = new Model.Geometry.Rectangle(length, width, color, centerX, centerY, true);

            _rectanglesTab = newRectangles;

            RectanListBox.Items.Add($"{_rectanglesTab.Length}: (X={centerX}; Y={centerY}; W={width}; H={length})");

            if (RectanListBox.Items.Count > 0)
            {
                RectanListBox.SelectedIndex = RectanListBox.Items.Count - 1;
            }

            // Добавление прямоугольника на панель
            CreatePanelForRectangle(_rectanglesTab.Length - 1);

            FindCollisions();
        }

        /// <summary>
        /// Удаление прямоугольников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtMinus_Click(object sender, EventArgs e)
        {
            int selectedIndex = RectanListBox.SelectedIndex;

            RectanListBox.SelectedIndexChanged -= RectanListBox_SelectedIndexChanged;

            try
            {
                // Удаляем панель
                if (_rectanglePanels != null && selectedIndex < _rectanglePanels.Count)
                {
                    Panel panelToRemove = _rectanglePanels[selectedIndex];
                    if (RecPanel.Controls.Contains(panelToRemove))
                        RecPanel.Controls.Remove(panelToRemove);
                    panelToRemove.Dispose();
                    _rectanglePanels.RemoveAt(selectedIndex);
                }

                // Удаляем из массива
                Model.Geometry.Rectangle[] newRectangles = new Model.Geometry.Rectangle[_rectanglesTab.Length - 1];
                int newIndex = 0;

                for (int i = 0; i < _rectanglesTab.Length; i++)
                {
                    if (i != selectedIndex)
                    {
                        newRectangles[newIndex] = _rectanglesTab[i];
                        newIndex++;
                    }
                }

                _rectanglesTab = newRectangles;

                RectanListBox.Items.Clear();
                for (int i = 0; i < _rectanglesTab.Length; i++)
                {
                    var rect = _rectanglesTab[i];
                    RectanListBox.Items.Add($"{i + 1}: (X={rect.Center.X}; Y={rect.Center.Y}; W={rect.Width}; H={rect.Length})");
                }

                // Обновляем номера на панелях
                for (int i = 0; i < _rectanglePanels.Count; i++)
                {
                    _rectanglePanels[i].Tag = i;
                    if (_rectanglePanels[i].Controls.Count > 0 && _rectanglePanels[i].Controls[0] is Label label)
                    {
                        label.Text = $"#{i + 1}";
                    }
                }

                FindCollisions();

                HeightBox.Text = WidthBox.Text = XBox.Text = YBox.Text = IdBox.Text = "";
                _currentRectangleTab = null;

                if (RectanListBox.Items.Count > 0)
                {
                    int newSelectedIndex = selectedIndex - 1;
                    if (newSelectedIndex < 0) newSelectedIndex = 0;
                    if (newSelectedIndex >= RectanListBox.Items.Count)
                        newSelectedIndex = RectanListBox.Items.Count - 1;
                    RectanListBox.SelectedIndex = newSelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
            finally
            {
                RectanListBox.SelectedIndexChanged += RectanListBox_SelectedIndexChanged;
            }
        }


        /// <summary>
        /// Функциональность поля X во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XBox.Text) || _currentRectangleTab == null)
            {
                XBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(XBox.Text, out double x) && x >= 0 && x <= 350)
            {
                _currentRectangleTab.Center = new Point2D(x, _currentRectangleTab.Center.Y);
                XBox.BackColor = Color.White;

                // Обновляем позицию панели на канве
                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }

            else
            {
                XBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Функциональность поля Y во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(YBox.Text) || _currentRectangleTab == null)
            {
                YBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(YBox.Text, out double y) && y >= 0 && y <= 350)
            {
                _currentRectangleTab.Center = new Point2D(_currentRectangleTab.Center.X, y);
                YBox.BackColor = Color.White;

                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }
            else
            {
                YBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Функциональность поля Width во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WidthBox.Text) || _currentRectangleTab == null)
            {
                WidthBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(WidthBox.Text, out double width) && width >= 1 && width <= 100)
            {
                _currentRectangleTab.Width = width;
                WidthBox.BackColor = Color.White;

                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }
            else
            {
                WidthBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Функциональность поля X во вкладке Rectangles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HeightBox.Text) || _currentRectangleTab == null)
            {
                HeightBox.BackColor = Color.White;
                return;
            }

            if (double.TryParse(HeightBox.Text, out double height) && height >= 1 && height <= 100)
            {
                _currentRectangleTab.Length = height;
                HeightBox.BackColor = Color.White;

                int index = Array.IndexOf(_rectanglesTab, _currentRectangleTab);
                if (index != -1 && index < _rectanglePanels.Count)
                {
                    UpdatePanelPosition(index);
                }

                if (RectanListBox.SelectedIndex != -1)
                {
                    RectanListBox.Items[RectanListBox.SelectedIndex] =
                        $"{RectanListBox.SelectedIndex + 1}: (X={_currentRectangleTab.Center.X}; Y={_currentRectangleTab.Center.Y}; W={_currentRectangleTab.Width}; H={_currentRectangleTab.Length})";
                }

                FindCollisions();
            }
            else
            {
                HeightBox.BackColor = Color.LightPink;
            }
        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
