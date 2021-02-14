using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public static bool NeedToNotifyChanges = true;

        public struct CMYK
        {
            public double c, m, y, k;

            public CMYK(double c, double m, double y, double k)
            {
                this.c = c;
                this.m = m;
                this.y = y;
                this.k = k;
            }
        }

        public struct XYZ
        {
            public double x, y, z;

            public XYZ(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        public struct HSL
        {
            public int h, s, l;

            public HSL(int h, int s, int l)
            {
                this.h = h;
                this.s = s;
                this.l = l;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            this.BackColor = ColorPicker.Color;

            NeedToNotifyChanges = false;

            CMYK newCmyk = From_RGB_TO_CMYK(ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B);

            SetCMYKParametrs(newCmyk);

            XYZ newXyz = From_RGB_TO_XYZ(ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B);

            SetXYZParametrs(newXyz);

            HSL newHsl = RGB_TO_HSL(ColorPicker.Color.R, ColorPicker.Color.G, ColorPicker.Color.B);

            SetHSLParametrs(newHsl);

            NeedToNotifyChanges = true;
        }

        private void SetCMYKParametrs(CMYK color)
        {
            C_Input.Value = Math.Max(0, Math.Min(C_Input.Maximum, (decimal)color.c * 100));
            M_Input.Value = Math.Max(0, Math.Min(M_Input.Maximum, (decimal)color.m * 100));
            Y_Input.Value = Math.Max(0, Math.Min(Y_Input.Maximum, (decimal)color.y * 100));
            K_Input.Value = Math.Max(0, Math.Min(K_Input.Maximum, (decimal)color.k * 100));
        }

        private void SetXYZParametrs(XYZ color)
        {
            X_input.Value = Math.Max(0, Math.Min(X_input.Maximum, (decimal)color.x));
            YY_input.Value = Math.Max(0, Math.Min(YY_input.Maximum, (decimal)color.y));
            Z_Input.Value = Math.Max(0, Math.Min(Z_Input.Maximum, (decimal)color.z));
        }

        private void SetHSLParametrs(HSL color)
        {
            H_Input.Value = Math.Max(0, Math.Min(H_Input.Maximum, (decimal)color.h));
            S_Input.Value = Math.Max(0, Math.Min(S_Input.Maximum, (decimal)color.s));
            L_Input.Value = Math.Max(0, Math.Min(L_Input.Maximum, (decimal)color.l));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CMYK_Input_ValueChanged(object sender, EventArgs e)
        {
            if (NeedToNotifyChanges)
            {
                NeedToNotifyChanges = false;

                var color = From_CMYK((1.0f * (int)C_Input.Value) / 100,
                    (1.0f * (int)M_Input.Value) / 100,
                    (1.0f * (int)Y_Input.Value) / 100,
                    (1.0f * (int)K_Input.Value) / 100);

                this.BackColor = color;

                SetXYZParametrs(From_RGB_TO_XYZ(color.R, color.G, color.B));
                SetHSLParametrs(RGB_TO_HSL(color.R, color.G, color.B));

                NeedToNotifyChanges = true;
            }
            else
            {
                return;
            }

        }

        private void XYZ_Input_ValueChanged(object sender, EventArgs e)
        {
            if (NeedToNotifyChanges)
            {
                NeedToNotifyChanges = false;

                var color = From_XYZ_TO_RGB(new XYZ((1.0f * (int)X_input.Value),
                    (1.0f * (int)YY_input.Value),
                    (1.0f * (int)Z_Input.Value)));

                this.BackColor = color;

                SetCMYKParametrs(From_RGB_TO_CMYK(color.R, color.G, color.B));
                SetHSLParametrs(RGB_TO_HSL(color.R, color.G, color.B));

                NeedToNotifyChanges = true;
            }
            else
            {
                return;
            }
        }

        private void HSL_Input_ValueChanged(object sender, EventArgs e)
        {
            if (NeedToNotifyChanges)
            {
                NeedToNotifyChanges = false;

                var color = FROM_HSL_TO_RGB(new HSL(((int)H_Input.Value),
                    ((int)S_Input.Value),
                    ((int)L_Input.Value)));

                this.BackColor = color;

                SetCMYKParametrs(From_RGB_TO_CMYK(color.R, color.G, color.B));
                SetXYZParametrs(From_RGB_TO_XYZ(color.R, color.G, color.B));

                NeedToNotifyChanges = true;
            }
            else
            {
                return;
            }
        }

        private Color From_CMYK(double c, double m, double y, double k)
        {
            int r = Math.Min(255, Math.Max(0, (int)(255 * (1 - c) * (1 - k))));
            int g = Math.Min(255, Math.Max(0, (int)(255 * (1 - m) * (1 - k))));
            int b = Math.Min(255, Math.Max(0, (int)(255 * (1 - y) * (1 - k))));


            return Color.FromArgb(r, g, b);
        }

        private CMYK From_RGB_TO_CMYK(int r, int g, int b)
        {
            double k = Math.Min(1 - 1.0f * r / 255, Math.Min(1 - 1.0f * g / 255, 1 - 1.0f * b / 255));

            if (k == 1)
            {
                return new CMYK(0, 0, 0, 1);
            }

            double c = Math.Max(0, (1 - (1.0f * r / 255) - k) / (1 - k));

            double m = Math.Max(0, (1 - (1.0f * g / 255) - k) / (1 - k));

            double y = Math.Max(0, (1 - (1.0f * b / 255) - k) / (1 - k));

            return new CMYK(c, m, y, k);
        }

        private XYZ From_RGB_TO_XYZ(int r, int g, int b)
        {
            double Func(double x)
            {
                if (x >= 0.04045)
                {
                    return (double)Math.Pow((x + 0.055) / 1.055, 2.4);
                }

                return x / 12.92f;
            }

            double Rn = Func(1.0f * r / 255) * 100;

            double Gn = Func(1.0f * g / 255) * 100;

            double Bn = Func(1.0f * b / 255) * 100;

            double X = 0.412453f * Rn + 0.357580f * Gn + 0.180423f * Bn;

            double Y = 0.212671f * Rn + 0.715160f * Gn + 0.072169f * Bn;

            double Z = 0.019334f * Rn + 0.119193f * Gn + 0.950227f * Bn;

            return new XYZ(X, Y, Z);
        }

        private Color From_XYZ_TO_RGB(XYZ xyz)
        {
            //xyz.x /= 100;
            //xyz.y /= 100;
            //xyz.z /= 100;

            double Func(double x)
            {
                if (x >= 0.0031308)
                {
                    return Math.Pow(x, 1 / 2.4) * 1.055f - 0.055f;
                }

                return x * 12.92f;
            }

            double Rn = 3.2406f * xyz.x / 100.0f + -1.5372f * xyz.y / 100.0f + -0.4986f * xyz.z / 100.0f;

            double Gn = -0.9689f * xyz.x / 100.0f + 1.8758f * xyz.y / 100.0f + 0.0415f * xyz.z / 100.0f;

            double Bn = 0.0557f * xyz.x / 100.0f + -0.2040f * xyz.y / 100.0f + 1.0570f * xyz.z / 100.0f;


            int R = (int)Math.Max(0, (Func(Rn) * 255));

            int G = (int)Math.Max(0, (Func(Gn) * 255));

            int B = (int)Math.Max(0, (Func(Bn) * 255));

            R = Math.Min(255, R);

            G = Math.Min(255, G);

            B = Math.Min(255, B);

            try
            {
                return Color.FromArgb(R, G, B);
            }
            catch
            {
                return Color.White;
            }

        }

        private HSL RGB_TO_HSL(int r, int g, int b)
        {
            double rS = 1.0 * r / 255;
            double gS = 1.0 * g / 255;
            double bS = 1.0 * b / 255;

            double cMax = Math.Max(rS, Math.Max(gS, bS));
            double cMin = Math.Min(rS, Math.Min(gS, bS));

            double delta = cMax - cMin;

            int H = 0;

            if (delta == 0)
            {
                H = 0;
            }
            else if (cMax == rS && gS>bS)
            {
                H = (int)(60 * (((gS - bS) / delta) % 6));
            }
            else if (cMax == rS)
            {
                H = (int)(60 * (((gS - bS) / delta) + 6));
            }

            else if (cMax == gS)
            {
                H = (int)(60 * (((bS - rS) / delta) + 2));
            }

            else
            {
                H = (int)(60 * (((rS - gS) / delta) + 4));
            }

            int L = (int)(100 * (cMax + cMin) / 2);

            int S = (int)(100 * delta / (1 - Math.Abs(2.0 * L / 100.0 - 1)));

            return new HSL(H, S, L);

        }

        private Color FROM_HSL_TO_RGB(HSL color)
        {
            double s = 1.0 * color.s / 100;

            double l = 1.0 * color.l / 100;

            double C = (1 - Math.Abs(2 * l - 1)) * s;

            double X = C * (1 - Math.Abs((1.0 * color.h / 60) % 2 - 1));

            double m = l - C / 2;

            double rS = 0, gS = 0, bS = 0;

            if (0 <= color.h && color.h < 60)
            {
                rS = C;
                gS = X;
                bS = 0;
            }
            else if (60 <= color.h && color.h < 120)
            {
                rS = X;
                gS = C;
                bS = 0;
            }
            else if (120 <= color.h && color.h < 180)
            {
                rS = 0;
                gS = C;
                bS = X;
            }
            else if (180 <= color.h && color.h < 240)
            {
                rS = 0;
                gS = X;
                bS = C;
            }
            else if (240 <= color.h && color.h < 300)
            {
                rS = X;
                gS = 0;
                bS = C;
            }
            else if (300 <= color.h && color.h <= 360)
            {
                rS = C;
                gS = 0;
                bS = X;
            }

            int R = Math.Min(255, Math.Max(0, (int)((rS + m) * 255)));
            int G = Math.Min(255, Math.Max(0, (int)((gS + m) * 255)));
            int B = Math.Min(255, Math.Max(0, (int)((bS + m) * 255)));

            return Color.FromArgb(R, G, B);
        }
    }
}