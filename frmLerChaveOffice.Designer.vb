<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLerChaveOffice
    Inherits VBLibrary.VB6Form


' Este construtor estatico serve para garantir a inicializacao da biblioteca VBLibrary antes de qualquer coisa.
Shared Sub New()
    EnsureVB6LibraryInitialization()
End Sub

#Region "Windows Form Designer generated code "

    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Create all controls and control arrays.
        InitializeComponents()
    End Sub

    ' This method wraps the call to InitializeComponent, but can be called from base class.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub InitializeComponents()
        Me.ObjectIsInitializing = True
        InitializeComponent()
        Me.ObjectIsInitializing = False
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents txtChaveOneNoteVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChaveMSProjectVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChaveVisioVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChavePublisherVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChavePowerPointVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChaveOutlookVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChaveAccessVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChaveWordVersao As VBLibrary.VB6TextBox
    Public WithEvents txtChaveExcelVersao As VBLibrary.VB6TextBox
    Public WithEvents cmdLerChaves As VBLibrary.VB6CommandButton
    Public WithEvents lblChaveOneNoteVersao As VBLibrary.VB6Label
    Public WithEvents lblChaveMSProjectVersao As VBLibrary.VB6Label
    Public WithEvents lblChaveVisioVersao As VBLibrary.VB6Label
    Public WithEvents lblChavePublisherVersao As VBLibrary.VB6Label
    Public WithEvents lblChavePowerPointVersao As VBLibrary.VB6Label
    Public WithEvents lblChaveOutlookVersao As VBLibrary.VB6Label
    Public WithEvents lblChaveAccessVersao As VBLibrary.VB6Label
    Public WithEvents lblChaveWordVersao As VBLibrary.VB6Label
    Public WithEvents lblChaveExcelVersao As VBLibrary.VB6Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtChaveOneNoteVersao = New VBLibrary.VB6TextBox()
        Me.txtChaveMSProjectVersao = New VBLibrary.VB6TextBox()
        Me.txtChaveVisioVersao = New VBLibrary.VB6TextBox()
        Me.txtChavePublisherVersao = New VBLibrary.VB6TextBox()
        Me.txtChavePowerPointVersao = New VBLibrary.VB6TextBox()
        Me.txtChaveOutlookVersao = New VBLibrary.VB6TextBox()
        Me.txtChaveAccessVersao = New VBLibrary.VB6TextBox()
        Me.txtChaveWordVersao = New VBLibrary.VB6TextBox()
        Me.txtChaveExcelVersao = New VBLibrary.VB6TextBox()
        Me.cmdLerChaves = New VBLibrary.VB6CommandButton()
        Me.lblChaveOneNoteVersao = New VBLibrary.VB6Label()
        Me.lblChaveMSProjectVersao = New VBLibrary.VB6Label()
        Me.lblChaveVisioVersao = New VBLibrary.VB6Label()
        Me.lblChavePublisherVersao = New VBLibrary.VB6Label()
        Me.lblChavePowerPointVersao = New VBLibrary.VB6Label()
        Me.lblChaveOutlookVersao = New VBLibrary.VB6Label()
        Me.lblChaveAccessVersao = New VBLibrary.VB6Label()
        Me.lblChaveWordVersao = New VBLibrary.VB6Label()
        Me.lblChaveExcelVersao = New VBLibrary.VB6Label()
        Me.SuspendLayout()
        '
        'txtChaveOneNoteVersao
        '
        Me.txtChaveOneNoteVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveOneNoteVersao.Location = New System.Drawing.Point(173, 60)
        Me.txtChaveOneNoteVersao.Name = "txtChaveOneNoteVersao"
        Me.txtChaveOneNoteVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveOneNoteVersao.TabIndex = 17
        '
        'txtChaveMSProjectVersao
        '
        Me.txtChaveMSProjectVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveMSProjectVersao.Location = New System.Drawing.Point(173, 132)
        Me.txtChaveMSProjectVersao.Name = "txtChaveMSProjectVersao"
        Me.txtChaveMSProjectVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveMSProjectVersao.TabIndex = 15
        '
        'txtChaveVisioVersao
        '
        Me.txtChaveVisioVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveVisioVersao.Location = New System.Drawing.Point(173, 180)
        Me.txtChaveVisioVersao.Name = "txtChaveVisioVersao"
        Me.txtChaveVisioVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveVisioVersao.TabIndex = 13
        '
        'txtChavePublisherVersao
        '
        Me.txtChavePublisherVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChavePublisherVersao.Location = New System.Drawing.Point(173, 156)
        Me.txtChavePublisherVersao.Name = "txtChavePublisherVersao"
        Me.txtChavePublisherVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChavePublisherVersao.TabIndex = 11
        '
        'txtChavePowerPointVersao
        '
        Me.txtChavePowerPointVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChavePowerPointVersao.Location = New System.Drawing.Point(173, 108)
        Me.txtChavePowerPointVersao.Name = "txtChavePowerPointVersao"
        Me.txtChavePowerPointVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChavePowerPointVersao.TabIndex = 9
        '
        'txtChaveOutlookVersao
        '
        Me.txtChaveOutlookVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveOutlookVersao.Location = New System.Drawing.Point(173, 84)
        Me.txtChaveOutlookVersao.Name = "txtChaveOutlookVersao"
        Me.txtChaveOutlookVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveOutlookVersao.TabIndex = 7
        '
        'txtChaveAccessVersao
        '
        Me.txtChaveAccessVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveAccessVersao.Location = New System.Drawing.Point(173, 12)
        Me.txtChaveAccessVersao.Name = "txtChaveAccessVersao"
        Me.txtChaveAccessVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveAccessVersao.TabIndex = 5
        '
        'txtChaveWordVersao
        '
        Me.txtChaveWordVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveWordVersao.Location = New System.Drawing.Point(173, 204)
        Me.txtChaveWordVersao.Name = "txtChaveWordVersao"
        Me.txtChaveWordVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveWordVersao.TabIndex = 3
        '
        'txtChaveExcelVersao
        '
        Me.txtChaveExcelVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveExcelVersao.Location = New System.Drawing.Point(173, 36)
        Me.txtChaveExcelVersao.Name = "txtChaveExcelVersao"
        Me.txtChaveExcelVersao.Size = New System.Drawing.Size(305, 20)
        Me.txtChaveExcelVersao.TabIndex = 2
        '
        'cmdLerChaves
        '
        Me.cmdLerChaves.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLerChaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLerChaves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLerChaves.Location = New System.Drawing.Point(397, 232)
        Me.cmdLerChaves.Name = "cmdLerChaves"
        Me.cmdLerChaves.Size = New System.Drawing.Size(81, 25)
        Me.cmdLerChaves.TabIndex = 0
        Me.cmdLerChaves.Text = "Ler &Chaves"
        Me.cmdLerChaves.UseVisualStyleBackColor = False
        '
        'lblChaveOneNoteVersao
        '
        Me.lblChaveOneNoteVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveOneNoteVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveOneNoteVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveOneNoteVersao.Location = New System.Drawing.Point(8, 64)
        Me.lblChaveOneNoteVersao.Name = "lblChaveOneNoteVersao"
        Me.lblChaveOneNoteVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveOneNoteVersao.TabIndex = 18
        Me.lblChaveOneNoteVersao.Text = "Chave do OneNote/Versão:"
        '
        'lblChaveMSProjectVersao
        '
        Me.lblChaveMSProjectVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveMSProjectVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveMSProjectVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveMSProjectVersao.Location = New System.Drawing.Point(8, 136)
        Me.lblChaveMSProjectVersao.Name = "lblChaveMSProjectVersao"
        Me.lblChaveMSProjectVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveMSProjectVersao.TabIndex = 16
        Me.lblChaveMSProjectVersao.Text = "Chave do MSProject/Versão:"
        '
        'lblChaveVisioVersao
        '
        Me.lblChaveVisioVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveVisioVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveVisioVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveVisioVersao.Location = New System.Drawing.Point(8, 184)
        Me.lblChaveVisioVersao.Name = "lblChaveVisioVersao"
        Me.lblChaveVisioVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveVisioVersao.TabIndex = 14
        Me.lblChaveVisioVersao.Text = "Chave do Visio/Versão:"
        '
        'lblChavePublisherVersao
        '
        Me.lblChavePublisherVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChavePublisherVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChavePublisherVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChavePublisherVersao.Location = New System.Drawing.Point(8, 160)
        Me.lblChavePublisherVersao.Name = "lblChavePublisherVersao"
        Me.lblChavePublisherVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChavePublisherVersao.TabIndex = 12
        Me.lblChavePublisherVersao.Text = "Chave do Publisher/Versão:"
        '
        'lblChavePowerPointVersao
        '
        Me.lblChavePowerPointVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChavePowerPointVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChavePowerPointVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChavePowerPointVersao.Location = New System.Drawing.Point(8, 112)
        Me.lblChavePowerPointVersao.Name = "lblChavePowerPointVersao"
        Me.lblChavePowerPointVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChavePowerPointVersao.TabIndex = 10
        Me.lblChavePowerPointVersao.Text = "Chave do PowerPoint/Versão:"
        '
        'lblChaveOutlookVersao
        '
        Me.lblChaveOutlookVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveOutlookVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveOutlookVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveOutlookVersao.Location = New System.Drawing.Point(8, 88)
        Me.lblChaveOutlookVersao.Name = "lblChaveOutlookVersao"
        Me.lblChaveOutlookVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveOutlookVersao.TabIndex = 8
        Me.lblChaveOutlookVersao.Text = "Chave do Outlook/Versão:"
        '
        'lblChaveAccessVersao
        '
        Me.lblChaveAccessVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveAccessVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveAccessVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveAccessVersao.Location = New System.Drawing.Point(8, 16)
        Me.lblChaveAccessVersao.Name = "lblChaveAccessVersao"
        Me.lblChaveAccessVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveAccessVersao.TabIndex = 6
        Me.lblChaveAccessVersao.Text = "Chave do Access/Versão:"
        '
        'lblChaveWordVersao
        '
        Me.lblChaveWordVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveWordVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveWordVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveWordVersao.Location = New System.Drawing.Point(8, 208)
        Me.lblChaveWordVersao.Name = "lblChaveWordVersao"
        Me.lblChaveWordVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveWordVersao.TabIndex = 4
        Me.lblChaveWordVersao.Text = "Chave do Word/Versão:"
        '
        'lblChaveExcelVersao
        '
        Me.lblChaveExcelVersao.BackColor = System.Drawing.SystemColors.Control
        Me.lblChaveExcelVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveExcelVersao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChaveExcelVersao.Location = New System.Drawing.Point(8, 40)
        Me.lblChaveExcelVersao.Name = "lblChaveExcelVersao"
        Me.lblChaveExcelVersao.Size = New System.Drawing.Size(159, 17)
        Me.lblChaveExcelVersao.TabIndex = 1
        Me.lblChaveExcelVersao.Text = "Chave do Excel/Versão:"
        '
        'frmLerChaveOffice
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = VBLibrary.VBRUN.FormBorderStyleConstants.vbFixedSingle
        Me.ClientSize = New System.Drawing.Size(490, 264)
        Me.Controls.Add(Me.txtChaveOneNoteVersao)
        Me.Controls.Add(Me.txtChaveMSProjectVersao)
        Me.Controls.Add(Me.txtChaveVisioVersao)
        Me.Controls.Add(Me.txtChavePublisherVersao)
        Me.Controls.Add(Me.txtChavePowerPointVersao)
        Me.Controls.Add(Me.txtChaveOutlookVersao)
        Me.Controls.Add(Me.txtChaveAccessVersao)
        Me.Controls.Add(Me.txtChaveWordVersao)
        Me.Controls.Add(Me.txtChaveExcelVersao)
        Me.Controls.Add(Me.cmdLerChaves)
        Me.Controls.Add(Me.lblChaveOneNoteVersao)
        Me.Controls.Add(Me.lblChaveMSProjectVersao)
        Me.Controls.Add(Me.lblChaveVisioVersao)
        Me.Controls.Add(Me.lblChavePublisherVersao)
        Me.Controls.Add(Me.lblChavePowerPointVersao)
        Me.Controls.Add(Me.lblChaveOutlookVersao)
        Me.Controls.Add(Me.lblChaveAccessVersao)
        Me.Controls.Add(Me.lblChaveWordVersao)
        Me.Controls.Add(Me.lblChaveExcelVersao)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DrawMode = VBLibrary.VBRUN.DrawModeConstants.vbCopyPen
        Me.DrawStyle = VBLibrary.VBRUN.DrawStyleConstants.vbSolid
        Me.FillStyle = VBLibrary.VBRUN.FillStyleConstants.vbFSTransparent
        Me.Location = New System.Drawing.Point(103, 208)
        Me.MaxButton = False
        Me.MinButton = False
        Me.MinimizeBox = False
        Me.MousePointer = VBLibrary.VBRUN.MousePointerConstants.vbDefault
        Me.Name = "frmLerChaveOffice"
        Me.OLEDropMode = VBLibrary.VBRUN.OLEDropConstants.vbOLEDropNone
        Me.ScaleMode = VBLibrary.VBRUN.ScaleModeConstants.vbTwips
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ler Chave Office"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


End Class
