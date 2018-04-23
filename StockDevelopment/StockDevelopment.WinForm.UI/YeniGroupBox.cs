﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StockDevelopment.WinForm.UI
{ 
    class YeniGroupBox : System.Windows.Forms.GroupBox
    {
        private System.Drawing.Color borderColor;
        public YeniGroupBox()
        {
            this.borderColor = Color.Red;
        }

        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);
            Rectangle borderRect = e.ClipRectangle;
            borderRect.Y = (borderRect.Y + (tSize.Height / 2));
            borderRect.Height = (borderRect.Height - (tSize.Height / 2));
            ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);
            Rectangle textRect = e.ClipRectangle;
            textRect.X = (textRect.X + 6);
            textRect.Width = tSize.Width;
            textRect.Height = tSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        }
    }
}