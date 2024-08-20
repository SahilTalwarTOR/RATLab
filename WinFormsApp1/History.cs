using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class History : Form
    {

        private Stack<String> _historyArr;
        public History(Stack<String> historyArr)
        {
            InitializeComponent();
            _historyArr = historyArr;
        }

        private void loadHistory(object sender, EventArgs e)
        {
            List<String> history_converted = new List<String>();
            foreach(String item in _historyArr)
            {
                history_converted.Add(item);
            }
            listBox1.DataSource = history_converted;
        }
    }
}
