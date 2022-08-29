using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowApplication
{
    public partial class ShadowForm : Form
    {
        private OvalShape m_osCurrent = null;
        private OvalShape m_osShadow = null;
        private OvalShape m_osDraw = null;
        private Rectangle m_rectDraw = new Rectangle();
        private Point m_ptDown;
        private CancellationTokenSource m_cancellationTokenSource;
        private Thread m_thread;
        private const int SHADOW_OFFSET = 3;

        public ShadowForm()
        {
            InitializeComponent();
        }

        private Rectangle NormalizeRectangle(Point pt1, Point pt2) => new Rectangle(Math.Min(pt1.X, pt2.X), Math.Min(pt1.Y, pt2.Y), Math.Abs(pt2.X - pt1.X), Math.Abs(pt2.Y - pt1.Y));

        private void ShadowForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_ptDown = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                m_rectDraw = new Rectangle(m_ptDown, Size.Empty);
            }
        }

        private void ShadowForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool update = false;
                if (!m_rectDraw.Size.IsEmpty)
                {
                    InvalidateRectangle(m_rectDraw);
                    update = true;
                }
                m_rectDraw = NormalizeRectangle(m_ptDown, e.Location);
                if (!m_rectDraw.Size.IsEmpty)
                {
                    InvalidateRectangle(m_rectDraw);
                    update = true;
                    m_osDraw = new OvalShape(m_rectDraw, Color.Black, false);
                }
                else
                    m_osDraw = null;

                if (update)
                    this.Update(); // Force a Paint event
            }
        }

        private void ShadowForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool update = false;
                m_osDraw = null;
                if (m_osCurrent != null)
                {
                    InvalidateRectangle(m_osCurrent.BoundingRectangle);
                    update = true;
                    m_osCurrent = null;
                }
                if (!m_rectDraw.Size.IsEmpty)
                {
                    InvalidateRectangle(m_rectDraw);
                    update = true;
                    m_osCurrent = new OvalShape(m_rectDraw, Color.Red, true);
                }

                if (update)
                    this.Update(); // Force a Paint event
            }
        }

        private void InvalidateRectangle(Rectangle rectangle)
        {
            rectangle.Width += 1; // Must enlarge the invalidate region by 1 in width and height
            rectangle.Height += 1;
            this.Invalidate(rectangle);
        }

        private void MoveShadow()
        {
            if (null == m_osCurrent)
                m_osShadow = null;
            else
            {
                if (null == m_osShadow)
                    m_osShadow = new OvalShape(m_osCurrent.BoundingRectangle, Color.DarkRed, m_osCurrent.Filled);
                Rectangle rectShadow = m_osShadow.BoundingRectangle;
                Rectangle rectNewShadow = rectShadow;
                Rectangle rectCurrent = m_osCurrent.BoundingRectangle;

                // Adjust the shadow size
                if (rectNewShadow.Width > rectCurrent.Width)
                    rectNewShadow.Width -= 1;
                else if (rectNewShadow.Width < rectCurrent.Width)
                    rectNewShadow.Width += 1;
                if (rectNewShadow.Height > rectCurrent.Height)
                    rectNewShadow.Height -= 1;
                else if (rectNewShadow.Height < rectCurrent.Height)
                    rectNewShadow.Height += 1;

                // Adjust the shadow location
                if (rectNewShadow.X + SHADOW_OFFSET > rectCurrent.X)
                    rectNewShadow.X -= 1;
                else if (rectNewShadow.X + SHADOW_OFFSET < rectCurrent.X)
                    rectNewShadow.X += 1;
                if (rectNewShadow.Y + SHADOW_OFFSET > rectCurrent.Y)
                    rectNewShadow.Y -= 1;
                else if (rectNewShadow.Y + SHADOW_OFFSET < rectCurrent.Y)
                    rectNewShadow.Y += 1;

                if (!rectShadow.Equals(rectNewShadow)) // If shadow has moved and/or resized
                {
                    m_osShadow = new OvalShape(rectNewShadow, Color.DarkRed, m_osShadow.Filled);
                    InvalidateRectangle(rectShadow); // Invalidate the old shadow location
                    InvalidateRectangle(rectNewShadow); // Invalidate the new shadow location
                    this.Update(); // Force a Paint event
                }
            }
        }

        private void ShadowForm_Paint(object sender, PaintEventArgs e)
        {
            if (m_osShadow != null)
                m_osShadow.Draw(e.Graphics);
            if (m_osCurrent != null)
                m_osCurrent.Draw(e.Graphics);
            if (m_osDraw != null)
                m_osDraw.Draw(e.Graphics);
        }

        private void ShadowForm_Load(object sender, EventArgs e)
        {
            m_thread = new Thread(threadInfo =>
            { // Thread code to move the shadow every 10 ms
                CancellationToken cancellationToken = (CancellationToken)threadInfo;
                cancellationToken.Register(myThread => ((Thread)myThread).Interrupt(), Thread.CurrentThread);
                while (!cancellationToken.IsCancellationRequested) // Exit loop when cancellation requested
                {
                    try
                    {
                        this.Invoke(new MethodInvoker(MoveShadow));
                        Thread.Sleep(10); // every 10 ms
                    }
                    catch(ThreadInterruptedException) // Occurs when Thread.Interrupt() is called
                    {
                        // Do nothing
                    }
                }
            });
            m_cancellationTokenSource = new CancellationTokenSource();
            m_thread.Start(m_cancellationTokenSource.Token); // Send the cancellation token to the thread
        }

        private void ShadowForm_FormClosing(object sender, FormClosingEventArgs e) => m_cancellationTokenSource.Cancel();
    }
}
