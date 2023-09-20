<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_transactions))
        Me.txtMemName = New System.Windows.Forms.TextBox()
        Me.txtTransactionType = New System.Windows.Forms.TextBox()
        Me.txtTransactionAmount = New System.Windows.Forms.TextBox()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.lblMemUsername = New System.Windows.Forms.Label()
        Me.lblMemName = New System.Windows.Forms.Label()
        Me.lblTransactionType = New System.Windows.Forms.Label()
        Me.lblTransactionDate = New System.Windows.Forms.Label()
        Me.lblTransactionAmount = New System.Windows.Forms.Label()
        Me.txtTransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalBalance = New System.Windows.Forms.TextBox()
        Me.dgAddTransaction = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMemUserName = New System.Windows.Forms.ComboBox()
        CType(Me.dgAddTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMemName
        '
        Me.txtMemName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemName.Location = New System.Drawing.Point(405, 174)
        Me.txtMemName.Name = "txtMemName"
        Me.txtMemName.Size = New System.Drawing.Size(268, 26)
        Me.txtMemName.TabIndex = 76
        '
        'txtTransactionType
        '
        Me.txtTransactionType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionType.Location = New System.Drawing.Point(12, 224)
        Me.txtTransactionType.Name = "txtTransactionType"
        Me.txtTransactionType.Size = New System.Drawing.Size(268, 26)
        Me.txtTransactionType.TabIndex = 77
        '
        'txtTransactionAmount
        '
        Me.txtTransactionAmount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTransactionAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionAmount.Location = New System.Drawing.Point(12, 272)
        Me.txtTransactionAmount.Name = "txtTransactionAmount"
        Me.txtTransactionAmount.Size = New System.Drawing.Size(268, 26)
        Me.txtTransactionAmount.TabIndex = 78
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddTransaction.FlatAppearance.BorderSize = 0
        Me.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTransaction.ForeColor = System.Drawing.Color.White
        Me.btnAddTransaction.Location = New System.Drawing.Point(275, 317)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(138, 36)
        Me.btnAddTransaction.TabIndex = 149
        Me.btnAddTransaction.Text = "Add"
        Me.btnAddTransaction.UseVisualStyleBackColor = False
        '
        'lblMemUsername
        '
        Me.lblMemUsername.AutoSize = True
        Me.lblMemUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemUsername.ForeColor = System.Drawing.Color.Black
        Me.lblMemUsername.Location = New System.Drawing.Point(12, 157)
        Me.lblMemUsername.Name = "lblMemUsername"
        Me.lblMemUsername.Size = New System.Drawing.Size(115, 16)
        Me.lblMemUsername.TabIndex = 150
        Me.lblMemUsername.Text = "MemUserName"
        '
        'lblMemName
        '
        Me.lblMemName.AutoSize = True
        Me.lblMemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemName.ForeColor = System.Drawing.Color.Black
        Me.lblMemName.Location = New System.Drawing.Point(402, 155)
        Me.lblMemName.Name = "lblMemName"
        Me.lblMemName.Size = New System.Drawing.Size(82, 16)
        Me.lblMemName.TabIndex = 151
        Me.lblMemName.Text = "MemName"
        '
        'lblTransactionType
        '
        Me.lblTransactionType.AutoSize = True
        Me.lblTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionType.ForeColor = System.Drawing.Color.Black
        Me.lblTransactionType.Location = New System.Drawing.Point(12, 205)
        Me.lblTransactionType.Name = "lblTransactionType"
        Me.lblTransactionType.Size = New System.Drawing.Size(126, 16)
        Me.lblTransactionType.TabIndex = 152
        Me.lblTransactionType.Text = "TransactionType"
        '
        'lblTransactionDate
        '
        Me.lblTransactionDate.AutoSize = True
        Me.lblTransactionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransactionDate.Location = New System.Drawing.Point(402, 203)
        Me.lblTransactionDate.Name = "lblTransactionDate"
        Me.lblTransactionDate.Size = New System.Drawing.Size(123, 16)
        Me.lblTransactionDate.TabIndex = 153
        Me.lblTransactionDate.Text = "TransactionDate"
        '
        'lblTransactionAmount
        '
        Me.lblTransactionAmount.AutoSize = True
        Me.lblTransactionAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionAmount.ForeColor = System.Drawing.Color.Black
        Me.lblTransactionAmount.Location = New System.Drawing.Point(12, 253)
        Me.lblTransactionAmount.Name = "lblTransactionAmount"
        Me.lblTransactionAmount.Size = New System.Drawing.Size(141, 16)
        Me.lblTransactionAmount.TabIndex = 154
        Me.lblTransactionAmount.Text = "TransactionAmount"
        '
        'txtTransactionDate
        '
        Me.txtTransactionDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.txtTransactionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionDate.Location = New System.Drawing.Point(405, 222)
        Me.txtTransactionDate.Name = "txtTransactionDate"
        Me.txtTransactionDate.Size = New System.Drawing.Size(268, 26)
        Me.txtTransactionDate.TabIndex = 155
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(402, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Total Balance"
        '
        'txtTotalBalance
        '
        Me.txtTotalBalance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBalance.Location = New System.Drawing.Point(405, 272)
        Me.txtTotalBalance.Name = "txtTotalBalance"
        Me.txtTotalBalance.Size = New System.Drawing.Size(268, 26)
        Me.txtTotalBalance.TabIndex = 157
        '
        'dgAddTransaction
        '
        Me.dgAddTransaction.BackgroundColor = System.Drawing.Color.White
        Me.dgAddTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAddTransaction.Location = New System.Drawing.Point(15, 359)
        Me.dgAddTransaction.Name = "dgAddTransaction"
        Me.dgAddTransaction.Size = New System.Drawing.Size(658, 339)
        Me.dgAddTransaction.TabIndex = 158
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button4.Location = New System.Drawing.Point(658, -1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 31)
        Me.Button4.TabIndex = 163
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(183, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 39)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label24.Location = New System.Drawing.Point(292, 49)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(136, 15)
        Me.Label24.TabIndex = 161
        Me.Label24.Text = "REGISTERED OFFICE :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 160
        Me.PictureBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label20.Location = New System.Drawing.Point(132, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(520, 25)
        Me.Label20.TabIndex = 159
        Me.Label20.Text = "Daystar Multi-Purpose Co-operative Society Ltd." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(177, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 24)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "MEMBER TRANSACTIONS FORM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(275, 733)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 36)
        Me.Button1.TabIndex = 199
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMemUserName
        '
        Me.txtMemUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMemUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemUserName.FormattingEnabled = True
        Me.txtMemUserName.Location = New System.Drawing.Point(12, 174)
        Me.txtMemUserName.Name = "txtMemUserName"
        Me.txtMemUserName.Size = New System.Drawing.Size(268, 26)
        Me.txtMemUserName.TabIndex = 269
        '
        'add_transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 832)
        Me.Controls.Add(Me.txtMemUserName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dgAddTransaction)
        Me.Controls.Add(Me.txtTotalBalance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTransactionDate)
        Me.Controls.Add(Me.lblTransactionAmount)
        Me.Controls.Add(Me.lblTransactionDate)
        Me.Controls.Add(Me.lblTransactionType)
        Me.Controls.Add(Me.lblMemName)
        Me.Controls.Add(Me.lblMemUsername)
        Me.Controls.Add(Me.btnAddTransaction)
        Me.Controls.Add(Me.txtTransactionAmount)
        Me.Controls.Add(Me.txtTransactionType)
        Me.Controls.Add(Me.txtMemName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_transactions"
        CType(Me.dgAddTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemName As TextBox
    Friend WithEvents txtTransactionType As TextBox
    Friend WithEvents txtTransactionAmount As TextBox
    Friend WithEvents btnAddTransaction As Button
    Friend WithEvents lblMemUsername As Label
    Friend WithEvents lblMemName As Label
    Friend WithEvents lblTransactionType As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblTransactionAmount As Label
    Friend WithEvents txtTransactionDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalBalance As TextBox
    Friend WithEvents dgAddTransaction As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMemUserName As ComboBox
End Class
