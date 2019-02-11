using System.Drawing;
using System.Windows.Forms;

namespace OTEL.Classes.Style
{
    public class ButtonStyle
    {
        public void Style(Button Btn,string LeaveForeColor,string HoverForeColor,string LeaveBackColor, string HoverBackColor)
        {
            Btn.BackColor = ColorTranslator.FromHtml(LeaveBackColor);
            Btn.ForeColor = ColorTranslator.FromHtml(LeaveForeColor);
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.FlatAppearance.BorderSize = 0;

            // Olaylar
            Btn.MouseHover += (sender, args) =>
            {
                Btn.BackColor = ColorTranslator.FromHtml(HoverBackColor);
                Btn.ForeColor = ColorTranslator.FromHtml(HoverForeColor);
            };
            Btn.MouseLeave += (sender, args) =>
            {
                Btn.BackColor = ColorTranslator.FromHtml(LeaveBackColor);
                Btn.ForeColor = ColorTranslator.FromHtml(LeaveForeColor);
            };
        }
    }
}
