Option Explicit On
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class frmMidiPiano
    Inherits System.Windows.Forms.Form


#Region "Windows Form Designer generated code "
    Public Sub New()

        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private WithEvents vsbVolume As System.Windows.Forms.VScrollBar
    Public WithEvents _key_15 As System.Windows.Forms.CheckBox
    Public WithEvents _key_13 As System.Windows.Forms.CheckBox
    Public WithEvents _key_10 As System.Windows.Forms.CheckBox
    Public WithEvents _key_8 As System.Windows.Forms.CheckBox
    Public WithEvents _key_6 As System.Windows.Forms.CheckBox
    Public WithEvents _key_3 As System.Windows.Forms.CheckBox
    Public WithEvents _key_1 As System.Windows.Forms.CheckBox
    Public WithEvents _key_16 As System.Windows.Forms.CheckBox
    Public WithEvents _key_14 As System.Windows.Forms.CheckBox
    Public WithEvents _key_12 As System.Windows.Forms.CheckBox
    Public WithEvents _key_11 As System.Windows.Forms.CheckBox
    Public WithEvents _key_9 As System.Windows.Forms.CheckBox
    Public WithEvents _key_7 As System.Windows.Forms.CheckBox
    Public WithEvents _key_5 As System.Windows.Forms.CheckBox
    Public WithEvents _key_4 As System.Windows.Forms.CheckBox
    Public WithEvents _key_2 As System.Windows.Forms.CheckBox
    Public WithEvents _key_0 As System.Windows.Forms.CheckBox
    Private WithEvents lblVolume As System.Windows.Forms.Label
    Public WithEvents mnuDevice0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice3 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice4 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice5 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice6 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice7 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice8 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice9 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice10 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel3 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel4 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel5 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel6 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel7 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel8 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel9 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel10 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel11 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel12 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel13 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel14 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel15 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel As System.Windows.Forms.MenuItem
    Public WithEvents mnuBaseNote As System.Windows.Forms.MenuItem
    Public mnuMain As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Private WithEvents btnPlay As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents btnRecord As System.Windows.Forms.Button
    Private WithEvents btnRemoveSilence As System.Windows.Forms.Button
    Friend WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents lblSeqSlow As System.Windows.Forms.Label
    Friend WithEvents lblSeqNormal As System.Windows.Forms.Label
    Friend WithEvents lblSeqFast As System.Windows.Forms.Label
    Friend WithEvents gbxInstrument As System.Windows.Forms.GroupBox
    Friend WithEvents tbBankMSB As System.Windows.Forms.TrackBar
    Friend WithEvents tbInstrument As System.Windows.Forms.TrackBar
    Friend WithEvents lblBankMSB As System.Windows.Forms.Label
    Friend WithEvents tmrSequencer As System.Windows.Forms.Timer
    Friend WithEvents tclMidiFunction As System.Windows.Forms.TabControl
    Friend WithEvents tabSequencer As System.Windows.Forms.TabPage
    Friend WithEvents tabDrumMachine As System.Windows.Forms.TabPage
    Friend WithEvents tabWhiteboard As System.Windows.Forms.TabPage
    Friend WithEvents gbxXAxis As System.Windows.Forms.GroupBox
    Friend WithEvents lblXValue As System.Windows.Forms.Label
    Friend WithEvents cboXTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblXTitle As System.Windows.Forms.Label
    Friend WithEvents lblXCaption As System.Windows.Forms.Label
    Friend WithEvents picWhiteboard As System.Windows.Forms.PictureBox
    Friend WithEvents gbxYAxis As System.Windows.Forms.GroupBox
    Friend WithEvents cboYTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblYTitle As System.Windows.Forms.Label
    Friend WithEvents lblYCaption As System.Windows.Forms.Label
    Friend WithEvents lblYValue As System.Windows.Forms.Label
    Public WithEvents picDrum As System.Windows.Forms.PictureBox
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpenMidi As System.Windows.Forms.MenuItem
    Public WithEvents tmrDrumPlayback As System.Windows.Forms.Timer
    Friend WithEvents lbICenter As System.Windows.Forms.Label
    Friend WithEvents lbIRight As System.Windows.Forms.Label
    Friend WithEvents lbILeft As System.Windows.Forms.Label
    Friend WithEvents tbPanning As System.Windows.Forms.TrackBar
    Friend WithEvents lbIPanning As System.Windows.Forms.Label
    Friend WithEvents gbxPlayMode As System.Windows.Forms.GroupBox
    Friend WithEvents rbChord As System.Windows.Forms.RadioButton
    Friend WithEvents rbNote As System.Windows.Forms.RadioButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents vsbTransposePitch As System.Windows.Forms.VScrollBar
    Friend WithEvents mnuSaveMidi As System.Windows.Forms.MenuItem
    Friend WithEvents lbTransposePitch As System.Windows.Forms.Label
    Friend WithEvents gbxDrumRowSize As System.Windows.Forms.GroupBox
    Friend WithEvents btnDrumDelCol As System.Windows.Forms.Button
    Friend WithEvents btnDrumAddCol As System.Windows.Forms.Button
    Friend WithEvents btnDrumDelRow As System.Windows.Forms.Button
    Friend WithEvents btnDrumAddRow As System.Windows.Forms.Button
    Friend WithEvents gbxDrumPlay As System.Windows.Forms.GroupBox
    Friend WithEvents btnDrumReset As System.Windows.Forms.Button
    Public WithEvents btnDrumStart As System.Windows.Forms.Button
    Public WithEvents btnDrumStop As System.Windows.Forms.Button
    Friend WithEvents gbxDrumSpeed As System.Windows.Forms.GroupBox
    Friend WithEvents tbDrumSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents gbxDrumSelection As System.Windows.Forms.GroupBox
    Friend WithEvents cbDrumType As System.Windows.Forms.ComboBox
    Friend WithEvents cbDrumNo As System.Windows.Forms.ComboBox
    Friend WithEvents gbxDrumColSize As System.Windows.Forms.GroupBox
    Friend WithEvents mnuOpenDrum As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSaveDrum As System.Windows.Forms.MenuItem
    Friend WithEvents gbxPlaySpeed As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLoop As System.Windows.Forms.CheckBox
    Friend WithEvents btnPlayAll As System.Windows.Forms.Button
    Friend WithEvents btnStopAll As System.Windows.Forms.Button
    Friend WithEvents lbPitchBend As System.Windows.Forms.Label
    Friend WithEvents vsbPitchBend As System.Windows.Forms.VScrollBar
    Friend WithEvents lblInstrument As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.vsbVolume = New System.Windows.Forms.VScrollBar()
        Me._key_15 = New System.Windows.Forms.CheckBox()
        Me._key_13 = New System.Windows.Forms.CheckBox()
        Me._key_10 = New System.Windows.Forms.CheckBox()
        Me._key_8 = New System.Windows.Forms.CheckBox()
        Me._key_6 = New System.Windows.Forms.CheckBox()
        Me._key_3 = New System.Windows.Forms.CheckBox()
        Me._key_1 = New System.Windows.Forms.CheckBox()
        Me._key_16 = New System.Windows.Forms.CheckBox()
        Me._key_14 = New System.Windows.Forms.CheckBox()
        Me._key_12 = New System.Windows.Forms.CheckBox()
        Me._key_11 = New System.Windows.Forms.CheckBox()
        Me._key_9 = New System.Windows.Forms.CheckBox()
        Me._key_7 = New System.Windows.Forms.CheckBox()
        Me._key_5 = New System.Windows.Forms.CheckBox()
        Me._key_4 = New System.Windows.Forms.CheckBox()
        Me._key_2 = New System.Windows.Forms.CheckBox()
        Me._key_0 = New System.Windows.Forms.CheckBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.mnuChannel0 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel1 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel2 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel3 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel4 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel5 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel6 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel7 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel8 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel9 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel10 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel11 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel12 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel13 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel14 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel15 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice0 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice1 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice2 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice3 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice4 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice5 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice6 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice7 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice8 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice9 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice10 = New System.Windows.Forms.MenuItem()
        Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuOpenMidi = New System.Windows.Forms.MenuItem()
        Me.mnuSaveMidi = New System.Windows.Forms.MenuItem()
        Me.mnuOpenDrum = New System.Windows.Forms.MenuItem()
        Me.mnuSaveDrum = New System.Windows.Forms.MenuItem()
        Me.mnuDevice = New System.Windows.Forms.MenuItem()
        Me.mnuChannel = New System.Windows.Forms.MenuItem()
        Me.mnuBaseNote = New System.Windows.Forms.MenuItem()
        Me.lblSeqFast = New System.Windows.Forms.Label()
        Me.lblSeqNormal = New System.Windows.Forms.Label()
        Me.lblSeqSlow = New System.Windows.Forms.Label()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.btnRemoveSilence = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.gbxInstrument = New System.Windows.Forms.GroupBox()
        Me.lbICenter = New System.Windows.Forms.Label()
        Me.lbIRight = New System.Windows.Forms.Label()
        Me.lbILeft = New System.Windows.Forms.Label()
        Me.tbPanning = New System.Windows.Forms.TrackBar()
        Me.lbIPanning = New System.Windows.Forms.Label()
        Me.tbBankMSB = New System.Windows.Forms.TrackBar()
        Me.tbInstrument = New System.Windows.Forms.TrackBar()
        Me.lblBankMSB = New System.Windows.Forms.Label()
        Me.lblInstrument = New System.Windows.Forms.Label()
        Me.tmrSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.tclMidiFunction = New System.Windows.Forms.TabControl()
        Me.tabSequencer = New System.Windows.Forms.TabPage()
        Me.lbPitchBend = New System.Windows.Forms.Label()
        Me.vsbPitchBend = New System.Windows.Forms.VScrollBar()
        Me.vsbTransposePitch = New System.Windows.Forms.VScrollBar()
        Me.gbxPlaySpeed = New System.Windows.Forms.GroupBox()
        Me.cbxLoop = New System.Windows.Forms.CheckBox()
        Me.lbTransposePitch = New System.Windows.Forms.Label()
        Me.tabWhiteboard = New System.Windows.Forms.TabPage()
        Me.gbxXAxis = New System.Windows.Forms.GroupBox()
        Me.lblXValue = New System.Windows.Forms.Label()
        Me.cboXTitle = New System.Windows.Forms.ComboBox()
        Me.lblXTitle = New System.Windows.Forms.Label()
        Me.lblXCaption = New System.Windows.Forms.Label()
        Me.picWhiteboard = New System.Windows.Forms.PictureBox()
        Me.gbxYAxis = New System.Windows.Forms.GroupBox()
        Me.cboYTitle = New System.Windows.Forms.ComboBox()
        Me.lblYTitle = New System.Windows.Forms.Label()
        Me.lblYCaption = New System.Windows.Forms.Label()
        Me.lblYValue = New System.Windows.Forms.Label()
        Me.tabDrumMachine = New System.Windows.Forms.TabPage()
        Me.gbxDrumColSize = New System.Windows.Forms.GroupBox()
        Me.btnDrumDelCol = New System.Windows.Forms.Button()
        Me.btnDrumAddCol = New System.Windows.Forms.Button()
        Me.gbxDrumSelection = New System.Windows.Forms.GroupBox()
        Me.cbDrumType = New System.Windows.Forms.ComboBox()
        Me.cbDrumNo = New System.Windows.Forms.ComboBox()
        Me.gbxDrumSpeed = New System.Windows.Forms.GroupBox()
        Me.tbDrumSpeed = New System.Windows.Forms.TrackBar()
        Me.gbxDrumRowSize = New System.Windows.Forms.GroupBox()
        Me.btnDrumDelRow = New System.Windows.Forms.Button()
        Me.btnDrumAddRow = New System.Windows.Forms.Button()
        Me.gbxDrumPlay = New System.Windows.Forms.GroupBox()
        Me.btnDrumReset = New System.Windows.Forms.Button()
        Me.btnDrumStart = New System.Windows.Forms.Button()
        Me.btnDrumStop = New System.Windows.Forms.Button()
        Me.picDrum = New System.Windows.Forms.PictureBox()
        Me.tmrDrumPlayback = New System.Windows.Forms.Timer(Me.components)
        Me.gbxPlayMode = New System.Windows.Forms.GroupBox()
        Me.rbChord = New System.Windows.Forms.RadioButton()
        Me.rbNote = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPlayAll = New System.Windows.Forms.Button()
        Me.btnStopAll = New System.Windows.Forms.Button()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInstrument.SuspendLayout()
        CType(Me.tbPanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBankMSB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tclMidiFunction.SuspendLayout()
        Me.tabSequencer.SuspendLayout()
        Me.gbxPlaySpeed.SuspendLayout()
        Me.tabWhiteboard.SuspendLayout()
        Me.gbxXAxis.SuspendLayout()
        CType(Me.picWhiteboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxYAxis.SuspendLayout()
        Me.tabDrumMachine.SuspendLayout()
        Me.gbxDrumColSize.SuspendLayout()
        Me.gbxDrumSelection.SuspendLayout()
        Me.gbxDrumSpeed.SuspendLayout()
        CType(Me.tbDrumSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDrumRowSize.SuspendLayout()
        Me.gbxDrumPlay.SuspendLayout()
        CType(Me.picDrum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPlayMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsbVolume
        '
        Me.vsbVolume.LargeChange = 1
        Me.vsbVolume.Location = New System.Drawing.Point(12, 25)
        Me.vsbVolume.Maximum = 127
        Me.vsbVolume.Name = "vsbVolume"
        Me.vsbVolume.Size = New System.Drawing.Size(50, 124)
        Me.vsbVolume.TabIndex = 17
        Me.vsbVolume.TabStop = True
        '
        '_key_15
        '
        Me._key_15.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_15.BackColor = System.Drawing.Color.Black
        Me._key_15.ForeColor = System.Drawing.Color.White
        Me._key_15.Location = New System.Drawing.Point(354, 12)
        Me._key_15.Name = "_key_15"
        Me._key_15.Size = New System.Drawing.Size(17, 84)
        Me._key_15.TabIndex = 16
        Me._key_15.Text = ";"
        Me._key_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_15.UseVisualStyleBackColor = False
        '
        '_key_13
        '
        Me._key_13.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_13.BackColor = System.Drawing.Color.Black
        Me._key_13.ForeColor = System.Drawing.Color.White
        Me._key_13.Location = New System.Drawing.Point(322, 12)
        Me._key_13.Name = "_key_13"
        Me._key_13.Size = New System.Drawing.Size(17, 84)
        Me._key_13.TabIndex = 15
        Me._key_13.Text = "L"
        Me._key_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_13.UseVisualStyleBackColor = False
        '
        '_key_10
        '
        Me._key_10.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_10.BackColor = System.Drawing.Color.Black
        Me._key_10.ForeColor = System.Drawing.Color.White
        Me._key_10.Location = New System.Drawing.Point(258, 12)
        Me._key_10.Name = "_key_10"
        Me._key_10.Size = New System.Drawing.Size(17, 84)
        Me._key_10.TabIndex = 14
        Me._key_10.Text = "J"
        Me._key_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_10.UseVisualStyleBackColor = False
        '
        '_key_8
        '
        Me._key_8.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_8.BackColor = System.Drawing.Color.Black
        Me._key_8.ForeColor = System.Drawing.Color.White
        Me._key_8.Location = New System.Drawing.Point(226, 12)
        Me._key_8.Name = "_key_8"
        Me._key_8.Size = New System.Drawing.Size(17, 84)
        Me._key_8.TabIndex = 13
        Me._key_8.Text = "H"
        Me._key_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_8.UseVisualStyleBackColor = False
        '
        '_key_6
        '
        Me._key_6.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_6.BackColor = System.Drawing.Color.Black
        Me._key_6.ForeColor = System.Drawing.Color.White
        Me._key_6.Location = New System.Drawing.Point(194, 12)
        Me._key_6.Name = "_key_6"
        Me._key_6.Size = New System.Drawing.Size(17, 84)
        Me._key_6.TabIndex = 12
        Me._key_6.Text = "G"
        Me._key_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_6.UseVisualStyleBackColor = False
        '
        '_key_3
        '
        Me._key_3.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_3.BackColor = System.Drawing.Color.Black
        Me._key_3.ForeColor = System.Drawing.Color.White
        Me._key_3.Location = New System.Drawing.Point(130, 12)
        Me._key_3.Name = "_key_3"
        Me._key_3.Size = New System.Drawing.Size(17, 84)
        Me._key_3.TabIndex = 11
        Me._key_3.Text = "D"
        Me._key_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_3.UseVisualStyleBackColor = False
        '
        '_key_1
        '
        Me._key_1.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_1.BackColor = System.Drawing.Color.Black
        Me._key_1.ForeColor = System.Drawing.Color.White
        Me._key_1.Location = New System.Drawing.Point(98, 12)
        Me._key_1.Name = "_key_1"
        Me._key_1.Size = New System.Drawing.Size(17, 84)
        Me._key_1.TabIndex = 10
        Me._key_1.Text = "S"
        Me._key_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_1.UseVisualStyleBackColor = False
        '
        '_key_16
        '
        Me._key_16.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_16.BackColor = System.Drawing.Color.White
        Me._key_16.ForeColor = System.Drawing.Color.Black
        Me._key_16.Location = New System.Drawing.Point(362, 12)
        Me._key_16.Name = "_key_16"
        Me._key_16.Size = New System.Drawing.Size(33, 137)
        Me._key_16.TabIndex = 9
        Me._key_16.Text = "/"
        Me._key_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_16.UseVisualStyleBackColor = False
        '
        '_key_14
        '
        Me._key_14.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_14.BackColor = System.Drawing.Color.White
        Me._key_14.ForeColor = System.Drawing.Color.Black
        Me._key_14.Location = New System.Drawing.Point(330, 12)
        Me._key_14.Name = "_key_14"
        Me._key_14.Size = New System.Drawing.Size(33, 137)
        Me._key_14.TabIndex = 8
        Me._key_14.Text = "."
        Me._key_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_14.UseVisualStyleBackColor = False
        '
        '_key_12
        '
        Me._key_12.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_12.BackColor = System.Drawing.Color.White
        Me._key_12.ForeColor = System.Drawing.Color.Black
        Me._key_12.Location = New System.Drawing.Point(298, 12)
        Me._key_12.Name = "_key_12"
        Me._key_12.Size = New System.Drawing.Size(33, 137)
        Me._key_12.TabIndex = 7
        Me._key_12.Text = ","
        Me._key_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_12.UseVisualStyleBackColor = False
        '
        '_key_11
        '
        Me._key_11.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_11.BackColor = System.Drawing.Color.White
        Me._key_11.ForeColor = System.Drawing.Color.Black
        Me._key_11.Location = New System.Drawing.Point(266, 12)
        Me._key_11.Name = "_key_11"
        Me._key_11.Size = New System.Drawing.Size(33, 137)
        Me._key_11.TabIndex = 6
        Me._key_11.Text = "M"
        Me._key_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_11.UseVisualStyleBackColor = False
        '
        '_key_9
        '
        Me._key_9.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_9.BackColor = System.Drawing.Color.White
        Me._key_9.ForeColor = System.Drawing.Color.Black
        Me._key_9.Location = New System.Drawing.Point(234, 12)
        Me._key_9.Name = "_key_9"
        Me._key_9.Size = New System.Drawing.Size(33, 137)
        Me._key_9.TabIndex = 5
        Me._key_9.Text = "N"
        Me._key_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_9.UseVisualStyleBackColor = False
        '
        '_key_7
        '
        Me._key_7.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_7.BackColor = System.Drawing.Color.White
        Me._key_7.ForeColor = System.Drawing.Color.Black
        Me._key_7.Location = New System.Drawing.Point(202, 12)
        Me._key_7.Name = "_key_7"
        Me._key_7.Size = New System.Drawing.Size(33, 137)
        Me._key_7.TabIndex = 4
        Me._key_7.Text = "B"
        Me._key_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_7.UseVisualStyleBackColor = False
        '
        '_key_5
        '
        Me._key_5.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_5.BackColor = System.Drawing.Color.White
        Me._key_5.ForeColor = System.Drawing.Color.Black
        Me._key_5.Location = New System.Drawing.Point(170, 12)
        Me._key_5.Name = "_key_5"
        Me._key_5.Size = New System.Drawing.Size(33, 137)
        Me._key_5.TabIndex = 3
        Me._key_5.Text = "V"
        Me._key_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_5.UseVisualStyleBackColor = False
        '
        '_key_4
        '
        Me._key_4.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_4.BackColor = System.Drawing.Color.White
        Me._key_4.ForeColor = System.Drawing.Color.Black
        Me._key_4.Location = New System.Drawing.Point(138, 12)
        Me._key_4.Name = "_key_4"
        Me._key_4.Size = New System.Drawing.Size(33, 137)
        Me._key_4.TabIndex = 2
        Me._key_4.Text = "C"
        Me._key_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_4.UseVisualStyleBackColor = False
        '
        '_key_2
        '
        Me._key_2.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_2.BackColor = System.Drawing.Color.White
        Me._key_2.ForeColor = System.Drawing.Color.Black
        Me._key_2.Location = New System.Drawing.Point(106, 12)
        Me._key_2.Name = "_key_2"
        Me._key_2.Size = New System.Drawing.Size(33, 137)
        Me._key_2.TabIndex = 1
        Me._key_2.Text = "X"
        Me._key_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_2.UseVisualStyleBackColor = False
        '
        '_key_0
        '
        Me._key_0.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_0.BackColor = System.Drawing.Color.White
        Me._key_0.ForeColor = System.Drawing.Color.Black
        Me._key_0.Location = New System.Drawing.Point(74, 12)
        Me._key_0.Name = "_key_0"
        Me._key_0.Size = New System.Drawing.Size(33, 137)
        Me._key_0.TabIndex = 0
        Me._key_0.Text = "Z"
        Me._key_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_0.UseVisualStyleBackColor = False
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(16, 12)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(42, 13)
        Me.lblVolume.TabIndex = 18
        Me.lblVolume.Text = "Volume"
        '
        'mnuChannel0
        '
        Me.mnuChannel0.Index = 0
        Me.mnuChannel0.Text = "1"
        '
        'mnuChannel1
        '
        Me.mnuChannel1.Index = 1
        Me.mnuChannel1.Text = "2"
        '
        'mnuChannel2
        '
        Me.mnuChannel2.Index = 2
        Me.mnuChannel2.Text = "3"
        '
        'mnuChannel3
        '
        Me.mnuChannel3.Index = 3
        Me.mnuChannel3.Text = "4"
        '
        'mnuChannel4
        '
        Me.mnuChannel4.Index = 4
        Me.mnuChannel4.Text = "5"
        '
        'mnuChannel5
        '
        Me.mnuChannel5.Index = 5
        Me.mnuChannel5.Text = "6"
        '
        'mnuChannel6
        '
        Me.mnuChannel6.Index = 6
        Me.mnuChannel6.Text = "7"
        '
        'mnuChannel7
        '
        Me.mnuChannel7.Index = 7
        Me.mnuChannel7.Text = "8"
        '
        'mnuChannel8
        '
        Me.mnuChannel8.Index = 8
        Me.mnuChannel8.Text = "9"
        '
        'mnuChannel9
        '
        Me.mnuChannel9.Index = 9
        Me.mnuChannel9.Text = "10"
        '
        'mnuChannel10
        '
        Me.mnuChannel10.Index = 10
        Me.mnuChannel10.Text = "11"
        '
        'mnuChannel11
        '
        Me.mnuChannel11.Index = 11
        Me.mnuChannel11.Text = "12"
        '
        'mnuChannel12
        '
        Me.mnuChannel12.Index = 12
        Me.mnuChannel12.Text = "13"
        '
        'mnuChannel13
        '
        Me.mnuChannel13.Index = 13
        Me.mnuChannel13.Text = "14"
        '
        'mnuChannel14
        '
        Me.mnuChannel14.Index = 14
        Me.mnuChannel14.Text = "15"
        '
        'mnuChannel15
        '
        Me.mnuChannel15.Index = 15
        Me.mnuChannel15.Text = "16"
        '
        'mnuDevice0
        '
        Me.mnuDevice0.Index = 0
        Me.mnuDevice0.Text = ""
        '
        'mnuDevice1
        '
        Me.mnuDevice1.Enabled = False
        Me.mnuDevice1.Index = 1
        Me.mnuDevice1.Text = ""
        Me.mnuDevice1.Visible = False
        '
        'mnuDevice2
        '
        Me.mnuDevice2.Enabled = False
        Me.mnuDevice2.Index = 2
        Me.mnuDevice2.Text = ""
        Me.mnuDevice2.Visible = False
        '
        'mnuDevice3
        '
        Me.mnuDevice3.Enabled = False
        Me.mnuDevice3.Index = 3
        Me.mnuDevice3.Text = ""
        Me.mnuDevice3.Visible = False
        '
        'mnuDevice4
        '
        Me.mnuDevice4.Enabled = False
        Me.mnuDevice4.Index = 4
        Me.mnuDevice4.Text = ""
        Me.mnuDevice4.Visible = False
        '
        'mnuDevice5
        '
        Me.mnuDevice5.Enabled = False
        Me.mnuDevice5.Index = 5
        Me.mnuDevice5.Text = ""
        Me.mnuDevice5.Visible = False
        '
        'mnuDevice6
        '
        Me.mnuDevice6.Enabled = False
        Me.mnuDevice6.Index = 6
        Me.mnuDevice6.Text = ""
        Me.mnuDevice6.Visible = False
        '
        'mnuDevice7
        '
        Me.mnuDevice7.Enabled = False
        Me.mnuDevice7.Index = 7
        Me.mnuDevice7.Text = ""
        Me.mnuDevice7.Visible = False
        '
        'mnuDevice8
        '
        Me.mnuDevice8.Enabled = False
        Me.mnuDevice8.Index = 8
        Me.mnuDevice8.Text = ""
        Me.mnuDevice8.Visible = False
        '
        'mnuDevice9
        '
        Me.mnuDevice9.Enabled = False
        Me.mnuDevice9.Index = 9
        Me.mnuDevice9.Text = ""
        Me.mnuDevice9.Visible = False
        '
        'mnuDevice10
        '
        Me.mnuDevice10.Enabled = False
        Me.mnuDevice10.Index = 10
        Me.mnuDevice10.Text = ""
        Me.mnuDevice10.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuDevice, Me.mnuChannel, Me.mnuBaseNote})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpenMidi, Me.mnuSaveMidi, Me.mnuOpenDrum, Me.mnuSaveDrum})
        Me.mnuFile.Text = "Midi &File"
        '
        'mnuOpenMidi
        '
        Me.mnuOpenMidi.Index = 0
        Me.mnuOpenMidi.Text = "&Load My midi File"
        '
        'mnuSaveMidi
        '
        Me.mnuSaveMidi.Index = 1
        Me.mnuSaveMidi.Text = "&Save to My midi File"
        '
        'mnuOpenDrum
        '
        Me.mnuOpenDrum.Index = 2
        Me.mnuOpenDrum.Text = "Open Drum File"
        '
        'mnuSaveDrum
        '
        Me.mnuSaveDrum.Index = 3
        Me.mnuSaveDrum.Text = "Save to Drum File"
        '
        'mnuDevice
        '
        Me.mnuDevice.Index = 1
        Me.mnuDevice.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDevice0, Me.mnuDevice1, Me.mnuDevice2, Me.mnuDevice3, Me.mnuDevice4, Me.mnuDevice5, Me.mnuDevice6, Me.mnuDevice7, Me.mnuDevice8, Me.mnuDevice9, Me.mnuDevice10})
        Me.mnuDevice.Text = "Midi &Device"
        '
        'mnuChannel
        '
        Me.mnuChannel.Index = 2
        Me.mnuChannel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChannel0, Me.mnuChannel1, Me.mnuChannel2, Me.mnuChannel3, Me.mnuChannel4, Me.mnuChannel5, Me.mnuChannel6, Me.mnuChannel7, Me.mnuChannel8, Me.mnuChannel9, Me.mnuChannel10, Me.mnuChannel11, Me.mnuChannel12, Me.mnuChannel13, Me.mnuChannel14, Me.mnuChannel15})
        Me.mnuChannel.Text = "&Channel"
        '
        'mnuBaseNote
        '
        Me.mnuBaseNote.Index = 3
        Me.mnuBaseNote.Text = "&Base Note"
        '
        'lblSeqFast
        '
        Me.lblSeqFast.Location = New System.Drawing.Point(175, 60)
        Me.lblSeqFast.Name = "lblSeqFast"
        Me.lblSeqFast.Size = New System.Drawing.Size(34, 23)
        Me.lblSeqFast.TabIndex = 27
        Me.lblSeqFast.Text = "Fast"
        Me.lblSeqFast.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSeqNormal
        '
        Me.lblSeqNormal.Location = New System.Drawing.Point(85, 60)
        Me.lblSeqNormal.Name = "lblSeqNormal"
        Me.lblSeqNormal.Size = New System.Drawing.Size(50, 32)
        Me.lblSeqNormal.TabIndex = 26
        Me.lblSeqNormal.Text = "Normal Speed"
        Me.lblSeqNormal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeqSlow
        '
        Me.lblSeqSlow.Location = New System.Drawing.Point(8, 60)
        Me.lblSeqSlow.Name = "lblSeqSlow"
        Me.lblSeqSlow.Size = New System.Drawing.Size(34, 23)
        Me.lblSeqSlow.TabIndex = 25
        Me.lblSeqSlow.Text = "Slow"
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(11, 22)
        Me.tbSpeed.Maximum = 9
        Me.tbSpeed.Minimum = -9
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(198, 45)
        Me.tbSpeed.TabIndex = 24
        '
        'btnRemoveSilence
        '
        Me.btnRemoveSilence.Location = New System.Drawing.Point(12, 45)
        Me.btnRemoveSilence.Name = "btnRemoveSilence"
        Me.btnRemoveSilence.Size = New System.Drawing.Size(95, 25)
        Me.btnRemoveSilence.TabIndex = 23
        Me.btnRemoveSilence.Text = "Remove Silence"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(114, 45)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(95, 25)
        Me.btnPlay.TabIndex = 22
        Me.btnPlay.Text = "Play"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(115, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(95, 25)
        Me.btnStop.TabIndex = 21
        Me.btnStop.Text = "Stop"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(12, 12)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(95, 25)
        Me.btnRecord.TabIndex = 20
        Me.btnRecord.Text = "Record"
        '
        'gbxInstrument
        '
        Me.gbxInstrument.Controls.Add(Me.lbICenter)
        Me.gbxInstrument.Controls.Add(Me.lbIRight)
        Me.gbxInstrument.Controls.Add(Me.lbILeft)
        Me.gbxInstrument.Controls.Add(Me.tbPanning)
        Me.gbxInstrument.Controls.Add(Me.lbIPanning)
        Me.gbxInstrument.Controls.Add(Me.tbBankMSB)
        Me.gbxInstrument.Controls.Add(Me.tbInstrument)
        Me.gbxInstrument.Controls.Add(Me.lblBankMSB)
        Me.gbxInstrument.Controls.Add(Me.lblInstrument)
        Me.gbxInstrument.Location = New System.Drawing.Point(407, 8)
        Me.gbxInstrument.Name = "gbxInstrument"
        Me.gbxInstrument.Size = New System.Drawing.Size(373, 129)
        Me.gbxInstrument.TabIndex = 22
        Me.gbxInstrument.TabStop = False
        Me.gbxInstrument.Text = "MIDI Instrument"
        '
        'lbICenter
        '
        Me.lbICenter.AutoSize = True
        Me.lbICenter.BackColor = System.Drawing.Color.Transparent
        Me.lbICenter.Location = New System.Drawing.Point(203, 102)
        Me.lbICenter.Name = "lbICenter"
        Me.lbICenter.Size = New System.Drawing.Size(38, 13)
        Me.lbICenter.TabIndex = 69
        Me.lbICenter.Text = "Center"
        '
        'lbIRight
        '
        Me.lbIRight.AutoSize = True
        Me.lbIRight.BackColor = System.Drawing.Color.Transparent
        Me.lbIRight.Location = New System.Drawing.Point(312, 102)
        Me.lbIRight.Name = "lbIRight"
        Me.lbIRight.Size = New System.Drawing.Size(32, 13)
        Me.lbIRight.TabIndex = 68
        Me.lbIRight.Text = "Right"
        '
        'lbILeft
        '
        Me.lbILeft.AutoSize = True
        Me.lbILeft.BackColor = System.Drawing.Color.Transparent
        Me.lbILeft.Location = New System.Drawing.Point(94, 102)
        Me.lbILeft.Name = "lbILeft"
        Me.lbILeft.Size = New System.Drawing.Size(25, 13)
        Me.lbILeft.TabIndex = 67
        Me.lbILeft.Text = "Left"
        '
        'tbPanning
        '
        Me.tbPanning.Location = New System.Drawing.Point(75, 81)
        Me.tbPanning.Maximum = 64
        Me.tbPanning.Minimum = -63
        Me.tbPanning.Name = "tbPanning"
        Me.tbPanning.Size = New System.Drawing.Size(290, 45)
        Me.tbPanning.TabIndex = 66
        Me.tbPanning.TickFrequency = 64
        '
        'lbIPanning
        '
        Me.lbIPanning.AutoSize = True
        Me.lbIPanning.Location = New System.Drawing.Point(10, 83)
        Me.lbIPanning.Name = "lbIPanning"
        Me.lbIPanning.Size = New System.Drawing.Size(52, 13)
        Me.lbIPanning.TabIndex = 65
        Me.lbIPanning.Text = "Panning :"
        '
        'tbBankMSB
        '
        Me.tbBankMSB.LargeChange = 2
        Me.tbBankMSB.Location = New System.Drawing.Point(75, 51)
        Me.tbBankMSB.Maximum = 5
        Me.tbBankMSB.Name = "tbBankMSB"
        Me.tbBankMSB.Size = New System.Drawing.Size(290, 45)
        Me.tbBankMSB.TabIndex = 3
        '
        'tbInstrument
        '
        Me.tbInstrument.Location = New System.Drawing.Point(75, 19)
        Me.tbInstrument.Maximum = 127
        Me.tbInstrument.Name = "tbInstrument"
        Me.tbInstrument.Size = New System.Drawing.Size(290, 45)
        Me.tbInstrument.TabIndex = 2
        '
        'lblBankMSB
        '
        Me.lblBankMSB.AutoSize = True
        Me.lblBankMSB.Location = New System.Drawing.Point(10, 58)
        Me.lblBankMSB.Name = "lblBankMSB"
        Me.lblBankMSB.Size = New System.Drawing.Size(61, 13)
        Me.lblBankMSB.TabIndex = 1
        Me.lblBankMSB.Text = "Bank MSB:"
        '
        'lblInstrument
        '
        Me.lblInstrument.AutoSize = True
        Me.lblInstrument.Location = New System.Drawing.Point(10, 25)
        Me.lblInstrument.Name = "lblInstrument"
        Me.lblInstrument.Size = New System.Drawing.Size(59, 13)
        Me.lblInstrument.TabIndex = 0
        Me.lblInstrument.Text = "Instrument:"
        '
        'tmrSequencer
        '
        '
        'tclMidiFunction
        '
        Me.tclMidiFunction.Controls.Add(Me.tabSequencer)
        Me.tclMidiFunction.Controls.Add(Me.tabWhiteboard)
        Me.tclMidiFunction.Controls.Add(Me.tabDrumMachine)
        Me.tclMidiFunction.Location = New System.Drawing.Point(12, 160)
        Me.tclMidiFunction.Name = "tclMidiFunction"
        Me.tclMidiFunction.SelectedIndex = 0
        Me.tclMidiFunction.Size = New System.Drawing.Size(768, 393)
        Me.tclMidiFunction.TabIndex = 23
        '
        'tabSequencer
        '
        Me.tabSequencer.Controls.Add(Me.lbPitchBend)
        Me.tabSequencer.Controls.Add(Me.vsbPitchBend)
        Me.tabSequencer.Controls.Add(Me.vsbTransposePitch)
        Me.tabSequencer.Controls.Add(Me.gbxPlaySpeed)
        Me.tabSequencer.Controls.Add(Me.cbxLoop)
        Me.tabSequencer.Controls.Add(Me.lbTransposePitch)
        Me.tabSequencer.Controls.Add(Me.btnRecord)
        Me.tabSequencer.Controls.Add(Me.btnStop)
        Me.tabSequencer.Controls.Add(Me.btnPlay)
        Me.tabSequencer.Controls.Add(Me.btnRemoveSilence)
        Me.tabSequencer.Location = New System.Drawing.Point(4, 22)
        Me.tabSequencer.Name = "tabSequencer"
        Me.tabSequencer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSequencer.Size = New System.Drawing.Size(760, 367)
        Me.tabSequencer.TabIndex = 0
        Me.tabSequencer.Text = "MIDI Sequencer"
        Me.tabSequencer.UseVisualStyleBackColor = True
        '
        'lbPitchBend
        '
        Me.lbPitchBend.AutoSize = True
        Me.lbPitchBend.Location = New System.Drawing.Point(355, 11)
        Me.lbPitchBend.Name = "lbPitchBend"
        Me.lbPitchBend.Size = New System.Drawing.Size(32, 26)
        Me.lbPitchBend.TabIndex = 34
        Me.lbPitchBend.Text = "Pitch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bend"
        Me.lbPitchBend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vsbPitchBend
        '
        Me.vsbPitchBend.Location = New System.Drawing.Point(358, 45)
        Me.vsbPitchBend.Maximum = 8192
        Me.vsbPitchBend.Minimum = -8192
        Me.vsbPitchBend.Name = "vsbPitchBend"
        Me.vsbPitchBend.Size = New System.Drawing.Size(21, 160)
        Me.vsbPitchBend.TabIndex = 33
        '
        'vsbTransposePitch
        '
        Me.vsbTransposePitch.Location = New System.Drawing.Point(294, 45)
        Me.vsbTransposePitch.Maximum = 60
        Me.vsbTransposePitch.Minimum = -60
        Me.vsbTransposePitch.Name = "vsbTransposePitch"
        Me.vsbTransposePitch.Size = New System.Drawing.Size(21, 160)
        Me.vsbTransposePitch.TabIndex = 29
        '
        'gbxPlaySpeed
        '
        Me.gbxPlaySpeed.Controls.Add(Me.lblSeqSlow)
        Me.gbxPlaySpeed.Controls.Add(Me.lblSeqNormal)
        Me.gbxPlaySpeed.Controls.Add(Me.lblSeqFast)
        Me.gbxPlaySpeed.Controls.Add(Me.tbSpeed)
        Me.gbxPlaySpeed.Location = New System.Drawing.Point(12, 78)
        Me.gbxPlaySpeed.Name = "gbxPlaySpeed"
        Me.gbxPlaySpeed.Size = New System.Drawing.Size(220, 97)
        Me.gbxPlaySpeed.TabIndex = 32
        Me.gbxPlaySpeed.TabStop = False
        Me.gbxPlaySpeed.Text = "Play Speed"
        '
        'cbxLoop
        '
        Me.cbxLoop.AutoSize = True
        Me.cbxLoop.Location = New System.Drawing.Point(218, 50)
        Me.cbxLoop.Name = "cbxLoop"
        Me.cbxLoop.Size = New System.Drawing.Size(50, 17)
        Me.cbxLoop.TabIndex = 31
        Me.cbxLoop.Text = "Loop"
        Me.cbxLoop.UseVisualStyleBackColor = True
        '
        'lbTransposePitch
        '
        Me.lbTransposePitch.AutoSize = True
        Me.lbTransposePitch.Location = New System.Drawing.Point(274, 10)
        Me.lbTransposePitch.Name = "lbTransposePitch"
        Me.lbTransposePitch.Size = New System.Drawing.Size(60, 26)
        Me.lbTransposePitch.TabIndex = 30
        Me.lbTransposePitch.Text = "Transpose " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pitch"
        Me.lbTransposePitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabWhiteboard
        '
        Me.tabWhiteboard.Controls.Add(Me.gbxXAxis)
        Me.tabWhiteboard.Controls.Add(Me.picWhiteboard)
        Me.tabWhiteboard.Controls.Add(Me.gbxYAxis)
        Me.tabWhiteboard.Location = New System.Drawing.Point(4, 22)
        Me.tabWhiteboard.Name = "tabWhiteboard"
        Me.tabWhiteboard.Size = New System.Drawing.Size(760, 367)
        Me.tabWhiteboard.TabIndex = 2
        Me.tabWhiteboard.Text = "MIDI Whiteboard"
        Me.tabWhiteboard.UseVisualStyleBackColor = True
        '
        'gbxXAxis
        '
        Me.gbxXAxis.Controls.Add(Me.lblXValue)
        Me.gbxXAxis.Controls.Add(Me.cboXTitle)
        Me.gbxXAxis.Controls.Add(Me.lblXTitle)
        Me.gbxXAxis.Controls.Add(Me.lblXCaption)
        Me.gbxXAxis.Location = New System.Drawing.Point(324, 12)
        Me.gbxXAxis.Name = "gbxXAxis"
        Me.gbxXAxis.Size = New System.Drawing.Size(145, 80)
        Me.gbxXAxis.TabIndex = 40
        Me.gbxXAxis.TabStop = False
        Me.gbxXAxis.Text = "X - axis"
        '
        'lblXValue
        '
        Me.lblXValue.Location = New System.Drawing.Point(48, 24)
        Me.lblXValue.Name = "lblXValue"
        Me.lblXValue.Size = New System.Drawing.Size(48, 16)
        Me.lblXValue.TabIndex = 38
        '
        'cboXTitle
        '
        Me.cboXTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboXTitle.Items.AddRange(New Object() {"(none)", "instrument", "velocity", "pitch", "stereo position", "pitch bend"})
        Me.cboXTitle.Location = New System.Drawing.Point(40, 48)
        Me.cboXTitle.Name = "cboXTitle"
        Me.cboXTitle.Size = New System.Drawing.Size(96, 21)
        Me.cboXTitle.TabIndex = 37
        '
        'lblXTitle
        '
        Me.lblXTitle.Location = New System.Drawing.Point(8, 51)
        Me.lblXTitle.Name = "lblXTitle"
        Me.lblXTitle.Size = New System.Drawing.Size(32, 16)
        Me.lblXTitle.TabIndex = 36
        Me.lblXTitle.Text = "Title:"
        '
        'lblXCaption
        '
        Me.lblXCaption.Location = New System.Drawing.Point(8, 24)
        Me.lblXCaption.Name = "lblXCaption"
        Me.lblXCaption.Size = New System.Drawing.Size(40, 16)
        Me.lblXCaption.TabIndex = 0
        Me.lblXCaption.Text = "Value:"
        '
        'picWhiteboard
        '
        Me.picWhiteboard.BackColor = System.Drawing.Color.White
        Me.picWhiteboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWhiteboard.Location = New System.Drawing.Point(12, 12)
        Me.picWhiteboard.Name = "picWhiteboard"
        Me.picWhiteboard.Size = New System.Drawing.Size(300, 300)
        Me.picWhiteboard.TabIndex = 39
        Me.picWhiteboard.TabStop = False
        '
        'gbxYAxis
        '
        Me.gbxYAxis.Controls.Add(Me.cboYTitle)
        Me.gbxYAxis.Controls.Add(Me.lblYTitle)
        Me.gbxYAxis.Controls.Add(Me.lblYCaption)
        Me.gbxYAxis.Controls.Add(Me.lblYValue)
        Me.gbxYAxis.Location = New System.Drawing.Point(324, 104)
        Me.gbxYAxis.Name = "gbxYAxis"
        Me.gbxYAxis.Size = New System.Drawing.Size(145, 80)
        Me.gbxYAxis.TabIndex = 41
        Me.gbxYAxis.TabStop = False
        Me.gbxYAxis.Text = "Y - axis"
        '
        'cboYTitle
        '
        Me.cboYTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYTitle.Items.AddRange(New Object() {"(none)", "instrument", "velocity", "pitch", "stereo position", "pitch bend"})
        Me.cboYTitle.Location = New System.Drawing.Point(40, 48)
        Me.cboYTitle.Name = "cboYTitle"
        Me.cboYTitle.Size = New System.Drawing.Size(96, 21)
        Me.cboYTitle.TabIndex = 37
        '
        'lblYTitle
        '
        Me.lblYTitle.Location = New System.Drawing.Point(8, 51)
        Me.lblYTitle.Name = "lblYTitle"
        Me.lblYTitle.Size = New System.Drawing.Size(32, 16)
        Me.lblYTitle.TabIndex = 36
        Me.lblYTitle.Text = "Title:"
        '
        'lblYCaption
        '
        Me.lblYCaption.Location = New System.Drawing.Point(8, 24)
        Me.lblYCaption.Name = "lblYCaption"
        Me.lblYCaption.Size = New System.Drawing.Size(40, 16)
        Me.lblYCaption.TabIndex = 0
        Me.lblYCaption.Text = "Value:"
        '
        'lblYValue
        '
        Me.lblYValue.Location = New System.Drawing.Point(48, 24)
        Me.lblYValue.Name = "lblYValue"
        Me.lblYValue.Size = New System.Drawing.Size(48, 16)
        Me.lblYValue.TabIndex = 39
        '
        'tabDrumMachine
        '
        Me.tabDrumMachine.Controls.Add(Me.gbxDrumColSize)
        Me.tabDrumMachine.Controls.Add(Me.gbxDrumSelection)
        Me.tabDrumMachine.Controls.Add(Me.gbxDrumSpeed)
        Me.tabDrumMachine.Controls.Add(Me.gbxDrumRowSize)
        Me.tabDrumMachine.Controls.Add(Me.gbxDrumPlay)
        Me.tabDrumMachine.Controls.Add(Me.picDrum)
        Me.tabDrumMachine.Location = New System.Drawing.Point(4, 22)
        Me.tabDrumMachine.Name = "tabDrumMachine"
        Me.tabDrumMachine.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDrumMachine.Size = New System.Drawing.Size(760, 367)
        Me.tabDrumMachine.TabIndex = 1
        Me.tabDrumMachine.Text = "Drum Machine"
        Me.tabDrumMachine.UseVisualStyleBackColor = True
        '
        'gbxDrumColSize
        '
        Me.gbxDrumColSize.Controls.Add(Me.btnDrumDelCol)
        Me.gbxDrumColSize.Controls.Add(Me.btnDrumAddCol)
        Me.gbxDrumColSize.Location = New System.Drawing.Point(12, 310)
        Me.gbxDrumColSize.Name = "gbxDrumColSize"
        Me.gbxDrumColSize.Size = New System.Drawing.Size(79, 42)
        Me.gbxDrumColSize.TabIndex = 33
        Me.gbxDrumColSize.TabStop = False
        Me.gbxDrumColSize.Text = "Column"
        '
        'btnDrumDelCol
        '
        Me.btnDrumDelCol.Location = New System.Drawing.Point(42, 16)
        Me.btnDrumDelCol.Name = "btnDrumDelCol"
        Me.btnDrumDelCol.Size = New System.Drawing.Size(26, 21)
        Me.btnDrumDelCol.TabIndex = 3
        Me.btnDrumDelCol.Text = "-"
        Me.btnDrumDelCol.UseVisualStyleBackColor = True
        '
        'btnDrumAddCol
        '
        Me.btnDrumAddCol.Location = New System.Drawing.Point(12, 16)
        Me.btnDrumAddCol.Name = "btnDrumAddCol"
        Me.btnDrumAddCol.Size = New System.Drawing.Size(24, 21)
        Me.btnDrumAddCol.TabIndex = 2
        Me.btnDrumAddCol.Text = "+"
        Me.btnDrumAddCol.UseVisualStyleBackColor = True
        '
        'gbxDrumSelection
        '
        Me.gbxDrumSelection.Controls.Add(Me.cbDrumType)
        Me.gbxDrumSelection.Controls.Add(Me.cbDrumNo)
        Me.gbxDrumSelection.Location = New System.Drawing.Point(395, 239)
        Me.gbxDrumSelection.Name = "gbxDrumSelection"
        Me.gbxDrumSelection.Size = New System.Drawing.Size(307, 63)
        Me.gbxDrumSelection.TabIndex = 32
        Me.gbxDrumSelection.TabStop = False
        Me.gbxDrumSelection.Text = "Drum Selection"
        '
        'cbDrumType
        '
        Me.cbDrumType.FormattingEnabled = True
        Me.cbDrumType.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.cbDrumType.Location = New System.Drawing.Point(157, 25)
        Me.cbDrumType.Name = "cbDrumType"
        Me.cbDrumType.Size = New System.Drawing.Size(132, 21)
        Me.cbDrumType.TabIndex = 1
        '
        'cbDrumNo
        '
        Me.cbDrumNo.FormattingEnabled = True
        Me.cbDrumNo.Items.AddRange(New Object() {"Drum Machine 1", "Drum Machine 2"})
        Me.cbDrumNo.Location = New System.Drawing.Point(20, 25)
        Me.cbDrumNo.Name = "cbDrumNo"
        Me.cbDrumNo.Size = New System.Drawing.Size(121, 21)
        Me.cbDrumNo.TabIndex = 0
        '
        'gbxDrumSpeed
        '
        Me.gbxDrumSpeed.Controls.Add(Me.tbDrumSpeed)
        Me.gbxDrumSpeed.Location = New System.Drawing.Point(395, 142)
        Me.gbxDrumSpeed.Name = "gbxDrumSpeed"
        Me.gbxDrumSpeed.Size = New System.Drawing.Size(171, 79)
        Me.gbxDrumSpeed.TabIndex = 31
        Me.gbxDrumSpeed.TabStop = False
        Me.gbxDrumSpeed.Text = "Drum Speed"
        '
        'tbDrumSpeed
        '
        Me.tbDrumSpeed.Location = New System.Drawing.Point(12, 22)
        Me.tbDrumSpeed.Maximum = 9
        Me.tbDrumSpeed.Minimum = -9
        Me.tbDrumSpeed.Name = "tbDrumSpeed"
        Me.tbDrumSpeed.Size = New System.Drawing.Size(148, 45)
        Me.tbDrumSpeed.TabIndex = 0
        '
        'gbxDrumRowSize
        '
        Me.gbxDrumRowSize.Controls.Add(Me.btnDrumDelRow)
        Me.gbxDrumRowSize.Controls.Add(Me.btnDrumAddRow)
        Me.gbxDrumRowSize.Location = New System.Drawing.Point(318, 5)
        Me.gbxDrumRowSize.Name = "gbxDrumRowSize"
        Me.gbxDrumRowSize.Size = New System.Drawing.Size(47, 70)
        Me.gbxDrumRowSize.TabIndex = 30
        Me.gbxDrumRowSize.TabStop = False
        Me.gbxDrumRowSize.Text = "Row"
        '
        'btnDrumDelRow
        '
        Me.btnDrumDelRow.Location = New System.Drawing.Point(8, 44)
        Me.btnDrumDelRow.Name = "btnDrumDelRow"
        Me.btnDrumDelRow.Size = New System.Drawing.Size(29, 21)
        Me.btnDrumDelRow.TabIndex = 1
        Me.btnDrumDelRow.Text = "-"
        Me.btnDrumDelRow.UseVisualStyleBackColor = True
        '
        'btnDrumAddRow
        '
        Me.btnDrumAddRow.Location = New System.Drawing.Point(7, 17)
        Me.btnDrumAddRow.Name = "btnDrumAddRow"
        Me.btnDrumAddRow.Size = New System.Drawing.Size(30, 21)
        Me.btnDrumAddRow.TabIndex = 0
        Me.btnDrumAddRow.Text = "+"
        Me.btnDrumAddRow.UseVisualStyleBackColor = True
        '
        'gbxDrumPlay
        '
        Me.gbxDrumPlay.Controls.Add(Me.btnDrumReset)
        Me.gbxDrumPlay.Controls.Add(Me.btnDrumStart)
        Me.gbxDrumPlay.Controls.Add(Me.btnDrumStop)
        Me.gbxDrumPlay.Location = New System.Drawing.Point(395, 12)
        Me.gbxDrumPlay.Name = "gbxDrumPlay"
        Me.gbxDrumPlay.Size = New System.Drawing.Size(115, 115)
        Me.gbxDrumPlay.TabIndex = 29
        Me.gbxDrumPlay.TabStop = False
        Me.gbxDrumPlay.Text = "Drum Play"
        '
        'btnDrumReset
        '
        Me.btnDrumReset.Location = New System.Drawing.Point(10, 83)
        Me.btnDrumReset.Name = "btnDrumReset"
        Me.btnDrumReset.Size = New System.Drawing.Size(95, 22)
        Me.btnDrumReset.TabIndex = 28
        Me.btnDrumReset.Text = "Reset Drum"
        Me.btnDrumReset.UseVisualStyleBackColor = True
        '
        'btnDrumStart
        '
        Me.btnDrumStart.Location = New System.Drawing.Point(10, 20)
        Me.btnDrumStart.Name = "btnDrumStart"
        Me.btnDrumStart.Size = New System.Drawing.Size(95, 25)
        Me.btnDrumStart.TabIndex = 26
        Me.btnDrumStart.Text = "Start Drum"
        '
        'btnDrumStop
        '
        Me.btnDrumStop.Enabled = False
        Me.btnDrumStop.Location = New System.Drawing.Point(10, 51)
        Me.btnDrumStop.Name = "btnDrumStop"
        Me.btnDrumStop.Size = New System.Drawing.Size(95, 25)
        Me.btnDrumStop.TabIndex = 27
        Me.btnDrumStop.Text = "Stop Drum"
        '
        'picDrum
        '
        Me.picDrum.BackColor = System.Drawing.SystemColors.Window
        Me.picDrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDrum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDrum.Location = New System.Drawing.Point(12, 12)
        Me.picDrum.Name = "picDrum"
        Me.picDrum.Size = New System.Drawing.Size(300, 290)
        Me.picDrum.TabIndex = 25
        Me.picDrum.TabStop = False
        '
        'tmrDrumPlayback
        '
        Me.tmrDrumPlayback.Interval = 250
        '
        'gbxPlayMode
        '
        Me.gbxPlayMode.Controls.Add(Me.rbChord)
        Me.gbxPlayMode.Controls.Add(Me.rbNote)
        Me.gbxPlayMode.Location = New System.Drawing.Point(409, 141)
        Me.gbxPlayMode.Margin = New System.Windows.Forms.Padding(1)
        Me.gbxPlayMode.Name = "gbxPlayMode"
        Me.gbxPlayMode.Padding = New System.Windows.Forms.Padding(1)
        Me.gbxPlayMode.Size = New System.Drawing.Size(163, 34)
        Me.gbxPlayMode.TabIndex = 24
        Me.gbxPlayMode.TabStop = False
        '
        'rbChord
        '
        Me.rbChord.AutoSize = True
        Me.rbChord.Location = New System.Drawing.Point(77, 10)
        Me.rbChord.Margin = New System.Windows.Forms.Padding(1)
        Me.rbChord.Name = "rbChord"
        Me.rbChord.Size = New System.Drawing.Size(76, 17)
        Me.rbChord.TabIndex = 1
        Me.rbChord.TabStop = True
        Me.rbChord.Text = "Play Chord"
        Me.rbChord.UseVisualStyleBackColor = True
        '
        'rbNote
        '
        Me.rbNote.AutoSize = True
        Me.rbNote.Location = New System.Drawing.Point(4, 9)
        Me.rbNote.Margin = New System.Windows.Forms.Padding(1)
        Me.rbNote.Name = "rbNote"
        Me.rbNote.Size = New System.Drawing.Size(71, 17)
        Me.rbNote.TabIndex = 0
        Me.rbNote.TabStop = True
        Me.rbNote.Text = "Play Note"
        Me.rbNote.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(712, 146)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(67, 29)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPlayAll
        '
        Me.btnPlayAll.Location = New System.Drawing.Point(576, 146)
        Me.btnPlayAll.Name = "btnPlayAll"
        Me.btnPlayAll.Size = New System.Drawing.Size(67, 29)
        Me.btnPlayAll.TabIndex = 26
        Me.btnPlayAll.Text = "Play All"
        Me.btnPlayAll.UseVisualStyleBackColor = True
        '
        'btnStopAll
        '
        Me.btnStopAll.Enabled = False
        Me.btnStopAll.Location = New System.Drawing.Point(644, 146)
        Me.btnStopAll.Name = "btnStopAll"
        Me.btnStopAll.Size = New System.Drawing.Size(67, 29)
        Me.btnStopAll.TabIndex = 27
        Me.btnStopAll.Text = "Stop All"
        Me.btnStopAll.UseVisualStyleBackColor = True
        '
        'frmMidiPiano
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(793, 565)
        Me.Controls.Add(Me.btnStopAll)
        Me.Controls.Add(Me.btnPlayAll)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxPlayMode)
        Me.Controls.Add(Me.tclMidiFunction)
        Me.Controls.Add(Me.gbxInstrument)
        Me.Controls.Add(Me.vsbVolume)
        Me.Controls.Add(Me._key_15)
        Me.Controls.Add(Me._key_13)
        Me.Controls.Add(Me._key_10)
        Me.Controls.Add(Me._key_8)
        Me.Controls.Add(Me._key_6)
        Me.Controls.Add(Me._key_3)
        Me.Controls.Add(Me._key_1)
        Me.Controls.Add(Me._key_16)
        Me.Controls.Add(Me._key_14)
        Me.Controls.Add(Me._key_12)
        Me.Controls.Add(Me._key_11)
        Me.Controls.Add(Me._key_9)
        Me.Controls.Add(Me._key_7)
        Me.Controls.Add(Me._key_5)
        Me.Controls.Add(Me._key_4)
        Me.Controls.Add(Me._key_2)
        Me.Controls.Add(Me._key_0)
        Me.Controls.Add(Me.lblVolume)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 49)
        Me.Menu = Me.mnuMain
        Me.Name = "frmMidiPiano"
        Me.Text = "VB Midi Piano"
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInstrument.ResumeLayout(False)
        Me.gbxInstrument.PerformLayout()
        CType(Me.tbPanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBankMSB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tclMidiFunction.ResumeLayout(False)
        Me.tabSequencer.ResumeLayout(False)
        Me.tabSequencer.PerformLayout()
        Me.gbxPlaySpeed.ResumeLayout(False)
        Me.gbxPlaySpeed.PerformLayout()
        Me.tabWhiteboard.ResumeLayout(False)
        Me.gbxXAxis.ResumeLayout(False)
        CType(Me.picWhiteboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxYAxis.ResumeLayout(False)
        Me.tabDrumMachine.ResumeLayout(False)
        Me.gbxDrumColSize.ResumeLayout(False)
        Me.gbxDrumSelection.ResumeLayout(False)
        Me.gbxDrumSpeed.ResumeLayout(False)
        Me.gbxDrumSpeed.PerformLayout()
        CType(Me.tbDrumSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDrumRowSize.ResumeLayout(False)
        Me.gbxDrumPlay.ResumeLayout(False)
        CType(Me.picDrum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPlayMode.ResumeLayout(False)
        Me.gbxPlayMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Const INVALID_NOTE As Short = -1 ' Code for keyboard keys that we don't handle
    Const MAX_CHANNEL As Short = 16

    Dim numDevices As Integer ' number of midi output devices
    Dim curDevice As Integer ' current midi device
    Dim hmidi As Integer ' midi output handle
    Dim rc As Integer ' return code
    Dim midimsg As Integer ' midi output message buffer
    Dim channel As Short ' midi output channel
    Dim volume As Short ' midi volume
    Dim baseNote As Short ' the first note on our "piano"
    Dim playChord As Boolean ' play cord or note
    Dim speed As Double = 1 'play speed
    Dim PitchBend As Integer = 0 'pitch bend
    Dim instrument(MAX_CHANNEL) As Integer
    Dim bank(MAX_CHANNEL) As Integer
    Dim panning(MAX_CHANNEL) As Integer

    Dim key As CheckBoxArray ' an array of check box for keys
    Dim chan As MenuItemArray ' an array of menu item for channel
    Dim device As MenuItemArray ' an array of menu item for midi device

    ' for recording
    Dim isRecording As Boolean ' recording status
    Dim isLoop As Boolean ' looping status
    Dim startTime As System.DateTime ' the time of starting recording
    Dim midiSequence() As SequenceData ' store MIDI sequence
    Dim currentIndex As Integer ' store the current playing sequence index

    ' for MIDI whiteboard
    Dim lastMidiMessage As Integer = -1 ' previous MIDI message sent to the card
    Dim cbXselected As Short = 0 ' selection of the X axis
    Dim cbYselected As Short = 3 ' selection of the Y axis

    ' for drum machine
    Dim dSpeed As Double = 1 'Drum speed
    Dim DRUM_INSTRUMENT As Short = 2 ' Predefined number of drum instruments
    Dim DRUM_SLOT As Short = 8 ' Predefined number of slots across the drum machine
    Dim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean ' Slot On/Off for the drum machine
    Dim drumNumber(DRUM_INSTRUMENT) As Short ' The instrument for the drums
    Dim drumMessageSent(DRUM_INSTRUMENT) As Boolean ' True if a note-on midi message for a drum is sent

#Region "function initControlArray()"


    Public Sub initControlArray()
        ' initialize key checkboxarray (not generated by vb)
        key = New CheckBoxArray

        AddHandler _key_0.MouseDown, AddressOf key_MouseDown
        AddHandler _key_0.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_0)

        AddHandler _key_1.MouseDown, AddressOf key_MouseDown
        AddHandler _key_1.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_1)

        AddHandler _key_2.MouseDown, AddressOf key_MouseDown
        AddHandler _key_2.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_2)

        AddHandler _key_3.MouseDown, AddressOf key_MouseDown
        AddHandler _key_3.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_3)

        AddHandler _key_4.MouseDown, AddressOf key_MouseDown
        AddHandler _key_4.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_4)

        AddHandler _key_5.MouseDown, AddressOf key_MouseDown
        AddHandler _key_5.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_5)

        AddHandler _key_6.MouseDown, AddressOf key_MouseDown
        AddHandler _key_6.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_6)

        AddHandler _key_7.MouseDown, AddressOf key_MouseDown
        AddHandler _key_7.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_7)

        AddHandler _key_8.MouseDown, AddressOf key_MouseDown
        AddHandler _key_8.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_8)

        AddHandler _key_9.MouseDown, AddressOf key_MouseDown
        AddHandler _key_9.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_9)

        AddHandler _key_10.MouseDown, AddressOf key_MouseDown
        AddHandler _key_10.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_10)

        AddHandler _key_11.MouseDown, AddressOf key_MouseDown
        AddHandler _key_11.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_11)

        AddHandler _key_12.MouseDown, AddressOf key_MouseDown
        AddHandler _key_12.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_12)

        AddHandler _key_13.MouseDown, AddressOf key_MouseDown
        AddHandler _key_13.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_13)

        AddHandler _key_14.MouseDown, AddressOf key_MouseDown
        AddHandler _key_14.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_14)

        AddHandler _key_15.MouseDown, AddressOf key_MouseDown
        AddHandler _key_15.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_15)

        AddHandler _key_16.MouseDown, AddressOf key_MouseDown
        AddHandler _key_16.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_16)

        ' initialize channel menuitemarray (not generated by vb)
        chan = New MenuItemArray
        AddHandler mnuChannel0.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel0)

        AddHandler mnuChannel1.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel1)

        AddHandler mnuChannel2.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel2)

        AddHandler mnuChannel3.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel3)

        AddHandler mnuChannel4.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel4)

        AddHandler mnuChannel5.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel5)

        AddHandler mnuChannel6.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel6)

        AddHandler mnuChannel7.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel7)

        AddHandler mnuChannel8.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel8)

        AddHandler mnuChannel9.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel9)

        AddHandler mnuChannel10.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel10)

        AddHandler mnuChannel11.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel11)

        AddHandler mnuChannel12.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel12)

        AddHandler mnuChannel13.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel13)

        AddHandler mnuChannel14.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel14)

        AddHandler mnuChannel15.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel15)

        ' initialize device menuitemarray (not generated by vb)
        device = New MenuItemArray

        AddHandler mnuDevice0.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice0)

        AddHandler mnuDevice1.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice1)

        AddHandler mnuDevice2.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice2)

        AddHandler mnuDevice3.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice3)

        AddHandler mnuDevice4.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice4)

        AddHandler mnuDevice5.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice5)

        AddHandler mnuDevice6.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice6)

        AddHandler mnuDevice7.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice7)

        AddHandler mnuDevice8.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice8)

        AddHandler mnuDevice9.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice9)

        AddHandler mnuDevice10.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice10)
    End Sub
