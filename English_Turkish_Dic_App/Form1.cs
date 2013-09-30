using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;

namespace English_Turkish_Dic_App
{
    public partial class frm_treng : Form
    {
        public frm_treng()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region All Variables
        static readonly private string cmlPath = string.Concat(System.Environment.CurrentDirectory, "/Treng.xml");
        private static readonly List<Vocabulary> all_content = new List<Vocabulary>();
        private static readonly ListView.ListViewItemCollection collection = new ListView.ListViewItemCollection(new ListView());
        private int locationX = 0, locationY = 0, widthF = 0, heightF = 0;
        Point tiklanan_Yer, size;
        private int? index = null;
        bool isSearched = false;
        private bool isEditing = false;
        #endregion

        private void txtEng_Enter(object sender, EventArgs e)
        {
            txtEng.Text = txtEng.Text == "English" ? "" : txtEng.Text;
        }

        private void txtTur_Enter(object sender, EventArgs e)
        {
            txtTur.Text = txtTur.Text == "Turkish" ? "" : txtTur.Text;
        }

        private int CreateXml()
        {
            try
            {
                if (!File.Exists(cmlPath))
                    return -1;
                bool sameEng = false, sameTur = false;
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(cmlPath);
                string[] kelimelerTr = txtTur.Text.Trim().ToLower().Split(',');

                foreach (Vocabulary item in all_content)
                {
                    if (item.Eng_ver == txtEng.Text.Trim().ToLower())
                        sameEng = true;

                    foreach (string item2 in item.Tr_ver)
                    {
                        for (int i = 0; i < kelimelerTr.Length; i++)
                        {
                            if (item2 == kelimelerTr[i] && sameEng)
                            {
                                sameTur = true;
                                break;
                            }
                        }
                    }

                    if (sameTur && sameEng)
                        return -2;
                    else if (sameEng && !sameTur)
                        break;
                }

                if (sameEng && !sameTur)
                {
                    //yeni element oluşturmadan kaydet türkçesini
                    foreach (XmlNode item in xdoc.SelectNodes("Items/Item"))
                    {
                        if (item["English"].InnerText == txtEng.Text)
                        {
                            if (kelimelerTr.Length >= 1)
                            {
                                for (int i = 0; i < kelimelerTr.Length; i++)
                                {
                                    XmlNode newWord = xdoc.CreateNode(XmlNodeType.Element, "Word", "");
                                    newWord.InnerText = kelimelerTr[i].Trim();
                                    item["Turkish"].AppendChild(newWord);
                                }
                            }
                        }
                    }
                }
                else
                {
                    // yeni item oluştur.
                    XmlElement newElem = xdoc.CreateElement("Item");
                    //newElem.SetAttribute("ID", (xdoc.ChildNodes[2].ChildNodes.Count + 1).ToString());
                    newElem.SetAttribute("Date", DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString());
                    //XmlNode newElem = xdoc.CreateNode(XmlNodeType.Element, "Item", "");

                    XmlNode newElemEng = xdoc.CreateNode(XmlNodeType.Element, "English", "");
                    newElemEng.InnerText = txtEng.Text.Trim().ToLower();
                    newElem.AppendChild(newElemEng);
                    XmlNode newElemTr = xdoc.CreateNode(XmlNodeType.Element, "Turkish", "");
                    if (kelimelerTr.Length >= 1)
                    {
                        for (int i = 0; i < kelimelerTr.Length; i++)
                        {
                            XmlNode newWord = xdoc.CreateNode(XmlNodeType.Element, "Word", "");
                            newWord.InnerText = kelimelerTr[i].Trim();
                            newElemTr.AppendChild(newWord);
                        }
                    }

                    newElem.AppendChild(newElemTr);
                    XmlNode node = xdoc.SelectSingleNode("Items");
                    node.AppendChild(newElem);
                }
                xdoc.Save(cmlPath);
                return 1;
            }
            //(XmlException ex)
            catch
            {
                return -1;
            }

        }

        private static void XmlTextWriter_Implementation()
        {

            //XmlTextWriter xwrt = new XmlTextWriter(cmlPath, Encoding.UTF8);
            //xwrt.Formatting = Formatting.Indented;
            //xwrt.Indentation = 3;

            //xwrt.WriteStartDocument();
            //xwrt.WriteComment("Creating Date:"+DateTime.Now.ToLongDateString());
            //xwrt.WriteStartElement("Items");

            //xwrt.WriteStartElement("Item");
            //xwrt.WriteAttributeString("ID", "1");
            //xwrt.WriteElementString("English", txtEng.Text);
            //xwrt.WriteElementString("Turkish", txtTur.Text);
            //xwrt.WriteEndElement();

            //xwrt.WriteEndElement();

            //xwrt.WriteEndDocument();
            //xwrt.Close();
        }

