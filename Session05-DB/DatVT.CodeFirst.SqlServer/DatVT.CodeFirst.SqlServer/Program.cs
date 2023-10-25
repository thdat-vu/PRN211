namespace DatVT.CodeFirst.SqlServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new ProductContext())
            //{
            //    //db.Database.EnsureCreated(); // tạo database nếu nó chưa tồn tại
            //    //var prod = new Product() { Name = "Sting Dâu Đỏ", Description = "Nước Tăng Lực" };
            //    //db.Products.Add(prod);
            //    //db.Products.Add(new Product() { Name = "Lipovitan", Description = "Nước Tăng Lực" });
            //    //db.Products.Add(new Product() { Name = "Cà Phê muối", Description = "Cà phê" });
            //    //Console.WriteLine("Insert successfully.");
            //    //db.SaveChanges();


            //    

            //}
            //lấy data ra, dùng LinQ
            using (var db = new ProductContext())
            {
                var result = db.Products.Where(s => true).ToList(); //select *
                Console.WriteLine("all of product from db");
                result.ForEach(s => Console.WriteLine(s.Id + "|" + s.Name + "|" + s.Description));
            }
        }
    }
}