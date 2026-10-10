/*
Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng 

Tình huống thực tế: Một quầy đổi tiền tại sân bay cần ứng dụng tính toán nhanh số tiền khách hàng nhận 
được khi đổi từ Việt Nam Đồng (VND) sang các loại ngoại tệ phổ biến (USD, EUR, JPY, GBP) có tính phí dịch vụ. 
Kiến thức trọng tâm: Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế. 
Yêu cầu bài toán: 
• Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP. 
• Khai báo tỷ giá cố định (Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP = 32,100 VNĐ). 
• Nhập vào số tiền VNĐ cần đổi (decimal) và chọn loại ngoại tệ muốn đổi. 
• Phí dịch vụ quy đổi là 0.5% trên tổng số tiền VNĐ. 
• Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng. 
• In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ.
*/
using System.Globalization;

class Bai3
{   
    enum ExchangeRate
    {
        USD = 25_400,
        EUR = 27_200,
        JPG = 165,
        GBP = 32_100
    }
    public static void Run()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();

        Console.WriteLine("Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng");
        Console.WriteLine();
        Console.WriteLine($"1 {ExchangeRate.USD} = {(int)ExchangeRate.USD:N0} VND");
        Console.WriteLine($"1 {ExchangeRate.EUR} = {(int)ExchangeRate.EUR:N0} VND");
        Console.WriteLine($"1 {ExchangeRate.JPG} = {(int)ExchangeRate.JPG:N0} VND");
        Console.WriteLine($"1 {ExchangeRate.GBP} = {(int)ExchangeRate.GBP:N0} VND");
        Console.WriteLine();
        Console.Write("Nhập số tiền muốn đổi: "); decimal amountVND = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Chọn loại ngoại tệ muốn đổi (USD/EUR/JPG/GBP): "); string currencyType = Console.ReadLine();

        decimal amountAfterFee = amountVND * 0.95m;
        decimal finalReceive; 


        switch (currencyType)
        {
            case "USD":
                finalReceive = amountAfterFee / (int)ExchangeRate.USD;
                break;
            case "EUR":
                finalReceive = amountAfterFee / (int)ExchangeRate.EUR;
                break;
            case "JPG":
                finalReceive = amountAfterFee / (int)ExchangeRate.JPG;
                break;
            case "GBP":
                finalReceive = amountAfterFee / (int)ExchangeRate.GBP;
                break;
            default:
                finalReceive = 0;
                Console.WriteLine("Không hợp lệ - Shutdown");
                break;
        }

        Console.WriteLine($"Phí dịch vụ (5%): {amountVND*0.05m:N0}");
        Console.WriteLine($"Số tiền VND được đổi: {amountAfterFee:N0}");
        Console.WriteLine($"Số tiền {currencyType} nhận được: {finalReceive:N2} {currencyType}");
    }
}
