using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class DataMinerForm : Form
    {
        private string fileName;
        // DataGridView dgvValues;
        public DataMinerForm()
        {
            InitializeComponent();
        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            InspectForm ins = new InspectForm();
            ins.Show();
        }

        private void invoiceGeneratedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DataMinerForm_Load(object sender, EventArgs e)
        {

        }
        //private string[,] LoadCsv(string filename)
        //{
        //    // Get the file's text.
        //    string whole_file = System.IO.File.ReadAllText(filename);

        //    // Split into lines.
        //    whole_file = whole_file.Replace('\n', '\r');
        //    string[] lines = whole_file.Split(new char[] { '\r' },
        //        StringSplitOptions.RemoveEmptyEntries);

        //    // See how many rows and columns there are.
        //    int num_rows = lines.Length;
        //    int num_cols = lines[0].Split(',').Length;

        //    // Allocate the data array.
        //    string[,] values = new string[num_rows, num_cols];

        //    // Load the array.
        //    for (int r = 0; r < num_rows; r++)
        //    {
        //        string[] line_r = lines[r].Split(',');
        //        for (int c = 0; c < num_cols; c++)
        //        {
        //            values[r, c] = line_r[c];
        //        }
        //    }

        //    // Return the values.
        //    return values;
        //}

        //public void CsvReader()
        //{
        //    using (StreamReader sr = new StreamReader(fileName))
        //    {
        //        String line;

        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            string[] parts = line.Split(',');

        //            string orderId = parts[2];
        //            // Do what you need with the orderID

        //        }
        //    }
        //}

        //public void ReadFile()
        //{


        //    try
        //    {
        //        using (StreamReader reader = new StreamReader(fileName))
        //        {

        //            string[] splitString;
        //            char[] deliminter = { ',', '\n', '\r' };
        //            int lineNumber = 0;
        //            string line = reader.ReadLine();
        //            string stringToSplit = line;

        //            while (line != null)
        //            {

        //                lineNumber++;
        //                splitString = stringToSplit.Split(deliminter);
        //                Printer(splitString);
        //                line = reader.ReadLine();

        //            }
        //        }

        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show("Input Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        MessageBox.Show("Finished Reading", "End of Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        //private void Printer(string [] linePrinter)
        //{
        //    DataReadRichTextBox.Text+=(linePrinter);
        //    DataReadRichTextBox.AppendText(Environment.NewLine);
        //}
        //private void saveFile()
        //{
        //    string saveText;
        //    try
        //    {
        //        using (StreamWriter writer = new StreamWriter(fileName, false))
        //        {
        //            saveText = DataReadRichTextBox.Text;
        //            writer.WriteLine(saveText);
        //            throw null;
        //        }
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show("Input Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        MessageBox.Show("Finished Writting", "End of Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        MessageBox.Show("Not saved", "Saving error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {

                fileName = openFileDialog1.FileName;

                readCSV(fileName);
                // readInvoice();
               readMonth();
                // ReadFile();
            }

        }

         
      
        private void readCSV(string FileName)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("InvoiceNo");
            dt.Columns.Add("Stock Code");
            dt.Columns.Add("Description");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Invoice Date ");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Customer ID");
            StreamReader reader = new StreamReader(FileName);
            string[] readData = new string[File.ReadAllLines(FileName).Length];
            readData = reader.ReadLine().Split(',');
            while (!reader.EndOfStream)
            {
                readData = reader.ReadLine().Split(',');
                dt.Rows.Add(readData[0], readData[1], readData[2], readData[3], readData[4], readData[5], readData[6]);
                
            }
            dataGridView1.DataSource = dt;
        }
        
        private void readInvoice()
        {
           
            string[] invoiceArray = new string[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                invoiceArray[i] = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                //textBox1.Text = Convert.ToString(invoiceArray);
            }
            //int l = 0;
            //foreach (string ss in invoiceArray)
            //{
            //    listBox1.Items.Add(ss);
            //    l++;
            //}
        }
        private void readMonth()
        {
            DateTime[] dateTimeArray = new DateTime[dataGridView1.Rows.Count];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dateTimeArray[i] = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                //dateTimeArray[i].Month.
                //DateTime[] dt = new DateTime [dateTimeArray.Length];

                // dt= Convert.ToDateTime(dateTimeArray);
            }
            //char[] space = { ' ' };
            //char[] colon = {':'};
            string[] spltTimeArray = new string[dateTimeArray.Length];
            
            string[] []splitDateArray = new string[dateTimeArray.Length][];
            //char[] deli = { " " };

            for (int j = 0; j < dateTimeArray.Length; j++)
            {
                

                spltTimeArray[j] = dateTimeArray[j].ToShortDateString();//.Split(' ');
                                                                        //spltTimeArray[j].Split('/');
                splitDateArray[j] = spltTimeArray[j].Split('/');
                // splitDateArray[] spltTimeArray[j].Split('/');
                //splitTimeArray[j]= Convert.ToString(dateTimeArray[j].Split('/'));
                // splitTimeArray[j]= Convert.ToString(dateTimeArray[j].Split(':'));


            }
           
            // dataGridView1.Cells[4].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            //var formatInfoinfo = new System.Globalization.DateTimeFormatInfo();

            //string[] monthName = formatInfoinfo.MonthNames;
            //int l = 0;
            //textBox1.Text =Convert.ToString( dt.Month);
            //int m = 0;
            //foreach (string[] dateTime in splitDateArray)
            //{

            //    listBox1.Items.Add(dateTime);
            //    m++;

            //}
            //    //    //m++;

            //    //    //DateTimePicker month = new DateTimePicker();
            //    //    //DateTime invoiceDate = month.Value.Month;

            //}
        }

        //private void readInvoice()
        //{
        //  string[] invoiceArray = new string[dataGridView1.Rows.Count];


        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        invoiceArray[i] = dataGridView1.Rows[i].ToString();
        //       //textBox1.Text = Convert.ToString(invoiceArray);
        //    }
        //    //foreach (DataGridViewColumn cl in dataGridView1.Columns)
        //    //{
        //    //    invoiceArray[cl.Index] = dataGridView1.Columns[0].ToString();
        //    //}
        //int l = 0;
        //    foreach (string ss in invoiceArray)
        //    {
        //        listBox1.Items.Add(ss);
        //        l++;
        //    }

        //    // textBox1.Text = Convert.ToString(invoiceArray);
        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //// Get the data.
        //    //string[,] values = LoadCsv(fileName);
        //    //int num_rows = values.GetUpperBound(0) + 1;
        //    //int num_cols = values.GetUpperBound(1) + 1;

        //    //// Display the data to show we have it.

        //    //// Make column headers.
        //    //// For this example, we assume the first row
        //    //// contains the column names.

        //    //dgvValues.Columns.Clear();
        //    //for (int c = 0; c < num_cols; c++)
        //    //    dgvValues.Columns.Add(values[0, c], values[0, c]);

        //    //// Add the data.
        //    //for (int r = 1; r < num_rows; r++)
        //    //{
        //    //    dgvValues.Rows.Add();
        //    //    for (int c = 0; c < num_cols; c++)
        //    //    {
        //    //        dgvValues.Rows[r - 1].Cells[c].Value = values[r, c];
        //    //    }
        //    //}
        //}
    }
}

