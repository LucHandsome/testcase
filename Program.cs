namespace Bai_105
{
    internal class Program
    {
        static void Nhap(out int n)
        {
            while (true)
            {
                Console.Write("Mời nhập số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
                if (n > 10 && n < 99)
                    break;
                Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại: ");
            }
        }
        static void DocSoNguyen(int n)
        {
            int donvi, chuc;
            donvi = n % 10;
            chuc = n / 10;

            if (chuc == 1) Console.Write(" Mười ");
            if (chuc == 2) Console.Write(" Hai ");
            if (chuc == 3) Console.Write(" Ba ");
            if (chuc == 4) Console.Write(" Bốn ");
            if (chuc == 5) Console.Write(" Năm ");
            if (chuc == 6) Console.Write(" Sáu ");
            if (chuc == 7) Console.Write(" Bảy ");
            if (chuc == 8) Console.Write(" Tám ");
            if (chuc == 9) Console.Write(" Chín ");

            switch (donvi)
            {
                case 1: Console.Write(" Mươi Mốt "); break;
                case 2: Console.Write(" Mươi Hai "); break;
                case 3: Console.Write(" Mươi Ba "); break;
                case 4: Console.Write(" Mươi Bốn "); break;
                case 5: Console.Write(" Mươi Năm "); break;
                case 6: Console.Write(" Mươi Sáu "); break;
                case 7: Console.Write(" Mươi Bảy "); break;
                case 8: Console.Write(" Mươi Tám "); break;
                case 9: Console.Write(" Mươi Chín "); break;
            }
        }
        static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Nhap(out int n);
            DocSoNguyen(n);
        }
    }
}