#End Region

    ' Set the value for the starting note of the piano
    Public Sub base_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBaseNote.Click
        Dim s As String
        Dim i As Short
        s = InputBox("Enter the new base note for the keyboard (0 - 111)", "Base note", CStr(baseNote))
        If IsNumeric(s) Then
            i = CShort(s)
            If i >= 0 And i < 112 Then
                baseNote = i
            End If
        End If
    End Sub

    ' Select the midi output channel
    Public Sub chan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.MenuItem).Index
        chan(channel).Checked = False
        exitChannel()
        channel = index
        chan(channel).Checked = True
        enterChannel()
    End Sub
    Sub exitChannel() 'store channel value
        instrument(channel) = tbInstrument.Value
        bank(channel) = tbBankMSB.Value
        panning(channel) = tbPanning.Value + 63
    End Sub

    Sub enterChannel() 'restore channel value
        tbInstrument.Value = instrument(channel)
        tbBankMSB.Value = bank(channel)
        If panning(channel) = Nothing Then
            tbPanning.Value = 0
        Else
            tbPanning.Value = panning(channel) - 63
        End If

    End Sub

    ' Open the midi device selected in the menu. The menu index equals the midi device number + 1.
    Public Sub device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.MenuItem).Index
        device(curDevice + 1).Checked = False
        device(index).Checked = True
        curDevice = index - 1
        rc = midiOutClose(hmidi)
        rc = midiOutOpen(hmidi, curDevice, 0, 0, 0)
        If rc <> 0 Then
            MessageBox.Show("Couldn't open midi out, rc = " & rc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' If user presses a keyboard key, start the corresponding midi note
    Private Sub frmMidiPiano_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = e.KeyCode

        StartNote(NoteFromKey(KeyCode))
    End Sub

    ' If user lifts a keyboard key, stop the corresponding midi note
    Private Sub frmMidiPiano_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Dim KeyCode As Short = e.KeyCode

        StopNote(NoteFromKey(KeyCode))
    End Sub

    Private Sub frmMidiPiano_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        Dim caps As MIDIOUTCAPS

        Try
            initControlArray()

            ' Set the first device as midi mapper
            device(0).Text = "MIDI Mapper"
            device(0).Visible = True
            device(0).Enabled = True

            ' Get the rest of the midi devices
            numDevices = midiOutGetNumDevs()
            For i = 0 To (numDevices - 1)
                midiOutGetDevCaps(i, caps, Len(caps))
                device(i + 1).Text = caps.szPname
                device(i + 1).Visible = True
                device(i + 1).Enabled = True
            Next

            ' Select the MIDI Mapper as the default device
            device_Click(device.Item(0), New System.EventArgs)

            ' Set the default channel
            channel = 0
            chan(channel).Checked = True
            For j = 1 To 15
                chan(j).Checked = False
            Next

            ' Set the base note
            baseNote = 60

            ' Set volume range
            volume = 127
            vsbVolume.Value = vsbVolume.Maximum - volume

            ' Set paly note
            playChord = False
            rbNote.Checked = True
            vsbTransposePitch.Value = 0
            vsbPitchBend.Value = 0
            ' Set no record
            midiSequence = Nothing
            isRecording = False
            isLoop = False

            ReDim Preserve midiSequence(MAX_CHANNEL)
            For i = 0 To MAX_CHANNEL - 1
                midiSequence(i) = New SequenceData
            Next

            'set instrument
            tbBankMSB.Value = 0
            tbInstrument.Value = 0
            tbPanning.Value = 0

            'Set Speed
            tbSpeed.Value = 0
            speed = 1

            cboXTitle.SelectedIndex = cbXselected
            cboYTitle.SelectedIndex = cbYselected

            'initial drum
            drumNumber(1) = &H3C
            drumNumber(2) = &H3D
            cbDrumNo.SelectedIndex = 0
            cbDrumType.SelectedIndex = 25

            btnPlay.Enabled = False
            cbxLoop.Enabled = False
            btnRemoveSilence.Enabled = False
            vsbTransposePitch.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMidiPiano_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ' Close current midi device
        rc = midiOutClose(hmidi)
    End Sub

    ' Start a note when user click on it
    Public Sub key_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.CheckBox).Tag
        StartNote(index)
    End Sub

    ' Stop the note when user lifts the mouse button
    Public Sub key_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.CheckBox).Tag
        StopNote(index)
    End Sub

    ' Press the button and send midi start event
    Private Sub StartNote(ByRef Index As Short)
        If Index = INVALID_NOTE Then
            Exit Sub
        End If
        If key(Index).CheckState = 1 Then
            Exit Sub
        End If

        key(Index).CheckState = System.Windows.Forms.CheckState.Checked

        'original key
        midimsg = &H90 + ((baseNote + Index) * &H100) + (volume * &H10000) + channel
        sendMidiMsg(hmidi, midimsg)

        'chord
        If (playChord) Then '+4,+7,+11
            midimsg = &H90 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
            midimsg = &H90 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
            midimsg = &H90 + ((baseNote + Index + 11) * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
        End If
    End Sub

    ' Raise the button and send midi stop event
    Private Sub StopNote(ByRef Index As Short)
        If Index = INVALID_NOTE Then
            Exit Sub
        End If

        key(Index).CheckState = System.Windows.Forms.CheckState.Unchecked

        'original key
        midimsg = &H80 + ((baseNote + Index) * &H100) + (volume * &H10000) + channel
        sendMidiMsg(hmidi, midimsg)
        'chord
        If (playChord) Then '+4,+7,+11
            midimsg = &H80 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
            midimsg = &H80 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
            midimsg = &H80 + ((baseNote + Index + 11) * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
        End If
    End Sub

    ' Get the note corresponding to a keyboard key
    Private Function NoteFromKey(ByRef key As Short) As Short

        NoteFromKey = INVALID_NOTE

        Select Case key
            Case System.Windows.Forms.Keys.Z
                NoteFromKey = 0
            Case System.Windows.Forms.Keys.S
                NoteFromKey = 1
            Case System.Windows.Forms.Keys.X
                NoteFromKey = 2
            Case System.Windows.Forms.Keys.D
                NoteFromKey = 3
            Case System.Windows.Forms.Keys.C
                NoteFromKey = 4
            Case System.Windows.Forms.Keys.V
                NoteFromKey = 5
            Case System.Windows.Forms.Keys.G
                NoteFromKey = 6
            Case System.Windows.Forms.Keys.B
                NoteFromKey = 7
            Case System.Windows.Forms.Keys.H
                NoteFromKey = 8
            Case System.Windows.Forms.Keys.N
                NoteFromKey = 9
            Case System.Windows.Forms.Keys.J
                NoteFromKey = 10
            Case System.Windows.Forms.Keys.M
                NoteFromKey = 11
            Case 188 ' comma
                NoteFromKey = 12
            Case System.Windows.Forms.Keys.L
                NoteFromKey = 13
            Case 190 ' period
                NoteFromKey = 14
            Case 186 ' semicolon
                NoteFromKey = 15
            Case 191 ' forward slash
                NoteFromKey = 16
        End Select

    End Function

    ' Set the volume
    Private Sub vsbVolume_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbVolume.Scroll
        Select Case e.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                volume = vsbVolume.Maximum - e.NewValue
        End Select
    End Sub

    ' Start recording MIDI sequence
    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        ' 2.1 Start recording a MIDI sequence
        ' Initialize the sequence data
        isRecording = True                 ' set the recording flag
        startTime = DateTime.Now           ' remember the time when recording starts

        ' the following two lines reset the midiSequence(channel) object
        If midiSequence(channel) Is Nothing Then
            ReDim midiSequence(0)
        Else
            ReDim Preserve midiSequence(MAX_CHANNEL)
        End If

        midiSequence(channel) = New SequenceData
        ' Send the messages for the instrument so that the playback will match

        ' Send a control change message to change the bank
        midimsg = &H80 + channel + (&H0 * &H100) + (tbBankMSB.Value * &H10000)
        sendMidiMsg(hmidi, midimsg)
        'Program change
        midimsg = &HC0 + channel + ((tbInstrument.Value) * &H100)
        sendMidiMsg(hmidi, midimsg)

        ' Change button display
        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        cbxLoop.Enabled = False
        btnRemoveSilence.Enabled = False

    End Sub

    ' Stop recording MIDI sequence
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        ' 2.2 Stop recording a MIDI sequence
        ' Stop the recording
        isRecording = False
        isLoop = False

        ' 2.3 Play a MIDI sequence
        ' Stop the playback
        tmrSequencer.Enabled = False

        ' All sounds Off
        midimsg = (&HB0 + channel) + (&H78 * &H100)
        sendMidiMsg(hmidi, midimsg)

        'Reset Keyboard Color
        key(0).BackColor = Color.White
        key(1).BackColor = Color.Black
        key(2).BackColor = Color.White
        key(3).BackColor = Color.Black
        key(4).BackColor = Color.White
        key(5).BackColor = Color.White
        key(6).BackColor = Color.Black
        key(7).BackColor = Color.White
        key(8).BackColor = Color.Black
        key(9).BackColor = Color.White
        key(10).BackColor = Color.Black
        key(11).BackColor = Color.White
        key(12).BackColor = Color.White
        key(13).BackColor = Color.Black
        key(14).BackColor = Color.White
        key(15).BackColor = Color.Black
        key(16).BackColor = Color.White

        'change button display
        If midiSequence(channel) Is Nothing Then
            'do nothing
        Else

            If midiSequence(channel).dataLength = 0 Then
                btnPlay.Enabled = False
                cbxLoop.Enabled = False
                btnRemoveSilence.Enabled = False
            Else
                btnPlay.Enabled = True
                btnRemoveSilence.Enabled = True
                cbxLoop.Enabled = True
            End If
        End If
        btnRecord.Enabled = True
        btnStop.Enabled = False
        gbxInstrument.Enabled = True
        rbNote.Enabled = True
        rbChord.Enabled = True
        btnStopAll.Enabled = False
        btnPlayAll.Enabled = True
        vsbTransposePitch.Enabled = True
    End Sub

    ' Play the MIDI sequence recorded
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If midiSequence(channel) Is Nothing Then
            Exit Sub
        End If
        currentIndex = 0 ' Store the current index of the MIDI msg

        ' 2.3 Play a MIDI sequence
        ' Start the timer using the time of the first sequencer message data
        tmrSequencer.Interval = CInt(midiSequence(channel).data(0).time.TotalMilliseconds) + 1
        tmrSequencer.Enabled = True

        ' change button display
        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        btnRemoveSilence.Enabled = True
        btnStopAll.Enabled = True
        btnPlayAll.Enabled = False
        gbxInstrument.Enabled = False
        rbNote.Enabled = False
        rbChord.Enabled = False
        vsbTransposePitch.Enabled = False
    End Sub

    Private Sub tmrSequencer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSequencer.Tick
        ' 2.3 Play a MIDI sequence
        'Loop
        If cbxLoop.Checked = True Then
            isLoop = True
        Else
            isLoop = False
        End If
        ' Stop the timer from running
        tmrSequencer.Enabled = False

        ' Send the MIDI message of the current message and schedule the next one
        ' Consume all sequence data which is on time

        sendMidiMsg(hmidi, midiSequence(channel).data(currentIndex).midiMsg)
        ' Schedule the timer for the next sequencer message
        If (currentIndex < midiSequence(channel).data.Length - 1) Then
            currentIndex += 1
            tmrSequencer.Interval = CInt((midiSequence(channel).data(currentIndex).time.Subtract(midiSequence(channel).data(currentIndex - 1).time).TotalMilliseconds) * speed) + 1
            tmrSequencer.Enabled = True
        ElseIf (isLoop) Then
            currentIndex = 0
            tmrSequencer.Interval = CInt(midiSequence(channel).data(0).time.TotalMilliseconds) + 1
            tmrSequencer.Enabled = True
        Else
            btnStop_Click(sender, e)
            btnStopAll_Click(sender, e)
        End If
    End Sub

    ' Send a MIDI message and store the message
    Private Sub sendMidiMsg(ByVal hMidiOut As Integer, ByVal dwMsg As Integer)

        'Set Color of keyboard
        Dim Index As Short = (dwMsg And &HFF00) / &H100 - baseNote
        If Index > 16 Then
            Index = Index Mod 12
        ElseIf Index < 0 Then
            Index = (Index + baseNote) Mod 12
        End If
        'note on
        If ((dwMsg And &HF0) = &H90) Then
            Select Case Index
                Case 0
                    key(Index).BackColor = Color.Red
                Case 1
                    key(Index).BackColor = Color.Red
                Case 2
                    key(Index).BackColor = Color.Orange
                Case 3
                    key(Index).BackColor = Color.Orange
                Case 4
                    key(Index).BackColor = Color.Yellow
                Case 5
                    key(Index).BackColor = Color.Green
                Case 6
                    key(Index).BackColor = Color.Green
                Case 7
                    key(Index).BackColor = Color.Blue
                Case 8
                    key(Index).BackColor = Color.Blue
                Case 9
                    key(Index).BackColor = Color.Indigo
                Case 10
                    key(Index).BackColor = Color.Indigo
                Case 11
                    key(Index).BackColor = Color.Violet
                Case 12
                    key(Index).BackColor = Color.Red
                Case 13
                    key(Index).BackColor = Color.Red
                Case 14
                    key(Index).BackColor = Color.Orange
                Case 15
                    key(Index).BackColor = Color.Orange
                Case 16
                    key(Index).BackColor = Color.Yellow
            End Select
        End If
        'note off
        If ((dwMsg And &HF0) = &H80) Then
            Select Case Index
                Case 0
                    key(Index).BackColor = Color.White
                Case 1
                    key(Index).BackColor = Color.Black
                Case 2
                    key(Index).BackColor = Color.White
                Case 3
                    key(Index).BackColor = Color.Black
                Case 4
                    key(Index).BackColor = Color.White
                Case 5
                    key(Index).BackColor = Color.White
                Case 6
                    key(Index).BackColor = Color.Black
                Case 7
                    key(Index).BackColor = Color.White
                Case 8
                    key(Index).BackColor = Color.Black
                Case 9
                    key(Index).BackColor = Color.White
                Case 10
                    key(Index).BackColor = Color.Black
                Case 11
                    key(Index).BackColor = Color.White
                Case 12
                    key(Index).BackColor = Color.White
                Case 13
                    key(Index).BackColor = Color.Black
                Case 14
                    key(Index).BackColor = Color.White
                Case 15
                    key(Index).BackColor = Color.Black
                Case 16
                    key(Index).BackColor = Color.White
            End Select
        End If

        'Transpose pitch
        Dim transpose As Integer
        Dim transposemsg As Integer
        If (dwMsg And &HE0) = &H80 Then
            transpose = (dwMsg And &HFF00) / &H100 - vsbTransposePitch.Value
            If transpose > 127 Then
                transpose = 127
            ElseIf transpose < 0 Then
                transpose = 0
            End If
            transposemsg = (dwMsg And &HFF00FF) + transpose * &H100
        Else
            transposemsg = dwMsg
        End If

        ' Send a MIDI message
        midiOutShortMsg(hMidiOut, transposemsg)

        If (dwMsg And &HF0) = &H90 Then
            sendMidiMsg(hmidi, (&HE0 + channel) + ((PitchBend Mod 256) * &H100) + ((PitchBend / 256) * &H10000))
        End If


        ' 2.1 Start recording a MIDI sequence   
        ' Store the message
        If isRecording And ((dwMsg And &HF) <> 9) Then 'Do not record channel 10 (drum)
            midiSequence(channel).AddSequenceData(dwMsg, DateTime.Now.Subtract(startTime))
        End If

    End Sub

    Private Sub tbSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpeed.Scroll
        If tbSpeed.Value > 0 Then
            speed = 1 - tbSpeed.Value / 10.0
        Else
            speed = 1 - tbSpeed.Value / 10.0
        End If
    End Sub

    Private Sub btnRemoveSilence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSilence.Click
        If midiSequence(channel) Is Nothing Then
            Exit Sub
        End If
        ' 3.1 Remove silence at the start
        Dim i As UInteger
        Dim offset As System.TimeSpan = Nothing
        For i = 0 To midiSequence(channel).dataLength - 1
            If ((midiSequence(channel).data(i).midiMsg And &HF0) = &H80) And (offset = Nothing) Then
                offset = midiSequence(channel).data(i).time
            ElseIf offset = Nothing Then
                midiSequence(channel).data(i).time -= midiSequence(channel).data(i).time
            End If
            midiSequence(channel).data(i).time = midiSequence(channel).data(i).time.Subtract(offset)
        Next
        If midiSequence(channel) Is Nothing Then
            Exit Sub
        End If
    End Sub

    ' Change the instrument by sending a program change message
    Private Sub tbInstrument_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbInstrument.ValueChanged
        ' Send a program change message for the instrument
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)
    End Sub

    Private Function sendMsgForWhiteboard(ByVal x As Double, ByVal y As Double) As Integer
        Dim pitch As Integer

        ' Instrument is selected
        If cbXselected = 1 Or cbYselected = 1 Then
            tbInstrument.Value = IIf(cbXselected = 1, x * 127, y * 127)
            midimsg = &HC0 + channel + (tbInstrument.Value * &H100)
            sendMidiMsg(hmidi, midimsg)
        End If

        ' Velocity is selected
        If cbXselected = 2 Or cbYselected = 2 Then
            volume = IIf(cbXselected = 2, x * 127, y * 127)
            vsbVolume.Value = 127 - volume
        End If

        ' Pitch is selected
        If cbXselected = 3 Or cbYselected = 3 Then
            pitch = IIf(cbXselected = 3, x * 127, y * 127)
            If lastMidiMessage <> -1 Then
                midimsg = lastMidiMessage And &HFFFFEF
                sendMidiMsg(hmidi, midimsg)
            End If
            midimsg = &H90 + channel + (pitch * &H100) + (volume * &H10000)
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = midimsg
        End If

        ' stereo position is selected
        If cbXselected = 4 Or cbYselected = 4 Then
            tbPanning.Value = IIf(cbXselected = 4, x * 127, y * 127) - 63
        End If

        ' pitch bend is selected
        If cbXselected = 5 Or cbYselected = 5 Then
            vsbPitchBend.Value = (IIf(cbXselected = 5, x * 16384, y * 16384)) - 8192
           End If
    End Function

    Private Sub picWhiteboard_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseMove

        Dim x As Double, y As Double

        ' Check the range of the x and y values
        If (Not e.Button = MouseButtons.Left Or
        e.X < 0 Or e.X >= picWhiteboard.Width Or
        e.Y < 0 Or e.Y >= picWhiteboard.Height) Then
            Exit Sub
        End If

        ' Send MIDI messages based on the x and y range
        x = e.X / (picWhiteboard.Width - 1)
        y = e.Y / (picWhiteboard.Height - 1)
        sendMsgForWhiteboard(x, y)

        ' Display the values in the x and y labels
        Select Case cbXselected
            Case 1
                lblXValue.Text = tbInstrument.Value
            Case 2
                lblXValue.Text = CInt(x * 127)
            Case 3
                lblXValue.Text = CInt(x * 127)
            Case 4
                lblXValue.Text = tbPanning.Value + 64
            Case 5
                lblXValue.Text = CInt(x * 16384)
        End Select

        Select Case cbYselected
            Case 1
                lblYValue.Text = tbInstrument.Value
            Case 2
                lblYValue.Text = CInt(y * 127)
            Case 3
                lblYValue.Text = CInt(y * 127)
            Case 4
                lblYValue.Text = tbPanning.Value + 64
            Case 5
                lblYValue.Text = CInt(y * 16384)
        End Select
    End Sub

    Private Sub cboXTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboXTitle.SelectedIndexChanged
        If cboXTitle.SelectedIndex = cbYselected Then
            cboXTitle.SelectedIndex = cbXselected
        Else
            cbXselected = cboXTitle.SelectedIndex
        End If
    End Sub

    Private Sub cboYTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYTitle.SelectedIndexChanged
        If cboYTitle.SelectedIndex = cbXselected Then
            cboYTitle.SelectedIndex = cbYselected
        Else
            cbYselected = cboYTitle.SelectedIndex
        End If
    End Sub

    Private Sub picWhiteboard_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseDown
        picWhiteboard_MouseMove(sender, e)
    End Sub

    Private Sub picWhiteboard_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseUp
        If lastMidiMessage <> -1 Then
            midimsg = lastMidiMessage And &HFFFFEF
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = -1
        End If
    End Sub

    ' Draw the drum slots in a PictureBox (picDrum) in two rows
    Private Sub DrawDrumConfiguration(ByVal g As Graphics)
        Dim Slot, Drum As Short
        Dim X1, X2 As Single
        Dim Y1, Y2 As Single
        Dim Width, Height As Single

        ' The width and height of a slot in the drum machine
        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        Height = picDrum.ClientRectangle.Height / DRUM_INSTRUMENT

        g.Clear(Color.White)

        'Create pens
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim redPen As New Pen(Color.Red, 3)

        For Slot = 1 To DRUM_SLOT
            X1 = Width * (Slot - 1)
            X2 = Width * Slot

            For Drum = 1 To DRUM_INSTRUMENT
                Y1 = Height * (Drum - 1)
                Y2 = Height * Drum

                ' Draw a black box if the slot is selected
                If drumSlot(Drum, Slot) Then
                    g.FillRectangle(blackBrush, X1, Y1, Width, Height)
                End If
            Next
            g.DrawLine(redPen, X1, 0, X1, (picDrum.ClientRectangle.Height))
        Next

        ' Draw the red separators between the slots
        For Drum = 1 To DRUM_INSTRUMENT - 1
            g.DrawLine(redPen, 0, Height * Drum, (picDrum.ClientRectangle.Width), Height * Drum)
        Next
    End Sub

    Private Sub picDrum_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDrum.MouseDown
        Dim X As Single = e.X
        Dim Y As Single = e.Y
        Dim Drum, Slot As Short
        Dim Width, Height As Single

        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        Height = picDrum.ClientRectangle.Height / DRUM_INSTRUMENT

        ' Determine the slot where the user has selected
        Slot = Math.Floor(X / Width) + 1
        Drum = Math.Floor(Y / Height) + 1

        ' Set/unset the drum slot
        drumSlot(Drum, Slot) = Not drumSlot(Drum, Slot)

        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub tmrDrumPlayback_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDrumPlayback.Tick
        Static Slot As Short
        Static Slot_p As Short = 0
        Dim Drum As Short
        Dim X1, X2, Width As Single
        Dim bluePen As New Pen(Color.Blue, 3)
        Dim redPen As New Pen(Color.Red, 3)
        Dim g As Graphics = picDrum.CreateGraphics

        Width = picDrum.ClientRectangle.Width / DRUM_SLOT

        X1 = Width * (Slot_p - 1)
        X2 = Width * (Slot - 1)


        'Draw the red line to overwrite the blue line
        g.DrawLine(redPen, X1, 0, X1, (picDrum.ClientRectangle.Height))

        ' Initialize the slot number
        If Slot <= 0 Then Slot = 1
        If Slot > DRUM_SLOT Then Slot = DRUM_SLOT
        If Drum <= 0 Then Drum = 1
        ' Start/Stop a drum for each row in the drum machine
        For Drum = 1 To DRUM_INSTRUMENT
            If drumMessageSent(Drum) Then
                ' You need to stop any drum note already sent to
                ' the midi card by checking the variable DrumMessageSent
                midimsg = &H89 + (drumNumber(Drum) * &H100) + (&H7F * &H10000)
                midiOutShortMsg(hmidi, midimsg)
            End If

            If drumSlot(Drum, Slot) Then
                ' Here, a drum slot is selected that means you have to
                ' start a midi note with the drum sound
                midimsg = &H99 + (drumNumber(Drum) * &H100) + (&H7F * &H10000)
                midiOutShortMsg(hmidi, midimsg)

                drumMessageSent(Drum) = True
            Else
                drumMessageSent(Drum) = False
            End If
        Next


        'Draw the blue line
        g.DrawLine(bluePen, X2, 0, X2, (picDrum.ClientRectangle.Height))

        'Save the current position
        Slot_p = Slot
        ' Increase the number by 1
        Slot = (Slot Mod DRUM_SLOT) + 1

    End Sub

    ' Draw the drum machine
    Private Sub picDrum_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picDrum.Paint
        DrawDrumConfiguration(e.Graphics())
    End Sub

    Private Sub btnDrumstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrumStart.Click
        ' start the drum timer
        tmrDrumPlayback.Enabled = True
        'Change ui
        gbxDrumRowSize.Enabled = False
        gbxDrumColSize.Enabled = False
        btnDrumStop.Enabled = True
        btnDrumStart.Enabled = False
    End Sub

    Private Sub btnDrumstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrumStop.Click
        Dim Drum As Short

        'ReDraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())

        ' stop the drum timer
        tmrDrumPlayback.Enabled = False

        'change UI
        btnDrumStart.Enabled = True
        gbxDrumRowSize.Enabled = True
        gbxDrumColSize.Enabled = True
        btnDrumStop.Enabled = False

        ' You need to stop any drum note already sent to the midi card
        For Drum = 1 To DRUM_INSTRUMENT
            If drumMessageSent(Drum) Then
                midimsg = &H89 + (drumNumber(Drum) * &H100) + (&H7F * &H10000)
                midiOutShortMsg(hmidi, midimsg)
            End If
        Next
    End Sub

    Private Sub picDisplay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics()

        g.Clear(Color.White)

        ' This code simply draws three rectangles on the picture box
        g.FillRectangle(Brushes.Black, 10, 10, 10, 2)
        g.FillRectangle(Brushes.Black, 20, 20, 10, 2)
        g.FillRectangle(Brushes.Black, 30, 30, 10, 2)
    End Sub

  

    Private Sub rbNote_CheckedChanged(sender As Object, e As EventArgs) Handles rbNote.CheckedChanged
        playChord = False
    End Sub

    Private Sub rbChord_CheckedChanged(sender As Object, e As EventArgs) Handles rbChord.CheckedChanged
        playChord = True
    End Sub

    Private Sub tbInstrument_Scroll(sender As Object, e As EventArgs) Handles tbInstrument.Scroll
        midimsg = (&HC0 + channel) + (tbInstrument.Value * &H100)
        sendMidiMsg(hmidi, midimsg)
    End Sub

    Private Sub tbBankMSB_Scroll(sender As Object, e As EventArgs) Handles tbBankMSB.Scroll
        'MSB
        midimsg = &HB0 + channel + (&H0 * &H100) + (tbBankMSB.Value * &H10000)
        sendMidiMsg(hmidi, midimsg)

        'Program change
        midimsg = &HC0 + channel + ((tbInstrument.Value) * &H100)
        sendMidiMsg(hmidi, midimsg)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'All sounds Off
        For channel = 0 To 15
            midimsg = (&HB0 + channel) + (&H78 * &H100)
            sendMidiMsg(hmidi, midimsg)
        Next

        'Clear white board
        lblXValue.Text = Nothing
        lblYValue.Text = Nothing
        cbXselected = 0
        cbYselected = 3

        'Initial Setting
        frmMidiPiano_Load(Nothing, Nothing)
        btnDrumReset_Click(sender, e)
    End Sub

    Private Sub tbPanning_Scroll(sender As Object, e As EventArgs) Handles tbPanning.Scroll
        midimsg = (&HB0 + channel) + (&HA * &H100) + ((tbPanning.Value + 63) * &H10000)
        sendMidiMsg(hmidi, midimsg)
    End Sub
 

    Private Sub cbDrumNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDrumNo.SelectedIndexChanged
        cbDrumType.SelectedIndex = drumNumber(cbDrumNo.SelectedIndex + 1) - 35
    End Sub

    Private Sub cbDrumType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDrumType.SelectedIndexChanged
        drumNumber(cbDrumNo.SelectedIndex + 1) = cbDrumType.SelectedIndex + 35
    End Sub

    Private Sub btnDrumReset_Click(sender As Object, e As EventArgs) Handles btnDrumReset.Click
        btnDrumstop_Click(sender, e)
        Dim i As Short = DRUM_INSTRUMENT
        Dim j As Short

        If DRUM_INSTRUMENT > 2 Then
            For j = 3 To i
                cbDrumNo.Items.RemoveAt(cbDrumNo.Items.Count - 1)
                cbDrumNo.SelectedIndex = cbDrumNo.Items.Count - 1
            Next j
        End If

        'initial drum
        drumNumber(1) = &H3C
        drumNumber(2) = &H3D
        cbDrumNo.SelectedIndex = 0
        cbDrumType.SelectedIndex = 25
        tbDrumSpeed.Value = 0
        dSpeed = 1
        btnDrumStop.Enabled = False
        'redraw drum machine
        DRUM_INSTRUMENT = 2
        DRUM_SLOT = 8
        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub tbDrumSpeed_Scroll(sender As Object, e As EventArgs) Handles tbDrumSpeed.Scroll
        dSpeed = 1 - tbDrumSpeed.Value / 10.0
        tmrDrumPlayback.Interval = 250 * dSpeed
    End Sub

    Private Sub btnDrumAddRow_Click(sender As Object, e As EventArgs) Handles btnDrumAddRow.Click
        'Store exist setting
        Dim row, col As Integer
        Dim tempArray(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        For row = LBound(drumSlot, 1) To UBound(drumSlot, 1)
            For col = LBound(drumSlot, 2) To UBound(drumSlot, 2)
                tempArray(row, col) = drumSlot(row, col)
            Next col
        Next row

        'add drum
        DRUM_INSTRUMENT += 1
        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        ReDim Preserve drumNumber(DRUM_INSTRUMENT)
        ReDim Preserve drumMessageSent(DRUM_INSTRUMENT)

        'destroy the array
        For row = LBound(tempArray, 1) To Math.Min(UBound(tempArray, 1), UBound(drumSlot, 1))
            For col = LBound(tempArray, 2) To Math.Min(UBound(tempArray, 2), UBound(drumSlot, 2))
                drumSlot(row, col) = tempArray(row, col)
            Next col
        Next row

        'add drum setting
        DrawDrumConfiguration(picDrum.CreateGraphics())
        drumNumber(DRUM_INSTRUMENT) = &H3C
        cbDrumType.SelectedIndex = 25
        cbDrumNo.Items.Add("Drum Machine " & DRUM_INSTRUMENT.ToString)
        cbDrumNo.SelectedIndex = DRUM_INSTRUMENT - 1
    End Sub

    Private Sub btnDrumDelRow_Click(sender As Object, e As EventArgs) Handles btnDrumDelRow.Click
        'Store exist setting
        Dim row, col As Integer
        Dim tempArray(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        For row = LBound(drumSlot, 1) To UBound(drumSlot, 1)
            For col = LBound(drumSlot, 2) To UBound(drumSlot, 2)
                tempArray(row, col) = drumSlot(row, col)
            Next col
        Next row

        'del drum
        If DRUM_INSTRUMENT > 1 Then
            DRUM_INSTRUMENT -= 1
            cbDrumNo.Items.RemoveAt(cbDrumNo.Items.Count - 1)
            cbDrumNo.SelectedIndex = cbDrumNo.Items.Count - 1
        Else
            MsgBox("Can not delete further", MsgBoxStyle.Exclamation, "Error")
        End If
        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        ReDim Preserve drumNumber(DRUM_INSTRUMENT)
        ReDim Preserve drumMessageSent(DRUM_INSTRUMENT)

        'destroy the array
        For row = LBound(tempArray, 1) To Math.Min(UBound(tempArray, 1), UBound(drumSlot, 1))
            For col = LBound(tempArray, 2) To Math.Min(UBound(tempArray, 2), UBound(drumSlot, 2))
                drumSlot(row, col) = tempArray(row, col)
            Next col
        Next row

        'del drum setting
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub btnDrumAddCol_Click(sender As Object, e As EventArgs) Handles btnDrumAddCol.Click
        'Store exist setting
        Dim row, col As Integer
        Dim tempArray(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        For row = LBound(drumSlot, 1) To UBound(drumSlot, 1)
            For col = LBound(drumSlot, 2) To UBound(drumSlot, 2)
                tempArray(row, col) = drumSlot(row, col)
            Next col
        Next row

        'add slot
        DRUM_SLOT += 1
        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        ReDim Preserve drumNumber(DRUM_INSTRUMENT)
        ReDim Preserve drumMessageSent(DRUM_INSTRUMENT)

        'destroy the array
        For row = LBound(tempArray, 1) To Math.Min(UBound(tempArray, 1), UBound(drumSlot, 1))
            For col = LBound(tempArray, 2) To Math.Min(UBound(tempArray, 2), UBound(drumSlot, 2))
                drumSlot(row, col) = tempArray(row, col)
            Next col
        Next row

        'add drum setting
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub btnDrumDelCol_Click(sender As Object, e As EventArgs) Handles btnDrumDelCol.Click
        'Store exist setting
        Dim row, col As Integer
        Dim tempArray(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        For row = LBound(drumSlot, 1) To UBound(drumSlot, 1)
            For col = LBound(drumSlot, 2) To UBound(drumSlot, 2)
                tempArray(row, col) = drumSlot(row, col)
            Next col
        Next row

        'del drum
        If DRUM_SLOT > 1 Then
            DRUM_SLOT -= 1
        Else
            MsgBox("Can not delete further", MsgBoxStyle.Exclamation, "Error")
        End If
        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        ReDim Preserve drumNumber(DRUM_INSTRUMENT)
        ReDim Preserve drumMessageSent(DRUM_INSTRUMENT)

        'destroy the array
        For row = LBound(tempArray, 1) To Math.Min(UBound(tempArray, 1), UBound(drumSlot, 1))
            For col = LBound(tempArray, 2) To Math.Min(UBound(tempArray, 2), UBound(drumSlot, 2))
                drumSlot(row, col) = tempArray(row, col)
            Next col
        Next row

        'del drum setting
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub btnPlayAll_Click(sender As Object, e As EventArgs) Handles btnPlayAll.Click
        btnStopAll.Enabled = True
        btnPlayAll.Enabled = False
        btnPlay_Click(sender, e)
        btnDrumstart_Click(sender, e)
    End Sub

    Private Sub btnStopAll_Click(sender As Object, e As EventArgs) Handles btnStopAll.Click
        btnStop_Click(sender, e)
        btnDrumstop_Click(sender, e)
        btnPlayAll.Enabled = True
        btnStopAll.Enabled = False
    End Sub

    Private Sub mnuOpenDrum_Click(sender As Object, e As EventArgs) Handles mnuOpenDrum.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        openFileDialog.DefaultExt = "txt"
        openFileDialog.Filter = "Text files (*.txt)|*.txt"
        openFileDialog.Multiselect = False
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim lines As String() = File.ReadAllLines(openFileDialog.FileName)
            Dim Size As String() = lines(0).Split(" ")
            If Size.Length <> 2 Then
                MessageBox.Show("invalid file")
                Exit Sub
            End If

            DRUM_INSTRUMENT = CInt(Size(0))
            DRUM_SLOT = CInt(Size(1))

            ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
            ReDim Preserve drumNumber(DRUM_INSTRUMENT)
            ReDim Preserve drumMessageSent(DRUM_INSTRUMENT)

            Dim i, j As Integer

            For i = 1 To DRUM_INSTRUMENT
                Dim line As String = lines(i)
                Dim data As String() = line.Split(" ")
                For j = 0 To DRUM_SLOT - 1
                    drumSlot(i, j + 1) = IIf(String.Compare(data(j), "1"), False, True)
                Next j
                drumNumber(i) = CInt(data(data.Length - 1))
            Next i

            For i = cbDrumNo.Items.Count + 1 To DRUM_INSTRUMENT
                cbDrumNo.Items.Add("Drum Machine " & i.ToString)
                cbDrumType.SelectedIndex = (drumNumber(cbDrumNo.SelectedIndex + 1) - 35)
            Next

            DrawDrumConfiguration(picDrum.CreateGraphics())
        End If
    End Sub

    Private Sub mnuSaveDrum_Click(sender As Object, e As EventArgs) Handles mnuSaveDrum.Click
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "Text files (*.txt)|*.txt"
        saveFileDialog.Title = "Save an Drum Configuration File"
        saveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        'save when ok
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim i, j As Integer
            My.Computer.FileSystem.WriteAllText(saveFileDialog.FileName, DRUM_INSTRUMENT.ToString & " " & DRUM_SLOT.ToString & vbCrLf, False)
            For i = 1 To DRUM_INSTRUMENT
                Dim tmp As String = ""
                For j = 1 To DRUM_SLOT
                    tmp = tmp & IIf(drumSlot(i, j), 1, 0).ToString & " "
                Next j
                tmp = tmp & drumNumber(i).ToString & vbCrLf
                My.Computer.FileSystem.WriteAllText(saveFileDialog.FileName, tmp, True)
            Next i
        End If
        
    End Sub
    Private Sub mnuSaveMidi_Click(sender As Object, e As EventArgs) Handles mnuSaveMidi.Click
        If midiSequence Is Nothing Then
            MsgBox("Nothing to save!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Dim dlg As New SaveFileDialog
        dlg.Filter = "My MIDI files (*.mymid)|*.mymid"
        dlg.Title = "Save an My MIDI File"
        dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        dlg.RestoreDirectory = True

        If dlg.ShowDialog() = DialogResult.OK Then

            If midiSequence Is Nothing Then
                Exit Sub
            End If
            Dim i, j As Integer
            My.Computer.FileSystem.WriteAllText(dlg.FileName, "csm" & vbCrLf, False)
            For i = 0 To MAX_CHANNEL - 1
                My.Computer.FileSystem.WriteAllText(dlg.FileName, i.ToString & vbCrLf, True)
                If midiSequence(channel) IsNot Nothing Then
                    My.Computer.FileSystem.WriteAllText(dlg.FileName, midiSequence(i).dataLength.ToString & vbCrLf, True)
                    For j = 0 To midiSequence(i).dataLength - 1
                        My.Computer.FileSystem.WriteAllText(dlg.FileName, midiSequence(i).data(j).midiMsg.ToString & vbCrLf, True)
                        My.Computer.FileSystem.WriteAllText(dlg.FileName, midiSequence(i).data(j).time.ToString & vbCrLf, True)
                    Next
                Else
                    My.Computer.FileSystem.WriteAllText(dlg.FileName, "0" & vbCrLf, True)
                End If
            Next
        End If

    End Sub
    Private Sub mnuOpenMidi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenMidi.Click
        Dim dlg As New OpenFileDialog

        ' Ask for the MIDI file
        dlg.DefaultExt = "mymid"
        dlg.Filter = "My MIDI files (*.mymid)|*.mymid"
        dlg.Multiselect = False

        If dlg.ShowDialog() = DialogResult.OK Then

            Dim streamReader As StreamReader = New StreamReader(dlg.FileName)
            Dim header As String = streamReader.ReadLine()

            'Check valid type
            If String.Compare(header, "csm") <> 0 Then
                MsgBox("Not valid mymid file!", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            ReDim Preserve midiSequence(MAX_CHANNEL)

            'load it to midi sequences
            Dim i, j As Integer
            For i = 0 To MAX_CHANNEL - 1
                Dim _channel As Integer = Conversions.ToInteger(streamReader.ReadLine())
                Dim channelLength As Integer = Conversions.ToInteger(streamReader.ReadLine())
                midiSequence(_channel) = New SequenceData
                For j = 0 To channelLength - 1 Step 1
                    Dim data As Integer = Conversions.ToInteger(streamReader.ReadLine())
                    Dim dtime As System.TimeSpan = TimeSpan.Parse(streamReader.ReadLine())
                    midiSequence(_channel).AddSequenceData(data, dtime)
                Next j
            Next i

            'change UI
            btnPlay.Enabled = True
            btnRemoveSilence.Enabled = True
            cbxLoop.Enabled = True
        End If
    End Sub

    Private Sub vsbPitchBend_Release(sender As Object, e As EventArgs) Handles vsbPitchBend.MouseLeave
        vsbPitchBend.Value = 0
        PitchBend = 8192
    End Sub

    Private Sub vsbPitchBend_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbPitchBend.Scroll
        PitchBend = vsbPitchBend.Value + 8192
    End Sub
End Class
