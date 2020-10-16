namespace baseball
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Input = new System.Windows.Forms.Button();
            this.list_Result = new System.Windows.Forms.ListBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Input
            // 
            this.tb_Input.BackColor = System.Drawing.Color.White;
            this.tb_Input.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Input.ForeColor = System.Drawing.Color.Navy;
            this.tb_Input.Location = new System.Drawing.Point(26, 44);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(226, 27);
            this.tb_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "숫자를 입력해주세요";
            // 
            // bt_Input
            // 
            this.bt_Input.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Input.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Input.ForeColor = System.Drawing.Color.White;
            this.bt_Input.Location = new System.Drawing.Point(258, 44);
            this.bt_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Input.Name = "bt_Input";
            this.bt_Input.Size = new System.Drawing.Size(71, 52);
            this.bt_Input.TabIndex = 2;
            this.bt_Input.Text = "Check";
            this.bt_Input.UseVisualStyleBackColor = false;
            this.bt_Input.Click += new System.EventHandler(this.bt_Input_Click);
            // 
            // list_Result
            // 
            this.list_Result.BackColor = System.Drawing.Color.White;
            this.list_Result.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_Result.ForeColor = System.Drawing.Color.Navy;
            this.list_Result.FormattingEnabled = true;
            this.list_Result.ItemHeight = 20;
            this.list_Result.Location = new System.Drawing.Point(26, 104);
            this.list_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_Result.Name = "list_Result";
            this.list_Result.Size = new System.Drawing.Size(303, 244);
            this.list_Result.TabIndex = 3;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Result.ForeColor = System.Drawing.Color.White;
            this.label_Result.Location = new System.Drawing.Point(26, 80);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 20);
            this.label_Result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(360, 362);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.list_Result);
            this.Controls.Add(this.bt_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Input);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "★★ BaseBall ★★";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Input;
        private System.Windows.Forms.ListBox list_Result;
        private System.Windows.Forms.Label label_Result;
    }
}

