using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml;

internal class Program
{
    static int tinhTong(int a, int b)
    {
        return a + b;
    }
    static void Bai01()
    {
        Console.Write("Nhập số nguyên thứ nhất: ");

        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập số nguyên thứ hai: ");

        int b = int.Parse(Console.ReadLine()!);

        int c = tinhTong(a, b);

        Console.WriteLine($"Tổng {a} + {b} = {c}");
    }


    static bool KiemTraChan(int a)
    {
        if (a % 2 == 0)
        {
            return true;

        } else
        {
            return false;
        }
    }
    static void Bai02()
    {
        Console.Write("Nhập số nguyên n: ");

        int n = int.Parse(Console.ReadLine()!);

        if (KiemTraChan(n))
        {
            Console.WriteLine($"{n} là số chẵn");

        }
        else
        {
            Console.WriteLine($"{n} là số lẻ");
        }
    }


    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
    static void Bai03()
    {
        Console.Write("Nhập số nguyên thứ nhất: ");

        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập số nguyên thứ hai: ");

        int b = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập số nguyên thứ ba: ");

        int c = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Số lớn nhất trong ba số {a}, {b}, {c} là: {TimMax(a, b, c)}");
    }


    static long TinhGiaiThua(int n)
    {
        long giaiThua = 1;
        
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }

