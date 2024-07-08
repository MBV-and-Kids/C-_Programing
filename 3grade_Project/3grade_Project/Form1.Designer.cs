namespace _3grade_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.examine = new System.Windows.Forms.Button();
            this.CropImageButton = new System.Windows.Forms.Button();
            this.Trigger = new System.Windows.Forms.Button();
            this.panel3Container = new System.Windows.Forms.Panel();
            this.lblResult1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cogDisplay4 = new WindowsFormsApplication1.CogDisplay();
            this.cogDisplay2 = new WindowsFormsApplication1.CogDisplay();
            this.cogDisplay3 = new WindowsFormsApplication1.CogDisplay();
            this.cogDisplay1 = new WindowsFormsApplication1.CogDisplay();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.White;
            this.Header_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header_Panel.Controls.Add(this.label2);
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Controls.Add(this.pictureBox1);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Header_Panel.Location = new System.Drawing.Point(22, 60);
            this.Header_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1662, 82);
            this.Header_Panel.TabIndex = 0;
            this.Header_Panel.SizeChanged += new System.EventHandler(this.Header_Panel_SizeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "GBSW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3grade_Project.Properties.Resources.GBSW;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.examine);
            this.panel2.Controls.Add(this.CropImageButton);
            this.panel2.Controls.Add(this.Trigger);
            this.panel2.Controls.Add(this.panel3Container);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(22, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1662, 653);
            this.panel2.TabIndex = 1;
            // 
            // examine
            // 
            this.examine.Location = new System.Drawing.Point(978, 591);
            this.examine.Name = "examine";
            this.examine.Size = new System.Drawing.Size(288, 44);
            this.examine.TabIndex = 8;
            this.examine.Text = "검사";
            this.examine.UseVisualStyleBackColor = true;
            this.examine.Click += new System.EventHandler(this.examine_Click);
            // 
            // CropImageButton
            // 
            this.CropImageButton.Location = new System.Drawing.Point(684, 591);
            this.CropImageButton.Name = "CropImageButton";
            this.CropImageButton.Size = new System.Drawing.Size(288, 44);
            this.CropImageButton.TabIndex = 7;
            this.CropImageButton.Text = "자르기";
            this.CropImageButton.UseVisualStyleBackColor = true;
            this.CropImageButton.Click += new System.EventHandler(this.CropImageButton_Click_1);
            // 
            // Trigger
            // 
            this.Trigger.Location = new System.Drawing.Point(390, 588);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(288, 44);
            this.Trigger.TabIndex = 0;
            this.Trigger.Text = "촬영";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.Trigger_Click);
            // 
            // panel3Container
            // 
            this.panel3Container.BackColor = System.Drawing.Color.Gray;
            this.panel3Container.Controls.Add(this.metroLabel4);
            this.panel3Container.Controls.Add(this.metroLabel3);
            this.panel3Container.Controls.Add(this.metroLabel2);
            this.panel3Container.Controls.Add(this.metroLabel1);
            this.panel3Container.Controls.Add(this.cogDisplay4);
            this.panel3Container.Controls.Add(this.cogDisplay2);
            this.panel3Container.Controls.Add(this.cogDisplay3);
            this.panel3Container.Controls.Add(this.cogDisplay1);
            this.panel3Container.Controls.Add(this.lblResult1);
            this.panel3Container.Location = new System.Drawing.Point(0, 0);
            this.panel3Container.Name = "panel3Container";
            this.panel3Container.Padding = new System.Windows.Forms.Padding(10);
            this.panel3Container.Size = new System.Drawing.Size(1659, 585);
            this.panel3Container.TabIndex = 3;
            // 
            // lblResult1
            // 
            this.lblResult1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult1.AutoSize = true;
            this.lblResult1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblResult1.Location = new System.Drawing.Point(803, 541);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(53, 25);
            this.lblResult1.Style = MetroFramework.MetroColorStyle.Black;
            this.lblResult1.TabIndex = 4;
            this.lblResult1.Text = "result";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Camera";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(429, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "image";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(839, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 25);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Hitmap";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(1245, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Histogram";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 40F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1053, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(849, 93);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team : 바지없는바지사장";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cogDisplay4
            // 
            this.cogDisplay4.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay4.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay4.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay4.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay4.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay4.DoubleTapZoomCycleLength = 2;
            this.cogDisplay4.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay4.Location = new System.Drawing.Point(1246, 13);
            this.cogDisplay4.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay4.MouseWheelSensitivity = 1D;
            this.cogDisplay4.Name = "cogDisplay4";
            this.cogDisplay4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay4.OcxState")));
            this.cogDisplay4.Size = new System.Drawing.Size(400, 497);
            this.cogDisplay4.TabIndex = 8;
            // 
            // cogDisplay2
            // 
            this.cogDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay2.Location = new System.Drawing.Point(429, 13);
            this.cogDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay2.MouseWheelSensitivity = 1D;
            this.cogDisplay2.Name = "cogDisplay2";
            this.cogDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay2.OcxState")));
            this.cogDisplay2.Size = new System.Drawing.Size(400, 497);
            this.cogDisplay2.TabIndex = 7;
            // 
            // cogDisplay3
            // 
            this.cogDisplay3.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay3.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay3.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay3.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay3.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay3.DoubleTapZoomCycleLength = 2;
            this.cogDisplay3.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay3.Location = new System.Drawing.Point(839, 13);
            this.cogDisplay3.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay3.MouseWheelSensitivity = 1D;
            this.cogDisplay3.Name = "cogDisplay3";
            this.cogDisplay3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay3.OcxState")));
            this.cogDisplay3.Size = new System.Drawing.Size(400, 497);
            this.cogDisplay3.TabIndex = 6;
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(13, 13);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(400, 497);
            this.cogDisplay1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1706, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Header_Panel);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(22, 60, 22, 20);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3Container.ResumeLayout(false);
            this.panel3Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3Container;
        private MetroFramework.Controls.MetroLabel lblResult1;
        private System.Windows.Forms.Button Trigger;
        private WindowsFormsApplication1.CogDisplay cogDisplay1;
        private WindowsFormsApplication1.CogDisplay cogDisplay3;
        private System.Windows.Forms.Button CropImageButton;
        private WindowsFormsApplication1.CogDisplay cogDisplay4;
        private WindowsFormsApplication1.CogDisplay cogDisplay2;
        private System.Windows.Forms.Button examine;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label2;
    }
}
