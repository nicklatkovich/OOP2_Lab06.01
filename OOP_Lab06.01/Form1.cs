using System;
using System.Windows.Forms;

using OOP_Lab04;

namespace OOP_Lab06._01 {
    public partial class Form1 : Form {

        public CollectionType<string> CT = new CollectionType<string>( );

        public Form1( ) {
            InitializeComponent( );
        }

        private void ButtonAdd_Click(Object sender, EventArgs e) {
            if (CT.Contains(this.TextInput.Text)) {
                MessageBox.Show("This value is already in the set");
            } else {
                CT.Add(this.TextInput.Text);
                ListView.Items.Add(this.TextInput.Text);
                this.TextInput.Text = "";
            }
        }

        public void ListViewUpdate( ) {
        }

        private void ListView_SelectedIndexChanged(Object sender, EventArgs e) {

        }
    }
}
