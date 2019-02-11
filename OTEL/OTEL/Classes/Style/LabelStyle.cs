using System.Drawing;
using System.Windows.Forms;

namespace OTEL.Classes.Style
{
    public class LabelStyle
    {
        // LeaveColor=default renk , HoverColor=üzerine gelindiğindeki renk
        public void Style(Label Lbl,string LeaveForeColor,string HoverForeColor)
        {
            Lbl.BackColor = Color.Transparent;
            Lbl.ForeColor = ColorTranslator.FromHtml(LeaveForeColor);

            // Olaylar
            Lbl.MouseHover += (sender, args) =>
            {
                Lbl.ForeColor = ColorTranslator.FromHtml(HoverForeColor);
            };
            Lbl.MouseLeave += (sender, args) =>
            {
                Lbl.ForeColor = ColorTranslator.FromHtml(LeaveForeColor);
            };
        }

        public void Style(Label Lbl, string LeaveForeColor, string HoverForeColor, string LeaveBackColor, string HoverBackColor)
        {
            Lbl.BackColor = ColorTranslator.FromHtml(LeaveBackColor);
            Lbl.ForeColor = ColorTranslator.FromHtml(LeaveForeColor);

            // Olaylar
            Lbl.MouseHover += (sender, args) =>
            {
                Lbl.BackColor = ColorTranslator.FromHtml(HoverBackColor);
                Lbl.ForeColor = ColorTranslator.FromHtml(HoverForeColor);
            };
            Lbl.MouseLeave += (sender, args) =>
            {
                Lbl.BackColor = ColorTranslator.FromHtml(LeaveBackColor);
                Lbl.ForeColor = ColorTranslator.FromHtml(LeaveForeColor);
            };
        }
    }
}
