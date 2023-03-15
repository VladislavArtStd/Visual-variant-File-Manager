namespace FileManager
{
    partial class window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.text_path = new System.Windows.Forms.TextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.data_list = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Window;
            this.btn_back.Enabled = false;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.Orange;
            this.btn_back.Location = new System.Drawing.Point(12, 408);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 30);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.BackColor = System.Drawing.Color.White;
            this.btn_forward.Enabled = false;
            this.btn_forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_forward.ForeColor = System.Drawing.Color.Orange;
            this.btn_forward.Location = new System.Drawing.Point(924, 408);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(82, 30);
            this.btn_forward.TabIndex = 1;
            this.btn_forward.Text = "Вперёд";
            this.btn_forward.UseVisualStyleBackColor = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // text_path
            // 
            this.text_path.BackColor = System.Drawing.SystemColors.Window;
            this.text_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_path.ForeColor = System.Drawing.Color.Black;
            this.text_path.Location = new System.Drawing.Point(15, 12);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(884, 22);
            this.text_path.TabIndex = 2;
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.SystemColors.Window;
            this.btn_go.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_go.ForeColor = System.Drawing.Color.Orange;
            this.btn_go.Location = new System.Drawing.Point(905, 6);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(101, 35);
            this.btn_go.TabIndex = 3;
            this.btn_go.Text = "Выполнить";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.UseWaitCursor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // data_list
            // 
            this.data_list.BackColor = System.Drawing.SystemColors.Window;
            this.data_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_list.ForeColor = System.Drawing.Color.Black;
            this.data_list.HideSelection = false;
            this.data_list.LargeImageList = this.imageList1;
            this.data_list.Location = new System.Drawing.Point(15, 47);
            this.data_list.Name = "data_list";
            this.data_list.Size = new System.Drawing.Size(994, 355);
            this.data_list.TabIndex = 4;
            this.data_list.UseCompatibleStateImageBehavior = false;
            this.data_list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.data_list_ItemSelectionChanged);
            this.data_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.data_list_MouseClick);
            this.data_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_list_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "audio.png");
            this.imageList1.Images.SetKeyName(2, "docx.png");
            this.imageList1.Images.SetKeyName(3, "pdf.png");
            this.imageList1.Images.SetKeyName(4, "exe.png");
            this.imageList1.Images.SetKeyName(5, "paint.png");
            this.imageList1.Images.SetKeyName(6, "unknown.png");
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1018, 446);
            this.Controls.Add(this.data_list);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.MaximizeBox = false;
            this.Name = "window";
            this.Text = "FileManager";
            this.Load += new System.EventHandler(this.window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Button btn_forward;
        public System.Windows.Forms.TextBox text_path;
        public System.Windows.Forms.ListView data_list;
        private System.Windows.Forms.ImageList imageList1;
        protected System.Windows.Forms.Button btn_go;
    }
}

