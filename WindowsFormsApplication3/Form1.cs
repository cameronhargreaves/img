using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.Timers;
using System.IO;

namespace WindowsFormsApplication3
{

    /// <summary>
    /// add the API stuff, aka sharing ( facebook, instagram all that)
    /// maybe possibly not add camera functionality
    /// </summary>

    // #nomorememes #savelives #metoo #savealexscode 

    public partial class Form1 : Form
    {
        Bitmap previousImage;
        Bitmap newImage;
        Bitmap greyBitmap;
        Bitmap originalImage;
        

        //LOTS OF VARIABLES
        // although there is a lot of variables that are global, these are accessed in many parts of the program - for instance the bitmap files. So need to be global for ease of access
        int totalRed = 0, totalGreen = 0, totalBlue = 0;
        int averageRed = 0, averageBlue = 0, averageGreen = 0;
        int numberOfPresses = 0;
        bool greyIntitalised = false; bool greyPressed = false; bool initialised = false;
        float redDivisible; float blueDivisible = 0; float greenDivisible = 0;


        //this is the form i dont know what you want me to say
        public Form1()
        {
            this.Activate();
            InitializeComponent();

            //puts the form to the specific size
            this.Width = 792;
            this.Height = 420;

            this.pictureBox1.AllowDrop = true;
        }


        //if file is a file, copy contents
        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            // if there is data in the dragged file, copy the contents
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            // if there is no data, do not copy anything
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //sets the data dragged on to the picturebox
        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extension = Path.GetExtension(file[0]);

            if ((extension != ".jpg") && (extension != ".png") && (extension != ".bmp") && (extension != ".jpeg"))
            {
                MessageBox.Show("You Need a valid Image File!");
                extension = "";
                return;
            }

            if (file.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(file[0]);
            }

            originalImage = new Bitmap(pictureBox1.Image);
            previousImage = new Bitmap(pictureBox1.Image);

        }


