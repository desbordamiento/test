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
                Me.lblWholeCost = New System.Windows.Forms.Label()
                Me.lblMarkup = New System.Windows.Forms.Label()
                Me.lblRetail = New System.Windows.Forms.Label()
                Me.txtWholeCost = New System.Windows.Forms.TextBox()
                Me.txtMarkup = New System.Windows.Forms.TextBox()
                Me.lblRetailOut = New System.Windows.Forms.Label()
                Me.btnGetRetail = New System.Windows.Forms.Button()
                Me.btnExit = New System.Windows.Forms.Button()
                Me.SuspendLayout()
                '
                'lblWholeCost
                '
                Me.lblWholeCost.AutoSize = True
                Me.lblWholeCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblWholeCost.Location = New System.Drawing.Point(16, 52)
                Me.lblWholeCost.Name = "lblWholeCost"
                Me.lblWholeCost.Size = New System.Drawing.Size(174, 20)
                Me.lblWholeCost.TabIndex = 0
                Me.lblWholeCost.Text = "Wholesale Cost of Item"
                '
                'lblMarkup
                '
                Me.lblMarkup.AutoSize = True
                Me.lblMarkup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblMarkup.Location = New System.Drawing.Point(110, 109)
                Me.lblMarkup.Name = "lblMarkup"
                Me.lblMarkup.Size = New System.Drawing.Size(80, 20)
                Me.lblMarkup.TabIndex = 1
                Me.lblMarkup.Text = "Markup %"
                '
                'lblRetail
                '
                Me.lblRetail.AutoSize = True
                Me.lblRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblRetail.Location = New System.Drawing.Point(101, 168)
                Me.lblRetail.Name = "lblRetail"
                Me.lblRetail.Size = New System.Drawing.Size(89, 20)
                Me.lblRetail.TabIndex = 2
                Me.lblRetail.Text = "Retail Price"
                '
                'txtWholeCost
                '
                Me.txtWholeCost.Location = New System.Drawing.Point(196, 52)
                Me.txtWholeCost.Name = "txtWholeCost"
                Me.txtWholeCost.Size = New System.Drawing.Size(154, 20)
                Me.txtWholeCost.TabIndex = 3
                '
                'txtMarkup
                '
                Me.txtMarkup.Location = New System.Drawing.Point(196, 109)
                Me.txtMarkup.Name = "txtMarkup"
                Me.txtMarkup.Size = New System.Drawing.Size(154, 20)
                Me.txtMarkup.TabIndex = 4
                '
                'lblRetailOut
                '
                Me.lblRetailOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                Me.lblRetailOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblRetailOut.Location = New System.Drawing.Point(192, 168)
                Me.lblRetailOut.Name = "lblRetailOut"
                Me.lblRetailOut.Size = New System.Drawing.Size(158, 20)
                Me.lblRetailOut.TabIndex = 5
                '
                'btnGetRetail
                '
                Me.btnGetRetail.Location = New System.Drawing.Point(12, 216)
                Me.btnGetRetail.Name = "btnGetRetail"
                Me.btnGetRetail.Size = New System.Drawing.Size(177, 82)
                Me.btnGetRetail.TabIndex = 6
                Me.btnGetRetail.Text = "Get Retail"
                Me.btnGetRetail.UseVisualStyleBackColor = True
                '
                'btnExit
                '
                Me.btnExit.Location = New System.Drawing.Point(196, 216)
                Me.btnExit.Name = "btnExit"
                Me.btnExit.Size = New System.Drawing.Size(177, 82)
                Me.btnExit.TabIndex = 7
                Me.btnExit.Text = "Exit"
                Me.btnExit.UseVisualStyleBackColor = True
                '
                'Form1
                '
                Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                Me.ClientSize = New System.Drawing.Size(377, 311)
                Me.Controls.Add(Me.btnExit)
                Me.Controls.Add(Me.btnGetRetail)
                Me.Controls.Add(Me.lblRetailOut)
                Me.Controls.Add(Me.txtMarkup)
                Me.Controls.Add(Me.txtWholeCost)
                Me.Controls.Add(Me.lblRetail)
                Me.Controls.Add(Me.lblMarkup)
                Me.Controls.Add(Me.lblWholeCost)
                Me.Name = "Form1"
                Me.Text = "Retail Price Calculator"
                Me.ResumeLayout(False)
                Me.PerformLayout()

        End Sub

        Friend WithEvents lblWholeCost As Label
        Friend WithEvents lblMarkup As Label
        Friend WithEvents lblRetail As Label
        Friend WithEvents txtWholeCost As TextBox
        Friend WithEvents txtMarkup As TextBox
        Friend WithEvents lblRetailOut As Label
        Friend WithEvents btnGetRetail As Button
        Friend WithEvents btnExit As Button
End Class
