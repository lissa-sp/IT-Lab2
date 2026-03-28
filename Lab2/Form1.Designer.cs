namespace Lab2
{
    partial class frmMain
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
            this.tbInitFile = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbCypherText = new System.Windows.Forms.RichTextBox();
            this.tbGenKey = new System.Windows.Forms.RichTextBox();
            this.lblInitFile = new System.Windows.Forms.Label();
            this.lblGenKey = new System.Windows.Forms.Label();
            this.lblCypherFile = new System.Windows.Forms.Label();
            this.tbInitKey = new System.Windows.Forms.RichTextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInitKey = new System.Windows.Forms.Label();
            this.btnEncypher = new System.Windows.Forms.Button();
            this.btnCypher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnShowAllBytes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInitFile
            // 
            this.tbInitFile.BackColor = System.Drawing.SystemColors.Window;
            this.tbInitFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbInitFile.Location = new System.Drawing.Point(12, 136);
            this.tbInitFile.Name = "tbInitFile";
            this.tbInitFile.Size = new System.Drawing.Size(560, 157);
            this.tbInitFile.TabIndex = 0;
            this.tbInitFile.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblName.Location = new System.Drawing.Point(227, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(483, 46);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Потоковое шифрование";
            // 
            // tbCypherText
            // 
            this.tbCypherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCypherText.Location = new System.Drawing.Point(12, 508);
            this.tbCypherText.Name = "tbCypherText";
            this.tbCypherText.Size = new System.Drawing.Size(560, 157);
            this.tbCypherText.TabIndex = 2;
            this.tbCypherText.Text = "";
            // 
            // tbGenKey
            // 
            this.tbGenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGenKey.Location = new System.Drawing.Point(12, 343);
            this.tbGenKey.Name = "tbGenKey";
            this.tbGenKey.Size = new System.Drawing.Size(560, 97);
            this.tbGenKey.TabIndex = 3;
            this.tbGenKey.Text = "";
            // 
            // lblInitFile
            // 
            this.lblInitFile.AutoSize = true;
            this.lblInitFile.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInitFile.Location = new System.Drawing.Point(13, 107);
            this.lblInitFile.Name = "lblInitFile";
            this.lblInitFile.Size = new System.Drawing.Size(169, 27);
            this.lblInitFile.TabIndex = 4;
            this.lblInitFile.Text = "Исходный файл:";
            // 
            // lblGenKey
            // 
            this.lblGenKey.AutoSize = true;
            this.lblGenKey.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenKey.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGenKey.Location = new System.Drawing.Point(13, 314);
            this.lblGenKey.Name = "lblGenKey";
            this.lblGenKey.Size = new System.Drawing.Size(237, 27);
            this.lblGenKey.TabIndex = 5;
            this.lblGenKey.Text = "Сгенерированный ключ:";
            // 
            // lblCypherFile
            // 
            this.lblCypherFile.AutoSize = true;
            this.lblCypherFile.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCypherFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCypherFile.Location = new System.Drawing.Point(13, 479);
            this.lblCypherFile.Name = "lblCypherFile";
            this.lblCypherFile.Size = new System.Drawing.Size(244, 27);
            this.lblCypherFile.TabIndex = 6;
            this.lblCypherFile.Text = "Преобразованный файл:";
            // 
            // tbInitKey
            // 
            this.tbInitKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbInitKey.Location = new System.Drawing.Point(19, 47);
            this.tbInitKey.MaxLength = 28;
            this.tbInitKey.Name = "tbInitKey";
            this.tbInitKey.Size = new System.Drawing.Size(201, 45);
            this.tbInitKey.TabIndex = 7;
            this.tbInitKey.Text = "";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoadFile.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F);
            this.btnLoadFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLoadFile.Location = new System.Drawing.Point(340, 92);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(232, 42);
            this.btnLoadFile.TabIndex = 8;
            this.btnLoadFile.Text = "Загрузить файл";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnShowAllBytes);
            this.panel1.Controls.Add(this.lblInitKey);
            this.panel1.Controls.Add(this.btnEncypher);
            this.panel1.Controls.Add(this.btnCypher);
            this.panel1.Controls.Add(this.tbInitKey);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 523);
            this.panel1.TabIndex = 10;
            // 
            // lblInitKey
            // 
            this.lblInitKey.AutoSize = true;
            this.lblInitKey.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitKey.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInitKey.Location = new System.Drawing.Point(14, 17);
            this.lblInitKey.Name = "lblInitKey";
            this.lblInitKey.Size = new System.Drawing.Size(74, 27);
            this.lblInitKey.TabIndex = 12;
            this.lblInitKey.Text = "Ключ: ";
            // 
            // btnEncypher
            // 
            this.btnEncypher.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEncypher.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F);
            this.btnEncypher.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEncypher.Location = new System.Drawing.Point(19, 259);
            this.btnEncypher.Name = "btnEncypher";
            this.btnEncypher.Size = new System.Drawing.Size(201, 42);
            this.btnEncypher.TabIndex = 12;
            this.btnEncypher.Text = "Дешифровать";
            this.btnEncypher.UseVisualStyleBackColor = false;
            this.btnEncypher.Click += new System.EventHandler(this.btnEncypher_Click);
            // 
            // btnCypher
            // 
            this.btnCypher.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCypher.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F);
            this.btnCypher.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCypher.Location = new System.Drawing.Point(19, 204);
            this.btnCypher.Name = "btnCypher";
            this.btnCypher.Size = new System.Drawing.Size(201, 42);
            this.btnCypher.TabIndex = 11;
            this.btnCypher.Text = "Шифровать";
            this.btnCypher.UseVisualStyleBackColor = false;
            this.btnCypher.Click += new System.EventHandler(this.btnCypher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(621, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 529);
            this.panel2.TabIndex = 11;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveToFile.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F);
            this.btnSaveToFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveToFile.Location = new System.Drawing.Point(340, 464);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(232, 42);
            this.btnSaveToFile.TabIndex = 13;
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnShowAllBytes
            // 
            this.btnShowAllBytes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnShowAllBytes.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F);
            this.btnShowAllBytes.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnShowAllBytes.Location = new System.Drawing.Point(19, 369);
            this.btnShowAllBytes.Name = "btnShowAllBytes";
            this.btnShowAllBytes.Size = new System.Drawing.Size(201, 71);
            this.btnShowAllBytes.TabIndex = 13;
            this.btnShowAllBytes.Text = "Показать все биты";
            this.btnShowAllBytes.UseVisualStyleBackColor = false;
            this.btnShowAllBytes.Click += new System.EventHandler(this.btnShowAllBytes_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClear.Font = new System.Drawing.Font("Rockwell Condensed", 13.8F);
            this.btnClear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Location = new System.Drawing.Point(19, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 42);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(912, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.lblCypherFile);
            this.Controls.Add(this.lblGenKey);
            this.Controls.Add(this.lblInitFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.tbGenKey);
            this.Controls.Add(this.tbCypherText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbInitFile);
            this.Name = "frmMain";
            this.Text = "StreamCypher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInitFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox tbCypherText;
        private System.Windows.Forms.RichTextBox tbGenKey;
        private System.Windows.Forms.Label lblInitFile;
        private System.Windows.Forms.Label lblGenKey;
        private System.Windows.Forms.Label lblCypherFile;
        private System.Windows.Forms.RichTextBox tbInitKey;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEncypher;
        private System.Windows.Forms.Button btnCypher;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label lblInitKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowAllBytes;
    }
}

