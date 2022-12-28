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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonRemoveY = new System.Windows.Forms.Button();
            this.buttonRemoveX = new System.Windows.Forms.Button();
            this.buttonAddY = new System.Windows.Forms.Button();
            this.buttonAddX = new System.Windows.Forms.Button();
            this.labelText_CostLabel = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelText_Cost = new System.Windows.Forms.Label();
            this.labelText_InX = new System.Windows.Forms.Label();
            this.labelText_InY = new System.Windows.Forms.Label();
            this.labelText_OutX = new System.Windows.Forms.Label();
            this.labelText_OutY = new System.Windows.Forms.Label();
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
            this.panelMain.Controls.Add(this.labelText_Cost);
            this.panelMain.Controls.Add(this.buttonClear);
            this.panelMain.Controls.Add(this.labelText_CostLabel);
            this.panelMain.Controls.Add(this.panelSolution);
            this.panelMain.Controls.Add(this.panelInput);
            this.panelMain.Controls.Add(this.buttonSolve);
            this.panelMain.Controls.Add(this.buttonRemoveY);
            this.panelMain.Controls.Add(this.buttonRemoveX);
            this.panelMain.Controls.Add(this.buttonAddY);
            this.panelMain.Controls.Add(this.buttonAddX);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1239, 363);
            this.panelMain.TabIndex = 0;
            // 
            // panelSolution
            // 
            this.panelSolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSolution.Controls.Add(this.labelText_OutY);
            this.panelSolution.Controls.Add(this.labelText_OutX);
            this.panelSolution.Controls.Add(this.dataFinalY);
            this.panelSolution.Controls.Add(this.dataFinalX);
            this.panelSolution.Controls.Add(this.dataFinal);
            this.panelSolution.Location = new System.Drawing.Point(716, 3);
            this.panelSolution.Name = "panelSolution";
            this.panelSolution.Size = new System.Drawing.Size(521, 332);
            this.panelSolution.TabIndex = 9;
            // 
            // dataFinalY
            // 
            this.dataFinalY.AllowUserToAddRows = false;
            this.dataFinalY.AllowUserToDeleteRows = false;
            this.dataFinalY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinalY.ColumnHeadersVisible = false;
            this.dataFinalY.Location = new System.Drawing.Point(3, 74);
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
            this.dataFinalX.Location = new System.Drawing.Point(60, 23);
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
            this.dataFinal.Location = new System.Drawing.Point(60, 74);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.RowHeadersVisible = false;
            this.dataFinal.RowHeadersWidth = 30;
            this.dataFinal.Size = new System.Drawing.Size(454, 251);
            this.dataFinal.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInput.Controls.Add(this.labelText_InY);
            this.panelInput.Controls.Add(this.labelText_InX);
            this.panelInput.Controls.Add(this.dataInputY);
            this.panelInput.Controls.Add(this.dataInputX);
            this.panelInput.Controls.Add(this.dataInputMain);
            this.panelInput.Location = new System.Drawing.Point(4, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(495, 337);
            this.panelInput.TabIndex = 8;
            // 
            // dataInputY
            // 
            this.dataInputY.AllowUserToAddRows = false;
            this.dataInputY.AllowUserToDeleteRows = false;
            this.dataInputY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInputY.ColumnHeadersVisible = false;
            this.dataInputY.Location = new System.Drawing.Point(3, 76);
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
            this.dataInputX.Location = new System.Drawing.Point(59, 23);
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
            this.dataInputMain.Location = new System.Drawing.Point(59, 76);
            this.dataInputMain.Name = "dataInputMain";
            this.dataInputMain.RowHeadersVisible = false;
            this.dataInputMain.RowHeadersWidth = 30;
            this.dataInputMain.Size = new System.Drawing.Size(429, 249);
            this.dataInputMain.TabIndex = 0;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(554, 155);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(105, 34);
            this.buttonSolve.TabIndex = 7;
            this.buttonSolve.Text = "Вирішити";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonRemoveY
            // 
            this.buttonRemoveY.Location = new System.Drawing.Point(618, 68);
            this.buttonRemoveY.Name = "buttonRemoveY";
            this.buttonRemoveY.Size = new System.Drawing.Size(90, 34);
            this.buttonRemoveY.TabIndex = 6;
            this.buttonRemoveY.Text = "Видалити рядок";
            this.buttonRemoveY.UseVisualStyleBackColor = true;
            this.buttonRemoveY.Click += new System.EventHandler(this.buttonRemoveY_Click);
            // 
            // buttonRemoveX
            // 
            this.buttonRemoveX.Location = new System.Drawing.Point(618, 28);
            this.buttonRemoveX.Name = "buttonRemoveX";
            this.buttonRemoveX.Size = new System.Drawing.Size(90, 34);
            this.buttonRemoveX.TabIndex = 5;
            this.buttonRemoveX.Text = "Видалити стовбчик";
            this.buttonRemoveX.UseVisualStyleBackColor = true;
            this.buttonRemoveX.Click += new System.EventHandler(this.buttonRemoveX_Click);
            // 
            // buttonAddY
            // 
            this.buttonAddY.Location = new System.Drawing.Point(505, 68);
            this.buttonAddY.Name = "buttonAddY";
            this.buttonAddY.Size = new System.Drawing.Size(90, 34);
            this.buttonAddY.TabIndex = 4;
            this.buttonAddY.Text = "Додати рядок";
            this.buttonAddY.UseVisualStyleBackColor = true;
            this.buttonAddY.Click += new System.EventHandler(this.buttonAddY_Click);
            // 
            // buttonAddX
            // 
            this.buttonAddX.Location = new System.Drawing.Point(506, 28);
            this.buttonAddX.Name = "buttonAddX";
            this.buttonAddX.Size = new System.Drawing.Size(90, 34);
            this.buttonAddX.TabIndex = 3;
            this.buttonAddX.Text = "Додати стовбчик";
            this.buttonAddX.UseVisualStyleBackColor = true;
            this.buttonAddX.Click += new System.EventHandler(this.buttonAddX_Click);
            // 
            // labelText_CostLabel
            // 
            this.labelText_CostLabel.AutoSize = true;
            this.labelText_CostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelText_CostLabel.Location = new System.Drawing.Point(718, 344);
            this.labelText_CostLabel.Name = "labelText_CostLabel";
            this.labelText_CostLabel.Size = new System.Drawing.Size(97, 15);
            this.labelText_CostLabel.TabIndex = 10;
            this.labelText_CostLabel.Text = "Ціна перевезень:";
            this.labelText_CostLabel.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(554, 195);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 34);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Очистити таблиці";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelText_Cost
            // 
            this.labelText_Cost.AutoSize = true;
            this.labelText_Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelText_Cost.Location = new System.Drawing.Point(820, 344);
            this.labelText_Cost.Name = "labelText_Cost";
            this.labelText_Cost.Size = new System.Drawing.Size(12, 15);
            this.labelText_Cost.TabIndex = 12;
            this.labelText_Cost.Text = " ";
            this.labelText_Cost.Visible = false;
            // 
            // labelText_InX
            // 
            this.labelText_InX.AutoSize = true;
            this.labelText_InX.Location = new System.Drawing.Point(56, 7);
            this.labelText_InX.Name = "labelText_InX";
            this.labelText_InX.Size = new System.Drawing.Size(50, 13);
            this.labelText_InX.TabIndex = 3;
            this.labelText_InX.Text = "Потреби";
            // 
            // labelText_InY
            // 
            this.labelText_InY.AutoSize = true;
            this.labelText_InY.Location = new System.Drawing.Point(3, 60);
            this.labelText_InY.Name = "labelText_InY";
            this.labelText_InY.Size = new System.Drawing.Size(44, 13);
            this.labelText_InY.TabIndex = 4;
            this.labelText_InY.Text = "Запаси";
            // 
            // labelText_OutX
            // 
            this.labelText_OutX.AutoSize = true;
            this.labelText_OutX.Location = new System.Drawing.Point(57, 7);
            this.labelText_OutX.Name = "labelText_OutX";
            this.labelText_OutX.Size = new System.Drawing.Size(50, 13);
            this.labelText_OutX.TabIndex = 5;
            this.labelText_OutX.Text = "Потреби";
            // 
            // labelText_OutY
            // 
            this.labelText_OutY.AutoSize = true;
            this.labelText_OutY.Location = new System.Drawing.Point(3, 60);
            this.labelText_OutY.Name = "labelText_OutY";
            this.labelText_OutY.Size = new System.Drawing.Size(44, 13);
            this.labelText_OutY.TabIndex = 5;
            this.labelText_OutY.Text = "Запаси";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 385);
            this.Controls.Add(this.panelMain);
            this.Name = "formMain";
            this.Text = "Калькулятор транспортної задачі";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelSolution.ResumeLayout(false);
            this.panelSolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinal)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInputMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataInputMain;
        private System.Windows.Forms.Button buttonAddY;
        private System.Windows.Forms.Button buttonAddX;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonRemoveY;
        private System.Windows.Forms.Button buttonRemoveX;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.DataGridView dataInputY;
        private System.Windows.Forms.DataGridView dataInputX;
        private System.Windows.Forms.Panel panelSolution;
        private System.Windows.Forms.DataGridView dataFinalY;
        private System.Windows.Forms.DataGridView dataFinalX;
        private System.Windows.Forms.DataGridView dataFinal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelText_CostLabel;
        private System.Windows.Forms.Label labelText_Cost;
        private System.Windows.Forms.Label labelText_OutY;
        private System.Windows.Forms.Label labelText_OutX;
        private System.Windows.Forms.Label labelText_InY;
        private System.Windows.Forms.Label labelText_InX;
    }
}

