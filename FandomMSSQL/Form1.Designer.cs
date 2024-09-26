namespace FandomMSSQL
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
            this.dgwTable = new System.Windows.Forms.DataGridView();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTable
            // 
            this.dgwTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable.Location = new System.Drawing.Point(22, 61);
            this.dgwTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgwTable.Name = "dgwTable";
            this.dgwTable.RowHeadersWidth = 72;
            this.dgwTable.Size = new System.Drawing.Size(755, 415);
            this.dgwTable.TabIndex = 0;
            // 
            // btnNames
            // 
            this.btnNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNames.Location = new System.Drawing.Point(1256, 82);
            this.btnNames.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(161, 74);
            this.btnNames.TabIndex = 1;
            this.btnNames.Text = "Имена";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(1256, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 67);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(833, 195);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(397, 50);
            this.tbSearch.TabIndex = 3;
            // 
            // tbReplace
            // 
            this.tbReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReplace.Location = new System.Drawing.Point(833, 370);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(397, 50);
            this.tbReplace.TabIndex = 4;
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReplace.Location = new System.Drawing.Point(947, 437);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(187, 67);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Замена";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tbFind
            // 
            this.tbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFind.Location = new System.Drawing.Point(833, 528);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(397, 50);
            this.tbFind.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.dgwTable);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTable;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox tbFind;
    }
}

