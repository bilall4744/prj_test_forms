using System;
using System.Drawing;
using System.Windows.Forms;

namespace prj_test_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChannelsTableContent();
            UpdateChannelsTableLayout();
            tabPageChannelsConfig.Resize += TabPageChannelsConfig_Resize;
        }

        private void TabPageChannelsConfig_Resize(object sender, EventArgs e)
        {
            UpdateChannelsTableLayout();
        }

        private void UpdateChannelsTableLayout()
        {
            const int margin = 8;
            int width = (int)(tabPageChannelsConfig.ClientSize.Width * 0.3);
            int height = tabPageChannelsConfig.ClientSize.Height - (margin * 2);

            tableLayoutPanelChannels.Location = new Point(margin, margin);
            tableLayoutPanelChannels.Size = new Size(Math.Max(width, 120), Math.Max(height, 120));
        }

        private void InitializeChannelsTableContent()
        {
            tableLayoutPanelChannels.Controls.Clear();

            string[] headers = { "№", "Режим", "Статус", "Счетчик" };

            for (int column = 0; column < headers.Length; column++)
            {
                tableLayoutPanelChannels.Controls.Add(CreateTableCellLabel(headers[column], true), column, 0);
            }

            for (int row = 1; row <= 8; row++)
            {
                tableLayoutPanelChannels.Controls.Add(CreateTableCellLabel(row.ToString(), false), 0, row);
            }
        }

        private Label CreateTableCellLabel(string text, bool isHeader)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = Padding.Empty,
                AutoSize = false,
                Font = isHeader
                    ? new Font(Font, FontStyle.Bold)
                    : new Font(Font, FontStyle.Regular)
            };
        }
    }
}