        private void frm_treng_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.Default)
            {
                tiklanan_Yer = new Point(e.X, e.Y);
            }
        }

        private void frm_treng_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.Cursor == Cursors.Default)
            {
                Point Koordinatlar;
                Koordinatlar = Control.MousePosition;
                Koordinatlar.Offset(-tiklanan_Yer.X, -tiklanan_Yer.Y);
                this.Location = Koordinatlar;
            }
        }

        private void txtEng_Leave(object sender, EventArgs e)
        {
            if (string.Equals(txtEng.Text, "", StringComparison.CurrentCulture))
            {
                txtEng.Text = "English";
            }

        }

        private void txtTur_Leave(object sender, EventArgs e)
        {
            if (string.Equals(txtTur.Text, "", StringComparison.CurrentCulture))
            {
                txtTur.Text = "Turkish";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (txtTur.Text != "Turkish" && txtEng.Text != "English")
            {
                if (MessageBox.Show("İşlem Kaydedilmeden Çıkılsın mı?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (txtTur.Text != "Turkish" && txtEng.Text != "English")
            {
                int ret = CreateXml();
                editToolStripMenuItem.Enabled = false;
                if (ret == 1)
                {
                    InitApp();
                }
                else if (ret == -2)
                {
                    MessageBox.Show("Exist on your repository", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtEng.Text = "English";
                txtTur.Text = "Turkish";
                txtSearch.Text = "Search";
            }
        }

        private void frm_treng_Click(object sender, EventArgs e)
        {
            if (txtTur.Text == string.Empty)
            {
                txtTur.Text = "Turkish";
            }

            if (txtEng.Text == string.Empty)
            {
                txtEng.Text = "English";
            }

            if (txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "Search";
            }
        }

        private void txtTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) && ((e.KeyChar != 8) || (e.KeyChar == 32)))
            {
                e.Handled = true;
            }
        }

        private void txtEng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) && ((e.KeyChar != 8) || (e.KeyChar == 32)))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "Search";
            }
        }

        private void frm_treng_Load(object sender, EventArgs e)
        {
            LocationChang();
            btn_Enter.Cursor = Cursors.Hand;
            btn_Exit.Cursor = Cursors.Hand;
            btnInfo.Cursor = Cursors.Hand;
            btnRefresh.Cursor = Cursors.Hand;
            InitApp();
        }

        private void LocationChang()
        {
            if (File.Exists(cmlPath))
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(cmlPath);
                int widh = Screen.PrimaryScreen.Bounds.Width;
                int heig = Screen.PrimaryScreen.Bounds.Height;
                locationX = Convert.ToInt32(xdoc.ChildNodes[1].Value.Split(' ')[0].Split('=')[1]);
                locationY = Convert.ToInt32(xdoc.ChildNodes[1].Value.Split(' ')[1].Split('=')[1]);
                widthF = Convert.ToInt32(xdoc.ChildNodes[1].Value.Split(' ')[2].Split('=')[1]);
                heightF = Convert.ToInt32(xdoc.ChildNodes[1].Value.Split(' ')[3].Split('=')[1]);

                if ((locationX >= 0 && locationX <= widh) && (locationY >= 0 && locationY <= heig))
                {
                    this.Left = locationX;
                    this.Top = locationY;
                }
                else
                {
                    this.StartPosition = FormStartPosition.CenterScreen;
                }

                if ((this.Width <= widthF && 350 >= widthF) && (this.Height <= heightF && 850 >= heightF))
                {
                    this.Height = heightF;
                    this.Width = widthF;
                }

            }
        }

        private void InitApp()
        {
            isCursorWait(true);
            editToolStripMenuItem.Enabled = false;
            txtSearch.Text = "Search";
            txtTur.Text = "Turkish";
            txtEng.Text = "English";

            if (GetWords() == 1)
            {
                AutoCompleteStart();
                Thread th = new Thread(new ThreadStart(ListAll));
                th.Priority = ThreadPriority.Normal;
                th.Start();
            }
            isCursorWait(false);
        }

        //thread
        private void ListAll()
        {
            isTxtanBtmEnable(true);
            if (collection.Count == 0)
            {
                editToolStripMenuItem.Enabled = false;
                lstVoca.Items.Clear();
                foreach (Vocabulary voca in all_content)
                {
                    foreach (string item in voca.Tr_ver)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = voca.Eng_ver;
                        li.SubItems.Add(item);
                        lstVoca.Items.Add(li);
                        collection.Add((ListViewItem)li.Clone());
                    }
                }
            }
            else
            {
                lstVoca.Items.Clear();
                foreach (ListViewItem item in collection)
                {
                    lstVoca.Items.Add((ListViewItem)item.Clone());
                }
            }
            isTxtanBtmEnable(false);
        }

        //remove collection
        private static void RemoveCollection()
        {
            int length = collection.Count;
            for (int i = length - 1; i >= 0; i--)
            {
                collection.RemoveAt(i);
            }
        }

        //thread hatası oluyor.
        private void AutoCompleteStart()
        {
            //txtSearch.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection str_Comlete = new AutoCompleteStringCollection();
            foreach (Vocabulary voca in all_content)
            {
                str_Comlete.Add(voca.Eng_ver);
                foreach (string item in voca.Tr_ver)
                {
                    str_Comlete.Add(item);
                }
            }
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = str_Comlete;
        }

        //thread
        //all_content fill
        private int GetWords()
        {
            try
            {
                if (!File.Exists(cmlPath))
                    return -1;

                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(cmlPath);
                all_content.Clear();
                RemoveCollection();
                XmlNodeList list = xdoc.SelectNodes("Items/Item");
                foreach (XmlNode item in list)
                {
                    Vocabulary voca = new Vocabulary();
                    voca.Eng_ver = item["English"].InnerText;

                    foreach (XmlNode tr_node in item["Turkish"].ChildNodes)
                    {
                        voca.Tr_ver.Add(tr_node.InnerText);
                    }
                    all_content.Add(voca);
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            InitApp();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                editToolStripMenuItem.Enabled = false;
                if (lstVoca.Items.Count >= 1)
                {
                    ListView.ListViewItemCollection lv = collection;
                    var result = from ListViewItem item in lv
                                 where item.Text.StartsWith(txtSearch.Text.Trim().ToLower(), StringComparison.CurrentCulture) ||
                                       item.SubItems[1].Text.StartsWith(txtSearch.Text.Trim().ToLower(), StringComparison.CurrentCulture)
                                 select item;

                    if (result.Count() != 0)
                    {
                        isSearched = true;
                        List<ListViewItem> get_result = new List<ListViewItem>(result);
                        lstVoca.Items.Clear();
                        foreach (ListViewItem item in get_result)
                        {
                            lstVoca.Items.Add((ListViewItem)item.Clone());
                        }

                        if (result.Count() == 1)
                            editToolStripMenuItem.Enabled = true;
                        else
                            editToolStripMenuItem.Enabled = false;
                    }
                }
            }
            else if (e.KeyData == Keys.Back && txtSearch.Text == string.Empty && isSearched)
            {
                editToolStripMenuItem.Enabled = false;
                isSearched = false;
                if (!isEditing)
                {
                    Thread th = new Thread(new ThreadStart(ListAll));
                    th.Priority = ThreadPriority.Normal;
                    th.Start();
                }
                else
                {
                    isEditing = false;
                    InitApp();
                }
            }
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe", "http://www.hakanozler.com.tr");
            }
            catch
            {
                MessageBox.Show("English Turkish Vocabulary Repository" + System.Environment.NewLine + "Developer: Hakan Özler / hakanozler.com.tr", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text == "Search" ? "" : txtSearch.Text;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = txtSearch.Text == "Search" ? "" : txtSearch.Text;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (panel2.Cursor == Cursors.SizeWE && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                size = Cursor.Position;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && panel2.Cursor == Cursors.SizeWE)
            {
                Point newPosition = Cursor.Position;
                int dx = newPosition.X - size.X;
                int dy = newPosition.Y - size.Y;
                this.Size = new Size(this.Width + dx, this.Height + dy);
                size = newPosition;
            }

            if (e.X >= this.ClientSize.Width - 5)
            {
                panel2.Cursor = Cursors.SizeWE;
            }
            else
            {
                panel2.Cursor = Cursors.Default;
            }
        }

        private void lstVoca_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            lstVoca.Items[e.Item.Index].ToolTipText = e.Item.SubItems[0].Text;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(cmlPath) || index == null)
                    return;
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(cmlPath);
                bool isFind = false;
                XmlNodeList list = xdoc.SelectNodes("Items/Item");
                foreach (XmlNode node in (from XmlNode item in list where item["English"].InnerText == lstVoca.Items[Convert.ToInt32(index)].Text select item))
                {
                    foreach (XmlNode tr_node in node["Turkish"].ChildNodes)
                    {
                        if (tr_node.InnerText == lstVoca.Items[Convert.ToInt32(index)].SubItems[1].Text)
                        {
                            if (node["Turkish"].ChildNodes.Count == 1)
                                xdoc.ChildNodes[3].RemoveChild(node);
                            else if (node["Turkish"].ChildNodes.Count > 1)
                                node["Turkish"].RemoveChild(tr_node);

                            isFind = true;
                            lstVoca.Items.RemoveAt(Convert.ToInt32(index));
                            xdoc.Save(cmlPath);
                        }
                        if (isFind)
                        {
                            InitApp();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ex.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index != null)
                Clipboard.SetText(string.Concat(lstVoca.Items[Convert.ToInt32(index)].Text, "->", lstVoca.Items[Convert.ToInt32(index)].SubItems[1].Text), TextDataFormat.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (index != null)
            {
                string eng = lstVoca.Items[Convert.ToInt32(index)].Text,
                tr = lstVoca.Items[Convert.ToInt32(index)].SubItems[1].Text;
                frm_edit saveFrm = new frm_edit(tr, eng, this.Location);
                saveFrm.eventSaveClick += new frm_edit.SaveClick(saveFrm_eventSaveClick);
                saveFrm.ShowDialog();
            }
        }

        //index = index ?? 123;
        private void lstVoca_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            index = e.ItemIndex;
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "TrEngWords.txt";
                DialogResult dio = saveFileDialog1.ShowDialog();
                if (dio == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    bool exist = File.Exists(saveFileDialog1.FileName);
                    if (exist)
                        File.Delete(saveFileDialog1.FileName);

                    StringBuilder sb = new StringBuilder();
                    sb.Append("\t     English -- Turkish"); //Add tabulation
                    sb.Append(System.Environment.NewLine);
                    sb.Append("\t--------------------------------");

                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                    sw.AutoFlush = true;
                    sw.WriteLine(sb.ToString());
                    sb.Clear();
                    foreach (ListViewItem item in (from ListViewItem lst in collection orderby lst.SubItems[0].Text ascending select lst))
                    {
                        sb.Append("\t");
                        sw.WriteLine(sb.ToString() + string.Format(" {0} - - {1} ", item.Text, item.SubItems[1].Text));
                        sb.Clear();
                    }

                    sw.Close();
                    sw.Dispose();
                    MessageBox.Show("Process Completed", "Export to Nodepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void saveFrm_eventSaveClick(string words, bool isTr, bool isEng, string oldwords)
        {
            ChangeEditing(words.Split(';'), isTr, isEng, oldwords);
        }

        private void ChangeEditing(string[] words, bool isTr, bool isEng, string oldwords)
        {
            if (!File.Exists(cmlPath) || index == null)
                return;
            string[] old = oldwords.ToLower().Split(';');
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(cmlPath);
            bool chanEng = false, changTr = false;
            foreach (XmlNode item in xdoc.SelectNodes("Items/Item"))
            {
                if (item["English"].InnerText == old[1] && isEng)
                {
                    item["English"].InnerText = words[0];
                    lstVoca.Items[Convert.ToInt32(index)].Text = words[0];
                    chanEng = true;
                }

                foreach (XmlNode tr_node in item["Turkish"].ChildNodes)
                {
                    if (tr_node.InnerText == old[0] && isTr && isEng)
                    {
                        tr_node.InnerText = words[1];
                        lstVoca.Items[Convert.ToInt32(index)].SubItems[1].Text = words[1];
                        changTr = true;
                    }
                    else if (tr_node.InnerText == old[0] && isTr && !isEng)
                    {
                        tr_node.InnerText = words[0];
                        lstVoca.Items[Convert.ToInt32(index)].SubItems[1].Text = words[0];
                        changTr = true;
                    }
                }

                if (chanEng || changTr)
                {
                    isEditing = true;
                    break;
                }
            }
            xdoc.Save(cmlPath);
        }

        private void frm_treng_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(cmlPath))
            {
                //int locationX = Convert.ToInt32(xdoc.ChildNodes[1].Value.Split(' ')[0].Split('=')[1]);
                //int locationY = Convert.ToInt32(xdoc.ChildNodes[1].Value.Split(' ')[1].Split('=')[1]);               

                if ((locationX != this.Location.X || locationY != this.Location.Y) || (widthF != this.Width || heightF != this.Height))
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(cmlPath);
                    string path = "" + string.Concat("X=", this.Location.X, " ", "Y=", this.Location.Y);
                    path += string.Concat(" wid=", this.Width, " ", "heig=", this.Height);
                    xdoc.ChildNodes[1].Value = path;
                    xdoc.Save(cmlPath);
                }

            }
        }

        private void frm_treng_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory);
        }

        private void exportToWordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thExport = new Thread(new ThreadStart(ExportToWord));
            thExport.Priority = ThreadPriority.Highest;
            thExport.Name = "ExportThread";
            thExport.Start();         
        }

        private void ExportToWord()
        {
            try
            {
                saveFileDialog1.FileName = "TrEngWords.docx";
                DialogResult dio = saveFileDialog1.ShowDialog();
                if (dio == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    isCursorWait(true);
                    Word.Application Wordapp = new Word.Application();
                    Wordapp.Documents.Add();
                    Word.Document doc = Wordapp.ActiveDocument;
                    Wordapp.Visible = false;

                    doc.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;
                    doc.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    doc.Content.Font.Name = "Trebuchet MS";
                    doc.Content.Font.Bold = 0;

                    Word.Paragraph parag = doc.Content.Paragraphs.Add();
                    parag.Range.Text = "English Turkish Words Repository";
                    parag.Range.Font.Size = 22;
                    parag.Range.Font.Color = Word.WdColor.wdColorDarkBlue;
                    parag.Range.Font.Italic = 0;
                    parag.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                    parag.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    parag.Format.SpaceAfter = 5;        //5 pt spacing after paragraph.
                    parag.Format.SpaceBefore = 15;    //15 pt spacing before paragraph.
                    parag.Range.InsertParagraphAfter();

                    foreach (ListViewItem item in (from ListViewItem lst in collection orderby lst.SubItems[0].Text ascending select lst))
                    {
                        Word.Paragraph parag2 = doc.Content.Paragraphs.Add();
                        parag2.Range.Text = string.Format(" {0} - - ", item.Text);
                        parag2.Range.Font.Size = 13;
                        parag2.Range.Font.Italic = 0;
                        parag2.Range.Font.Color = Word.WdColor.wdColorBlack;
                        parag2.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                        parag2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        parag2.Format.SpaceAfter = 0;    //1 pt spacing after paragraph.   
                        parag2.Format.SpaceBefore = 0;
                        parag2.Range.InsertAfter(string.Format(" {0}", item.SubItems[1].Text));
                        parag2.Range.InsertParagraphAfter();
                    }

                    Word.Paragraph lastPara = doc.Content.Paragraphs.Add();
                    lastPara.Range.Text = string.Format("Hakan Özler");
                    lastPara.Range.Font.Italic = 1;
                    lastPara.Range.Font.Size = 12;
                    lastPara.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    lastPara.Range.Font.Color = Word.WdColor.wdColorBlack;
                    lastPara.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    lastPara.Format.SpaceAfter = 0;    //0 pt spacing after paragraph.  
                    lastPara.Format.SpaceBefore = 50;
                    lastPara.Range.InsertAfter(string.Concat("  http://www.hakanozler.com.tr", "  ", DateTime.Now));
                    lastPara.Range.InsertParagraphAfter();

                    doc.SaveAs(string.Format(@"{0}", saveFileDialog1.FileName));
                    //Wordapp.Documents.Close();
                    Wordapp.Quit();
                    isCursorWait(false);
                    MessageBox.Show("Process successfuly created!", "Info message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void isCursorWait(bool isWaiting)
        {
            if (isWaiting)
            {
                this.Cursor = Cursors.WaitCursor;
                this.lstVoca.Cursor = Cursors.WaitCursor;
                this.panel2.Cursor = Cursors.WaitCursor;
                this.panel1.Cursor = Cursors.WaitCursor;
            }
            else
            {
                this.Cursor = Cursors.Default;
                this.lstVoca.Cursor = Cursors.Default;
                this.panel2.Cursor = Cursors.Default;
                this.panel1.Cursor = Cursors.Default;
            }
        }

        private void isTxtanBtmEnable(bool isWaiting)
        {
            if (isWaiting)
            {
                btnRefresh.Enabled = false;
                txtSearch.Enabled = false;
                txtEng.Enabled = false;
                txtTur.Enabled = false;
            }
            else
            {
                btnRefresh.Enabled = true;
                txtSearch.Enabled = true;
                txtEng.Enabled = true;
                txtTur.Enabled = true;
            }
        }
    }

    public class Vocabulary
    {
        public List<string> Tr_ver = null;
        public string Eng_ver { get; set; }

        public Vocabulary()
        {
            Tr_ver = new List<string>();
        }

    }
}
