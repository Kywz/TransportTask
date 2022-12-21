namespace TransportTask
{
    partial class formMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSolution = new System.Windows.Forms.Panel();
            this.dataFinalY = new System.Windows.Forms.DataGridView();
            this.dataFinalX = new System.Windows.Forms.DataGridView();
            this.dataFinal = new System.Windows.Forms.DataGridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.dataInputY = new System.Windows.Forms.DataGridView();
            this.dataInputX = new System.Windows.Forms.DataGridView();
            this.dataInputMain = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonRemoveY = new System.Windows.Forms.Button();
            this.buttonRemoveX = new System.Windows.Forms.Button();
            this.buttonAddY = new System.Windows.Forms.Button();
            this.buttonAddX = new System.Windows.Forms.Button();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinal)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panelSolution);
            this.panelMain.Controls.Add(this.panelInput);
            this.panelMain.Controls.Add(this.button5);
            this.panelMain.Controls.Add(this.buttonRemoveY);
            this.panelMain.Controls.Add(this.buttonRemoveX);
            this.panelMain.Controls.Add(this.buttonAddY);
            this.panelMain.Controls.Add(this.buttonAddX);
            this.panelMain.Controls.Add(this.panelProcess);
            this.panelMain.Location = new System.Drawing.Point(13, 13);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1239, 656);
            this.panelMain.TabIndex = 0;
            // 
            // panelSolution
            // 
            this.panelSolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSolution.Controls.Add(this.dataFinalY);
            this.panelSolution.Controls.Add(this.dataFinalX);
            this.panelSolution.Controls.Add(this.dataFinal);
            this.panelSolution.Location = new System.Drawing.Point(716, 4);
            this.panelSolution.Name = "panelSolution";
            this.panelSolution.Size = new System.Drawing.Size(521, 307);
            this.panelSolution.TabIndex = 9;
            // 
            // dataFinalY
            // 
            this.dataFinalY.AllowUserToAddRows = false;
            this.dataFinalY.AllowUserToDeleteRows = false;
            this.dataFinalY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinalY.ColumnHeadersVisible = false;
            this.dataFinalY.Location = new System.Drawing.Point(3, 54);
            this.dataFinalY.Name = "dataFinalY";
            this.dataFinalY.RowHeadersVisible = false;
            this.dataFinalY.RowHeadersWidth = 30;
            this.dataFinalY.Size = new System.Drawing.Size(51, 251);
            this.dataFinalY.TabIndex = 2;
            // 
            // dataFinalX
            // 
            this.dataFinalX.AllowUserToAddRows = false;
            this.dataFinalX.AllowUserToDeleteRows = false;
            this.dataFinalX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinalX.ColumnHeadersVisible = false;
            this.dataFinalX.Location = new System.Drawing.Point(60, 3);
            this.dataFinalX.Name = "dataFinalX";
            this.dataFinalX.RowHeadersVisible = false;
            this.dataFinalX.RowHeadersWidth = 30;
            this.dataFinalX.Size = new System.Drawing.Size(454, 47);
            this.dataFinalX.TabIndex = 1;
            // 
            // dataFinal
            // 
            this.dataFinal.AllowUserToAddRows = false;
            this.dataFinal.AllowUserToDeleteRows = false;
            this.dataFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinal.ColumnHeadersVisible = false;
            this.dataFinal.Location = new System.Drawing.Point(60, 54);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.RowHeadersVisible = false;
            this.dataFinal.RowHeadersWidth = 30;
            this.dataFinal.Size = new System.Drawing.Size(454, 251);
            this.dataFinal.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInput.Controls.Add(this.dataInputY);
            this.panelInput.Controls.Add(this.dataInputX);
            this.panelInput.Controls.Add(this.dataInputMain);
            this.panelInput.Location = new System.Drawing.Point(4, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(495, 312);
            this.panelInput.TabIndex = 8;
            // 
            // dataInputY
            // 
            this.dataInputY.AllowUserToAddRows = false;
            this.dataInputY.AllowUserToDeleteRows = false;
            this.dataInputY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInputY.ColumnHeadersVisible = false;
            this.dataInputY.Location = new System.Drawing.Point(3, 56);
            this.dataInputY.Name = "dataInputY";
            this.dataInputY.RowHeadersVisible = false;
            this.dataInputY.RowHeadersWidth = 30;
            this.dataInputY.Size = new System.Drawing.Size(50, 249);
            this.dataInputY.TabIndex = 2;
            // 
            // dataInputX
            // 
            this.dataInputX.AllowUserToAddRows = false;
            this.dataInputX.AllowUserToDeleteRows = false;
            this.dataInputX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInputX.ColumnHeadersVisible = false;
            this.dataInputX.Location = new System.Drawing.Point(59, 3);
            this.dataInputX.Name = "dataInputX";
            this.dataInputX.RowHeadersVisible = false;
            this.dataInputX.RowHeadersWidth = 30;
            this.dataInputX.Size = new System.Drawing.Size(429, 47);
            this.dataInputX.TabIndex = 1;
            // 
            // dataInputMain
            // 
            this.dataInputMain.AllowUserToAddRows = false;
            this.dataInputMain.AllowUserToDeleteRows = false;
            this.dataInputMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInputMain.ColumnHeadersVisible = false;
            this.dataInputMain.Location = new System.Drawing.Point(59, 56);
            this.dataInputMain.Name = "dataInputMain";
            this.dataInputMain.RowHeadersVisible = false;
            this.dataInputMain.RowHeadersWidth = 30;
            this.dataInputMain.Size = new System.Drawing.Size(429, 249);
            this.dataInputMain.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(554, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 34);
            this.button5.TabIndex = 7;
            this.button5.Text = "Вирішити";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveY
            // 
            this.buttonRemoveY.Location = new System.Drawing.Point(618, 46);
            this.buttonRemoveY.Name = "buttonRemoveY";
            this.buttonRemoveY.Size = new System.Drawing.Size(90, 34);
            this.buttonRemoveY.TabIndex = 6;
            this.buttonRemoveY.Text = "Видалити стовбчик";
            this.buttonRemoveY.UseVisualStyleBackColor = true;
            this.buttonRemoveY.Click += new System.EventHandler(this.buttonRemoveY_Click);
            // 
            // buttonRemoveX
            // 
            this.buttonRemoveX.Location = new System.Drawing.Point(618, 4);
            this.buttonRemoveX.Name = "buttonRemoveX";
            this.buttonRemoveX.Size = new System.Drawing.Size(90, 34);
            this.buttonRemoveX.TabIndex = 5;
            this.buttonRemoveX.Text = "Видалити стовбчик";
            this.buttonRemoveX.UseVisualStyleBackColor = true;
            this.buttonRemoveX.Click += new System.EventHandler(this.buttonRemoveX_Click);
            // 
            // buttonAddY
            // 
            this.buttonAddY.Location = new System.Drawing.Point(505, 44);
            this.buttonAddY.Name = "buttonAddY";
            this.buttonAddY.Size = new System.Drawing.Size(90, 34);
            this.buttonAddY.TabIndex = 4;
            this.buttonAddY.Text = "Додати рядок";
            this.buttonAddY.UseVisualStyleBackColor = true;
            this.buttonAddY.Click += new System.EventHandler(this.buttonAddY_Click);
            // 
            // buttonAddX
            // 
            this.buttonAddX.Location = new System.Drawing.Point(506, 4);
            this.buttonAddX.Name = "buttonAddX";
            this.buttonAddX.Size = new System.Drawing.Size(90, 34);
            this.buttonAddX.TabIndex = 3;
            this.buttonAddX.Text = "Додати стовбчик";
            this.buttonAddX.UseVisualStyleBackColor = true;
            this.buttonAddX.Click += new System.EventHandler(this.buttonAddX_Click);
            // 
            // panelProcess
            // 
            this.panelProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProcess.Location = new System.Drawing.Point(4, 322);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(495, 327);
            this.panelProcess.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMain);
            this.Name = "formMain";
            this.Text = "Калькулятор транспортної задачі";
            this.panelMain.ResumeLayout(false);
            this.panelSolution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinal)).EndInit();
            this.panelInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInputY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.DataGridView dataInputMain;
        private System.Windows.Forms.Button buttonAddY;
        private System.Windows.Forms.Button buttonAddX;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonRemoveY;
        private System.Windows.Forms.Button buttonRemoveX;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.DataGridView dataInputY;
        private System.Windows.Forms.DataGridView dataInputX;
        private System.Windows.Forms.Panel panelSolution;
        private System.Windows.Forms.DataGridView dataFinalY;
        private System.Windows.Forms.DataGridView dataFinalX;
        private System.Windows.Forms.DataGridView dataFinal;
    }
}

