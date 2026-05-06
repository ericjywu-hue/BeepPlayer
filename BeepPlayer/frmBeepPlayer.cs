using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BeepPlayer
{
    public partial class frmBeepPlayer : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        private readonly int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };
        private readonly string[] noteNames = { "Do", "Re", "Mi", "Fa", "Sol", "La", "Si", "Do'" };
        private readonly Color[] noteColors =
        {
            Color.FromArgb(255,  99,  99),
            Color.FromArgb(255, 165,  50),
            Color.FromArgb(240, 210,  50),
            Color.FromArgb(100, 200, 100),
            Color.FromArgb( 80, 160, 240),
            Color.FromArgb(100, 100, 240),
            Color.FromArgb(160,  80, 220),
            Color.FromArgb(255,  80, 120),
        };

        private System.Windows.Forms.Timer visualTimer;
        private int visualPhase = 0;
        private int activeNoteIndex = -1;

        private int initPanelWidth, initPanelHeight;
        private Dictionary<string, Rectangle> initControlRect = new Dictionary<string, Rectangle>();

        public frmBeepPlayer()
        {
            InitializeComponent();
            SetupVisualTimer();

            btn2.Click += btn1_Click;
            btn3.Click += btn1_Click;
            btn4.Click += btn1_Click;
            btn5.Click += btn1_Click;
            btn6.Click += btn1_Click;
            btn7.Click += btn1_Click;
            btn8.Click += btn1_Click;

            this.Load += frmBeepPlayer_Load;
            this.SizeChanged += frmBeepPlayer_SizeChanged;
            this.KeyPreview = true;
            this.KeyDown += frmBeepPlayer_KeyDown;
        }

        private void SetupVisualTimer()
        {
            visualTimer = new System.Windows.Forms.Timer();
            visualTimer.Interval = 40;
            visualTimer.Tick += (s, e) => { visualPhase++; pnlVisualizer.Invalidate(); };
            visualTimer.Start();
        }

        private void frmBeepPlayer_Load(object sender, EventArgs e)
        {
            initPanelWidth = palMain.Width;
            initPanelHeight = palMain.Height;
            foreach (Control c in palMain.Controls)
                initControlRect[c.Name] = new Rectangle(c.Left, c.Top, c.Width, c.Height);

            lblStatus.Text = "按下琴鍵或鍵盤 [A S D F G H J K] 演奏";
        }

        private void frmBeepPlayer_SizeChanged(object sender, EventArgs e)
        {
            if (initPanelWidth == 0) return;
            double rW = (double)palMain.Width / initPanelWidth;
            double rH = (double)palMain.Height / initPanelHeight;
            foreach (Control c in palMain.Controls)
            {
                if (!initControlRect.ContainsKey(c.Name)) continue;
                var r = initControlRect[c.Name];
                c.Left = (int)(r.Left * rW);
                c.Top = (int)(r.Top * rH);
                c.Width = (int)(r.Width * rW);
                c.Height = (int)(r.Height * rH);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int idx = btn.TabIndex;
            activeNoteIndex = idx;

            btn.Enabled = false;
            Beep(freq[idx], 300);
            btn.Enabled = true;

            lblStatus.Text = $"播放音符：{noteNames[idx]}  ({freq[idx]} Hz)";

            var t = new System.Windows.Forms.Timer { Interval = 400 };
            t.Tick += (s2, e2) =>
            {
                activeNoteIndex = -1;
                lblStatus.Text = "按下琴鍵或鍵盤 [A S D F G H J K] 演奏";
                ((System.Windows.Forms.Timer)s2).Stop();
            };
            t.Start();
        }

        private void frmBeepPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            string keys = "ASDFGHJK";
            int idx = keys.IndexOf((char)e.KeyCode);
            if (idx < 0) return;
            e.Handled = true;
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };
            btns[idx].PerformClick();
        }

        private void pnlVisualizer_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var rc = pnlVisualizer.ClientRectangle;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var bg = new LinearGradientBrush(rc,
                Color.FromArgb(18, 18, 30), Color.FromArgb(30, 18, 50),
                LinearGradientMode.Vertical))
                g.FillRectangle(bg, rc);

            int bars = 32;
            int barW = rc.Width / bars - 2;
            float time = visualPhase * 0.08f;

            for (int i = 0; i < bars; i++)
            {
                float phase = (float)i / bars;
                float amp = activeNoteIndex >= 0
                    ? (float)(0.4 + 0.6 * Math.Abs(Math.Sin(time + phase * Math.PI * 3)))
                    : (float)(0.05 + 0.05 * Math.Abs(Math.Sin(time * 0.3f + phase * Math.PI)));

                Color barColor = activeNoteIndex >= 0
                    ? InterpolateColor(Color.FromArgb(60, 60, 80), noteColors[activeNoteIndex], amp)
                    : Color.FromArgb(40, 60, 90);

                int h = (int)(amp * (rc.Height - 8));
                int x = i * (barW + 2) + 2;
                int y = rc.Height / 2 - h / 2;

                using (var brush = new LinearGradientBrush(
                    new Rectangle(x, y, barW, Math.Max(h, 1)),
                    Color.FromArgb(200, barColor),
                    Color.FromArgb(60, barColor),
                    LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, x, y, barW, h);
                }
            }
        }

        private static Color InterpolateColor(Color a, Color b, float t)
        {
            t = Math.Max(0f, Math.Min(1f, t));
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * t),
                (int)(a.G + (b.G - a.G) * t),
                (int)(a.B + (b.B - a.B) * t));
        }
    }
}