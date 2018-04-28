using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
        }
        DataTable memory = new DataTable();
        DataTable process = new DataTable();
        int selectedRow;
       

        private void Memory_Load(object sender, EventArgs e)
        {

            memory.Columns.Add("Size", typeof(int));
            memory.Columns.Add("From", typeof(int));
            memory.Columns.Add("To", typeof(int));

            process.Columns.Add("ID", typeof(String));
            process.Columns.Add("From", typeof(int));
            process.Columns.Add("To", typeof(int));


            dataGridView_Memory.DataSource = memory;
            dataGridView_Process.DataSource = process;
            

            
        }

        
        private void btn_Ad_Click(object sender, EventArgs e)
        {

            // Check there is given data or not
            if (string.IsNullOrWhiteSpace(txtBox_Process_ID.Text) || string.IsNullOrWhiteSpace(txtBox_Process_Size.Text))
            {
                // Message box
                MessageBox.Show("Please enter complete data!");
                goto here;
            }

            int ProcessSize = int.Parse(txtBox_Process_Size.Text);
            int memorySize;
            int memoryTo;
            int memoryFrom;
            int ProcessFrom;
            int maxSize = 0;
            maxSize += int.Parse(txtBox_Process_Size.Text);
            if (maxSize > 1024)
            {
                MessageBox.Show("You will exceed the 1MB you can access");
                goto here;
            }

            // First Fit
            if (radio_FF.Checked)
            {
                bool fit = false;
                for (int i = 0; i < dataGridView_Memory.Rows.Count-1; i++)
                {
                    memorySize = int.Parse(dataGridView_Memory.Rows[i].Cells[0].Value.ToString());
                    memoryFrom = int.Parse(dataGridView_Memory.Rows[i].Cells[1].Value.ToString());
                    if (ProcessSize <= memorySize)
                    {
                        fit = true;
                        // Insert process
                        ProcessFrom = int.Parse(dataGridView_Memory.Rows[i].Cells[1].Value.ToString());
                        process.Rows.Add(txtBox_Process_ID.Text, ProcessFrom, ProcessFrom + int.Parse(txtBox_Process_Size.Text)); 
                        dataGridView_Process.DataSource = process;

                        // Update Memory
                        memorySize -= ProcessSize;
                        memoryFrom += ProcessSize;
                        dataGridView_Memory.Rows[i].Cells[0].Value = memorySize;
                        dataGridView_Memory.Rows[i].Cells[1].Value = memoryFrom;
                       
                        // Drawing
                        Button dynamicButton = new Button();

                        // Check if hole = 0
                        if (int.Parse(dataGridView_Memory.Rows[i].Cells[0].Value.ToString()) == 0)
                        {
                            dataGridView_Memory.Rows.RemoveAt(i);
                        }


                        // Set Button properties
                        dynamicButton.Height = (Convert.ToInt32(txtBox_Process_Size.Text) / 2);
                        dynamicButton.Width = 200;
                        int myX = 1135;
                        int myY = 40 + (ProcessFrom/2);
                        dynamicButton.Location = new Point(myX, myY);
                        dynamicButton.Text = "";
                        dynamicButton.BackColor = Color.FromArgb(42,204,113); 
                        Controls.Add(dynamicButton);
                        dynamicButton.BringToFront();
                        break;
                    }
                }
                if (fit == false)
                {
                    MessageBox.Show("No Suitable Hole");
                }


            }

            // Best Fit
            else if (radio_BF.Checked)
            {
                int myBest = -1;
                int diff = 1000000;
                for (int i = 0; i < dataGridView_Memory.Rows.Count-1; i++)
                {
                    // get BestFit
                    memorySize = int.Parse(dataGridView_Memory.Rows[i].Cells[0].Value.ToString());
                    if((memorySize-ProcessSize)>=0 && (memorySize-ProcessSize)<diff)
                    {
                        diff = memorySize - ProcessSize;
                        myBest = i;
                    }
                }
                if (myBest == -1)
                {
                    MessageBox.Show("No Suitable Hole");
                }
                // Insert Process
                else
                {
                    ProcessFrom = int.Parse(dataGridView_Memory.Rows[myBest].Cells[1].Value.ToString());
                    process.Rows.Add(txtBox_Process_ID.Text, ProcessFrom, ProcessFrom + int.Parse(txtBox_Process_Size.Text));
                    dataGridView_Process.DataSource = process;

                    // Update Memory
                    memorySize = int.Parse(dataGridView_Memory.Rows[myBest].Cells[0].Value.ToString());
                    memoryFrom = int.Parse(dataGridView_Memory.Rows[myBest].Cells[1].Value.ToString());
                    memorySize -= ProcessSize;
                    memoryFrom += ProcessSize;
                    dataGridView_Memory.Rows[myBest].Cells[0].Value = memorySize;
                    dataGridView_Memory.Rows[myBest].Cells[1].Value = memoryFrom;

                    if (int.Parse(dataGridView_Memory.Rows[myBest].Cells[0].Value.ToString()) == 0)
                    {
                        dataGridView_Memory.Rows.RemoveAt(myBest);
                    }

                    // Drawing
                    Button dynamicButton = new Button();
                    // Set Button properties
                    dynamicButton.Height = (Convert.ToInt32(txtBox_Process_Size.Text) / 2);
                    dynamicButton.Width = 200;
                    int myX = 1135;
                    int myY = 40 + (ProcessFrom / 2);
                    dynamicButton.Location = new Point(myX, myY);
                    dynamicButton.Text = "";
                    dynamicButton.BackColor = Color.FromArgb(42,204,113);
                    dynamicButton.Font = new Font("Georgia", 16);
                    Controls.Add(dynamicButton);
                    dynamicButton.BringToFront();
                }


            }

            // Worst Fit
            else if (radio_WF.Checked)
            {
                int myWorst = -1;
                int diff = 0;
                for (int i = 0; i < dataGridView_Memory.Rows.Count - 1; i++)
                {
                    // get WorstFit
                    memorySize = int.Parse(dataGridView_Memory.Rows[i].Cells[0].Value.ToString());
                    if ((memorySize - ProcessSize) >= 0 && (memorySize - ProcessSize) > diff)
                    {
                        diff = memorySize - ProcessSize;
                        myWorst = i;
                    }
                }
                if (myWorst == -1)
                {
                    MessageBox.Show("No Suitable Hole");
                }
                // Insert Process
                else
                {
                    ProcessFrom = int.Parse(dataGridView_Memory.Rows[myWorst].Cells[1].Value.ToString());
                    process.Rows.Add(txtBox_Process_ID.Text, ProcessFrom, ProcessFrom + int.Parse(txtBox_Process_Size.Text));
                    dataGridView_Process.DataSource = process;

                    // Update Memory
                    memorySize = int.Parse(dataGridView_Memory.Rows[myWorst].Cells[0].Value.ToString());
                    memoryTo = int.Parse(dataGridView_Memory.Rows[myWorst].Cells[2].Value.ToString());
                    memorySize -= ProcessSize;
                    memoryTo -= ProcessSize;
                    dataGridView_Memory.Rows[myWorst].Cells[0].Value = memorySize;
                    dataGridView_Memory.Rows[myWorst].Cells[2].Value = memoryTo;

                    if (int.Parse(dataGridView_Memory.Rows[myWorst].Cells[0].Value.ToString()) == 0)
                    {
                        dataGridView_Memory.Rows.RemoveAt(myWorst);
                    }

                    // Drawing
                    Button dynamicButton = new Button();
                    // Set Button properties
                    dynamicButton.Height = (Convert.ToInt32(txtBox_Process_Size.Text) / 2);
                    dynamicButton.Width = 200;
                    int myX = 1135;
                    int myY = 40 + (ProcessFrom / 2);
                    dynamicButton.Location = new Point(myX, myY);
                    dynamicButton.Text = "";
                    dynamicButton.BackColor = Color.FromArgb(42,204,113);
                    dynamicButton.Font = new Font("Georgia", 16);
                    Controls.Add(dynamicButton);
                    dynamicButton.BringToFront();
                }


            }
            else
            {
                MessageBox.Show("Please choose allocation type!");
            }

        here:
            int y;
        }

        private void btn_Allocate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Memory_Size.Text) || string.IsNullOrWhiteSpace(txtBox_Memory_From.Text))
            {
                // Message box
                MessageBox.Show("Please enter complete data!");
                goto here1;
                
            }
            bool error = false;
            int maxSize = 0;
            int myHoleFrom = int.Parse(txtBox_Memory_From.Text);
            int mySize = int.Parse(txtBox_Memory_Size.Text);
            maxSize += int.Parse(txtBox_Memory_Size.Text);
            if (dataGridView_Memory.Rows.Count == 0)
            {
                if(maxSize>1024 || (myHoleFrom+mySize)>(1024-myHoleFrom))
                {
                    MessageBox.Show("You will exceed the 1MB you can access");
                    goto here1;
                }
                memory.Rows.Add(txtBox_Memory_Size.Text, txtBox_Memory_From.Text, int.Parse(txtBox_Memory_From.Text) + int.Parse(txtBox_Memory_Size.Text));
                this.dataGridView_Memory.Sort(this.dataGridView_Memory.Columns["From"], ListSortDirection.Ascending);
                dataGridView_Memory.DataSource = memory;
            }
            else
            {
                for (int i = 0; i < dataGridView_Memory.Rows.Count - 1; i++)
                {
                    int myMemoryFrom = int.Parse(dataGridView_Memory.Rows[i].Cells[1].Value.ToString());
                    int myMemoryTo= int.Parse(dataGridView_Memory.Rows[i].Cells[2].Value.ToString());
                    if(myHoleFrom>=myMemoryFrom && myHoleFrom<=myMemoryTo)
                    {
                        MessageBox.Show("Can't add hole in this range");
                        error = true;
                        break;
                    }
                }
                if(error==false)
                {
                    if (maxSize > 1024 || (myHoleFrom + mySize) > (1024 - myHoleFrom))
                    {
                        MessageBox.Show("You will exceed the 1MB you can access");
                        goto here1;
                    }
                    memory.Rows.Add(txtBox_Memory_Size.Text, txtBox_Memory_From.Text, int.Parse(txtBox_Memory_From.Text) + int.Parse(txtBox_Memory_Size.Text));
                    this.dataGridView_Memory.Sort(this.dataGridView_Memory.Columns["From"], ListSortDirection.Ascending);
                    dataGridView_Memory.DataSource = memory;
                    maxSize += int.Parse(txtBox_Memory_Size.Text);

                }
            }
            if (error == false)
            {
                Button dynamicButton = new Button();

                // Set Button 
                dynamicButton.Height = (Convert.ToInt32(txtBox_Memory_Size.Text) / 2);
                dynamicButton.Width = 200;
                int myX = 1135;
                int myY = 40 + (Convert.ToInt32(txtBox_Memory_From.Text) / 2);
                dynamicButton.Location = new Point(myX, myY);
                dynamicButton.Text = "";
                dynamicButton.BackColor = Color.FromArgb(231,70,69);
                Controls.Add(dynamicButton);
                dynamicButton.BringToFront();
            }

            here1:
            int x;
          
        }
    

        private void btn_Deallocate_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView_Process.CurrentCell.RowIndex;
            int myFrom = int.Parse(dataGridView_Process.Rows[selectedRow].Cells[1].Value.ToString());
            int myTo = int.Parse(dataGridView_Process.Rows[selectedRow].Cells[2].Value.ToString());
            int mySize = myTo - myFrom;
            
            // Reset Hole Button 
            Button dynamicButton = new Button();
            dynamicButton.Height = (mySize / 2);
            dynamicButton.Width = 200;
            int myX = 1135;
            int myY = 40 + (myFrom / 2);
            dynamicButton.Location = new Point(myX, myY);
            dynamicButton.Text = "";
            dynamicButton.BackColor = Color.FromArgb(231,70,69);
            dynamicButton.Font = new Font("Georgia", 16);
            
            Controls.Add(dynamicButton);
            dynamicButton.BringToFront();

            
            // Add to Hole table
            memory.Rows.Add(mySize, myFrom, myTo);
            this.dataGridView_Memory.Sort(this.dataGridView_Memory.Columns["From"], ListSortDirection.Ascending);
            dataGridView_Memory.DataSource = memory;


            // Remove Process from it's table
            dataGridView_Process.Rows.RemoveAt(selectedRow);

        }

        private void btn_Help_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("How to use :"+"\n"+"1- Allocate the hole in the main memory using (Add Hole button) and attached text boxes"+"\n"+"2-Select type of allocation you want to use"+"\n"+"3- Add process using (Add Process Button) and attached text boxes"+"\n"+"4- Remove any process by selecting it in the table and pressing (Remove Process Button)"+"\n"+"5- Use (Reset Button) to remove all Process and Hole , and Clear tables"+"\n"+"6- Maximum size of all process or all hole is 1MB" + "\n" + "Submitted By : " + "\n" + "Ahmed Atef" + "\n" + "Mohamed Elshorbagy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView_Memory.DataSource).Rows.Clear();
            ((DataTable)dataGridView_Process.DataSource).Rows.Clear();

            Button dynamicButton = new Button();

            // Remove all buttons 
            dynamicButton.Height = 500;
            dynamicButton.Width = 200;
            dynamicButton.Location = new Point(1135, 40);
            dynamicButton.Text = "";
            Controls.Add(dynamicButton);
            dynamicButton.BringToFront();
        }

        private void Process1_Click(object sender, EventArgs e)
        {

        }
    }
}
