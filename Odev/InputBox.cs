using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public static class InputBox
    {
        public static DialogResult Show(string title, string pText, ref string value)
        {
            //Dinamik form,label,textbox ve buttonlarımı tanımlıyorum.
            frmInputBox frm = new frmInputBox();
            Label lbl = new Label();
            TextBox txt = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();

            //Parametrelerden aldığım değerleri nesnelerin Text özelliğine tanımlıyorum.
            frm.Text = title;
            lbl.Text = pText;
            txt.Text = value;

            //Butonlari için ilgili özellikleri ekliyorum.
            btnOk.Text = "Tamam";
            btnCancel.Text = "İptal";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            //Nesnelerimin form üzerindeki pozisyonlarını tanımlıyorum.
            lbl.SetBounds(10, 22, 372, 14);
            txt.SetBounds(13, 38, 372, 21);
            btnOk.SetBounds(229, 72, 75, 23);
            btnCancel.SetBounds(310, 72, 75, 23);

            //Formda nesnelerin düzgün görünmesi için Anchor özelliğini yapılandırıyorum.
            lbl.AutoSize = true;
            txt.Anchor = txt.Anchor | AnchorStyles.Right;
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            //Form ile ilgili özellikleri yapılandırıyorum.
            //Form boyut,üzerinde bulunacak nesneler ve diğer özellikler.
            frm.ClientSize = new Size(399, 109);
            frm.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
            frm.ClientSize = new Size(Math.Max(300, lbl.Right + 10), frm.ClientSize.Height);
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.AcceptButton = btnOk;
            frm.CancelButton = btnCancel;
            //Formu diyalog tipinde açıyor ve girilen bilgiyi ref türündeki value değişkenine gönderiyorum.
            DialogResult dialogResult = frm.ShowDialog();
            value = txt.Text;
            return dialogResult;
        }

    }
}
