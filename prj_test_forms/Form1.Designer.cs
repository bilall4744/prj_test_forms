namespace prj_test_forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageChannelsConfig = new System.Windows.Forms.TabPage();
            this.tabPageUtilitySettings = new System.Windows.Forms.TabPage();
            this.groupBoxModeSelection = new System.Windows.Forms.GroupBox();
            this.groupBoxConfigSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxBottom = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageChannelsConfig);
            this.tabControl1.Controls.Add(this.tabPageUtilitySettings);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageChannelsConfig
            // 
            this.tabPageChannelsConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageChannelsConfig.Name = "tabPageChannelsConfig";
            this.tabPageChannelsConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChannelsConfig.Size = new System.Drawing.Size(890, 309);
            this.tabPageChannelsConfig.TabIndex = 0;
            this.tabPageChannelsConfig.Text = "Конфигурация каналов DI";
            this.tabPageChannelsConfig.UseVisualStyleBackColor = true;
            // 
            // tabPageUtilitySettings
            // 
            this.tabPageUtilitySettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtilitySettings.Name = "tabPageUtilitySettings";
            this.tabPageUtilitySettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUtilitySettings.Size = new System.Drawing.Size(890, 309);
            this.tabPageUtilitySettings.TabIndex = 1;
            this.tabPageUtilitySettings.Text = "Настройки утилиты";
            this.tabPageUtilitySettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxModeSelection
            // 
            this.groupBoxModeSelection.Location = new System.Drawing.Point(5, 345);
            this.groupBoxModeSelection.Name = "groupBoxModeSelection";
            this.groupBoxModeSelection.Size = new System.Drawing.Size(446, 130);
            this.groupBoxModeSelection.TabIndex = 1;
            this.groupBoxModeSelection.TabStop = false;
            this.groupBoxModeSelection.Text = "Выбор режима";
            // 
            // groupBoxConfigSettings
            // 
            this.groupBoxConfigSettings.Location = new System.Drawing.Point(457, 345);
            this.groupBoxConfigSettings.Name = "groupBoxConfigSettings";
            this.groupBoxConfigSettings.Size = new System.Drawing.Size(446, 130);
            this.groupBoxConfigSettings.TabIndex = 2;
            this.groupBoxConfigSettings.TabStop = false;
            this.groupBoxConfigSettings.Text = "Настройки конфигурации";
            // 
            // groupBoxBottom
            // 
            this.groupBoxBottom.Location = new System.Drawing.Point(5, 480);
            this.groupBoxBottom.Name = "groupBoxBottom";
            this.groupBoxBottom.Size = new System.Drawing.Size(898, 58);
            this.groupBoxBottom.TabIndex = 3;
            this.groupBoxBottom.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxBottom);
            this.Controls.Add(this.groupBoxConfigSettings);
            this.Controls.Add(this.groupBoxModeSelection);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageChannelsConfig;
        private System.Windows.Forms.TabPage tabPageUtilitySettings;
        private System.Windows.Forms.GroupBox groupBoxModeSelection;
        private System.Windows.Forms.GroupBox groupBoxConfigSettings;
        private System.Windows.Forms.GroupBox groupBoxBottom;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
