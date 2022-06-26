using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicUtility;

namespace FileFinder {
  public partial class Main: Form {
    DataTable dt = new("Result");
    
    public Main() {
      InitializeComponent();

      dt.Columns.Add("FilePath");
      tb_rootPath.Text = Path.GetPathRoot(Directory.GetCurrentDirectory());
    }

    public void SearchFile(){
      if(string.IsNullOrEmpty(tb_rootPath.Text)) {
        MessageBox.Show("The root path name can be empty.", "INFO", MessageBoxButtons.OK);
        return;
      }

      if(string.IsNullOrEmpty(tb_filename.Text)) {
        MessageBox.Show("The name of the file to find cannot be empty.", "INFO", MessageBoxButtons.OK);
        return;
      }

      var result = XSystem.LocateFileOnSystem(tb_filename.Text, cb_exactMatch.Checked, cb_onlyFirst.Checked, tb_rootPath.Text);

      if(result == null) {
        dt.Rows.Add("NOT FOUND");
        return;
      }

      if(result.Count == 0) {
        dt.Rows.Add("NOT FOUND");
        return;
      }

      foreach(string item in result) {
        dt.Rows.Add(item);
      }

      dgv_resultr.DataSource = dt;
    }

    private void btn_find_Click(object sender, EventArgs e) {
      dt.Rows.Clear();

      btn_find.Visible = false;

      SearchFile();

      btn_find.Visible = true;
    }
  }
}
