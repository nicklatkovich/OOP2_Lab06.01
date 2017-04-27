using System;
using System.Windows.Forms;

using OOP_Lab04;

namespace OOP_Lab06._01 {
    public partial class Form1 : Form {

        public CollectionType<string> CT = new CollectionType<string>( );
        public bool TrueSorting = true;

        public Form1( ) {
            InitializeComponent( );
        }

        private void ButtonAdd_Click(Object sender, EventArgs e) {
            if (this.TextInput.Text.Length == 0) {
                return;
            }
            if (CT.Contains(this.TextInput.Text)) {
                MessageBox.Show("This value is already in the set");
            } else {
                CT.Add(this.TextInput.Text);
                this.TextInput.Text = "";
                ListViewUpdate( );
            }
        }

        public void ListViewUpdate( ) {
            ListBox.Items.Clear( );
            if (TrueSorting) {
                foreach (var a in CT) {
                    ListBox.Items.Add(a);
                }
            } else {
                uint set_size = (uint)CT.Count;
                string[ ] @out = new string[set_size];
                uint index = 0;
                foreach (var a in CT) {
                    @out[index++] = a;
                }
                for (int i = (int)set_size - 1; i >= 0; i--) {
                    ListBox.Items.Add(@out[i]);
                }
            }
        }

        private void ButtonRemove_Click(Object sender, EventArgs e) {
            if (this.TextInput.Text.Length == 0) {
                return;
            }
            if (CT.Contains(this.TextInput.Text)) {
                CT.Remove(this.TextInput.Text);
                this.TextInput.Text = "";
                ListViewUpdate( );
            } else {
                MessageBox.Show("This value is not in the set");
            }
        }

        private void ButtonSort_Click(Object sender, EventArgs e) {
            this.TrueSorting = !TrueSorting;
            ListViewUpdate( );
        }
    }
}
