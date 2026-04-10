using System.ComponentModel.Design;

Banktransfer banktransfer = new Banktransfer();
Ewallet ewallet = new Ewallet();
Kartukredit kartukredit = new Kartukredit();

Console.WriteLine("---Simulasi Checkout---");
Console.WriteLine("Pilih metode:");
Console.WriteLine("1.Bank Transfer\n2. E-Wallet \n3. Kartukredit");
Console.Write("Pilihan anda (1/2/3): ");
string pilihan = Console.ReadLine();

switch (pilihan)
{
    case "1":
        banktransfer = new Banktransfer();
        banktransfer.Bayar(10000);
        break;
    case "2":
        ewallet = new Ewallet();
        ewallet.Bayar(100000);
        break;
    case "3":
        kartukredit = new Kartukredit();
        kartukredit.Bayar(10000);
        break; 
 
    

}

class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine($"Segera lakukan pembayaran sebesar Rp {jumlah}");
    }
}

class Banktransfer : MetodePembayaran
{
    public override void Bayar(int Jumlah)
    {
        Console.WriteLine($"Segera melakukan transfer sejumlah {Jumlah} ke nomor rekening 12345");
    }
}

class Ewallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Saldo terpotong sejumlah {jumlah}");
    }
}

class Kartukredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sejumlah{jumlah} berhasil dilakukan");
    }
}