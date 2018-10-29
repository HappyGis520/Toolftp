using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace EllaMaker.FTP.Component
{
    public class Rule : FrameworkElement
    {
        public Rule() { }

        public double ZeroOffset
        {
            get { return (double)GetValue(ZeroOffsetProperty); }
            set
            {
                SetValue(ZeroOffsetProperty, value);
                InvalidateVisual();
            }
        }
        public static readonly DependencyProperty ZeroOffsetProperty =
            DependencyProperty.Register(
            "ZeroOffset",
            typeof(double),
            typeof(Rule),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));
        public double Zoom
        {
            get { return (double)GetValue(ZoomProperty); }
            set
            {
                SetValue(ZoomProperty, value);
                InvalidateVisual();
            }
        }
        public static readonly DependencyProperty ZoomProperty =
            DependencyProperty.Register(
            "Zoom",
            typeof(double),
            typeof(Rule),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));


        public int Interval
        {
            get { return (int)GetValue(IntervalProperty); }
            set { SetValue(IntervalProperty, value); }
        }
        public static readonly DependencyProperty IntervalProperty =
             DependencyProperty.Register("Interval", typeof(int), typeof(Rule),
                  new FrameworkPropertyMetadata(1,
                        FrameworkPropertyMetadataOptions.AffectsRender));


        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            //画横向线
            drawingContext.DrawLine(new Pen(Brushes.Black, 1), new Point(0, ActualHeight), new Point(ActualWidth, ActualHeight));
            double rateInterval = Zoom * Interval;

            //起始坐标
            int startNumber = Convert.ToInt32(ZeroOffset * -1f / rateInterval);
            if (ZeroOffset % rateInterval != 0)
                startNumber--;

            //终止坐标
            int endNumber = Convert.ToInt32((ActualWidth - ZeroOffset) / rateInterval);
            if ((ActualWidth - ZeroOffset) % rateInterval != 0)
                endNumber--;

            //计算最小刻度显示数字
            double minInterval = 100 * Convert.ToInt32(1f / rateInterval);
            //画线
            for (double i = startNumber; i <= endNumber; i = i + 1)
            {
                if (rateInterval <= 0.8)
                {
                    if (i == 0 || i % minInterval == 0)
                    {
                        DrawWord((int)i, rateInterval, drawingContext);
                        DrawLine((int)i, rateInterval, 0.6, drawingContext);
                        DrawLine((int)i + Convert.ToInt32((100 * Convert.ToInt32(1f / rateInterval)) * 0.2), rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + Convert.ToInt32((100 * Convert.ToInt32(1f / rateInterval)) * 0.4), rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + Convert.ToInt32((100 * Convert.ToInt32(1f / rateInterval)) * 0.6), rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + Convert.ToInt32((100 * Convert.ToInt32(1f / rateInterval)) * 0.8), rateInterval, 1 / 4f, drawingContext);
                    }
                }
                else if (rateInterval <= 4)
                {
                    if (i % 50 == 0)
                    {
                        DrawWord((int)i, rateInterval, drawingContext);
                        DrawLine((int)i, rateInterval, 0.6, drawingContext);
                        DrawLine((int)i + 10, rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + 20, rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + 30, rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + 40, rateInterval, 1 / 4f, drawingContext);
                    }

                }
                else if (rateInterval <= 8)
                {
                    if (i % 10 == 0)
                    {
                        DrawWord((int)i, rateInterval, drawingContext);
                        DrawLine((int)i, rateInterval, 0.6, drawingContext);
                        DrawLine((int)i + 2, rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + 4, rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + 6, rateInterval, 1 / 4f, drawingContext);
                        DrawLine((int)i + 8, rateInterval, 1 / 4f, drawingContext);
                    }

                }
                else if (rateInterval <= 20)
                {
                    if (i % 2 == 0)
                    {
                        DrawWord((int)i, rateInterval, drawingContext);
                        DrawLine((int)i, rateInterval, 0.6, drawingContext);
                        DrawLine((int)i + 1, rateInterval, 1 / 4f, drawingContext);
                    }

                }
                else
                {
                    DrawWord((int)i, rateInterval, drawingContext);
                    DrawLine((int)i, rateInterval, 0.6, drawingContext);

                }


            }

        }
        private void DrawLine(int index, double rateInterval, double heightRate, DrawingContext drawingContext)
        {

            Pen pen = new Pen(Brushes.Black, 1);
            drawingContext.DrawLine(pen, new Point((index * rateInterval + ZeroOffset), 0), new Point((index * rateInterval + ZeroOffset), Height * heightRate));

        }
        private void DrawWord(int index, double rateInterval, DrawingContext drawingContext)
        {
            FormattedText text = GetDrawText(index);
            drawingContext.DrawText(text, new Point((index * rateInterval + ZeroOffset), (Height - text.Height)));
        }
        private FormattedText GetDrawText(int index)
        {

            var ft = new FormattedText(
                         (index).ToString(CultureInfo.CurrentCulture),
                          CultureInfo.CurrentCulture,
                          FlowDirection.LeftToRight,
                          new Typeface("Arial"),
                          Height * 3 / 10,
                          Brushes.DimGray);
            ft.SetFontWeight(FontWeights.Bold);
            ft.TextAlignment = TextAlignment.Center;
            return ft;
        }
    }
}
