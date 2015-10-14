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
		Me.lstWrkshp = New System.Windows.Forms.ListBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lstLocation = New System.Windows.Forms.ListBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lstSelWrkshp = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.btnAddWrkshp = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lstWrkshp
		'
		Me.lstWrkshp.FormattingEnabled = True
		Me.lstWrkshp.ItemHeight = 16
		Me.lstWrkshp.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotation", "How to Interview"})
		Me.lstWrkshp.Location = New System.Drawing.Point(16, 19)
		Me.lstWrkshp.Name = "lstWrkshp"
		Me.lstWrkshp.Size = New System.Drawing.Size(156, 100)
		Me.lstWrkshp.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lstWrkshp)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(15, 20)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(187, 134)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Pick a Workshop"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lstLocation)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(208, 20)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(187, 134)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Pick a Location"
		'
		'lstLocation
		'
		Me.lstLocation.FormattingEnabled = True
		Me.lstLocation.ItemHeight = 16
		Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Pheonix", "Raleigh"})
		Me.lstLocation.Location = New System.Drawing.Point(16, 19)
		Me.lstLocation.Name = "lstLocation"
		Me.lstLocation.Size = New System.Drawing.Size(153, 100)
		Me.lstLocation.TabIndex = 0
		'
		'GroupBox3
		'
		Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox3.Controls.Add(Me.lstSelWrkshp)
		Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox3.Location = New System.Drawing.Point(401, 20)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(292, 134)
		Me.GroupBox3.TabIndex = 3
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Selected Workshops"
		'
		'lstSelWrkshp
		'
		Me.lstSelWrkshp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstSelWrkshp.FormattingEnabled = True
		Me.lstSelWrkshp.ItemHeight = 16
		Me.lstSelWrkshp.Location = New System.Drawing.Point(17, 19)
		Me.lstSelWrkshp.Name = "lstSelWrkshp"
		Me.lstSelWrkshp.Size = New System.Drawing.Size(257, 100)
		Me.lstSelWrkshp.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(93, 176)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(154, 17)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Total for all workshops:"
		'
		'lblTotal
		'
		Me.lblTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotal.Location = New System.Drawing.Point(254, 176)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(97, 23)
		Me.lblTotal.TabIndex = 5
		Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnAddWrkshp
		'
		Me.btnAddWrkshp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAddWrkshp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddWrkshp.Location = New System.Drawing.Point(159, 231)
		Me.btnAddWrkshp.Name = "btnAddWrkshp"
		Me.btnAddWrkshp.Size = New System.Drawing.Size(128, 31)
		Me.btnAddWrkshp.TabIndex = 6
		Me.btnAddWrkshp.Text = "Add Workshop"
		Me.btnAddWrkshp.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReset.Location = New System.Drawing.Point(293, 231)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(110, 31)
		Me.btnReset.TabIndex = 7
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(409, 231)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(92, 31)
		Me.btnExit.TabIndex = 8
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnRemove
		'
		Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRemove.Location = New System.Drawing.Point(496, 176)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(92, 28)
		Me.btnRemove.TabIndex = 9
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 299)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(705, 22)
		Me.StatusStrip1.TabIndex = 10
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(705, 321)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnRemove)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnAddWrkshp)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Workshop Selector"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lstWrkshp As ListBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents lstLocation As ListBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents lstSelWrkshp As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents btnAddWrkshp As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents btnRemove As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
