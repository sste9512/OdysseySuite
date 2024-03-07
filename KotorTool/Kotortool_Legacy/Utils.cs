// Decompiled with JetBrains decompiler
// Type: kotor_tool.Utils
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class Utils
{
    public static Control FindControl(Control ParentCtrl, string CtrlName)
    {
            try
            {
                foreach (Control control1 in ParentCtrl.Controls)
                {
                    if (StringType.StrCmp(control1.Name, CtrlName, false) == 0)
                        return control1;
                    if (control1.Controls.Count <= 0) continue;
                    var control2 = FindControl(control1, CtrlName);
                    if (control2 != null)
                        return control2;
                }
            }
            finally
            {
            }

            return null;
        }

    public static void EditScriptForTextBox(
        Button editButton,
        string EditingFilePath,
        int KotorVersionIndex)
    {
            var CtrlName = editButton.Name.Replace("btnEdit", "tb");
            var control = (TextBox)FindControl(editButton.Parent, CtrlName);
            var bifFileHash = FrmMain.KxChitinKey(KotorVersionIndex).GetBifFileHash("scripts");
            var str1 = control.Text.Trim();
            if (StringType.StrCmp(str1, "", false) == 0)
                return;
            var str2 = Path.Combine(Path.GetDirectoryName(EditingFilePath) ?? string.Empty, str1 + ".nss");
            frmTextEditor frmTextEditor = null;
            if (File.Exists(str2))
                frmTextEditor = new frmTextEditor(str2, KotorVersionIndex, true);
            else if (bifFileHash.ContainsKey(str1 + ".nss"))
            {
                frmTextEditor = new frmTextEditor();
                var asciiEncoding = new ASCIIEncoding();
                frmTextEditor.tbGeneric.Text =
                    asciiEncoding.GetString(FrmMain.GetBiffResourceData(KotorVersionIndex, str1,
                        FrmMain.GetIdForRsrcType("nss")));
                frmTextEditor.tbGeneric.SelectionLength = 0;
                frmTextEditor.KotorVersionIndex = KotorVersionIndex;
                frmTextEditor.EditingFilePath = str2;
                frmTextEditor.DirectEdit = true;
                var num = (int)Interaction.MsgBox(
                    "The file " + str1 + ".nss already exists as a standard game resource." + "\n" +
                    "If you save it, this module will use your modified version instead of the global one.",
                    MsgBoxStyle.Information, "Notice");
            }
            else
            {
                var num1 = (int)Interaction.MsgBox(
                    "The file " + str1 +
                    ".nss does not exist in the same directory as this file nor as a standard game resource.",
                    MsgBoxStyle.Critical, "File not found");
            }

            if (frmTextEditor == null)
                return;
            frmTextEditor.Filename = str1 + ".nss";
            var num2 = (int)frmTextEditor.ShowDialog(editButton.TopLevelControl);
            control.Text = Path.GetFileNameWithoutExtension(frmTextEditor.Filename);
        }
}