        return giaiThua;
    }
    static void Bai04()
    {
        Console.Write("Nhập số nguyên dương n:");

        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"{n}! = {TinhGiaiThua(n)}");
    }


    static string DaoNguocChuoi(string input)
    {
        char[] charArray = input.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
    static void Bai05()
    {
        Console.Write("Nhập chuỗi kí tự cần đảo: ");

        string input = Console.ReadLine()!;

        Console.WriteLine($"Chuỗi đảo ngược của {input} là {DaoNguocChuoi(input)}");
    }



    static bool KiemTraSoNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Bai06()
    {
        Console.Write("Nhập số nguyên n: ");

        int n = int.Parse(Console.ReadLine()!);

        if (KiemTraSoNguyenTo(n))
        {
            Console.WriteLine($"{n} là số nguyên tố");

        } else
        {
            Console.WriteLine($"{n} không phải là số nguyên tố");
        }
    }


    static void InFibonacci(int n)
    {

        int a = 0, b = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            int temp = a + b;

            a = b;

            b = temp;
        }
        Console.WriteLine();
    }
    static void Bai07()
    {
        Console.Write("Nhập số tự nhiên n: ");

        int n = int.Parse(Console.ReadLine()!);

        Console.Write($"{n} số Fibonnaci đầu tiên: ");

        InFibonacci(n);

    }


    static int DemNguyenAm(string s)
    {
        s.ToLower();

        int dem = 0;

        foreach (char c in s)
        {
            if (c == 97 || c == 101 || c == 105 || c == 111 || c == 117)
            {
                dem++;
            }
        }
        return dem;
    }
    static void Bai08()
    {
        Console.Write("Nhập chuỗi cần đếm (không dấu): ");

        string s = Console.ReadLine()!;

        Console.WriteLine($"Số chữ cái nguyên âm trong {s} = {DemNguyenAm(s)}");
    }


    static double TinhLuyThua(double x, int y)
    {
        double ans = 1d;

        for (int i = 1; i <= y; i++)
        {
            ans *= x;
        }
        return ans;
    }
    static void Bai09()
    {
        Console.Write("Nhập số nguyên thực x: ");

        double x = double.Parse(Console.ReadLine()!);

        Console.Write("Nhập số nguyên y: ");

        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"x ^ y = {TinhLuyThua(x, y)}");
    }


    static double TinhTrungBinh(int[] arr)
    {
        double tong = 0d;

        for (int i = 0; i < arr.Length; i++)
        {
            tong += arr[i];
        }
        double ans = tong / arr.Length;

        return ans;
    }
    static void Bai10()
    {
        Console.Write("Nhập số cột điểm cần tính: ");

        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Cột điểm thứ {i + 1}: ");

            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"Điểm trung bình = {TinhTrungBinh(arr)}");
    }


    static bool KiemTraDoiXung(string s)
    {
        for  (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    static void Bai11()
    {
        Console.Write("Nhập chuỗi cần kiểm tra đối xứng (không dấu): ");

        string s = Console.ReadLine()!;

        if (KiemTraDoiXung(s))
        {
            Console.WriteLine($"Chuỗi {s} có đối xứng");

        } else
        {
            Console.WriteLine($"Chuỗi {s} không có đối xứng");
        }
    }


    static double CelsiusToFahrenheit(double c)
    {
        return c * 1.8 + 32;
    }
    static void Bai12()
    {
        Console.Write("Nhập độ C: ");

        double c = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"{c} độ C = {CelsiusToFahrenheit(c)} độ F");
    }


    static int TimMin(int[] arr)
    {
        int ans = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < ans)
            {
                ans = arr[i];
            }
        }
        return ans;
    }
    static void Bai13()
    {
        Console.Write("Nhập số lượng phần tử trong mảng: ");

        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"phần tử thứ {i + 1}: ");

            arr[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"Phần tử nhỏ nhất trong mảng là: {TimMin(arr)}");
    }


    static int TongCacChuSo(int n)
    {
        int tong = 0;

        while (n > 0)
        {
            int du = n % 10;

            tong += du;

            n /= 10;
        }
        return tong;
    }
    static void Bai14()
    {
        Console.Write("Nhập số nguyên duơng n: ");

        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"tổng các chữ số trong {n}: {TongCacChuSo(n)}");
    }


    static void SapXepMang(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j ++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];

                    arr[i] = arr[j];

                    arr[j] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Bai15()
    {
        Console.Write("Nhập số lượng phần tử trong mảng: ");

        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"phần tử thứ {i + 1}: ");

            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Console.Write($"Phần tử trong mảng sau khi được sắp xếp: ");

        SapXepMang(arr);
    }


    static string xoaTrungLap(string s)
    {
        string ans = "";

        foreach (char c in s)
        {
            if (!ans.Contains(c))
            {
                ans += c;
            }
        }
        return ans;
    }
    static void Bai16()
    {
        Console.Write("Nhập chuỗi cần xóa kí tự trùng lặp: ");

        string s = Console.ReadLine()!;

        Console.WriteLine($"chuỗi {s} sau khi xóa ký tự trùng lặp: {xoaTrungLap(s)}");
    }


    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;

            b = a % b;

            a = temp;
        }
        return Math.Abs(a);
    }
    static void Bai17()
    {
        Console.Write("Nhập số thư nhất: ");

        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập số thứ hai: ");

        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là: {UCLN(a, b)}");
    }


    static string decimalToBinary(int n)
    {
        string ans = "";

        if (n == 0) return "0";

        while (n != 0)
        {
            int soChia = n / 2;

            int du = n % 2;

            ans += du;

            n = soChia;
        }
        string ketqua = new string(ans.Reverse().ToArray());

        return ketqua;
    }
    static void Bai18()
    {
        Console.Write("Nhập số thập phân cần chuyển sang nhị phân: ");

        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Nhị phân của {n} : {decimalToBinary(n)}");
    }
    


    static bool kiemTraNamNhuan(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
    static void Bai19()
    {
        Console.Write("Nhập năm cần kiểm tra: ");

        int nam = int.Parse(Console.ReadLine()!);

        if (kiemTraNamNhuan(nam))
        {
            Console.WriteLine($"Năm {nam} là năm nhuận");
        }
        else
        {
            Console.WriteLine($"Năm {nam} không phải là năm nhuận");
        }
    }


    static int demSoTu(string sentence)
    {
        string[] tu = sentence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        return tu.Length;
    }

    static void Bai20()
    {
        Console.Write("Nhập câu cần đến từ: ");

        string s = Console.ReadLine()!;

        Console.WriteLine($"Số từ trong câu {s}: {demSoTu(s)}");
    }
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;

        Console.OutputEncoding = Encoding.UTF8;

        //Bai01();

        //Bai02();

        //Bai03();

        //Bai04();

        //Bai05();

        //Bai06();

        //Bai07();

        //Bai08();

        //Bai09();

        //Bai10();

        //Bai11();

        //Bai12();

        //Bai13();

        //Bai14();

        //Bai15();

        //Bai16();

        //Bai17();

        //Bai18();

        //Bai19();

        //Bai20();

    }
}