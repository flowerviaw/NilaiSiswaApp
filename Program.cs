string nama_siswa;
int nilai_siswa;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Masukkan nama:  ");
nama_siswa = Console.ReadLine();

Console.Write("Masukkan Nilai:  ");
nilai_siswa = int.Parse(Console.ReadLine());

if (nilai_siswa >= 75)
{
    Console.WriteLine("Status: Lulus");
}
else
{
    Console.WriteLine("Status: Tidak Lulus");
}