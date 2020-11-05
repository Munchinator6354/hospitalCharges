<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hospitalCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hospitalCharges))
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVisitDuration = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblSurgicalFees = New System.Windows.Forms.Label()
        Me.lblLabFees = New System.Windows.Forms.Label()
        Me.lblPhysical = New System.Windows.Forms.Label()
        Me.txtVisitDuration = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtSurgicalFees = New System.Windows.Forms.TextBox()
        Me.txtLabFees = New System.Windows.Forms.TextBox()
        Me.txtPhysical = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBill = New System.Windows.Forms.GroupBox()
        Me.lblPerDayMed = New System.Windows.Forms.Label()
        Me.lblPerDaySurg = New System.Windows.Forms.Label()
        Me.lblPerDayLab = New System.Windows.Forms.Label()
        Me.lblPerDayPhys = New System.Windows.Forms.Label()
        Me.lblTotalBill = New System.Windows.Forms.Label()
        Me.lblTotalBillDescription = New System.Windows.Forms.Label()
        Me.lblDurationDescription = New System.Windows.Forms.Label()
        Me.picAmericanFlag = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBill.SuspendLayout()
        CType(Me.picAmericanFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(3, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(121, 34)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall 2020"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(166, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(447, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "American Hospital Bill Calculator"
        '
        'lblVisitDuration
        '
        Me.lblVisitDuration.AutoSize = True
        Me.lblVisitDuration.Location = New System.Drawing.Point(34, 19)
        Me.lblVisitDuration.Name = "lblVisitDuration"
        Me.lblVisitDuration.Size = New System.Drawing.Size(96, 17)
        Me.lblVisitDuration.TabIndex = 0
        Me.lblVisitDuration.Text = "Visit Duration:"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Location = New System.Drawing.Point(34, 53)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(80, 17)
        Me.lblMedication.TabIndex = 3
        Me.lblMedication.Text = "Medication:"
        '
        'lblSurgicalFees
        '
        Me.lblSurgicalFees.AutoSize = True
        Me.lblSurgicalFees.Location = New System.Drawing.Point(34, 84)
        Me.lblSurgicalFees.Name = "lblSurgicalFees"
        Me.lblSurgicalFees.Size = New System.Drawing.Size(98, 17)
        Me.lblSurgicalFees.TabIndex = 6
        Me.lblSurgicalFees.Text = "Surgical Fees:"
        '
        'lblLabFees
        '
        Me.lblLabFees.AutoSize = True
        Me.lblLabFees.Location = New System.Drawing.Point(34, 113)
        Me.lblLabFees.Name = "lblLabFees"
        Me.lblLabFees.Size = New System.Drawing.Size(71, 17)
        Me.lblLabFees.TabIndex = 9
        Me.lblLabFees.Text = "Lab Fees:"
        '
        'lblPhysical
        '
        Me.lblPhysical.AutoSize = True
        Me.lblPhysical.Location = New System.Drawing.Point(34, 146)
        Me.lblPhysical.Name = "lblPhysical"
        Me.lblPhysical.Size = New System.Drawing.Size(64, 17)
        Me.lblPhysical.TabIndex = 12
        Me.lblPhysical.Text = "Physical:"
        '
        'txtVisitDuration
        '
        Me.txtVisitDuration.Location = New System.Drawing.Point(136, 19)
        Me.txtVisitDuration.Name = "txtVisitDuration"
        Me.txtVisitDuration.Size = New System.Drawing.Size(100, 22)
        Me.txtVisitDuration.TabIndex = 1
        Me.txtVisitDuration.Text = "0"
        Me.txtVisitDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(136, 50)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(100, 22)
        Me.txtMedication.TabIndex = 4
        Me.txtMedication.Text = "0.00"
        Me.txtMedication.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSurgicalFees
        '
        Me.txtSurgicalFees.Location = New System.Drawing.Point(136, 81)
        Me.txtSurgicalFees.Name = "txtSurgicalFees"
        Me.txtSurgicalFees.Size = New System.Drawing.Size(100, 22)
        Me.txtSurgicalFees.TabIndex = 7
        Me.txtSurgicalFees.Text = "0.00"
        Me.txtSurgicalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLabFees
        '
        Me.txtLabFees.Location = New System.Drawing.Point(136, 110)
        Me.txtLabFees.Name = "txtLabFees"
        Me.txtLabFees.Size = New System.Drawing.Size(100, 22)
        Me.txtLabFees.TabIndex = 10
        Me.txtLabFees.Text = "0.00"
        Me.txtLabFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPhysical
        '
        Me.txtPhysical.Location = New System.Drawing.Point(136, 143)
        Me.txtPhysical.Name = "txtPhysical"
        Me.txtPhysical.Size = New System.Drawing.Size(100, 22)
        Me.txtPhysical.TabIndex = 13
        Me.txtPhysical.Text = "0.00"
        Me.txtPhysical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(130, 357)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(162, 52)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charges"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(298, 357)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(162, 52)
        Me.btnClearForm.TabIndex = 4
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(466, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 52)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpBill
        '
        Me.grpBill.Controls.Add(Me.lblDurationDescription)
        Me.grpBill.Controls.Add(Me.lblTotalBillDescription)
        Me.grpBill.Controls.Add(Me.lblTotalBill)
        Me.grpBill.Controls.Add(Me.lblPerDayPhys)
        Me.grpBill.Controls.Add(Me.lblPerDayLab)
        Me.grpBill.Controls.Add(Me.lblPerDaySurg)
        Me.grpBill.Controls.Add(Me.lblPerDayMed)
        Me.grpBill.Controls.Add(Me.txtPhysical)
        Me.grpBill.Controls.Add(Me.txtLabFees)
        Me.grpBill.Controls.Add(Me.txtSurgicalFees)
        Me.grpBill.Controls.Add(Me.txtMedication)
        Me.grpBill.Controls.Add(Me.txtVisitDuration)
        Me.grpBill.Controls.Add(Me.lblPhysical)
        Me.grpBill.Controls.Add(Me.lblLabFees)
        Me.grpBill.Controls.Add(Me.lblSurgicalFees)
        Me.grpBill.Controls.Add(Me.lblMedication)
        Me.grpBill.Controls.Add(Me.lblVisitDuration)
        Me.grpBill.Location = New System.Drawing.Point(209, 86)
        Me.grpBill.Name = "grpBill"
        Me.grpBill.Size = New System.Drawing.Size(344, 265)
        Me.grpBill.TabIndex = 2
        Me.grpBill.TabStop = False
        '
        'lblPerDayMed
        '
        Me.lblPerDayMed.AutoSize = True
        Me.lblPerDayMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerDayMed.Location = New System.Drawing.Point(242, 53)
        Me.lblPerDayMed.Name = "lblPerDayMed"
        Me.lblPerDayMed.Size = New System.Drawing.Size(103, 16)
        Me.lblPerDayMed.TabIndex = 5
        Me.lblPerDayMed.Text = "Dollars Per Day"
        '
        'lblPerDaySurg
        '
        Me.lblPerDaySurg.AutoSize = True
        Me.lblPerDaySurg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerDaySurg.Location = New System.Drawing.Point(242, 81)
        Me.lblPerDaySurg.Name = "lblPerDaySurg"
        Me.lblPerDaySurg.Size = New System.Drawing.Size(103, 16)
        Me.lblPerDaySurg.TabIndex = 8
        Me.lblPerDaySurg.Text = "Dollars Per Day"
        '
        'lblPerDayLab
        '
        Me.lblPerDayLab.AutoSize = True
        Me.lblPerDayLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerDayLab.Location = New System.Drawing.Point(242, 113)
        Me.lblPerDayLab.Name = "lblPerDayLab"
        Me.lblPerDayLab.Size = New System.Drawing.Size(103, 16)
        Me.lblPerDayLab.TabIndex = 11
        Me.lblPerDayLab.Text = "Dollars Per Day"
        '
        'lblPerDayPhys
        '
        Me.lblPerDayPhys.AutoSize = True
        Me.lblPerDayPhys.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerDayPhys.Location = New System.Drawing.Point(242, 148)
        Me.lblPerDayPhys.Name = "lblPerDayPhys"
        Me.lblPerDayPhys.Size = New System.Drawing.Size(103, 16)
        Me.lblPerDayPhys.TabIndex = 14
        Me.lblPerDayPhys.Text = "Dollars Per Day"
        '
        'lblTotalBill
        '
        Me.lblTotalBill.AutoSize = True
        Me.lblTotalBill.Location = New System.Drawing.Point(190, 194)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(0, 17)
        Me.lblTotalBill.TabIndex = 16
        '
        'lblTotalBillDescription
        '
        Me.lblTotalBillDescription.AutoSize = True
        Me.lblTotalBillDescription.Location = New System.Drawing.Point(34, 192)
        Me.lblTotalBillDescription.Name = "lblTotalBillDescription"
        Me.lblTotalBillDescription.Size = New System.Drawing.Size(288, 51)
        Me.lblTotalBillDescription.TabIndex = 15
        Me.lblTotalBillDescription.Text = "Total Amount Owed:   $" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                    + Your 1 Arm && 1 Leg" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If no insurance            + First Born Child"
        '
        'lblDurationDescription
        '
        Me.lblDurationDescription.AutoSize = True
        Me.lblDurationDescription.Location = New System.Drawing.Point(242, 22)
        Me.lblDurationDescription.Name = "lblDurationDescription"
        Me.lblDurationDescription.Size = New System.Drawing.Size(40, 17)
        Me.lblDurationDescription.TabIndex = 2
        Me.lblDurationDescription.Text = "Days"
        '
        'picAmericanFlag
        '
        Me.picAmericanFlag.Image = CType(resources.GetObject("picAmericanFlag.Image"), System.Drawing.Image)
        Me.picAmericanFlag.Location = New System.Drawing.Point(22, 105)
        Me.picAmericanFlag.Name = "picAmericanFlag"
        Me.picAmericanFlag.Size = New System.Drawing.Size(181, 102)
        Me.picAmericanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAmericanFlag.TabIndex = 16
        Me.picAmericanFlag.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(560, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'hospitalCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picAmericanFlag)
        Me.Controls.Add(Me.grpBill)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblID)
        Me.Name = "hospitalCharges"
        Me.Text = "American Hospital Bill Calculator"
        Me.grpBill.ResumeLayout(False)
        Me.grpBill.PerformLayout()
        CType(Me.picAmericanFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVisitDuration As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblSurgicalFees As Label
    Friend WithEvents lblLabFees As Label
    Friend WithEvents lblPhysical As Label
    Friend WithEvents txtVisitDuration As TextBox
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents txtSurgicalFees As TextBox
    Friend WithEvents txtLabFees As TextBox
    Friend WithEvents txtPhysical As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpBill As GroupBox
    Friend WithEvents lblPerDayPhys As Label
    Friend WithEvents lblPerDayLab As Label
    Friend WithEvents lblPerDaySurg As Label
    Friend WithEvents lblPerDayMed As Label
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents lblTotalBillDescription As Label
    Friend WithEvents lblDurationDescription As Label
    Friend WithEvents picAmericanFlag As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
