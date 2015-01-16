namespace DeltaUpdate
{
    partial class FormMain
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
            this.gb_software = new System.Windows.Forms.GroupBox();
            this.tb_Software = new System.Windows.Forms.TextBox();
            this.gb_action = new System.Windows.Forms.GroupBox();
            this.tb_Action = new System.Windows.Forms.TextBox();
            this.rb_singleGroup = new System.Windows.Forms.RadioButton();
            this.rb_mulipleGroup = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_loopSounder = new System.Windows.Forms.CheckBox();
            this.gb_software.SuspendLayout();
            this.gb_action.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_software
            // 
            this.gb_software.Controls.Add(this.tb_Software);
            this.gb_software.Location = new System.Drawing.Point(7, 85);
            this.gb_software.Name = "gb_software";
            this.gb_software.Size = new System.Drawing.Size(270, 100);
            this.gb_software.TabIndex = 1;
            this.gb_software.TabStop = false;
            this.gb_software.Text = "Godkjent software";
            // 
            // tb_Software
            // 
            this.tb_Software.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Software.Location = new System.Drawing.Point(6, 19);
            this.tb_Software.Multiline = true;
            this.tb_Software.Name = "tb_Software";
            this.tb_Software.ReadOnly = true;
            this.tb_Software.Size = new System.Drawing.Size(258, 75);
            this.tb_Software.TabIndex = 0;
            // 
            // gb_action
            // 
            this.gb_action.Controls.Add(this.tb_Action);
            this.gb_action.Location = new System.Drawing.Point(7, 191);
            this.gb_action.Name = "gb_action";
            this.gb_action.Size = new System.Drawing.Size(270, 100);
            this.gb_action.TabIndex = 2;
            this.gb_action.TabStop = false;
            this.gb_action.Text = "Aksjon";
            // 
            // tb_Action
            // 
            this.tb_Action.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Action.Location = new System.Drawing.Point(6, 19);
            this.tb_Action.Multiline = true;
            this.tb_Action.Name = "tb_Action";
            this.tb_Action.ReadOnly = true;
            this.tb_Action.Size = new System.Drawing.Size(258, 75);
            this.tb_Action.TabIndex = 1;
            // 
            // rb_singleGroup
            // 
            this.rb_singleGroup.AutoSize = true;
            this.rb_singleGroup.Location = new System.Drawing.Point(3, 3);
            this.rb_singleGroup.Name = "rb_singleGroup";
            this.rb_singleGroup.Size = new System.Drawing.Size(152, 17);
            this.rb_singleGroup.TabIndex = 4;
            this.rb_singleGroup.TabStop = true;
            this.rb_singleGroup.Text = "En gruppetype pr. subzone";
            this.rb_singleGroup.UseVisualStyleBackColor = true;
            this.rb_singleGroup.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_mulipleGroup
            // 
            this.rb_mulipleGroup.AutoSize = true;
            this.rb_mulipleGroup.Location = new System.Drawing.Point(3, 28);
            this.rb_mulipleGroup.Name = "rb_mulipleGroup";
            this.rb_mulipleGroup.Size = new System.Drawing.Size(165, 17);
            this.rb_mulipleGroup.TabIndex = 5;
            this.rb_mulipleGroup.TabStop = true;
            this.rb_mulipleGroup.Text = "Flere gruppetyper pr. subzone";
            this.rb_mulipleGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.rb_singleGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rb_mulipleGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_loopSounder, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 71);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // cb_loopSounder
            // 
            this.cb_loopSounder.AutoSize = true;
            this.cb_loopSounder.Location = new System.Drawing.Point(3, 53);
            this.cb_loopSounder.Name = "cb_loopSounder";
            this.cb_loopSounder.Size = new System.Drawing.Size(140, 15);
            this.cb_loopSounder.TabIndex = 6;
            this.cb_loopSounder.Text = "Sløyfedrevet alarmorgan";
            this.cb_loopSounder.UseVisualStyleBackColor = true;
            this.cb_loopSounder.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 299);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gb_action);
            this.Controls.Add(this.gb_software);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Delta Update?";
            this.gb_software.ResumeLayout(false);
            this.gb_software.PerformLayout();
            this.gb_action.ResumeLayout(false);
            this.gb_action.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_software;
        private System.Windows.Forms.GroupBox gb_action;
        private System.Windows.Forms.TextBox tb_Software;
        private System.Windows.Forms.TextBox tb_Action;
        private System.Windows.Forms.RadioButton rb_singleGroup;
        private System.Windows.Forms.RadioButton rb_mulipleGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cb_loopSounder;
    }
}

