﻿namespace SchoolTimeTable_Work_with_file_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xLSXToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xLSXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xLSXToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeTable = new System.Windows.Forms.DataGridView();
            this.Update_TimeTable_btn = new System.Windows.Forms.Button();
            this.Delete_Lesson_btn = new System.Windows.Forms.Button();
            this.Add_lesson_btn = new System.Windows.Forms.Button();
            this.TimeTable_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCall = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCall)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(807, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem2,
            this.xMLToolStripMenuItem2,
            this.cSVToolStripMenuItem2,
            this.jSONToolStripMenuItem2,
            this.xLSXToolStripMenuItem2});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // tXTToolStripMenuItem2
            // 
            this.tXTToolStripMenuItem2.Name = "tXTToolStripMenuItem2";
            this.tXTToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.tXTToolStripMenuItem2.Text = "TXT";
            this.tXTToolStripMenuItem2.Click += new System.EventHandler(this.tXTToolStripMenuItem2_Click);
            // 
            // xMLToolStripMenuItem2
            // 
            this.xMLToolStripMenuItem2.Name = "xMLToolStripMenuItem2";
            this.xMLToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem2.Text = "XML";
            this.xMLToolStripMenuItem2.Click += new System.EventHandler(this.xMLToolStripMenuItem2_Click);
            // 
            // cSVToolStripMenuItem2
            // 
            this.cSVToolStripMenuItem2.Name = "cSVToolStripMenuItem2";
            this.cSVToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.cSVToolStripMenuItem2.Text = "CSV";
            this.cSVToolStripMenuItem2.Click += new System.EventHandler(this.cSVToolStripMenuItem2_Click);
            // 
            // jSONToolStripMenuItem2
            // 
            this.jSONToolStripMenuItem2.Name = "jSONToolStripMenuItem2";
            this.jSONToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem2.Text = "JSON";
            this.jSONToolStripMenuItem2.Click += new System.EventHandler(this.jSONToolStripMenuItem2_Click);
            // 
            // xLSXToolStripMenuItem2
            // 
            this.xLSXToolStripMenuItem2.Name = "xLSXToolStripMenuItem2";
            this.xLSXToolStripMenuItem2.Size = new System.Drawing.Size(127, 26);
            this.xLSXToolStripMenuItem2.Text = "XLSX";
            this.xLSXToolStripMenuItem2.Click += new System.EventHandler(this.xLSXToolStripMenuItem2_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.xLSXToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // xLSXToolStripMenuItem
            // 
            this.xLSXToolStripMenuItem.Name = "xLSXToolStripMenuItem";
            this.xLSXToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.xLSXToolStripMenuItem.Text = "XLSX";
            this.xLSXToolStripMenuItem.Click += new System.EventHandler(this.xLSXToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem3,
            this.xMLToolStripMenuItem3,
            this.cSVToolStripMenuItem3,
            this.jSONToolStripMenuItem3,
            this.xLSXToolStripMenuItem3});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // tXTToolStripMenuItem3
            // 
            this.tXTToolStripMenuItem3.Name = "tXTToolStripMenuItem3";
            this.tXTToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.tXTToolStripMenuItem3.Text = "TXT";
            this.tXTToolStripMenuItem3.Click += new System.EventHandler(this.tXTToolStripMenuItem3_Click);
            // 
            // xMLToolStripMenuItem3
            // 
            this.xMLToolStripMenuItem3.Name = "xMLToolStripMenuItem3";
            this.xMLToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem3.Text = "XML";
            this.xMLToolStripMenuItem3.Click += new System.EventHandler(this.xMLToolStripMenuItem3_Click);
            // 
            // cSVToolStripMenuItem3
            // 
            this.cSVToolStripMenuItem3.Name = "cSVToolStripMenuItem3";
            this.cSVToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.cSVToolStripMenuItem3.Text = "CSV";
            this.cSVToolStripMenuItem3.Click += new System.EventHandler(this.cSVToolStripMenuItem3_Click);
            // 
            // jSONToolStripMenuItem3
            // 
            this.jSONToolStripMenuItem3.Name = "jSONToolStripMenuItem3";
            this.jSONToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem3.Text = "JSON";
            this.jSONToolStripMenuItem3.Click += new System.EventHandler(this.jSONToolStripMenuItem3_Click);
            // 
            // xLSXToolStripMenuItem3
            // 
            this.xLSXToolStripMenuItem3.Name = "xLSXToolStripMenuItem3";
            this.xLSXToolStripMenuItem3.Size = new System.Drawing.Size(127, 26);
            this.xLSXToolStripMenuItem3.Text = "XLSX";
            this.xLSXToolStripMenuItem3.Click += new System.EventHandler(this.xLSXToolStripMenuItem3_Click);
            // 
            // TimeTable
            // 
            this.TimeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TimeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TimeTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TimeTable.GridColor = System.Drawing.SystemColors.Control;
            this.TimeTable.Location = new System.Drawing.Point(19, 115);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.RowHeadersWidth = 51;
            this.TimeTable.RowTemplate.Height = 24;
            this.TimeTable.Size = new System.Drawing.Size(455, 248);
            this.TimeTable.TabIndex = 74;
           
            // 
            // Update_TimeTable_btn
            // 
            this.Update_TimeTable_btn.Location = new System.Drawing.Point(321, 380);
            this.Update_TimeTable_btn.Name = "Update_TimeTable_btn";
            this.Update_TimeTable_btn.Size = new System.Drawing.Size(153, 27);
            this.Update_TimeTable_btn.TabIndex = 87;
            this.Update_TimeTable_btn.Text = "Редагувати дані";
            this.Update_TimeTable_btn.UseVisualStyleBackColor = true;
            this.Update_TimeTable_btn.Click += new System.EventHandler(this.Update_TimeTable_btn_Click);
            // 
            // Delete_Lesson_btn
            // 
            this.Delete_Lesson_btn.Location = new System.Drawing.Point(321, 413);
            this.Delete_Lesson_btn.Name = "Delete_Lesson_btn";
            this.Delete_Lesson_btn.Size = new System.Drawing.Size(153, 27);
            this.Delete_Lesson_btn.TabIndex = 86;
            this.Delete_Lesson_btn.Text = "Видалити урок";
            this.Delete_Lesson_btn.UseVisualStyleBackColor = true;
            this.Delete_Lesson_btn.Click += new System.EventHandler(this.Delete_Lesson_btn_Click);
            // 
            // Add_lesson_btn
            // 
            this.Add_lesson_btn.Location = new System.Drawing.Point(19, 380);
            this.Add_lesson_btn.Name = "Add_lesson_btn";
            this.Add_lesson_btn.Size = new System.Drawing.Size(153, 27);
            this.Add_lesson_btn.TabIndex = 85;
            this.Add_lesson_btn.Text = "Додати урок";
            this.Add_lesson_btn.UseVisualStyleBackColor = true;
            this.Add_lesson_btn.Click += new System.EventHandler(this.Add_lesson_btn_Click);
            // 
            // TimeTable_label
            // 
            this.TimeTable_label.AutoSize = true;
            this.TimeTable_label.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTable_label.Location = new System.Drawing.Point(177, 63);
            this.TimeTable_label.Name = "TimeTable_label";
            this.TimeTable_label.Size = new System.Drawing.Size(135, 49);
            this.TimeTable_label.TabIndex = 88;
            this.TimeTable_label.Text = "Розклад";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(543, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 89;
            this.label1.Text = "Розклад дзвінків";
            // 
            // dataGridViewCall
            // 
            this.dataGridViewCall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridViewCall.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewCall.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCall.Location = new System.Drawing.Point(530, 115);
            this.dataGridViewCall.Name = "dataGridViewCall";
            this.dataGridViewCall.RowHeadersWidth = 51;
            this.dataGridViewCall.RowTemplate.Height = 24;
            this.dataGridViewCall.Size = new System.Drawing.Size(237, 229);
            this.dataGridViewCall.TabIndex = 90;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 27);
            this.buttonSave.TabIndex = 91;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 501);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewCall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeTable_label);
            this.Controls.Add(this.Update_TimeTable_btn);
            this.Controls.Add(this.Delete_Lesson_btn);
            this.Controls.Add(this.Add_lesson_btn);
            this.Controls.Add(this.TimeTable);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xLSXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xLSXToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xLSXToolStripMenuItem3;
        private System.Windows.Forms.DataGridView TimeTable;
        private System.Windows.Forms.Button Update_TimeTable_btn;
        private System.Windows.Forms.Button Delete_Lesson_btn;
        private System.Windows.Forms.Button Add_lesson_btn;
        private System.Windows.Forms.Label TimeTable_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCall;
        private System.Windows.Forms.Button buttonSave;
    }
}

