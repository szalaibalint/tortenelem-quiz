using System.ComponentModel;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;
namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public class minta
        {
            public string neve;
            public int sorszama;

            public minta(string neve, int sorszama)
            {
                this.neve = neve;
                this.sorszama = sorszama;
            }
        }
        public Form1()
        {

            InitializeComponent();


            this.Load += new EventHandler(Form1_Load);
        }
        private void InitializeListBox()
        {
            listBox1.Location = new System.Drawing.Point(81, 69);
            listBox1.Size = new System.Drawing.Size(120, 95);
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);
            Controls.Add(listBox1);
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Green;

        }

        public List<minta> mintak = new List<minta>();

        public List<int> sorszam = new List<int> { 1, 3, 2, 4 };

        public List<int> sorrend = new List<int>() { 1, 2, 3, 4 };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise the ListBox.
            this.listBox1.AllowDrop = true;
            //Ide kellenek a lehetõségek
            mintak.Add(new minta("Item 1", 1));
            mintak.Add(new minta("Item 2", 2));
            mintak.Add(new minta("Item 3", 3));
            mintak.Add(new minta("Item 4", 4));


            listBox1.Items.Clear();
            for (int i = 0; i < sorrend.Count; i++)
            {
                foreach (minta item in mintak)
                {
                    if (item.sorszama == sorrend[i])
                    {
                        listBox1.Items.Add(item.neve);
                    }
                }
            }




            this.listBox1.MouseDown += new MouseEventHandler(listBox1_MouseDown);
            this.listBox1.DragEnter += new DragEventHandler(listBox1_DragEnter);
            this.listBox1.DragOver += new DragEventHandler(listBox1_DragEnter);
            this.listBox1.DragDrop += new DragEventHandler(listBox1_DragDrop);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Test whether the mouse is over an item.
            if (this.GetItemIndexAtPoint(e.Location) != -1)
            {
                // The mouse is over an item so start dragging.
                this.listBox1.DoDragDrop(this.listBox1, DragDropEffects.Move);
            }
        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Test whether the data being dragged is the ListBox itself.
            if (e.Data.GetDataPresent("System.Windows.Forms.ListBox") &&
                e.Data.GetData("System.Windows.Forms.ListBox") == this.listBox1)
            {
                // Get the location of the mouse relative to the ListBox.
                Point mouseLocation = this.listBox1.PointToClient(new Point(e.X, e.Y));
                // Force the location to be within the horizontal bounds of the ListBox.
                if (mouseLocation.X < 0)
                {
                    mouseLocation.X = 0;
                }
                else if (mouseLocation.X > this.listBox1.Width)
                {
                    mouseLocation.X = this.listBox1.Width;
                }
                // Force the location to be within the vertical bounds of the ListBox.
                if (mouseLocation.Y < 0)
                {
                    mouseLocation.Y = 0;
                }
                else if (mouseLocation.Y > this.listBox1.Height)
                {
                    mouseLocation.Y = this.listBox1.Height;
                }

                if (this.GetItemIndexAtPoint(mouseLocation) == this.listBox1.SelectedIndex)
                {
                    // Don't allow the selected item to be dropped on itself.
                    e.Effect = DragDropEffects.None;
                }
                else
                {
                    // Allow the selected item to be moved.
                    e.Effect = DragDropEffects.Move;
                }

            }
        }
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Test whether the data being dragged is the ListBox itself and the selected item can be moved.
            if (e.AllowedEffect == DragDropEffects.Move &&
                e.Data.GetDataPresent("System.Windows.Forms.ListBox") &&
                e.Data.GetData("System.Windows.Forms.ListBox") == this.listBox1)
            {
                int selectedIndex = this.listBox1.SelectedIndex;

                // Get the index of the item being dropped on.
                int dropIndex = this.GetItemIndexAtPoint(this.listBox1.PointToClient(new Point(e.X, e.Y)));

                // If the item being dropped on is below the selected item, the index of the
                // item being dropped on will decrement once the selected item is removed.
                if (dropIndex > selectedIndex)
                {
                    dropIndex -= 1;
                }

                object selectedItem = this.listBox1.SelectedItem;

                this.listBox1.Items.Remove(selectedItem);

                if (dropIndex == -1)
                {
                    // The item was dropped after the last item so add it at the end of the list.
                    this.listBox1.Items.Add(selectedItem);
                }
                else
                {
                    // Insert the item above the item it was dropped on.
                    this.listBox1.Items.Insert(dropIndex, selectedItem);
                }
                // as



                this.listBox1.SelectedItem = selectedItem;

            }



        }
        private int GetItemIndexAtPoint(Point location)
        {
            int itemIndex = -1;

            for (int index = 0; index < this.listBox1.Items.Count; index++)
            {
                // Test whether the location is within an item.
                if (this.listBox1.GetItemRectangle(index).Contains(location))
                {
                    itemIndex = index;
                    break;
                }
            }
            return itemIndex;
        }

        public int ind;

        private void button1_Click(object sender, EventArgs e)
        {
            correction.Items.Clear();

            listBox1.SelectedIndex = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < sorrend.Count; i++)
            {
                for (int j = 0; j < mintak.Count; j++)
                {
                    if (mintak[j].sorszama == sorrend[i])
                    {
                        listBox1.Items.Add(mintak[j].neve);
                        break;
                    }
                }
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < mintak.Count; j++)
                {
                    if (mintak[j].neve == listBox1.Items[i].ToString())
                    {
                        ind = j;
                    }
                }
                if (sorszam[ind] == i + 1)
                {
                    correction.Items.Add("+");
                }
                else
                {
                    correction.Items.Add("-");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            sorrend.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < mintak.Count; j++)
                {
                    if (listBox1.Items[i].ToString() == mintak[j].neve)
                    {
                        sorrend.Add(mintak[j].sorszama);
                        break;
                    }
                }
            }
        }
    }
}
