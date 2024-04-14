namespace ImageProcessing
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
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRedFilter = new System.Windows.Forms.Button();
            this.btnBlueFilter = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnFlipH = new System.Windows.Forms.Button();
            this.btnFlipV = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnSwitchCorners = new System.Windows.Forms.Button();
            this.btnPixellate = new System.Windows.Forms.Button();
            this.btnTile = new System.Windows.Forms.Button();
            this.btnScrolling = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(121, 318);
            this.btnTransform.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(100, 28);
            this.btnTransform.TabIndex = 5;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(13, 318);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(16, 15);
            this.picImage.Margin = new System.Windows.Forms.Padding(4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(427, 295);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            this.picImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picImage_MouseClick);
            // 
            // btnRedFilter
            // 
            this.btnRedFilter.Location = new System.Drawing.Point(229, 318);
            this.btnRedFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedFilter.Name = "btnRedFilter";
            this.btnRedFilter.Size = new System.Drawing.Size(100, 28);
            this.btnRedFilter.TabIndex = 6;
            this.btnRedFilter.Text = "Red Filter";
            this.btnRedFilter.UseVisualStyleBackColor = true;
            this.btnRedFilter.Click += new System.EventHandler(this.btnRedFilter_Click);
            // 
            // btnBlueFilter
            // 
            this.btnBlueFilter.Location = new System.Drawing.Point(337, 318);
            this.btnBlueFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlueFilter.Name = "btnBlueFilter";
            this.btnBlueFilter.Size = new System.Drawing.Size(100, 28);
            this.btnBlueFilter.TabIndex = 7;
            this.btnBlueFilter.Text = "Blue Filter";
            this.btnBlueFilter.UseVisualStyleBackColor = true;
            this.btnBlueFilter.Click += new System.EventHandler(this.btnBlueFilter_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(13, 354);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(100, 28);
            this.btnNegative.TabIndex = 8;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(121, 354);
            this.btnLighten.Margin = new System.Windows.Forms.Padding(4);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(100, 28);
            this.btnLighten.TabIndex = 9;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(229, 354);
            this.btnDarken.Margin = new System.Windows.Forms.Padding(4);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(100, 28);
            this.btnDarken.TabIndex = 10;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(337, 354);
            this.btnSunset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(100, 28);
            this.btnSunset.TabIndex = 11;
            this.btnSunset.Text = "Sunset";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(13, 390);
            this.btnGrayscale.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(100, 28);
            this.btnGrayscale.TabIndex = 12;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(121, 390);
            this.btnPolarize.Margin = new System.Windows.Forms.Padding(4);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(100, 28);
            this.btnPolarize.TabIndex = 13;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnFlipH
            // 
            this.btnFlipH.Location = new System.Drawing.Point(229, 390);
            this.btnFlipH.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlipH.Name = "btnFlipH";
            this.btnFlipH.Size = new System.Drawing.Size(100, 28);
            this.btnFlipH.TabIndex = 14;
            this.btnFlipH.Text = "Flip H";
            this.btnFlipH.UseVisualStyleBackColor = true;
            this.btnFlipH.Click += new System.EventHandler(this.btnFlipH_Click);
            // 
            // btnFlipV
            // 
            this.btnFlipV.Location = new System.Drawing.Point(337, 390);
            this.btnFlipV.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlipV.Name = "btnFlipV";
            this.btnFlipV.Size = new System.Drawing.Size(100, 28);
            this.btnFlipV.TabIndex = 15;
            this.btnFlipV.Text = "Flip V";
            this.btnFlipV.UseVisualStyleBackColor = true;
            this.btnFlipV.Click += new System.EventHandler(this.btnFlipV_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(13, 426);
            this.btnRotate180.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(100, 28);
            this.btnRotate180.TabIndex = 16;
            this.btnRotate180.Text = "Rotate 180";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // btnSwitchCorners
            // 
            this.btnSwitchCorners.Location = new System.Drawing.Point(121, 426);
            this.btnSwitchCorners.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchCorners.Name = "btnSwitchCorners";
            this.btnSwitchCorners.Size = new System.Drawing.Size(123, 28);
            this.btnSwitchCorners.TabIndex = 17;
            this.btnSwitchCorners.Text = "Switch Corners";
            this.btnSwitchCorners.UseVisualStyleBackColor = true;
            this.btnSwitchCorners.Click += new System.EventHandler(this.btnSwitchCorners_Click);
            // 
            // btnPixellate
            // 
            this.btnPixellate.Location = new System.Drawing.Point(252, 426);
            this.btnPixellate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixellate.Name = "btnPixellate";
            this.btnPixellate.Size = new System.Drawing.Size(100, 28);
            this.btnPixellate.TabIndex = 18;
            this.btnPixellate.Text = "Pixellate";
            this.btnPixellate.UseVisualStyleBackColor = true;
            this.btnPixellate.Click += new System.EventHandler(this.btnPixellate_Click);
            // 
            // btnTile
            // 
            this.btnTile.Location = new System.Drawing.Point(360, 426);
            this.btnTile.Margin = new System.Windows.Forms.Padding(4);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(77, 28);
            this.btnTile.TabIndex = 19;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // btnScrolling
            // 
            this.btnScrolling.Location = new System.Drawing.Point(13, 462);
            this.btnScrolling.Margin = new System.Windows.Forms.Padding(4);
            this.btnScrolling.Name = "btnScrolling";
            this.btnScrolling.Size = new System.Drawing.Size(100, 28);
            this.btnScrolling.TabIndex = 20;
            this.btnScrolling.Text = "Scrolling";
            this.btnScrolling.UseVisualStyleBackColor = true;
            this.btnScrolling.Click += new System.EventHandler(this.btnScrolling_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(121, 462);
            this.btnBlur.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(63, 28);
            this.btnBlur.TabIndex = 21;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(192, 462);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(63, 28);
            this.btnSort.TabIndex = 22;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(263, 462);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(63, 28);
            this.btnZoom.TabIndex = 23;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 532);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnScrolling);
            this.Controls.Add(this.btnTile);
            this.Controls.Add(this.btnPixellate);
            this.Controls.Add(this.btnSwitchCorners);
            this.Controls.Add(this.btnRotate180);
            this.Controls.Add(this.btnFlipV);
            this.Controls.Add(this.btnFlipH);
            this.Controls.Add(this.btnPolarize);
            this.Controls.Add(this.btnGrayscale);
            this.Controls.Add(this.btnSunset);
            this.Controls.Add(this.btnDarken);
            this.Controls.Add(this.btnLighten);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnBlueFilter);
            this.Controls.Add(this.btnRedFilter);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnRedFilter;
        private System.Windows.Forms.Button btnBlueFilter;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnFlipH;
        private System.Windows.Forms.Button btnFlipV;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnSwitchCorners;
        private System.Windows.Forms.Button btnPixellate;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Button btnScrolling;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnZoom;
    }
}

