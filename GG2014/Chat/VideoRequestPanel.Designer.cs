﻿namespace GG2014
{
    partial class VideoRequestPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoRequestPanel));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinButtomReject = new CCWin.SkinControl.SkinButton();
            this.btnAccept = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(28, 166);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(137, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "对方视频通话邀请中 . . .";
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.BackgroundImage = global::GG2014.Properties.Resources.VideoWaitToAnswer;
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(25, 16);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(142, 142);
            this.skinPanel2.TabIndex = 129;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinPanel1.BackgroundImage = global::GG2014.Properties.Resources.AV_VDC_Bkg;
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(22, 14);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(148, 148);
            this.skinPanel1.TabIndex = 129;
            // 
            // skinButtomReject
            // 
            this.skinButtomReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButtomReject.BackColor = System.Drawing.Color.Transparent;
            this.skinButtomReject.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtomReject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.skinButtomReject.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButtomReject.DownBack")));
            this.skinButtomReject.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButtomReject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtomReject.Image = global::GG2014.Properties.Resources.AV_Refuse;
            this.skinButtomReject.Location = new System.Drawing.Point(62, 219);
            this.skinButtomReject.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButtomReject.MouseBack")));
            this.skinButtomReject.Name = "skinButtomReject";
            this.skinButtomReject.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButtomReject.NormlBack")));
            this.skinButtomReject.Size = new System.Drawing.Size(69, 24);
            this.skinButtomReject.TabIndex = 128;
            this.skinButtomReject.Text = "拒绝";
            this.skinButtomReject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButtomReject.UseVisualStyleBackColor = false;
            this.skinButtomReject.Click += new System.EventHandler(this.skinButtomReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.DownBack = ((System.Drawing.Image)(resources.GetObject("btnAccept.DownBack")));
            this.btnAccept.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnAccept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAccept.Image = global::GG2014.Properties.Resources.AV_Accept;
            this.btnAccept.Location = new System.Drawing.Point(62, 189);
            this.btnAccept.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnAccept.MouseBack")));
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnAccept.NormlBack")));
            this.btnAccept.Size = new System.Drawing.Size(69, 24);
            this.btnAccept.TabIndex = 128;
            this.btnAccept.Text = "接受";
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // VideoRequestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.skinButtomReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.skinLabel1);
            this.Name = "VideoRequestPanel";
            this.Size = new System.Drawing.Size(192, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnAccept;
        private CCWin.SkinControl.SkinButton skinButtomReject;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
    }
}
