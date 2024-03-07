// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmImageViewer
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmImageViewer : Form
{
  [AccessedThroughProperty("btnWriteFile")]
  private Button _btnWriteFile;
  [AccessedThroughProperty("lblMipMapCount")]
  private Label _lblMipMapCount;
  [AccessedThroughProperty("lblFlag1")]
  private Label _lblFlag1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("lblFlag2")]
  private Label _lblFlag2;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("tbImageInfo")]
  private TextBox _tbImageInfo;
  [AccessedThroughProperty("chkbExportSelectionToTXIfile")]
  private CheckBox _chkbExportSelectionToTXIfile;
  [AccessedThroughProperty("pbox")]
  private PictureBox _pbox;
  [AccessedThroughProperty("lblFlag3")]
  private Label _lblFlag3;
  [AccessedThroughProperty("lblFlag4")]
  private Label _lblFlag4;
  private IContainer components;
  public byte[] PxData;
  public byte[] TPCData;
  public byte[] Pixeldata;
  private short _xSize;
  private short _ySize;
  private short _BitsPerPixel;
  private string fname;
  private GCHandle ghImage;
  private bool bNeedToFlipForWriting;
  private int dataSize;
  private int encoding1;
  private int mipmapCnt;
  private int decode_cmd;
  private byte flag1;
  private byte flag2;
  private byte flag3;
  private byte flag4;

  public frmImageViewer()
  {
      Load += new EventHandler(frmImageViewer_Load);
      Closing += new CancelEventHandler(frmImageViewer_Closing);
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual PictureBox pbox
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pbox == null)
          ;
        _pbox = value;
        if (_pbox == null)
          ;
      }
    get => _pbox;
  }

  internal virtual Button btnOK
  {
    get => _btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK != null)
          _btnOK.Click -= new EventHandler(btnOK_Click);
        _btnOK = value;
        if (_btnOK == null)
          return;
        _btnOK.Click += new EventHandler(btnOK_Click);
      }
  }

  internal virtual Panel Panel1
  {
    get => _Panel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Panel1 == null)
          ;
        _Panel1 = value;
        if (_Panel1 == null)
          ;
      }
  }

  internal virtual TextBox tbImageInfo
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbImageInfo == null)
          ;
        _tbImageInfo = value;
        if (_tbImageInfo == null)
          ;
      }
    get => _tbImageInfo;
  }

  internal virtual Label Label1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 == null)
          ;
      }
    get => _Label1;
  }

  internal virtual Label lblMipMapCount
  {
    get => _lblMipMapCount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblMipMapCount == null)
          ;
        _lblMipMapCount = value;
        if (_lblMipMapCount == null)
          ;
      }
  }

  internal virtual Label Label2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label2 == null)
          ;
        _Label2 = value;
        if (_Label2 == null)
          ;
      }
    get => _Label2;
  }

  internal virtual Button btnWriteFile
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnWriteFile != null)
          _btnWriteFile.Click -= new EventHandler(btnWriteFile_Click);
        _btnWriteFile = value;
        if (_btnWriteFile == null)
          return;
        _btnWriteFile.Click += new EventHandler(btnWriteFile_Click);
      }
    get => _btnWriteFile;
  }

  internal virtual Label lblFlag1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblFlag1 == null)
          ;
        _lblFlag1 = value;
        if (_lblFlag1 == null)
          ;
      }
    get => _lblFlag1;
  }

  internal virtual Label lblFlag2
  {
    get => _lblFlag2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblFlag2 == null)
          ;
        _lblFlag2 = value;
        if (_lblFlag2 == null)
          ;
      }
  }

  internal virtual Label lblFlag3
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblFlag3 == null)
          ;
        _lblFlag3 = value;
        if (_lblFlag3 == null)
          ;
      }
    get => _lblFlag3;
  }

  internal virtual Label lblFlag4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblFlag4 == null)
          ;
        _lblFlag4 = value;
        if (_lblFlag4 == null)
          ;
      }
    get => _lblFlag4;
  }

  internal virtual CheckBox chkbExportSelectionToTXIfile
  {
    get => _chkbExportSelectionToTXIfile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbExportSelectionToTXIfile == null)
          ;
        _chkbExportSelectionToTXIfile = value;
        if (_chkbExportSelectionToTXIfile == null)
          ;
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmImageViewer));
      pbox = new PictureBox();
      btnOK = new Button();
      Panel1 = new Panel();
      tbImageInfo = new TextBox();
      Label1 = new Label();
      lblMipMapCount = new Label();
      Label2 = new Label();
      this.btnWriteFile = new Button();
      lblFlag1 = new Label();
      lblFlag2 = new Label();
      lblFlag3 = new Label();
      lblFlag4 = new Label();
      chkbExportSelectionToTXIfile = new CheckBox();
      Panel1.SuspendLayout();
      SuspendLayout();
      pbox.BorderStyle = BorderStyle.FixedSingle;
      PictureBox pbox1 = pbox;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      pbox1.Location = point2;
      pbox.Name = "pbox";
      PictureBox pbox2 = pbox;
      Size size1 = new Size(96, 80);
      Size size2 = size1;
      pbox2.Size = size2;
      pbox.SizeMode = PictureBoxSizeMode.CenterImage;
      pbox.TabIndex = 0;
      pbox.TabStop = false;
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.Cancel;
      Button btnOk = btnOK;
      point1 = new Point(344, 456);
      Point point3 = point1;
      btnOk.Location = point3;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 0;
      btnOK.Text = "OK";
      Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      Panel1.AutoScroll = true;
      Panel1.Controls.Add(pbox);
      Panel panel1_1 = Panel1;
      point1 = new Point(16, 16);
      Point point4 = point1;
      panel1_1.Location = point4;
      Panel1.Name = "Panel1";
      Panel panel1_2 = Panel1;
      size1 = new Size(416, 376);
      Size size3 = size1;
      panel1_2.Size = size3;
      Panel1.TabIndex = 1;
      tbImageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tbImageInfo1 = tbImageInfo;
      point1 = new Point(16, 400);
      Point point5 = point1;
      tbImageInfo1.Location = point5;
      tbImageInfo.Multiline = true;
      tbImageInfo.Name = "tbImageInfo";
      TextBox tbImageInfo2 = tbImageInfo;
      size1 = new Size(160, 64);
      Size size4 = size1;
      tbImageInfo2.Size = size4;
      tbImageInfo.TabIndex = 2;
      tbImageInfo.Text = "";
      Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label1_1 = Label1;
      point1 = new Point(184, 400);
      Point point6 = point1;
      label1_1.Location = point6;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(112, 16);
      Size size5 = size1;
      label1_2.Size = size5;
      Label1.TabIndex = 3;
      Label1.Text = "Number of mipmaps:";
      Label1.TextAlign = ContentAlignment.MiddleRight;
      lblMipMapCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      lblMipMapCount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label lblMipMapCount1 = lblMipMapCount;
      point1 = new Point(294, 400);
      Point point7 = point1;
      lblMipMapCount1.Location = point7;
      lblMipMapCount.Name = "lblMipMapCount";
      Label lblMipMapCount2 = lblMipMapCount;
      size1 = new Size(24, 16);
      Size size6 = size1;
      lblMipMapCount2.Size = size6;
      lblMipMapCount.TabIndex = 4;
      lblMipMapCount.TextAlign = ContentAlignment.MiddleCenter;
      Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
      Label label2_1 = Label2;
      point1 = new Point(288, 416);
      Point point8 = point1;
      label2_1.Location = point8;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(24, 16);
      Size size7 = size1;
      label2_2.Size = size7;
      Label2.TabIndex = 4;
      Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.btnWriteFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnWriteFile = this.btnWriteFile;
      point1 = new Point(248, 456);
      Point point9 = point1;
      btnWriteFile.Location = point9;
      this.btnWriteFile.Name = "btnWriteFile";
      this.btnWriteFile.TabIndex = 0;
      this.btnWriteFile.Text = "Write File";
      lblFlag1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label lblFlag1_1 = lblFlag1;
      point1 = new Point(184, 432);
      Point point10 = point1;
      lblFlag1_1.Location = point10;
      lblFlag1.Name = "lblFlag1";
      Label lblFlag1_2 = lblFlag1;
      size1 = new Size(20, 16);
      Size size8 = size1;
      lblFlag1_2.Size = size8;
      lblFlag1.TabIndex = 5;
      lblFlag1.Text = "AA";
      lblFlag1.TextAlign = ContentAlignment.MiddleCenter;
      lblFlag2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label lblFlag2_1 = lblFlag2;
      point1 = new Point(208, 432);
      Point point11 = point1;
      lblFlag2_1.Location = point11;
      lblFlag2.Name = "lblFlag2";
      Label lblFlag2_2 = lblFlag2;
      size1 = new Size(20, 16);
      Size size9 = size1;
      lblFlag2_2.Size = size9;
      lblFlag2.TabIndex = 6;
      lblFlag2.Text = "AA";
      lblFlag2.TextAlign = ContentAlignment.MiddleCenter;
      lblFlag3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label lblFlag3_1 = lblFlag3;
      point1 = new Point(232, 432);
      Point point12 = point1;
      lblFlag3_1.Location = point12;
      lblFlag3.Name = "lblFlag3";
      Label lblFlag3_2 = lblFlag3;
      size1 = new Size(20, 16);
      Size size10 = size1;
      lblFlag3_2.Size = size10;
      lblFlag3.TabIndex = 7;
      lblFlag3.Text = "AA";
      lblFlag3.TextAlign = ContentAlignment.MiddleCenter;
      lblFlag4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label lblFlag4_1 = lblFlag4;
      point1 = new Point(256, 432);
      Point point13 = point1;
      lblFlag4_1.Location = point13;
      lblFlag4.Name = "lblFlag4";
      Label lblFlag4_2 = lblFlag4;
      size1 = new Size(20, 16);
      Size size11 = size1;
      lblFlag4_2.Size = size11;
      lblFlag4.TabIndex = 8;
      lblFlag4.Text = "AA";
      lblFlag4.TextAlign = ContentAlignment.MiddleCenter;
      chkbExportSelectionToTXIfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      CheckBox selectionToTxIfile1 = chkbExportSelectionToTXIfile;
      point1 = new Point(16, 472);
      Point point14 = point1;
      selectionToTxIfile1.Location = point14;
      chkbExportSelectionToTXIfile.Name = "chkbExportSelectionToTXIfile";
      CheckBox selectionToTxIfile2 = chkbExportSelectionToTXIfile;
      size1 = new Size(160, 16);
      Size size12 = size1;
      selectionToTxIfile2.Size = size12;
      chkbExportSelectionToTXIfile.TabIndex = 9;
      chkbExportSelectionToTXIfile.Text = "Export Selection to TXI file";
      AcceptButton = btnOK;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = btnOK;
      size1 = new Size(448, 493);
      ClientSize = size1;
      Controls.Add(chkbExportSelectionToTXIfile);
      Controls.Add(lblFlag4);
      Controls.Add(lblFlag3);
      Controls.Add(lblFlag2);
      Controls.Add(lblFlag1);
      Controls.Add(lblMipMapCount);
      Controls.Add(Label1);
      Controls.Add(tbImageInfo);
      Controls.Add(Panel1);
      Controls.Add(btnOK);
      Controls.Add(Label2);
      Controls.Add(this.btnWriteFile);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(456, 472);
      MinimumSize = size1;
      Name = nameof (frmImageViewer);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.Manual;
      Text = "Image Viewer";
      Panel1.ResumeLayout(false);
      ResumeLayout(false);
    }

  public void SetupPixelArray(Array data)
  {
      PxData = (byte[]) Array.CreateInstance(typeof (byte), data.Length);
      Array.Copy(data, PxData, data.Length);
    }

  public void SetupTPCData(Array data, string filename)
  {
      TPCData = (byte[]) Array.CreateInstance(typeof (byte), data.Length);
      Array.Copy(data, TPCData, data.Length);
      fname = filename;
    }

  public void ShowImage(int BytesPerPixel, PixelFormat pxFormat)
  {
      if (ghImage.IsAllocated)
        ghImage.Free();
      ghImage = GCHandle.Alloc(Pixeldata, GCHandleType.Pinned);
      IntPtr scan0 = ghImage.AddrOfPinnedObject();
      try
      {
        pbox.Image = new Bitmap(_xSize, _ySize, checked (BytesPerPixel * _xSize), pxFormat, scan0);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox("Cannot view this image", MsgBoxStyle.Critical, "Weirdness Alert");
        ProjectData.ClearProjectError();
      }
      pbox.Size = new Size(_xSize, _ySize);
      _BitsPerPixel = checked ((short) (BytesPerPixel * 8));
      Text = "Image Viewer: " + fname;
    }

  public void DecodeImage()
  {
      dataSize = checked ((int) Math.Round(TPCData[0] + TPCData[1] * 256.0 + TPCData[2] * 65536.0 + TPCData[3] * 16777216.0));
      flag1 = TPCData[4];
      flag2 = TPCData[5];
      flag3 = TPCData[6];
      flag4 = TPCData[7];
      _xSize = checked ((short) (TPCData[8] + TPCData[9] * 256));
      _ySize = checked ((short) (TPCData[10] + TPCData[11] * 256));
      encoding1 = TPCData[12];
      mipmapCnt = TPCData[13];
      Array.Copy(TPCData, 128, TPCData, 0, checked (TPCData.Length - 128));
      int decode_cmd = 0;
      if (dataSize == 0 & encoding1 == 2 & mipmapCnt == 1)
      {
        bNeedToFlipForWriting = false;
        int num1 = checked ((short) unchecked (_xSize * _ySize) - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
          byte num3 = TPCData[checked (num2 * 3)];
          TPCData[checked (num2 * 3)] = TPCData[checked (num2 * 3 + 2)];
          TPCData[checked (num2 * 3 + 2)] = num3;
          checked { ++num2; }
        }
        Pixeldata = (byte[]) Array.CreateInstance(typeof (byte), TPCData.Length);
        Array.Copy(TPCData, Pixeldata, TPCData.Length);
        Array pixeldata = Pixeldata;
        FlipImageVertically(ref pixeldata, checked (3 * _xSize), _ySize);
        Pixeldata = (byte[]) pixeldata;
      }
      else if (dataSize == 0 & encoding1 == 4 & mipmapCnt == 1)
      {
        bNeedToFlipForWriting = false;
        int num4 = checked (_xSize * _ySize - 1);
        int num5 = 0;
        while (num5 <= num4)
        {
          byte num6 = TPCData[checked (num5 * 4)];
          TPCData[checked (num5 * 4)] = TPCData[checked (num5 * 4 + 2)];
          TPCData[checked (num5 * 4 + 2)] = num6;
          checked { ++num5; }
        }
        Pixeldata = (byte[]) Array.CreateInstance(typeof (byte), TPCData.Length);
        Array.Copy(TPCData, Pixeldata, TPCData.Length);
        Array pixeldata = Pixeldata;
        FlipImageVertically(ref pixeldata, checked (4 * _xSize), _ySize);
        Pixeldata = (byte[]) pixeldata;
      }
      else if (encoding1 == 2 | encoding1 == 4)
      {
        bNeedToFlipForWriting = true;
        long[] numArray1 = new long[1] { _xSize };
        long[] numArray2 = numArray1;
        int index1 = 0;
        int index2 = index1;
        long num7 = checked (numArray1[index1] * _ySize);
        numArray2[index2] = num7;
        long[] numArray3 = numArray1;
        int index3 = 0;
        int index4 = index3;
        long num8 = checked (numArray1[index3] * 4L);
        numArray3[index4] = num8;
        Pixeldata = (byte[]) Array.CreateInstance(typeof (byte), numArray1);
        if (encoding1 == 2)
          decode_cmd = 1;
        else if (encoding1 == 4)
          decode_cmd = 5;
      }
      if (dataSize > 0 & (encoding1 == 2 | encoding1 == 4))
      {
        TpcTool tpcTool = new TpcTool();
        GCHandle gcHandle1 = GCHandle.Alloc(TPCData, GCHandleType.Pinned);
        GCHandle gcHandle2 = GCHandle.Alloc(Pixeldata, GCHandleType.Pinned);
        IntPtr data = gcHandle1.AddrOfPinnedObject();
        IntPtr outdata = gcHandle2.AddrOfPinnedObject();
        tpcTool.foo(data, outdata, _xSize, _ySize, decode_cmd);
        gcHandle1.Free();
        gcHandle2.Free();
      }
      if (dataSize == 0 & encoding1 == 2 & mipmapCnt == 1)
        ShowImage(3, PixelFormat.Format24bppRgb);
      else if (dataSize == 0 & encoding1 == 4 & mipmapCnt == 1)
      {
        ShowImage(4, PixelFormat.Format32bppArgb);
      }
      else
      {
        ShowImage(4, PixelFormat.Format32bppArgb);
        int byteIndex = checked (128 + MipLevel2Bytes(mipmapCnt, encoding1 * 4));
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        object o1 = checked (TPCData.Length - byteIndex);
        tbImageInfo.Text = ObjectType.ObjTst(o1, 0, false) <= 0 ? "" : asciiEncoding.GetString(TPCData, byteIndex, IntegerType.FromObject(o1));
      }
      lblMipMapCount.Text = StringType.FromInteger(mipmapCnt);
      lblFlag1.Text = Strings.Format(flag1, "x");
      lblFlag2.Text = Strings.Format(flag2, "x");
      lblFlag3.Text = Strings.Format(flag3, "x");
      lblFlag4.Text = Strings.Format(flag4, "x");
    }

  public int MipLevel2Bytes(int miplevel, int dxtBytesPerTexel)
  {
      int num = 0;
      switch (miplevel)
      {
        case 1:
          num = 16;
          break;
        case 2:
          num = 32;
          break;
        case 3:
          num = 48;
          break;
        case 4:
          num = 112;
          break;
        case 5:
          num = 368;
          break;
        case 6:
          num = 1392;
          break;
        case 7:
          num = 5488;
          break;
        case 8:
          num = 21872;
          break;
        case 9:
          num = 87408;
          break;
        case 10:
          num = 349552;
          break;
        case 11:
          num = 1398128;
          break;
      }
      return checked ((int) Math.Round(num / 16.0 / dxtBytesPerTexel));
    }

  public void FlipImageVertically(ref Array PixelData, int stride, int ySize)
  {
      Array instance = Array.CreateInstance(typeof (byte), stride);
      int num1 = checked ((int) Math.Round(ySize / 2.0 - 1.0));
      int num2 = 0;
      while (num2 <= num1)
      {
        Array.Copy(PixelData, checked (num2 * stride), instance, 0, stride);
        Array.Copy(PixelData, checked (ySize - num2 - 1 * stride), PixelData, checked (num2 * stride), stride);
        Array.Copy(instance, 0, PixelData, checked (ySize - num2 - 1 * stride), stride);
        checked { ++num2; }
      }
    }

  private void btnWriteFile_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("save", FrmMain.CurrentSettings.defaultSaveLocation, Strings.Mid(fname, 1, fname.IndexOf(".")) + ".tga", "Save TGA file...", "tga"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      BinaryWriter binaryWriter = new BinaryWriter(new FileStream(str, FileMode.Create), Encoding.ASCII);
      binaryWriter.Write((byte) 0);
      binaryWriter.Write((byte) 0);
      binaryWriter.Write((byte) 2);
      binaryWriter.Write(0);
      binaryWriter.Write(0);
      binaryWriter.Write((byte) 0);
      binaryWriter.Write(_xSize);
      binaryWriter.Write(_ySize);
      binaryWriter.Write(_BitsPerPixel);
      if (dataSize > 0)
      {
        Array pixeldata = Pixeldata;
        FlipImageVertically(ref pixeldata, checked (4 * _xSize), _ySize);
        Pixeldata = (byte[]) pixeldata;
        binaryWriter.Write(Pixeldata);
      }
      else
        binaryWriter.Write(TPCData);
      binaryWriter.Close();
      if (tbImageInfo.SelectionLength <= 0 || !chkbExportSelectionToTXIfile.Checked)
        return;
      StreamWriter streamWriter = new StreamWriter(new FileStream(Strings.Replace(str, ".tga", ".txi"), FileMode.Create), Encoding.ASCII);
      streamWriter.Write(tbImageInfo.SelectedText);
      streamWriter.Close();
    }

  public void WriteTGAFile(string outputPath)
  {
      BinaryWriter binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create), Encoding.ASCII);
      binaryWriter.Write((byte) 0);
      binaryWriter.Write((byte) 0);
      binaryWriter.Write((byte) 2);
      binaryWriter.Write(0);
      binaryWriter.Write(0);
      binaryWriter.Write((byte) 0);
      binaryWriter.Write(_xSize);
      binaryWriter.Write(_ySize);
      binaryWriter.Write(_BitsPerPixel);
      if (dataSize > 0)
      {
        Array pixeldata = Pixeldata;
        FlipImageVertically(ref pixeldata, checked (4 * _xSize), _ySize);
        Pixeldata = (byte[]) pixeldata;
        binaryWriter.Write(Pixeldata);
      }
      else
        binaryWriter.Write(TPCData);
      binaryWriter.Close();
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      if (ghImage.IsAllocated)
        ghImage.Free();
      Hide();
    }

  public void PositionWindow()
  {
      Point point1 = default;
      if (!FrmMain.CurrentSettings.ImageViewerWindowLoc.IsEmpty)
      {
        point1 = FrmMain.CurrentSettings.ImageViewerWindowLoc;
        if (point1.X < 0)
          FrmMain.CurrentSettings.ImageViewerWindowLoc = new Point(10, 10);
        if (FrmMain.CurrentSettings.ImageViewerWindowLoc.Y < 0)
        {
          Options currentSettings = FrmMain.CurrentSettings;
          point1 = new Point(10, 10);
          Point point2 = point1;
          currentSettings.ImageViewerWindowLoc = point2;
        }
        ((Control) this).Location = FrmMain.CurrentSettings.ImageViewerWindowLoc;
      }
      if (FrmMain.CurrentSettings.ImageViewerWindowSize.IsEmpty)
        return;
      Size size1 = FrmMain.CurrentSettings.ImageViewerWindowSize;
      int height1 = size1.Height;
      Rectangle workingArea1 = Screen.PrimaryScreen.WorkingArea;
      int height2 = workingArea1.Height;
      Point location;
      int height3 = 0;
      Size size2 = default;
      if (height1 > height2)
      {
        ref Point local1 = ref point1;
        location = ((Control) this).Location;
        int x = location.X;
        int top = Screen.PrimaryScreen.WorkingArea.Top;
        local1 = new Point(x, top);
        ((Control) this).Location = point1;
        height3 = Screen.PrimaryScreen.WorkingArea.Height;
        ref Size local2 = ref size2;
        size1 = Size;
        int width = size1.Width;
        int height4 = height3;
        local2 = new Size(width, height4);
        Size = size2;
      }
      size2 = FrmMain.CurrentSettings.ImageViewerWindowSize;
      int width1 = size2.Width;
      Rectangle workingArea2 = Screen.PrimaryScreen.WorkingArea;
      int width2 = workingArea2.Width;
      int width3 = 0;
      if (width1 > width2)
      {
        ref Point local3 = ref point1;
        workingArea1 = Screen.PrimaryScreen.WorkingArea;
        int left = workingArea1.Left;
        location = ((Control) this).Location;
        int y = location.Y;
        local3 = new Point(left, y);
        ((Control) this).Location = point1;
        workingArea2 = Screen.PrimaryScreen.WorkingArea;
        width3 = workingArea2.Width;
        ref Size local4 = ref size1;
        int width4 = width3;
        size2 = Size;
        int height5 = size2.Height;
        local4 = new Size(width4, height5);
        Size = size1;
      }
      if (!(width3 == 0 & height3 == 0))
        return;
      Size = FrmMain.CurrentSettings.ImageViewerWindowSize;
    }

  public void SaveSettings()
  {
      FrmMain.CurrentSettings.ImageViewerWindowLoc = ((Control) this).Location;
      FrmMain.CurrentSettings.ImageViewerWindowSize = Size;
    }

  private void frmImageViewer_Load(object sender, EventArgs e) => PositionWindow();

  private void frmImageViewer_Closing(object sender, CancelEventArgs e) => SaveSettings();
}