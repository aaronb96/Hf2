using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap buffer;
        Graphics bufferg;


        Thread t;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            t = new Thread(new ThreadStart(szal));
            t.Start();
        }

        void szal()
        {

            bufferg.Clear(Color.White);

            int h, w;

            lock (buffer)
            {
                h = buffer.Height;
                w = buffer.Width;
            }

            PrimKereso pr = new PrimKereso();
            



            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if ((y * w + x) % 8 == 1)
                        lock (buffer)
                            buffer.SetPixel(x, y, Color.Black);

            this.Invoke(new Action(() => { button1.Enabled = true; }));
        }
    }
}
