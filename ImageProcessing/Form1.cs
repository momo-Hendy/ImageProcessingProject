using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

        //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArrayFromBitmap();

        }
        private void SetBitmapFromArray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        private void SetArrayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        
        private void btnTransform_Click(object sender, EventArgs e)
        {
                if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth ; i++)
            {
                for (int j = 0; j < iHeight ; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;
                   
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnRedFilter_Click(object sender, EventArgs e)
        {

            if (bitmapImage == null) return;

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int row = 0; row < iWidth; row++)
            {
                for (int col = 0; col < iHeight; col++)
                {
                    Color color = ImageArray[row, col];

                    //Get the Red element of the color
                    Red = color.R;
                    Green = color.G;
                    Blue = color.B;

                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[row, col] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnBlueFilter_Click(object sender, EventArgs e)
        {

            if (bitmapImage == null) return;

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int row = 0; row < iWidth; row++)
            {
                for (int col = 0; col < iHeight; col++)
                {
                    Color color = ImageArray[row, col];

                    //Get the Blue element of the color
                    Red = color.R;
                    Green = color.G;
                    Blue = color.B;

                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[row, col] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Red, Green, Blue;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color color = ImageArray[row, col];

                    // Get negative of image
                    Red = 255 - color.R;
                    Green = 255 - color.G;
                    Blue = 255 - color.B;

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[row, col] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color color = ImageArray[row, col];
                    int Red = Convert.ToInt32(color.R * 1.5);
                    int Green = Convert.ToInt32(color.G * 1.5);
                    int Blue = Convert.ToInt32(color.B * 1.5);

                    if (Red > 255) Red = 255;
                    if (Green > 255) Green = 255;
                    if (Blue > 255) Blue = 255;

                    ImageArray[row, col] = Color.FromArgb(Red, Green, Blue);
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color color = ImageArray[row, col];

                    int Red = Convert.ToInt32(color.R * 0.6);
                    int Green = Convert.ToInt32(color.G * 0.6);
                    int Blue = Convert.ToInt32(color.B * 0.6);

                    if (Red > 255) Red = 255;
                    if (Green > 255) Green = 255;
                    if (Blue > 255) Blue = 255;

                    ImageArray[row, col] = Color.FromArgb(Red, Green, Blue);
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0;col < Height; col++)
                {
                    Color color = ImageArray[row, col];
                    int Red = Convert.ToInt32(color.R * 1.5);
                    int Blue = Convert.ToInt32(color.B * 0.9);

                    if (Red > 255) Red = 255;

                    ImageArray[row, col] = Color.FromArgb(Red, color.G, Blue);
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for ( int col = 0; col < Height; col++)
                {
                    Color color = ImageArray[row, col];
                    int grayscale = (color.R + color.G + color.B) / 3;
                    ImageArray[row, col] = Color.FromArgb(grayscale, grayscale, grayscale);
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;
            
            long sumRed = 0, sumGreen = 0, sumBlue = 0;
            int totalPixels = 76800;

            int Width = 320;
            int Height = 240;

            // Calculate sum of all R, G and B values
            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color color = ImageArray[row, col];
                    sumRed += color.R;
                    sumGreen += color.G;
                    sumBlue += color.B;
                }
            }

            // Get average of RGB
            int averageRed = Convert.ToInt32(sumRed / totalPixels);
            int averageGreen = Convert.ToInt32(sumGreen / totalPixels);
            int averageBlue = Convert.ToInt32(sumBlue / totalPixels);

            // Polarize each pixel based on average values
            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color color = ImageArray[row, col];
                    int Red, Green, Blue;

                    if (color.R >= averageRed) Red = 255;
                    else Red = 0;

                    if (color.G >= averageGreen) Green = 255;
                    else Green = 0;

                    if (color.B >= averageBlue) Blue = 255;
                    else Blue = 0;

                    ImageArray[row, col] = Color.FromArgb(Red, Green, Blue);
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipH_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240 / 2;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color temp = ImageArray[row, col];
                    ImageArray[row, col] = ImageArray[row, 240 - col - 1];
                    ImageArray[row, 240 - col - 1] = temp;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipV_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320 / 2;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color temp = ImageArray[row, col];
                    ImageArray[row, col] = ImageArray[320 - row - 1, col];
                    ImageArray[320 - row - 1, col] = temp;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height / 2; col++)
                {
                    Color temp = ImageArray[row, col];
                    ImageArray[row, col] = ImageArray[row, 240 - col - 1];
                    ImageArray[row, 240 - col - 1] = temp;
                }
            }

            for (int row = 0; row < Width / 2; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color temp = ImageArray[row, col];
                    ImageArray[row, col] = ImageArray[320 - row - 1, col];
                    ImageArray[320 - row - 1, col] = temp;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSwitchCorners_Click(object sender, EventArgs e)
        {
            if (picImage == null) return;

            int Width = 320 / 2;
            int Height = 240 / 2;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color temp = ImageArray[row, col];
                    ImageArray[row, col] = ImageArray[row + Width, col + Height];
                    ImageArray[row + Width, col + Height] = temp;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnPixellate_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int blockSize = 8;
            int Width = 320;
            int Height = 240;
            Color[,] tempArray = new Color[Width, Height];

            for (int row = 0; row < Width; row += blockSize)
            {
                for (int col = 0; col < Height; col += blockSize)
                {
                    int sumRed = 0, sumGreen = 0, sumBlue = 0;
                    int count = 0;

                    // Sum up all colors in the block
                    for (int i = 0; i < blockSize; i++)
                    {
                        for (int j = 0; j < blockSize; j++)
                        {
                            if (row + i < Width &&  col + j < Height) // Check to make sure pixel doesn't cross block boundries
                            {
                                Color color = ImageArray[row + i, col + j];
                                sumRed += color.R;
                                sumGreen += color.G;
                                sumBlue += color.B;
                                count++;
                            }
                        }
                    }

                    // Calculate average color for RGB
                    int avgRed = sumRed / count;
                    int avgGreen = sumGreen / count;
                    int avgBlue = sumBlue / count;
                    Color avgColor = Color.FromArgb(avgRed, avgGreen, avgBlue);

                    // Assign average to each pixel in block
                    for (int i = 0; i < blockSize; i++)
                    {
                        for (int j = 0; j < blockSize; j++)
                        {
                            // Check to make sure pixel doesn't cross block boundries
                            if (row + i < Width && col + j < Height) tempArray[row + i, col + j] = avgColor; 
                        }
                    }
                }
            }

            Array.Copy(tempArray, ImageArray, tempArray.Length);

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            Color[,] tempArray = new Color[Width, Height];

            for (int row = 0;  row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    // 1st Quadrant: Original
                    tempArray[row / 2, col / 2] = ImageArray[row, col];
                    // 2nd Quadrant: Flip H
                    tempArray[row / 2, Height / 2 + col / 2] = ImageArray[row, Height - col - 1];
                    // 3rd Quadrant: Flip V
                    tempArray[Width / 2 + row / 2, col / 2] = ImageArray[Width - row - 1, col];
                    // 4th Quadrant: Rotate 180
                    tempArray[Width / 2 + row / 2, Height / 2 + col / 2] = ImageArray[Width - row - 1, Height - col - 1];
                }
            }

            Array.Copy(tempArray, ImageArray, tempArray.Length);

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnScrolling_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int scrollAmount = 40;
            int Width = 320;
            int Height = 240;
            Color[,] tempArray = new Color[Width, Height];

            // We implement a horizontal scroll feature
            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    int newRow = (row + scrollAmount) % Width; // We use modulus to wrap around
                    tempArray[newRow, col] = ImageArray[row, col];
                }
            }

            Array.Copy(tempArray, ImageArray, tempArray.Length);

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            Color[,] tempArray = new Color[Width, Height];
            Array.Copy(ImageArray, tempArray, ImageArray.Length);

            for (int row = 1; row < Width - 1; row++) // We avoid the edges for a more simplistic look
            {
                for ( int col = 1; col < Height - 1; col++) // Same thing for the columns
                {
                    int sumRed = 0, sumGreen = 0, sumBlue = 0;
                    int count = 0;

                    // Here we consider the singular starting pixel and its 8 neighbours
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1 ; j <= 1; j++)
                        {
                            Color color = tempArray[row + i, col + j];
                            sumRed += color.R;
                            sumGreen += color.G;
                            sumBlue += color.B;
                            count++;
                        }
                    }

                    int avgRed = sumRed / count;
                    int avgGreen = sumGreen / count;
                    int avgBlue = sumBlue / count;

                    ImageArray[row, col] = Color.FromArgb(avgRed, avgGreen, avgBlue);
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null) return;

            int Width = 320;
            int Height = 240;

            for (int row = 0; row < Width; row++)
            {
                for (int col = 0; col < Height; col++)
                {
                    Color key = ImageArray[row, col];
                    int keyAvg = (key.R + key.G + key.B) / 3;
                    int j = col - 1;

                    while (j >= 0 && ((ImageArray[row, j].R + ImageArray[row, j].G + ImageArray[row, j].B) / 3) > keyAvg)
                    {
                        ImageArray[row, j + 1] = ImageArray[row, j];
                        j--;
                    }
                    ImageArray[row, j + 1] = key;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {

        }

        private void picImage_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
