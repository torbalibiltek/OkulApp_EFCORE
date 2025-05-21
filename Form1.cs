using Microsoft.EntityFrameworkCore;
using OkulApp.Modeller;

namespace OkulApp
{
    public partial class Form1 : Form
    {
        //global scope
        OkulDataContext db = new();
        //global scope
        public Form1()
        {
            InitializeComponent();
        }

        void VerileriYukle()
        {
            //local scope
            db.Siniflar.Load(); //Veritaban�ndaki s�n�flar� y�kle

            //var liste = db.Siniflar.ToList(); //Veritaban�ndaki s�n�flar� listele
            var liste = db.Siniflar.Local.ToBindingList(); //Veritaban�ndaki s�n�flar� listele
            lbSiniflar.DataSource = liste; //Listeyi liste kutusuna ata
            lbSiniflar.DisplayMember = "SinifAdi"; //Liste kutusundaki g�sterilecek alan� belirle
            lbSiniflar.ValueMember = "Id"; //Liste kutusundaki de�eri belirle
            //local scope 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle(); //Form y�klendi�inde verileri y�kle
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            //1-Ekleme (Listede bir�ey se�ili de�ilse)
            //2-G�ncelleme (Listede se�ili s�n�f var ise)

            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Se�ili s�n�f� al

            if (secili == null)
            {
                DbSinif yeniSinif = new();
                yeniSinif.SinifAdi = txtSinif.Text; //S�n�f ad�n� al

                db.Siniflar.Add(yeniSinif); //S�n�f� ekle
                db.SaveChanges(); //De�i�iklikleri kaydet
                MessageBox.Show("Yeni s�n�f eklendi.");
            }
            else
            {
                secili.SinifAdi = txtSinif.Text; //Se�ili s�n�f�n ad�n� g�ncelle
                db.SaveChanges(); //De�i�iklikleri kaydet
                db.Siniflar.Local.ToBindingList().ResetBindings(); //Listeyi g�ncelle
                MessageBox.Show("S�n�f g�ncellendi.");
            }

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lbSiniflar.SelectedIndex = -1; //Liste kutusundaki se�ili ��eyi kald�r
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Se�ili s�n�f� al
        
            if(secili!=null)
            {
                var cevap = MessageBox.Show(secili.SinifAdi + " adl� s�n�f� silmek istedi�inze" +
                    "emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(cevap == DialogResult.Yes)
                {
                    db.Siniflar.Remove(secili);
                    db.SaveChanges();
                    MessageBox.Show("S�n�f silindi.");
                }
            }
        }
    }
}