        // all the buttons are together, this pleases me
        // open file dialog
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            Thread startConversionThread = new Thread(StartConversion);
            startConversionThread.Start();

        }
        // save file dialog
        private void SaveFileButton_Click(object sender, EventArgs e)
        {

            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("There isn't an image to save!");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Image Files (*.png)|*.png|(*.bmp)|*.bmp|(*.jpg)|*.jpg|All Files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog1.FileName;
                pictureBox1.Image.Save(filepath, System.Drawing.Imaging.ImageFormat.Png);

            }
        }
        //resets all changes made to image
        private void ResetButton_Click(object sender, EventArgs e)
        {

            averageBlue = 0;
            averageGreen = 0;
            averageRed = 0;
            initialised = false;
            previousImage = null;
            newImage = null;
            originalImage = null;
            pictureBox1.Image = null;
            pictureBox2.BackColor = Form1.DefaultBackColor;
            pictureBox3.BackColor = Form1.DefaultBackColor;
            pictureBox4.BackColor = Form1.DefaultBackColor;
            pictureBox5.BackColor = Form1.DefaultBackColor;
            pictureBox7.BackColor = Form1.DefaultBackColor;

        }
        //resets EVERYTHIIIIIING
        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originalImage;
            averageBlue = 0;
            averageGreen = 0;
            averageRed = 0;
            previousImage = originalImage;
        }
        //this calls the pixelise thing (runThroughImage)
        private void pixelliseButton_Click(object sender, EventArgs e)
        {
            Thread RunThroughImageThread = new Thread(runThroughImage);
            RunThroughImageThread.Start();
        }
        //calls greyscale function
        private void GreyScaleButton_Click(object sender, EventArgs e)
        {
            GreyScale();
        }
        //calls the limit colours function
        private void LimitColoursButton_Click(object sender, EventArgs e)
        {
            RestrictColours();
        }
        //zoom function
        private void ZoomButton_Click(object sender, EventArgs e)
        {
            if ((numberOfPresses % 2 == 0) || (numberOfPresses == 0))
            {
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                pictureBox1.Size = Screen.PrimaryScreen.WorkingArea.Size;
                pictureBox1.BringToFront();
                ZoomButton.BringToFront();
            }
            else
            {
                this.Size = new Size(778, 412);
                pictureBox1.Size = new Size(500, 300);
            }
            numberOfPresses += 1;
        }
        //calls the function for the matrix changes the values of Red Green and Blue
        private void RGBEditButton_Click(object sender, EventArgs e)
        {
            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            this.Width = 1014;
            if (initialised == false)
            {
                RedTrackBar.Value = 100;
                GreenTrackBar.Value = 100;
                BlueTrackBar.Value = 100;
                initialised = true;
            }
        }
        //uses a matrix to invert the image
        private void InvertButton_Click(object sender, EventArgs e)
        {
            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            newImage = new Bitmap(previousImage.Width, previousImage.Height);
            Graphics g = Graphics.FromImage(newImage);
            ImageAttributes attributes = new ImageAttributes();
            ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
                new float[][]
            {


                new float[] {-1,0,0,0,0},
                new float[] {0,-1,0,0,0},
                new float[] {0,0,-1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {1,1,1,0,1},

            }
            );

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(previousImage, new Rectangle(0, 0, previousImage.Width, previousImage.Height), 0, 0, previousImage.Width, previousImage.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            pictureBox1.Image = newImage;
            previousImage = newImage;

        }
        //uses a matrix to sepia-fy the image
        private void SepiaButton_Click(object sender, EventArgs e)
        {
            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            newImage = new Bitmap(previousImage.Width, previousImage.Height);
            Graphics g = Graphics.FromImage(newImage);
            ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
                new float[][]
            {


                new float[] {0.393f,0.349f,0.272f,0,0},
                new float[] {0.769f,0.686f,0.534f,0,0},
                new float[] {0.189f,0.168f,0.131f,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1},
            }
            );

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(previousImage, new Rectangle(0, 0, previousImage.Width, previousImage.Height), 0, 0, previousImage.Width, previousImage.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            pictureBox1.Image = newImage;
            previousImage = newImage;
        }
        // ok button after RGB edit / greyscale is selected, closes popout menu
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (greyPressed == true)
            {
                previousImage = greyBitmap;
                this.Width = 792;
                greyPressed = false;
                greyIntitalised = false;
            }
            else
            {
                previousImage = newImage;
                this.Width = 792;
                initialised = false;
            }
        }


        //start the program, runs RunThroughImage
        private void StartConversion()
        {
            string text;

            this.Invoke((MethodInvoker)delegate()
            {
                text = comboBox1.Text;
                openFileDialog1.Filter = "Image Files |*.jpg;*.png;*.bmp;*.jpeg|All files (*.*)|*.*";
                openFileDialog1.InitialDirectory = @"C:\My Pictures";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);

                    string fullPath = openFileDialog1.FileName;
                    string fileName = openFileDialog1.SafeFileName;
                    string path = fullPath.Replace(fileName, "");
                    sr.Close();
                    string extension = Path.GetExtension(fullPath);
                    if ((extension != ".jpg") && (extension != ".png") && (extension != ".bmp") && (extension != ".jpeg"))
                    {
                        MessageBox.Show("You Need a valid Image File!");
                        return;
                    }
                    pictureBox1.Image = Image.FromFile(fullPath);
                    originalImage = new Bitmap(fullPath);
                    previousImage = new Bitmap(pictureBox1.Image);

                };
            });
        }

        //pixelises, calls FindAverage
        private void runThroughImage()
        {


            string text;
            this.Invoke((MethodInvoker)delegate()
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("You have to input a pixel size first!");
                    return;
                }
                this.Invoke((MethodInvoker)delegate()
                {
                    text = comboBox1.Text;

                    if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
                    {
                        MessageBox.Show("You have to select an image first!");
                        return;
                    }


                    newImage = new Bitmap(previousImage.Width, previousImage.Height);
                    pictureBox1.Image = newImage;
                    int squaresOrNah;
                    if (checkBox1.Checked)
                    {
                        squaresOrNah = 1;
                    }
                    else squaresOrNah = 0;
                    Color average;
                    double pixelSizeDouble = Convert.ToDouble(comboBox1.Text);
                    pixelSizeDouble = Math.Round(pixelSizeDouble);
                    int pixelSize = Convert.ToInt32(comboBox1.Text);
                    if ((pixelSize > originalImage.Height) || (pixelSize > originalImage.Width))
                    {
                        MessageBox.Show("Thats too big a pixel size!");
                        return;
                    }
                    if (pixelSize == 0)
                    {
                        MessageBox.Show("Now, you dont wanna be going dividing something by 0 now do you?");
                        return;
                    }
                    if ((pixelSize == 1) && (squaresOrNah == 1))
                    {
                        MessageBox.Show("Ugh. 1-1, (quick maths), If you have 1 and minus one what would you be left with. 0. Thats just dumb.");
                        return;
                    }
                    int bufferSizeWidth = previousImage.Width % pixelSize;
                    int bufferSizeHeight = newImage.Height % pixelSize;

                    for (int x = 0; x < newImage.Width - bufferSizeWidth; x += pixelSize)
                    {
                        for (int y = 0; y < newImage.Height - bufferSizeHeight; y += pixelSize)
                        {
                            average = FindPixelAverage(pixelSize, x, y, previousImage);
                            for (int i = 0; i < pixelSize - squaresOrNah; i++)
                            {
                                for (int j = 0; j < pixelSize - squaresOrNah; j++)
                                {
                                    newImage.SetPixel(x + i, y + j, average);
                                }
                            }
                        }
                    }

                    //pictureBox1.Hide();
                    pictureBox1.Image = newImage;
                    previousImage = newImage;
                    //Thread RestrictColoursThread = new Thread(RestrictColours);
                    //if (IsPainted == false)
                    //{
                    //    GreyScale();
                    //    RestrictColours();

                    //}
                });
                return;

            });
        }
        public Color FindPixelAverage(int pixelSize, int x, int y, Bitmap bitmapImage)
        {
            Color pixelColour;
            //int amountOfColours = 0;
            //Color[] Colours;
            //
            //for (int c = 0; c < 255; c=+ amountOfColours)
            //{
            //    for (int d = 0; d <= amountOfColours; d++)
            //    {
            //        Colours[d];
            //    }
            //}

            int pixelTotalRed = 0; int pixelTotalGreen = 0; int pixelTotalBlue = 0;
            averageRed = 0; averageGreen = 0; averageBlue = 0;

            for (int a = 0; a < pixelSize; a++)
            {
                for (int b = 0; b < pixelSize; b++)
                {
                    pixelColour = previousImage.GetPixel(a + x, b + y);
                    //MessageBox.Show(pixelColour.R.ToString() + " " + pixelColour.G.ToString() + " " + pixelColour.B.ToString());
                    totalRed = totalRed + pixelColour.R;
                    pixelTotalRed = pixelTotalRed + pixelColour.R;
                    totalGreen = totalGreen + pixelColour.G;
                    pixelTotalGreen = pixelTotalGreen + pixelColour.G;
                    totalBlue = totalBlue + pixelColour.B;
                    pixelTotalBlue = pixelTotalBlue + pixelColour.B;
                    if ((a == pixelSize - 1) && (b == pixelSize - 1))
                    {
                        averageRed = pixelTotalRed / (pixelSize * pixelSize);
                        averageGreen = pixelTotalGreen / (pixelSize * pixelSize);
                        averageBlue = pixelTotalBlue / (pixelSize * pixelSize);
                        //MessageBox.Show(averageRed + " " + averageGreen + " " + averageBlue);
                    }
                }
            }

            return Color.FromArgb(averageRed, averageGreen, averageBlue);
        }

        //restricting colours stuff
        private void RestrictColours()
        {
            //Stopwatch test = new Stopwatch();
            //test.Start();
            //int amountOfColours = Convert.ToInt32(comboBox2.Text) + 1;
            int pixelRed = 0; int pixelGreen = 0; int pixelBlue = 0;
            averageRed = 0; averageGreen = 0; averageBlue = 0;
            totalRed = 0; totalGreen = 0; totalBlue = 0;
            int differenceToLower, DifferenceToHigher, differenceToMiddle;
            int lowerValue, higherValue, middleValue;

            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            newImage = new Bitmap(previousImage.Width, previousImage.Height);

            BitmapData data = previousImage.LockBits(new Rectangle(0, 0, previousImage.Width, previousImage.Height), ImageLockMode.ReadWrite, previousImage.PixelFormat);

            IntPtr pointer = data.Scan0;

            int bytes = Math.Abs(data.Stride) * previousImage.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(pointer, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i += 4)
            {
                totalRed = totalRed + rgbValues[i + 2];
                totalGreen = totalGreen + rgbValues[i + 1];
                totalBlue = totalBlue + rgbValues[i];
            }


            averageRed = totalRed / (previousImage.Width * previousImage.Height);
            averageGreen = totalGreen / (previousImage.Width * previousImage.Height);
            averageBlue = totalBlue / (previousImage.Width * previousImage.Height);

            for (int c = 0; c < previousImage.Width; c++)
            {
                for (int d = 0; d < previousImage.Height; d++)
                {
                    pixelRed = rgbValues[((((c) + (d * previousImage.Width)) * 4) + 2)];
                    pixelGreen = rgbValues[((((c) + (d * previousImage.Width)) * 4) + 1)];
                    pixelBlue = rgbValues[((((c) + (d * previousImage.Width)) * 4))];

                    // find pixel, x 4, + 2 + 1 etc to find pixel values
                    // kill this

                    //red
                    if (pixelRed < averageRed)
                    {

                        higherValue = averageRed;
                        lowerValue = 0;
                        middleValue = ((higherValue + lowerValue) / 2);
                        differenceToLower = pixelRed - 0;
                        differenceToMiddle = pixelRed - middleValue;
                        DifferenceToHigher = (averageRed - pixelRed);
                        if (differenceToLower < differenceToMiddle)
                        {
                            pixelRed = lowerValue;
                        }
                        else if (differenceToLower > differenceToMiddle)
                        {

                            if (DifferenceToHigher < differenceToMiddle)
                            {
                                pixelRed = averageRed;
                            }
                            else
                            {
                                pixelRed = middleValue;
                            }

                        }
                    }

                    else if (pixelRed > averageRed)
                    {
                        higherValue = 255;
                        lowerValue = averageRed;
                        middleValue = ((higherValue + lowerValue) / 2);
                        differenceToLower = pixelRed - lowerValue;
                        differenceToMiddle = pixelRed - middleValue;
                        DifferenceToHigher = 255 - pixelRed;
                        if (differenceToLower < differenceToMiddle)
                        {
                            pixelRed = averageRed;
                        }
                        else if (differenceToLower > differenceToMiddle)
                        {
                            if (DifferenceToHigher < differenceToMiddle)
                            {
                                pixelRed = higherValue;
                            }
                            else
                            {
                                pixelRed = middleValue;
                            }
                        }
                    }

                    //green
                    if (pixelGreen < averageGreen)
                    {

                        higherValue = averageGreen;
                        lowerValue = 0;
                        middleValue = ((higherValue + lowerValue) / 2);
                        differenceToLower = pixelGreen - 0;
                        differenceToMiddle = pixelGreen - middleValue;
                        DifferenceToHigher = (averageGreen - pixelGreen);
                        if (differenceToLower < differenceToMiddle)
                        {
                            pixelGreen = 0;
                        }
                        else if (differenceToLower > differenceToMiddle)
                        {

                            if (DifferenceToHigher < differenceToMiddle)
                            {
                                pixelGreen = averageGreen;
                            }
                            else
                            {
                                pixelGreen = middleValue;
                            }

                        }
                    }

                    else if (pixelGreen > averageGreen)
                    {
                        higherValue = 255;
                        lowerValue = averageGreen;
                        middleValue = ((higherValue + lowerValue) / 2);
                        differenceToLower = pixelGreen - lowerValue;
                        differenceToMiddle = pixelGreen - middleValue;
                        DifferenceToHigher = 255 - pixelGreen;
                        if (differenceToLower < differenceToMiddle)
                        {
                            pixelGreen = averageGreen;
                        }
                        else if (differenceToLower > differenceToMiddle)
                        {
                            if (DifferenceToHigher < differenceToMiddle)
                            {
                                pixelGreen = higherValue;
                            }
                            else
                            {
                                pixelGreen = middleValue;
                            }
                        }
                    }

                    //blue
                    if (pixelBlue < averageBlue)
                    {

                        higherValue = averageBlue;
                        lowerValue = 0;
                        middleValue = ((higherValue + lowerValue) / 2);
                        differenceToLower = pixelBlue - 0;
                        differenceToMiddle = pixelBlue - middleValue;
                        DifferenceToHigher = (averageBlue - pixelBlue);
                        if (differenceToLower < differenceToMiddle)
                        {
                            pixelBlue = 0;
                        }
                        else if (differenceToLower > differenceToMiddle)
                        {

                            if (DifferenceToHigher < differenceToMiddle)
                            {
                                pixelBlue = averageBlue;
                            }
                            else
                            {
                                pixelBlue = middleValue;
                            }

                        }
                    }

                    else if (pixelBlue > averageBlue)
                    {
                        higherValue = 255;
                        lowerValue = averageBlue;
                        middleValue = ((higherValue + lowerValue) / 2);
                        differenceToLower = pixelBlue - lowerValue;
                        differenceToMiddle = pixelBlue - middleValue;
                        DifferenceToHigher = 255 - pixelBlue;
                        if (differenceToLower < differenceToMiddle)
                        {
                            pixelBlue = averageBlue;
                        }
                        else if (differenceToLower > differenceToMiddle)
                        {
                            if (DifferenceToHigher < differenceToMiddle)
                            {
                                pixelBlue = higherValue;
                            }
                            else
                            {
                                pixelBlue = middleValue;
                            }
                        }
                    }

                    rgbValues[((((c) + (d * previousImage.Width)) * 4) + 2)] = (byte)pixelRed;
                    rgbValues[((((c) + (d * previousImage.Width)) * 4) + 1)] = (byte)pixelGreen;
                    rgbValues[((((c) + (d * previousImage.Width)) * 4))] = (byte)pixelBlue;

                }
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pointer, bytes);
            previousImage.UnlockBits(data);
            //Graphics g = Graphics.FromImage(previousImage);
            //g.DrawImage(previousImage, 0, 150);
            //test.Stop();
            //MessageBox.Show("time : " + test.Elapsed);
            pictureBox1.Image = previousImage;
            //previousImage = newImage;
        }

        //greyscale matrix
        private void GreyScale()
        {
            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            if (greyIntitalised == false)
            {
                RedTrackBar.Value = 30;
                GreenTrackBar.Value = 59;
                BlueTrackBar.Value = 11;
                greyIntitalised = true;
            }
            greyPressed = true;
            this.Width = 1014;

            redDivisible = RedTrackBar.Value;
            redDivisible /= 100;
            greenDivisible = GreenTrackBar.Value;
            greenDivisible /= 100;
            blueDivisible = BlueTrackBar.Value;
            blueDivisible /= 100;

            greyBitmap = new Bitmap(previousImage.Width, previousImage.Height);
            Graphics g = Graphics.FromImage(greyBitmap);
            ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
                new float[][]
            {
                new float[] {redDivisible,redDivisible,redDivisible,0,0},
                new float[] {greenDivisible,greenDivisible,greenDivisible,0,0},
                new float[] {blueDivisible,blueDivisible,blueDivisible,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1},
            }
            );

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(previousImage, new Rectangle(0, 0, previousImage.Width, previousImage.Height), 0, 0, previousImage.Width, previousImage.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            pictureBox1.Image = greyBitmap;
        }

        //the zoom function
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((numberOfPresses % 2 == 0) || (numberOfPresses == 0))
            {
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                pictureBox1.Size = Screen.PrimaryScreen.WorkingArea.Size;
                pictureBox1.BringToFront();
                ZoomButton.BringToFront();
            }
            else
            {
                this.Size = new Size(778, 412);
                pictureBox1.Size = new Size(500, 300);
            }
            numberOfPresses += 1;
        }

        // all trackbars together, this is nice
        private void RedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (greyPressed == true)
            {
                GreyScale();
            }
            else
            {
                ChangeRGB();
            }

        }
        private void GreenTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (greyPressed == true)
            {
                GreyScale();
            }
            else
            {
                ChangeRGB();
            }
        }
        private void BlueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (greyPressed == true)
            {
                GreyScale();
            }
            else
            {
                ChangeRGB();
            }
        }

        //uses a matrix to change the value of R G and B
        private void ChangeRGB()
        {

            redDivisible = RedTrackBar.Value;
            redDivisible /= 100;
            greenDivisible = GreenTrackBar.Value;
            greenDivisible /= 100;
            blueDivisible = BlueTrackBar.Value;
            blueDivisible /= 100;

            newImage = new Bitmap(previousImage.Width, previousImage.Height);
            Graphics g = Graphics.FromImage(newImage);
            ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
                new float[][]
            {
                new float[] {redDivisible,0,0,0,0},
                new float[] {0,greenDivisible,0,0,0},
                new float[] {0,0,blueDivisible,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1},

            }
            );

            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(colorMatrix);

            g.DrawImage(previousImage, new Rectangle(0, 0, previousImage.Width, previousImage.Height), 0, 0, previousImage.Width, previousImage.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            pictureBox1.Image = newImage;
        }

        private void COLOURSSSSSS()
        {
            int count = 0;
            HashSet<Color> colors = new HashSet<Color>();

            for (int y = 0; y < previousImage.Height; y++)
            {
                for (int x = 0; x < previousImage.Width; x++)
                {
                    colors.Add(previousImage.GetPixel(x, y));
                }
            }
            count = colors.Count;
            MessageBox.Show(Convert.ToString(count));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            int count = 0;


            using (Bitmap newImage = new Bitmap(previousImage))
            {
                var topColours = GetPixels(newImage)
                                        .GroupBy(color => color)
                                        .OrderByDescending(grp => grp.Count())
                                        .Select(grp => grp.Key)
                                        .Take(5);


                foreach (var color in topColours)
                {
                    count += 1;
                    if (count == 1)
                    {
                        pictureBox2.BackColor = (color);
                    }
                    if (count == 2)
                    {
                        pictureBox3.BackColor = (color);
                    }
                    if (count == 3)
                    {
                        pictureBox4.BackColor = (color);
                    }
                    if (count == 4)
                    {
                        pictureBox5.BackColor = (color);
                    }
                    if (count == 5)
                    {
                        pictureBox7.BackColor = (color);
                    }

                }
            }
            MessageBox.Show(Convert.ToString(count));
        }
        public static IEnumerable<Color> GetPixels(Bitmap previousImage)
        {
            for (int y = 0; y < previousImage.Height; y++)
            {
                for (int x = 0; x < previousImage.Width; x++)
                {
                    Color pixel = previousImage.GetPixel(x, y);
                    yield return pixel;
                }
            }
        }

        private void ColoursButton_Click(object sender, EventArgs e)
        {

            if ((pictureBox1.Image == null) && (pictureBox1.ImageLocation == null))
            {
                MessageBox.Show("You have to select an image first!");
                return;
            }

            COLOURSSSSSS();
        }

    }
}