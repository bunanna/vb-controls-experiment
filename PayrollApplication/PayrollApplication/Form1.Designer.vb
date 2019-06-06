<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radMarried = New System.Windows.Forms.RadioButton()
        Me.txtExemptions = New System.Windows.Forms.TextBox()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYearToDateEarnings = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblGrossEarnings = New System.Windows.Forms.Label()
        Me.lblFicaTax = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblUpdatedEarnings = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTotalGrossPay = New System.Windows.Forms.Label()
        Me.lblTotalFicaTax = New System.Windows.Forms.Label()
        Me.lblTotalWithheldTax = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHideSummary = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marital Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Withholding" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exemptions:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hourly Wage:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hours Worked:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 30)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 22)
        Me.txtName.TabIndex = 0
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(33, 101)
        Me.radSingle.Margin = New System.Windows.Forms.Padding(4)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(68, 21)
        Me.radSingle.TabIndex = 1
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'radMarried
        '
        Me.radMarried.AutoSize = True
        Me.radMarried.BackColor = System.Drawing.Color.WhiteSmoke
        Me.radMarried.Location = New System.Drawing.Point(33, 129)
        Me.radMarried.Margin = New System.Windows.Forms.Padding(4)
        Me.radMarried.Name = "radMarried"
        Me.radMarried.Size = New System.Drawing.Size(77, 21)
        Me.radMarried.TabIndex = 2
        Me.radMarried.TabStop = True
        Me.radMarried.Text = "Married"
        Me.radMarried.UseVisualStyleBackColor = False
        '
        'txtExemptions
        '
        Me.txtExemptions.Location = New System.Drawing.Point(113, 176)
        Me.txtExemptions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExemptions.Name = "txtExemptions"
        Me.txtExemptions.Size = New System.Drawing.Size(97, 22)
        Me.txtExemptions.TabIndex = 3
        '
        'txtHourlyWage
        '
        Me.txtHourlyWage.Location = New System.Drawing.Point(149, 31)
        Me.txtHourlyWage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(97, 22)
        Me.txtHourlyWage.TabIndex = 4
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(149, 97)
        Me.txtHoursWorked.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(97, 22)
        Me.txtHoursWorked.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 153)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 51)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Previous" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year-to-Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Earnings:"
        '
        'txtYTDEarnings
        '
        Me.txtYearToDateEarnings.Location = New System.Drawing.Point(149, 165)
        Me.txtYearToDateEarnings.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYearToDateEarnings.Name = "txtYTDEarnings"
        Me.txtYearToDateEarnings.Size = New System.Drawing.Size(97, 22)
        Me.txtYearToDateEarnings.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExemptions)
        Me.GroupBox1.Controls.Add(Me.radMarried)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(265, 226)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtYearToDateEarnings)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtHoursWorked)
        Me.GroupBox2.Controls.Add(Me.txtHourlyWage)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 74)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(279, 226)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wage Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 101)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gross Earnings:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "FICA Tax:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 173)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 34)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Federal Income " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax Withheld:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 224)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Net Earnings:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 251)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 51)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Updated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year-to-Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Earnings:"
        '
        'lblGrossEarnings
        '
        Me.lblGrossEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossEarnings.Location = New System.Drawing.Point(124, 100)
        Me.lblGrossEarnings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGrossEarnings.Name = "lblGrossEarnings"
        Me.lblGrossEarnings.Size = New System.Drawing.Size(133, 25)
        Me.lblGrossEarnings.TabIndex = 22
        '
        'lblFicaTax
        '
        Me.lblFicaTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFicaTax.Location = New System.Drawing.Point(124, 141)
        Me.lblFicaTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFicaTax.Name = "lblFicaTax"
        Me.lblFicaTax.Size = New System.Drawing.Size(133, 25)
        Me.lblFicaTax.TabIndex = 23
        '
        'lblFedTax
        '
        Me.lblFedTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFedTax.Location = New System.Drawing.Point(124, 180)
        Me.lblFedTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(133, 25)
        Me.lblFedTax.TabIndex = 24
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetPay.Location = New System.Drawing.Point(124, 223)
        Me.lblNetPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(133, 25)
        Me.lblNetPay.TabIndex = 25
        '
        'lblUpdatedEarnings
        '
        Me.lblUpdatedEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdatedEarnings.Location = New System.Drawing.Point(124, 264)
        Me.lblUpdatedEarnings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdatedEarnings.Name = "lblUpdatedEarnings"
        Me.lblUpdatedEarnings.Size = New System.Drawing.Size(133, 25)
        Me.lblUpdatedEarnings.TabIndex = 26
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblUpdatedEarnings)
        Me.GroupBox3.Controls.Add(Me.lblNetPay)
        Me.GroupBox3.Controls.Add(Me.lblFedTax)
        Me.GroupBox3.Controls.Add(Me.lblName)
        Me.GroupBox3.Controls.Add(Me.lblFicaTax)
        Me.GroupBox3.Controls.Add(Me.lblGrossEarnings)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 325)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(265, 328)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pay Information"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(62, 38)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(195, 25)
        Me.lblName.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 39)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 17)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Name:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(30, 682)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(265, 31)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 60)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 34)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Total Gross" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Earnings:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 134)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 34)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Total FICA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tax Paid:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 211)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 51)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Total Federal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Income Tax" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paid:"
        '
        'lblTotalGrossPay
        '
        Me.lblTotalGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossPay.Location = New System.Drawing.Point(128, 63)
        Me.lblTotalGrossPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalGrossPay.Name = "lblTotalGrossPay"
        Me.lblTotalGrossPay.Size = New System.Drawing.Size(133, 25)
        Me.lblTotalGrossPay.TabIndex = 36
        '
        'lblTotalFicaTax
        '
        Me.lblTotalFicaTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFicaTax.Location = New System.Drawing.Point(128, 142)
        Me.lblTotalFicaTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalFicaTax.Name = "lblTotalFicaTax"
        Me.lblTotalFicaTax.Size = New System.Drawing.Size(133, 25)
        Me.lblTotalFicaTax.TabIndex = 37
        '
        'lblTotalWithheldTax
        '
        Me.lblTotalWithheldTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWithheldTax.Location = New System.Drawing.Point(128, 222)
        Me.lblTotalWithheldTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalWithheldTax.Name = "lblTotalWithheldTax"
        Me.lblTotalWithheldTax.Size = New System.Drawing.Size(133, 25)
        Me.lblTotalWithheldTax.TabIndex = 38
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalWithheldTax)
        Me.GroupBox4.Controls.Add(Me.lblTotalFicaTax)
        Me.GroupBox4.Controls.Add(Me.lblTotalGrossPay)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Location = New System.Drawing.Point(355, 325)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(277, 328)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payroll Summary"
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(30, 732)
        Me.btnNextEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(265, 31)
        Me.btnNextEmployee.TabIndex = 8
        Me.btnNextEmployee.Text = "&Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(30, 787)
        Me.btnSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(265, 31)
        Me.btnSummary.TabIndex = 9
        Me.btnSummary.Text = "Payroll &Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(355, 787)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(277, 31)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 861)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(659, 22)
        Me.StatusStrip1.TabIndex = 42
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'btnHideSummary
        '
        Me.btnHideSummary.Location = New System.Drawing.Point(355, 682)
        Me.btnHideSummary.Name = "btnHideSummary"
        Me.btnHideSummary.Size = New System.Drawing.Size(277, 31)
        Me.btnHideSummary.TabIndex = 10
        Me.btnHideSummary.Text = "&Hide Payroll Summary"
        Me.btnHideSummary.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(355, 732)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(277, 31)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(193, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(287, 43)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Payroll Application"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(659, 883)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHideSummary)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Payroll Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents radMarried As System.Windows.Forms.RadioButton
    Friend WithEvents txtExemptions As System.Windows.Forms.TextBox
    Friend WithEvents txtHourlyWage As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYearToDateEarnings As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblGrossEarnings As System.Windows.Forms.Label
    Friend WithEvents lblFicaTax As System.Windows.Forms.Label
    Friend WithEvents lblFedTax As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents lblUpdatedEarnings As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblTotalGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblTotalFicaTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalWithheldTax As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNextEmployee As System.Windows.Forms.Button
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnHideSummary As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label12 As Label
End Class
