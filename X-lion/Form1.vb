Imports dll
Imports dll.Class1

Public Class Form1
    Dim int As Integer = 0
    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        ToolStripProgressBar1.Maximum = e.MaximumProgress
        ToolStripProgressBar1.Value = e.CurrentProgress
    End Sub

    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        ComboBox1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
       

    End Sub

    Private Sub صفحةجديدةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صفحةجديدةToolStripMenuItem.Click

        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Private Sub اغلاقالصفحهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اغلاقالصفحهToolStripMenuItem.Click

        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ComboBox1.Text)
    End Sub

    Private Sub خصائصToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pro.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub

    Private Sub حولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حولToolStripMenuItem.Click
        MsgBox("Developed by Raidan Shugaa Addin. 2015", MsgBoxStyle.Information)
    End Sub

    Private Sub نسخهالبرنامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نسخهالبرنامجToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub التواصلمعناToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles التواصلمعناToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ToolStripProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RedemptionButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton1.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ComboBox1.Text)
    End Sub

    Private Sub RedemptionButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton2.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Private Sub RedemptionButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton3.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub RedemptionButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionButton4.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripProgressBar1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub XLionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XLionToolStripMenuItem.Click

    End Sub

    Private Sub تغييرالثيمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تغييرالثيمToolStripMenuItem.Click
        ColorDialog1.Color = Me.BackColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
        End If
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub اعداداتالخطToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FontDialog1.ShowDialog()

    End Sub

    Private Sub تنزيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()
    End Sub

    Private Sub التنزيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles التنزيلToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub QuickPortScannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickPortScannerToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Dim computer As New Class1
        If ToolStripStatusLabel2.Visible = My.Computer.Keyboard.CapsLock Then
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
