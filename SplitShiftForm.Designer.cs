namespace EmeraldRestaurant
{
    partial class SplitShiftForm
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
            this.dataGridViewSplitShift = new System.Windows.Forms.DataGridView();
            this.splitShiftsbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSplitShift)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSplitShift
            // 
            this.dataGridViewSplitShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSplitShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSplitShift.Location = new System.Drawing.Point(15, 62);
            this.dataGridViewSplitShift.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSplitShift.Name = "dataGridViewSplitShift";
            this.dataGridViewSplitShift.RowHeadersWidth = 51;
            this.dataGridViewSplitShift.RowTemplate.Height = 24;
            this.dataGridViewSplitShift.Size = new System.Drawing.Size(970, 596);
            this.dataGridViewSplitShift.TabIndex = 1;
            // 
            // splitShiftsbutton
            // 
            this.splitShiftsbutton.Image = global::EmeraldRestaurant.Properties.Resources.ShiftIcon;
            this.splitShiftsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitShiftsbutton.Location = new System.Drawing.Point(15, 20);
            this.splitShiftsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.splitShiftsbutton.Name = "splitShiftsbutton";
            this.splitShiftsbutton.Size = new System.Drawing.Size(138, 34);
            this.splitShiftsbutton.TabIndex = 0;
            this.splitShiftsbutton.Text = "Split Shifts";
            this.splitShiftsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitShiftsbutton.UseVisualStyleBackColor = true;
            this.splitShiftsbutton.Click += new System.EventHandler(this.splitShiftsbutton_Click);
            // 
            // SplitShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.dataGridViewSplitShift);
            this.Controls.Add(this.splitShiftsbutton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SplitShiftForm";
            this.Text = "SplitShiftForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSplitShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button splitShiftsbutton;
        private System.Windows.Forms.DataGridView dataGridViewSplitShift;
    }
}