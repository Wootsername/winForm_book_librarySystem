using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winForm_book_librarySystem
{
    public static class ThemeSettings
    {
        // ── Theme Color Palette ──
        public static Color SidebarBg = Color.FromArgb(19, 17, 36);        // #131124 - Dark navy/purple sidebar
        public static Color SidebarActiveBg = Color.FromArgb(37, 33, 58);  // #25213A - Lighter active item bg
        public static Color Gold = Color.FromArgb(226, 182, 89);          // #E2B659 - Warm gold accent
        public static Color GoldLight = Color.FromArgb(250, 247, 237);     // #FAF7ED - Cream active bg for role buttons
        public static Color ContentBg = Color.FromArgb(247, 247, 246);     // #F7F7F6 - Soft light warm gray main bg
        public static Color TextPrimary = Color.FromArgb(19, 17, 36);      // #131124 - Deep primary text
        public static Color TextMuted = Color.FromArgb(113, 113, 122);     // #71717A - Subtle secondary text
        public static Color CardBg = Color.White;
        public static Color BorderColor = Color.FromArgb(230, 230, 230);   // #E6E6E6 - Soft panel borders
        public static Color White = Color.White;

        // Status Colors
        public static Color SuccessGreen = Color.FromArgb(16, 185, 129);   // #10B981
        public static Color SuccessBg = Color.FromArgb(236, 253, 245);
        public static Color WarningOrange = Color.FromArgb(245, 158, 11);  // #F59E0B
        public static Color WarningBg = Color.FromArgb(254, 243, 199);
        public static Color DangerRed = Color.FromArgb(239, 68, 68);       // #EF4444
        public static Color DangerBg = Color.FromArgb(254, 226, 226);
        public static Color InfoBlue = Color.FromArgb(59, 130, 246);        // #3B82F6
        public static Color InfoBg = Color.FromArgb(239, 246, 255);

        // Legacy color variables mapping for backward compatibility
        public static Color DarkNavy = Color.FromArgb(19, 17, 36);
        public static Color LightGray = Color.FromArgb(113, 113, 122);
        public static Color ButtonText = Color.FromArgb(19, 17, 36);
        public static Color InputBackground = Color.White;

        /// <summary>
        /// Applies the legacy baseline global styling to standard components.
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            form.BackColor = ContentBg;
            form.ForeColor = TextPrimary;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            ApplyToControls(form.Controls);
        }

        private static bool IsInsideDarkBackground(Control control)
        {
            Control parent = control.Parent;
            while (parent != null)
            {
                if (parent.BackColor == Gold || parent.BackColor == Color.FromArgb(212, 175, 55) || parent.BackColor == GoldLight)
                {
                    return false;
                }
                string parentName = parent.Name != null ? parent.Name.ToLower() : "";
                if (parentName.Contains("sidebar") || parentName.Contains("left") || 
                    parentName.Contains("pnluserprofile") || parentName.Contains("panelleft") ||
                    parentName.Contains("pnluserinitials") || parentName.Contains("pnllogoicon") ||
                    parent.BackColor == SidebarBg || parent.BackColor == Color.FromArgb(26, 26, 46) ||
                    parent.BackColor == Color.FromArgb(19, 17, 36) || parent.BackColor == Color.FromArgb(28, 25, 48))
                {
                    return true;
                }
                parent = parent.Parent;
            }
            return false;
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                string name = control.Name != null ? control.Name.ToLower() : "";

                if (control is Panel pnl)
                {
                    if (name.Contains("sidebar") || name.Contains("left"))
                    {
                        StyleSidebar(pnl);
                    }
                    else if (name.Contains("detail") || name.Contains("card") || name.Contains("kpi") || name.Contains("pnlcard"))
                    {
                        ApplyCardStyle(pnl);
                    }
                }
                else if (control is Button btn)
                {
                    if (name.Contains("nav") || name.Contains("genre") || name.Contains("role"))
                    {
                        // Custom styled individually or with StyleNavButton
                    }
                    else if (name.Contains("delete") || name.Contains("cancel") || name.Contains("danger"))
                    {
                        StyleButtonDanger(btn);
                    }
                    else if (name.Contains("login") || name.Contains("reserve") || name.Contains("save") || name.Contains("add") || name.Contains("solid") || name.Contains("reports"))
                    {
                        StyleButtonSolidGold(btn);
                    }
                    else if (name.Contains("outline"))
                    {
                        StyleButtonGoldOutline(btn);
                    }
                    else
                    {
                        StyleButtonSecondary(btn);
                    }
                }
                else if (control is Label lbl)
                {
                    bool isDark = IsInsideDarkBackground(lbl);
                    if (name.Contains("title") || name.Contains("welcome") || name.Contains("header") || name.Contains("logo"))
                    {
                        lbl.Font = new Font("Segoe UI", name.Contains("logo") ? 11F : 14F, FontStyle.Bold);
                        lbl.ForeColor = isDark ? Color.White : TextPrimary;
                    }
                    else if (name.Contains("subtitle") || name.Contains("sub") || name.Contains("muted") || name.Contains("gray"))
                    {
                        lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                        lbl.ForeColor = isDark ? Color.FromArgb(160, 160, 190) : TextMuted;
                    }
                    else
                    {
                        lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                        lbl.ForeColor = isDark ? Color.FromArgb(220, 220, 240) : TextPrimary;
                    }
                }
                else if (control is TextBox txt)
                {
                    StyleTextBox(txt);
                }
                else if (control is DataGridView dgv)
                {
                    StyleGridView(dgv);
                }
                else if (control is System.Windows.Forms.DataVisualization.Charting.Chart chart)
                {
                    StyleChart(chart);
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = Color.White;
                    cmb.ForeColor = TextPrimary;
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.Font = new Font("Segoe UI", 9.5F);
                }

                if (control.HasChildren)
                {
                    ApplyToControls(control.Controls);
                }
            }
        }

        // ── Custom GDI+ Painter for Rounded Corners ──
        public static void MakeRoundedControl(Control control, int radius = 12, Color? borderColor = null, int borderSize = 1)
        {
            void ApplyRegion()
            {
                Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
                if (rect.Width > 0 && rect.Height > 0)
                {
                    using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
                    {
                        control.Region = new Region(path);
                    }
                }
            }

            // Set region initially
            ApplyRegion();

            // Handle resize to update region
            control.SizeChanged += (sender, e) => ApplyRegion();

            // Paint border
            if (borderColor.HasValue && borderSize > 0)
            {
                control.Paint += (sender, e) =>
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
                    rect.Width -= borderSize;
                    rect.Height -= borderSize;
                    if (rect.Width > 0 && rect.Height > 0)
                    {
                        using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
                        using (Pen pen = new Pen(borderColor.Value, borderSize))
                        {
                            pen.Alignment = PenAlignment.Inset;
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                };
            }
            control.Invalidate();
        }

        private static GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = Math.Min(radius, Math.Min(rect.Width / 2f, rect.Height / 2f));
            if (r <= 0) r = 1;
            float diameter = r * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        // ── Specific Component Styling Methods ──

        public static void StyleSidebar(Panel panel)
        {
            panel.BackColor = SidebarBg;
            panel.BorderStyle = BorderStyle.None;
        }

        public static void ApplyCardStyle(Panel panel, int radius = 12)
        {
            panel.BackColor = CardBg;
            panel.BorderStyle = BorderStyle.None;
            MakeRoundedControl(panel, radius, BorderColor, 1);
        }

        public static void StyleNavButton(Button btn, bool isActive)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = SidebarActiveBg;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 25, 48);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Font = new Font("Segoe UI", 9.5F, isActive ? FontStyle.Bold : FontStyle.Regular);
            
            if (isActive)
            {
                btn.BackColor = SidebarActiveBg;
                btn.ForeColor = Gold;
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(160, 160, 190);
            }
        }

        public static void StyleButtonPrimary(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.White;
            btn.ForeColor = TextPrimary;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            
            // Standard rounded style for buttons inside content panel
            MakeRoundedControl(btn, 8, BorderColor, 1);
        }

        public static void StyleButtonGoldOutline(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = White;
            btn.ForeColor = Gold;
            btn.FlatAppearance.BorderColor = Gold;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            MakeRoundedControl(btn, 8, Gold, 1);
        }

        public static void StyleButtonSolidGold(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Gold;
            btn.ForeColor = SidebarBg;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            MakeRoundedControl(btn, 8, null, 0);
        }

        public static void StyleButtonSecondary(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.White;
            btn.ForeColor = TextMuted;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;

            MakeRoundedControl(btn, 8, BorderColor, 1);
        }

        public static void StyleButtonDanger(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.White;
            btn.ForeColor = DangerRed;
            btn.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            MakeRoundedControl(btn, 8, Color.FromArgb(254, 202, 202), 1);
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = TextPrimary;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10F);
            
            // To make textboxes look gorgeous and rounded, we can add a custom painting of parent if needed, 
            // but standard clean flat border is great!
        }

        public static void StyleGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(245, 245, 245);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Columns/Headers styling
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextMuted;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextMuted;
            dgv.ColumnHeadersHeight = 36;

            // Rows styling
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 249, 246);
            dgv.DefaultCellStyle.SelectionForeColor = TextPrimary;
            
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 251);
            dgv.RowTemplate.Height = 42;
        }

        public static void CreateBadge(Label lbl, string status)
        {
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            
            switch (status.ToLower())
            {
                case "pending":
                    lbl.BackColor = WarningBg;
                    lbl.ForeColor = WarningOrange;
                    break;
                case "approved":
                case "active":
                case "available":
                    lbl.BackColor = SuccessBg;
                    lbl.ForeColor = SuccessGreen;
                    break;
                case "overdue":
                case "cancelled":
                case "suspended":
                case "needs attention":
                    lbl.BackColor = DangerBg;
                    lbl.ForeColor = DangerRed;
                    break;
                default:
                    lbl.BackColor = InfoBg;
                    lbl.ForeColor = InfoBlue;
                    break;
            }

            MakeRoundedControl(lbl, 6, null, 0);
        }

        public static void StyleChart(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            if (chart == null) return;

            // 1. General Chart Styling
            chart.BackColor = Color.White;
            chart.BorderlineColor = Color.Transparent;
            chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;

            // Apply card rounded style container
            MakeRoundedControl(chart, 12, BorderColor, 1);

            // 2. Chart Area Setup
            if (chart.ChartAreas.Count > 0)
            {
                var area = chart.ChartAreas[0];
                area.BackColor = Color.White;
                area.BorderColor = Color.Transparent;
                area.BorderWidth = 0;

                // Subtle X-Axis Grid
                area.AxisX.MajorGrid.LineColor = Color.FromArgb(242, 242, 242);
                area.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                area.AxisX.LineColor = Color.FromArgb(220, 220, 220);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                area.AxisX.LabelStyle.ForeColor = TextMuted;

                // Subtle Y-Axis Grid
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(242, 242, 242);
                area.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                area.AxisY.LineColor = Color.FromArgb(220, 220, 220);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                area.AxisY.LabelStyle.ForeColor = TextMuted;
            }

            // 3. Legend Customization
            if (chart.Legends.Count > 0)
            {
                var legend = chart.Legends[0];
                legend.BackColor = Color.Transparent;
                legend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                legend.ForeColor = TextPrimary;
                legend.Alignment = StringAlignment.Far;
                legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            }

            // 4. Series Styling (Luxurious Spline Area)
            foreach (var series in chart.Series)
            {
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                
                // Semi-transparent Gold fill and solid Gold line border
                series.Color = Color.FromArgb(40, Gold.R, Gold.G, Gold.B);
                series.BorderColor = Gold;
                series.BorderWidth = 3;
                
                // Exquisite circular data markers
                series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                series.MarkerSize = 8;
                series.MarkerColor = Gold;
                series.MarkerBorderColor = Color.White;
                series.MarkerBorderWidth = 2;
            }
        }
    }
}
