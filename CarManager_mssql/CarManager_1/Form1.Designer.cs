namespace CarManager_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OutCar = new System.Windows.Forms.Button();
            this.button_InCar = new System.Windows.Forms.Button();
            this.textBox_PhoneNum = new System.Windows.Forms.TextBox();
            this.textBox_DriverName = new System.Windows.Forms.TextBox();
            this.textBox_CarNum = new System.Windows.Forms.TextBox();
            this.textBox_ParkingSpot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_CarManager = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarManager)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OutCar);
            this.groupBox1.Controls.Add(this.button_InCar);
            this.groupBox1.Controls.Add(this.textBox_PhoneNum);
            this.groupBox1.Controls.Add(this.textBox_DriverName);
            this.groupBox1.Controls.Add(this.textBox_CarNum);
            this.groupBox1.Controls.Add(this.textBox_ParkingSpot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차/출차";
            // 
            // button_OutCar
            // 
            this.button_OutCar.Location = new System.Drawing.Point(202, 51);
            this.button_OutCar.Name = "button_OutCar";
            this.button_OutCar.Size = new System.Drawing.Size(75, 23);
            this.button_OutCar.TabIndex = 9;
            this.button_OutCar.Text = "출차";
            this.button_OutCar.UseVisualStyleBackColor = true;
            this.button_OutCar.Click += new System.EventHandler(this.button_OutCar_Click);
            // 
            // button_InCar
            // 
            this.button_InCar.Location = new System.Drawing.Point(202, 21);
            this.button_InCar.Name = "button_InCar";
            this.button_InCar.Size = new System.Drawing.Size(75, 23);
            this.button_InCar.TabIndex = 8;
            this.button_InCar.Text = "주차";
            this.button_InCar.UseVisualStyleBackColor = true;
            this.button_InCar.Click += new System.EventHandler(this.button_InCar_Click);
            // 
            // textBox_PhoneNum
            // 
            this.textBox_PhoneNum.Location = new System.Drawing.Point(77, 118);
            this.textBox_PhoneNum.Name = "textBox_PhoneNum";
            this.textBox_PhoneNum.Size = new System.Drawing.Size(100, 21);
            this.textBox_PhoneNum.TabIndex = 7;
            // 
            // textBox_DriverName
            // 
            this.textBox_DriverName.Location = new System.Drawing.Point(77, 87);
            this.textBox_DriverName.Name = "textBox_DriverName";
            this.textBox_DriverName.Size = new System.Drawing.Size(100, 21);
            this.textBox_DriverName.TabIndex = 6;
            // 
            // textBox_CarNum
            // 
            this.textBox_CarNum.Location = new System.Drawing.Point(77, 53);
            this.textBox_CarNum.Name = "textBox_CarNum";
            this.textBox_CarNum.Size = new System.Drawing.Size(100, 21);
            this.textBox_CarNum.TabIndex = 5;
            // 
            // textBox_ParkingSpot
            // 
            this.textBox_ParkingSpot.Location = new System.Drawing.Point(77, 23);
            this.textBox_ParkingSpot.Name = "textBox_ParkingSpot";
            this.textBox_ParkingSpot.Size = new System.Drawing.Size(100, 21);
            this.textBox_ParkingSpot.TabIndex = 4;
            this.textBox_ParkingSpot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ParkingSpot_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "차주이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "차량번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "공간번호";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_CarManager);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 현황";
            // 
            // dataGridView_CarManager
            // 
            this.dataGridView_CarManager.AllowUserToAddRows = false;
            this.dataGridView_CarManager.AllowUserToDeleteRows = false;
            this.dataGridView_CarManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CarManager.Location = new System.Drawing.Point(8, 26);
            this.dataGridView_CarManager.Name = "dataGridView_CarManager";
            this.dataGridView_CarManager.ReadOnly = true;
            this.dataGridView_CarManager.RowTemplate.Height = 23;
            this.dataGridView_CarManager.Size = new System.Drawing.Size(762, 232);
            this.dataGridView_CarManager.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(20, 444);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(762, 88);
            this.listBox1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Search);
            this.groupBox3.Controls.Add(this.textBox_Search);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(301, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 147);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 공간 현황 관리";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(198, 23);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 10;
            this.button_Search.Text = "조회";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(75, 23);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(100, 21);
            this.textBox_Search.TabIndex = 10;
            this.textBox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "공간번호";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarManager_1.Car);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarManager)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OutCar;
        private System.Windows.Forms.Button button_InCar;
        private System.Windows.Forms.TextBox textBox_PhoneNum;
        private System.Windows.Forms.TextBox textBox_DriverName;
        private System.Windows.Forms.TextBox textBox_CarNum;
        private System.Windows.Forms.TextBox textBox_ParkingSpot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_CarManager;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

