using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming_Data
{
    public partial class Form1 : Form
    {


        Model1 company = new Model1();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var store in company.Stores)
            {

                listBox1.Items.Add(store.StoreName);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            var store = company.Stores.Find(textBox1.Text);

            if (store != null)
            {


                store.Address = textBox2.Text;

                company.SaveChanges();

                textBox1.Text = textBox2.Text = "";

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Store store = new Store();


            var str = company.Stores.Find(textBox1.Text);

            if (str == null)
            {

                store.StoreName = textBox1.Text;
                store.Address = textBox2.Text;
                store.RespPerson = textBox3.Text;

                company.Stores.Add(store);
                company.SaveChanges();

                listBox1.Items.Add(store.StoreName);
                textBox1.Text = textBox2.Text = textBox3.Text = "";



            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string store = listBox1.Text;

            Store st = company.Stores.Find(store);



            listBox2.Items.Clear();


            foreach (Material m in st.Materials)
            {
                listBox2.Items.Add(m.Name);
            }









        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Material material = new Material();

            var mtr = company.Materials.Find(int.Parse(textBox4.Text));

            if (mtr == null)
            {

                material.Code = int.Parse(textBox4.Text);
                material.Name = textBox5.Text;
                material.MU = textBox6.Text;

                company.Materials.Add(material);
                company.SaveChanges();


                textBox4.Text = textBox5.Text = textBox6.Text = "";





            }

        }

        private void button4_Click(object sender, EventArgs e)
        {



            var material = company.Materials.Find(int.Parse(textBox4.Text));

            if (material != null)
            {


                material.Name = textBox5.Text;

                company.SaveChanges();

                textBox4.Text = textBox5.Text = "";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Supplier supplier = new Supplier();


            var spl = company.Suppliers.Find(textBox7.Text);



            if (spl == null)
            {

                supplier.Name = textBox7.Text;
                supplier.ID = int.Parse(textBox8.Text);
                supplier.Telephone = int.Parse(textBox9.Text);
                supplier.Fax = int.Parse(textBox10.Text);
                supplier.Mobile = int.Parse(textBox11.Text);
                supplier.Email = textBox12.Text;
                supplier.Website = textBox13.Text;

                company.Suppliers.Add(supplier);
                company.SaveChanges();


            }




        }

        private void button6_Click(object sender, EventArgs e)
        {


            var sup = company.Suppliers.Find(textBox7.Text);

            if (sup != null)
            {


                sup.ID = int.Parse(textBox8.Text);

                company.SaveChanges();

                textBox7.Text = textBox8.Text = "";

            }



        }

        private void button7_Click(object sender, EventArgs e)
        {

            Client client = new Client();

            var clt = company.Clients.Find(textBox7.Text);



            if (clt == null)
            {

                client.Name = textBox14.Text;
                client.Telephone = int.Parse(textBox15.Text);
                client.Fax = int.Parse(textBox16.Text);
                client.Mobile = int.Parse(textBox17.Text);
                client.Email = textBox18.Text;
                client.Website = textBox19.Text;

                company.Clients.Add(client);
                company.SaveChanges();

            }






        }

        private void button8_Click(object sender, EventArgs e)
        {


            var clt = company.Clients.Find(textBox14.Text);

            if (clt != null)
            {
                clt.Telephone = int.Parse(textBox15.Text);

                company.SaveChanges();

                textBox14.Text = textBox15.Text = "";

            }



        }

        private void button9_Click(object sender, EventArgs e)
        {

            SupplyPerm perm = new SupplyPerm();


            var per = company.SupplyPerms.Find(int.Parse(textBox20.Text));

            if (per == null)
            {

                perm.PermNum = int.Parse(textBox20.Text);
                perm.Storename = textBox21.Text;
                perm.PermDate = DateTime.Parse(textBox22.Text);

                perm.material = textBox23.Text;
                perm.quantity = int.Parse(textBox24.Text);
                perm.SupplierName = textBox25.Text;

                perm.ProdDate = DateTime.Parse(textBox26.Text);
                perm.expiry = DateTime.Parse(textBox27.Text);

                company.SupplyPerms.Add(perm);
                company.SaveChanges();




            }






        }

        private void button10_Click(object sender, EventArgs e)

        {
            var sp = company.SupplyPerms.Find(int.Parse(textBox20.Text));

            if (sp != null)
            {
                sp.Storename = textBox21.Text;

                company.SaveChanges();

                textBox20.Text = textBox21.Text = "";

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {

            Dismissal dismissal = new Dismissal();

            var d = company.Dismissals.Find(int.Parse(textBox28.Text));

            if (d == null)
            {

                dismissal.PermNum = int.Parse(textBox28.Text);
                dismissal.StoreName = textBox29.Text;
                dismissal.PermDate = DateTime.Parse(textBox30.Text);
                dismissal.material = textBox31.Text;
                dismissal.quantity = int.Parse(textBox32.Text);
                dismissal.SupplierName = textBox33.Text;

                company.Dismissals.Add(dismissal);
                company.SaveChanges();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            var d = company.Dismissals.Find(int.Parse(textBox28.Text));

            if (d != null)
            {
                d.StoreName = textBox29.Text;

                company.SaveChanges();

                textBox29.Text = textBox29.Text = "";

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {






        }

        private void button13_Click(object sender, EventArgs e)
        {

            string store = textBox34.Text;

            var str = company.Stores.Find(store);

            if (str != null)
            {

                listBox3.Items.Clear();
                listBox3.Items.Add(str.StoreName + "\t" + str.Address + "\t" + str.RespPerson);



            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox35.Text);

            var material = company.Materials.Find(c);

            if (material != null)
            {

                listBox3.Items.Clear();

                listBox3.Items.Add(material.Code + "\t" + material.Name + "\t" + material.MU);



            }



        }

       



        }
    }
