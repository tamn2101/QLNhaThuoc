namespace QLNhaThuoc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QLNhaThuoc.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QLNhaThuoc.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.KhuVucLuuTrus.AddOrUpdate(c => c.MaKhuVuc,
              new Models.KhuVucLuuTru { MaKhuVuc = 1, TenKhuVuc = @"Quầy" },
              new Models.KhuVucLuuTru { MaKhuVuc = 2, TenKhuVuc = @"kho" });


            context.Thuocs.AddOrUpdate(c => c.MaThuoc,
               new Models.Thuoc
               {
                   MaThuoc = 1,
                   TenThuoc = @"Nước súc miệng T-B Fresh Traphaco hỗ trợ sát trùng răng miệng, họng, thơm miệng (500ml)",
                   MaKhuVuc = 1,
                   GiaBan = 25000,
                   DonViTinh = @"Chai",
                   Hinh = @"Content/images/Thuoc/nuocsucmieng.png",
                   CongDung = "Nước Súc Miệng T-B Fresh 500Ml - Traphaco của Công ty Cổ phần Traphaco, thành phần chính acid boric, xylitol, natri clorid và natri fluorid, là thuốc dùng để sạch răng, miệng, họng giúp ngăn ngừa viêm họng, viêm lợi, chảy máu chân răng, sâu răng, các tinh dầu thơm mát thúc đẩy tuần hoàn lợi (nướu), khử mùi hôi của thuốc lá, thuốc lào, hành tỏi, các chất tanh."
               },
               new Models.Thuoc
               {
                   MaThuoc = 2,
                   TenThuoc = @"Viên uống Bamogin Thành Công giúp tăng cường tuần hoàn não(60 viên)",
                   MaKhuVuc = 1,
                   GiaBan = 160000,
                   DonViTinh = @"Chai",
                   Hinh = @"Content/images/Thuoc/Viên uống Bamogin.png",
                   CongDung = ""
               },
               new Models.Thuoc
               {
                   MaThuoc = 3,
                   TenThuoc = @"Thuốc Panadol Extra đỏ GSK giúp giảm đau, hạ sốt (15 vỉ x 12 viên)",
                   MaKhuVuc = 1,
                   GiaBan = 1500,
                   DonViTinh = @"Viên",
                   Hinh = @"Content/images/Thuoc/panadol.png",
               },
               new Models.Thuoc
               {
                   MaThuoc = 6,
                   TenThuoc = @"Thuốc Đại Tràng Hoàn P/H điều trị viêm đại tràng cấp và mãn tính (10 gói)",
                   MaKhuVuc = 1,
                   GiaBan = 40000,
                   DonViTinh = @"Hộp",
                   Hinh = "Content/images/Thuoc/DaiTrang.png"
               },
               new Models.Thuoc
               {
                   MaThuoc = 7,
                   TenThuoc = @"Thuốc Cebraton Traphaco phòng và điều trị suy giảm trí nhớ (5 vỉ x 10 viên)",
                   MaKhuVuc = 1,
                   GiaBan = 160000,
                   DonViTinh = @"Hộp",
                   Hinh = "Content/images/Thuoc/cebraton.png"
               },
               new Models.Thuoc
               {
                   MaThuoc = 8,
                   TenThuoc = @"Thuốc Enterogermina Sanofi điều trị rối loạn hệ vi khuẩn đường ruột (20 ống x 5ml)",
                   MaKhuVuc = 1,
                   GiaBan = 280000,
                   DonViTinh = @"Hộp",
                   Hinh = @"Content/images/Thuoc/enterogermina.png"
               },
               new Models.Thuoc
               {
                   MaThuoc = 9,
                   TenThuoc = @"Thuốc Hà Thủ Ô Traphaco điều trị đau lưng, di mộng tinh, thiếu máu (100 viên)",
                   MaKhuVuc = 1,
                   GiaBan = 45000,
                   DonViTinh = @"Hộp",
                   Hinh = @"Content/images/Thuoc/hathuo.png",
                   CongDung = " Hà thủ ô Traphaco của công ty cổ phần công nghệ cao Traphaco, thành phần chính là cao đặc rễ Hà thủ ô đỏ, là thuốc dùng để điều trị đau lưng, mỏi gối, di mộng tinh; râu tóc bạc sớm; hỗ trợ điều trị thiếu máu, chóng mặt, ù tai.Hà thủ ô Traphaco được bào chế ở dạng viên nén bao đường, mỗi viên nén bao đường 300 mg (tương đương 1, 5 g rễ Hà thủ ô đỏ)."
               },
               new Models.Thuoc
               {
                   MaThuoc = 10,
                   TenThuoc = "Viên nén nhai OH NO Việt Phúc hỗ trợ bỏ hút thuốc lá (1 lọ x 12 viên)",
                   MaKhuVuc = 1,
                   GiaBan = 36000,
                   DonViTinh = "Hộp",
                   Hinh = "Content/images/Thuoc/ohno.png"
               }

               );
            context.ThucPhamChucNangs.AddOrUpdate(c => c.MaThucPham,
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 1,
                 TenThucPham = @"Viên uống Sâm Nhung Bổ Thận NV Dolexpharm giúp tráng dương, mạnh gân cốt (30 viên)",
                 MaKhuVuc = 1,
                 GiaBan = 113000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/samnhung.png",
                 CongDung = @"Sâm Nhung Bổ Thận NV hỗ trợ bổ thận, tăng cường khả năng sinh lý, hỗ trợ tăng cường sinh lực, làm chậm quá trình mãn dục nam.",
                 XuatXu = @"Việt Nam"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 2,
                 TenThucPham = @"Sữa bột Nestlé Nutren Junior hỗ trợ hệ tiêu hóa giúp trẻ hấp thu dinh dưỡng (850g)",
                 MaKhuVuc = 1,
                 GiaBan = 600000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/Nutren.png",
                 CongDung = @"Nutren Junior là sản phẩm dinh dưỡng chuyên biệt từ Nestle Thụy Sĩ với nguồn sữa tinh khiết chuẩn Châu Âu chuẩn vị con thích, giàu năng lượng cùng lợi khuẩn và chất xơ giúp hỗ trợ hệ tiêu hóa giúp trẻ hấp thu tốt các dưỡng chất để bắt kịp đà tăng trưởng và phát triển..",
                 XuatXu = @"Thụy Sĩ"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 3,
                 TenThucPham = @"Viên uống Queenmax Naga Extra Vesta bổ sung collagen cho da (30 viên)",
                 MaKhuVuc = 1,
                 GiaBan = 125000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/Queenmax.png",
                 CongDung = @"Viên uống đẹp da Queenmax Naga Extra bổ sung collagen, một số vitamin và khoáng chất giúp da săn chắc, tươi sáng, mịn màng từ bên trong.",
                 XuatXu = @"Việt Nam"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 4,
                 TenThucPham = @"Viên uống Vit Hair Men Galien hỗ trợ ngăn rụng tóc (60 viên)",
                 MaKhuVuc = 1,
                 GiaBan = 490000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/Vit.png",
                 CongDung = @"Viên uống Vit Hair Men của Galien - Pháp, chứa Saw Palmetto và Nettles leaf giúp cân bằng lượng DHT, làm thông thoáng nang tóc để nang tóc hấp thu dưỡng chất dễ dàng. Đồng thời bổ sung thêm các dưỡng chất thiết yếu cho tóc.",
                 XuatXu = @"Pháp"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 5,
                 TenThucPham = @"Nước uống Collagen Jpanwell Hana Colla Q10 chống oxi hóa cho cơ thể (10 chai x 50ml)",
                 MaKhuVuc = 1,
                 GiaBan = 970000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/Collagen.png",
                 CongDung = @" Hana Colla Q10 bổ sung Collagen và các chất chống oxy hóa cho cơ thể; hỗ trợ hạn chế quá trình oxy hóa da, tăng độ ẩm, độ đàn hồi cho da; giúp đẹp da. Thích hợp sử dụng cho người trưởng thành có nhu cầu làm đẹp da.",
                 XuatXu = @"Nhật Bản"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 6,
                 TenThucPham = @"Nước uống Royal Placenta Jpanwell làm đẹp da, sáng da (720ml)",
                 MaKhuVuc = 1,
                 GiaBan = 2850000,
                 DonViTinh = @"Chai",
                 Hinh = @"Content/images/ThucPhamChucNang/Royal.png",
                 CongDung = "Nước uống làm đẹp Royal Placenta Jpanwell giúp da trắng sáng mịn màng, mờ nám tàn nhang, hạn chế quá trình lão hóa, giảm nếp nhăn, cải thiện sức đề kháng, điều hòa nội tiết tố trong cơ thể.",
                 XuatXu = @"Nhật Bản"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 7,
                 TenThucPham = @"Viên ngừa mụn An Bảo Nam Dược sạch mụn, chống thâm, mở sẹo, ngăn ngừa mụn tái phát (30 viên)",
                 MaKhuVuc = 1,
                 GiaBan = 58000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/An.png",
                 CongDung = "An Bảo hỗ trợ thanh nhiệt giải độc, mát gan, tiêu viêm, giảm các triệu chứng mụn trứng cá, mụn nhọt, mẩn ngứa. Hỗ trợ giảm vết sẹo, vết thâm trên da do mụn, giảm nguy cơ xuất hiện mụn.",
                 XuatXu = @"Việt Nam"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 8,
                 TenThucPham = @"Viên uống Onagre Cevrai hỗ trợ làm giảm triệu chứng tiền kinh nguyệt, tiền mãn kinh và mãn kinh (60 viên)",
                 MaKhuVuc = 1,
                 GiaBan = 505000,
                 DonViTinh = @"Hộp",
                 Hinh = @"Content/images/ThucPhamChucNang/Onagre.png",
                 CongDung = "Onagre cung cấp các acid không no thực vật và các vitamin E giúp giảm nguy cơ lão hóa của tế bào, duy trì độ ẩm và căng da.Hỗ trợ giảm các triệu chứng của hội chứng tiền kinh nguyệt, tiền mãn kinh và mãn kinh.",
                 XuatXu = @"Pháp"
             },
             new Models.ThucPhamChucNang
             {
                 MaThucPham = 9,
                 TenThucPham = @"Siro Healthy New Kids hỗ trợ kích thích tiêu hóa, giúp ăn ngon (120ml)",
                 MaKhuVuc = 1,
                 GiaBan = 81000,
                 DonViTinh = @"Chai",
                 Hinh = @"Content/images/ThucPhamChucNang/Siro.png",
                 CongDung = " Siro Healthy New được chiết xuất dựa trên các thành phần acid amin, các vitamin và khoáng chất thiết yếu giúp trẻ ăn ngon miệng, hấp thụ tốt, tăng sức đề kháng và phát triển toàn diện.",
                 XuatXu = @"Việt Nam"
             }
             );

            context.ThietBiYTes.AddOrUpdate(c => c.MaThietBi,
            new Models.ThietBiYTe
            {
                MaThietBi = 0001,
                TenThietBi = @"Que thử thai nhanh HCG Allisa Pregnancy Test Kit Traphaco",
                MaKhuVuc = 1,
                GiaBan = 15000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/HCG.png",
                CongDung = @"Que thử thai nhanh HCG Allisa được sử dụng để định tính hormone HCG trong nước tiểu người, giúp phát hiện sớm thai kỳ (7 - 10 ngày sau khi thụ thai).",
                XuatXu = @"Việt Nam"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0002,
                TenThietBi = @"Máy đo đường huyết tự động MediUSA GM3300 hỗ trợ kiểm soát đường huyết",
                MaKhuVuc = 1,
                GiaBan = 1139000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/MediUSA.png",
                CongDung = @" Máy đo đường huyết MediUSA GM3300 được thiết kế dựa trên nhu cầu kiểm tra đường huyết thường xuyên của tất cả mọi người. Sản phẩm kiểm soát đường huyết tự động mã hóa, kích cỡ mẫu máu 0.7ul, đo nhanh trong 6 giây, kết quả đo trung bình của 7 ngày, bộ nhớ 250 kết quả và thiết kế gọn nhẹ. ",
                XuatXu = @"Hoa Kỳ"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0003,
                TenThietBi = @"Nhiệt kế hồng ngoại MediUSA Infrared Thermometer TP-336N New hỗ trợ đo nhiệt độ cơ thể",
                MaKhuVuc = 1,
                GiaBan = 650000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/Thermometer.png",
                CongDung = @"Nhiệt kế hồng ngoại MediUSA TP-336N thích hợp đo thân nhiệt trẻ em và người lớn. Thiết bị đo không chạm, cho kết quả nhanh trong 3 giây, kích thước nhỏ gọn tiện lợi mang theo khi di chuyển.",
                XuatXu = @"Mỹ"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0004,
                TenThietBi = @"Máy đo huyết áp tự động Microlife B3 Basic hỗ trợ đo huyết áp",
                MaKhuVuc = 1,
                GiaBan = 1350000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/Microlife.png",
                CongDung = @"Máy đo huyết áp bắp tay tự động Microlife B3 Basic là sản phẩm thế hệ mới của thương hiệu Microlife đến từ Thụy Sĩ, dùng để đo huyết áp và nhịp tim. Sản phẩm ứng dụng công nghệ MAM hiện đại, thông minh mang lại cho người dùng trải nghiệm an toàn, nhanh chóng và chính xác.",
                XuatXu = @"Thụy Sĩ"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0005,
                TenThietBi = @"Máy xông khí dung Microlife NEB200 hỗ trợ các bệnh viêm mũi, viêm xoang",
                MaKhuVuc = 1,
                GiaBan = 1050000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/NEB200 .png",
                CongDung = @"Máy xông khí dung Microlife NEB200 có các cải tiến về mặt công nghệ giúp người sử dụng dễ dàng hơn trong quá trình phòng và điều trị bệnh liên quan đến đường hô hấp. Sản phẩm được thiết kế nhỏ gọn, chất liệu cao cấp, dễ dàng vận hành và sử dụng, NEB200 đang dần trở thành giải pháp tối ưu trong quá trình phòng và điều trị bệnh.",
                XuatXu = @"Thụy Sĩ"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0006,
                TenThietBi = @"Tinh dầu xoa bóp dược liệu Nhất Phong giảm các cơn đau nhức xương khớp, mỏi cơ bắp, làm ấm cơ thể (50ml)",
                MaKhuVuc = 1,
                GiaBan = 195000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/NhatPhong.png",
                CongDung = @"Tinh dầu xoa bóp dược liệu Nhất Phong với thành phần từ các loại tinh dầu thiên nhiên ngâm kèm thảo mộc, giúp giảm các cơn đau nhức xương khớp, mỏi cơ bắp, làm ấm cơ thể hiệu quả.",
                XuatXu = @"Việt Nam"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0007,
                TenThietBi = @"Khẩu trang y tế Naturecare 3 lớp hỗ trợ lọc không khí (50 cái)",
                MaKhuVuc = 1,
                GiaBan = 40000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/KhauTrang.png",
                CongDung = @"Khẩu trang y tế NatureCare 3 lớp có thiết kế ôm khít khuôn mặt với cấu tạo 3 lớp bao gồm: Vải không dệt, lớp lọc kháng khuẩn, nẹp mũi, dây đeo, giúp lọc không khí và chống giọt bắn hiệu quả.",
                XuatXu = @"Việt Nam"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0008,
                TenThietBi = @"Khẩu trang 4D Kids Niva ngăn vi khuẩn, không gây dị ứng da (25 cái)",
                MaKhuVuc = 1,
                GiaBan = 45000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/Kids.png",
                CongDung = @"Khẩu trang Niva 4D Kids 25 cái với thiết kế lớp vải lọc khí không thấm nước, không gây dị ứng da, thanh tựa mũi dễ định hình, giúp cố định khẩu trang và tạo độ kín, ôm trọn khuôn mặt. Sản phẩm khẩu trang trẻ em Niva 4D giúp ngăn khói, bụi mịn, giọt bắn, vi khuẩn xâm nhập, phòng chống các dịch bệnh nguy hiểm lây qua đường hô hấp.",
                XuatXu = @"Việt Nam"
            },
            new Models.ThietBiYTe
            {
                MaThietBi = 0009,
                TenThietBi = @"Băng keo cá nhân vải Plaid Elastic Fabric Plaster Young Chemical Vina (60mm x 19mm - 100 miếng)",
                MaKhuVuc = 1,
                GiaBan = 113000,
                DonViTinh = @"Hộp",
                Hinh = @"Content/images/ThietBiYTe/Plaid .png",
                CongDung = @"Băng keo cá nhân vải Plaid Elastic Fabric dùng để bảo vệ vết thương hở nhỏ, vết cắt, vết thương bị trầy xước, ....",
                XuatXu = @"Hàn Quốc"
            }
            );


            context.DuocMyPhams.AddOrUpdate(c => c.MaDMP,
           new Models.DuocMyPham
           {
               MaDMP = 0001,
               TenDMP = @"Kem dưỡng ẩm Vaseline Pure OPC hương dâu hỗ trợ làm mềm da, phòng khô nứt môi (10g)",
               MaKhuVuc = 1,
               GiaBan = 22000,
               DonViTinh = @"Tuýp",
               Hinh = @"Content/images/DuocMyPham/Vaseline .png",
               CongDung = @"Tuýp dưỡng ẩm Vaseline Pure Hương Dâu có công dụng dưỡng và phòng nứt môi, khô môi, làm mềm lớp sừng, nứt da bàn chân, bàn tay. Cho bạn một làn da mền mại và căng mịn. Sản phẩm không lẫn tạp chất nên rất an toàn khi sử dụng. ",
               XuatXu = @"Việt Nam"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0002,
               TenDMP = @"Kem dưỡng môi La Roche-Posay Cicaplast Levres hỗ trợ giảm khô môi, nứt nẻ (7,5ml)",
               MaKhuVuc = 1,
               GiaBan = 215000,
               DonViTinh = @"Hộp",
               Hinh = @"Content/images/DuocMyPham/Roche-Posay.png",
               CongDung = @"Kem dưỡng môi La Roche-Posay Cicaplast Levres cung cấp độ ẩm cần thiết giúp làm dịu đôi môi tức thì, giảm tình trạng môi khô môi, nứt nẻ và kích ứng.",
               XuatXu = @"Pháp"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0003,
               TenDMP = @"Kem bôi dịu da cho bé Kutieskin hỗ trợ giảm ngứa nhanh, mẩn đỏ, tái tạo da (30g)",
               MaKhuVuc = 1,
               GiaBan = 96000,
               DonViTinh = @"Hộp",
               Hinh = @"Content/images/DuocMyPham/Kutieskin.png",
               CongDung = @"Kem bôi dịu da cho bé Kutieskin giúp chống viêm, kháng khuẩn, giảm ngứa, dịu mẩn đỏ, dưỡng ẩm, tạo màng bảo vệ, tái tạo da, ngăn ngừa thâm sẹo. Kem bôi dịu da cho bé Kutieskin với các thành phần thảo dược kháng viêm, giảm ngứa tự nhiên tốt nhất cho da bé, được kiểm định chất lượng theo tiêu chuẩn khắt khe của châu Âu, chứng nhận an toàn bởi Ecocert là giải pháp thiên nhiên, an toàn giúp giảm viêm ngứa, bảo vệ nâng niu làn da bé và ngăn ngừa không để lại vết sẹo thâm trên da bé.",
               XuatXu = @"Việt Nam"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0004,
               TenDMP = @"Kem bôi Dizigone Baby dưỡng ẩm dịu mẩn ngứa, hăm da em bé (30g)",
               MaKhuVuc = 1,
               GiaBan = 180000,
               DonViTinh = @"Hộp",
               Hinh = @"Content/images/DuocMyPham/Dizigone.png",
               CongDung = @"Kem bôi dịu da cho bé Dizigone Baby 30g là kem bôi làm dịu da mẫn ngứa, hăm da, giúp phòng ngừa và xử lý các tổn thương da thường gặp ở trẻ sơ sinh và trẻ nhỏ. Dizigone Baby chứa bảng thành phần lành tính, an toàn, mang đến giải pháp chăm sóc hiệu quả cho làn da mỏng manh, nhạy cảm của bé.",
               XuatXu = @"Việt Nam"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0005,
               TenDMP = @"Lăn khử mùi EtiaXil Detranspirant Aisselles Peaux Sensibles đặc trị cho da nhạy cảm (15ml)",
               MaKhuVuc = 1,
               GiaBan = 272000,
               DonViTinh = @"Hộp",
               Hinh = @"Content/images/DuocMyPham/EtiaXil.png",
               CongDung = @" Lăn khử mùi đặc trị EtiaXil Detranspirant Aisselles Peaux Sensibles dành cho da nhạy cảm là dòng sản phẩm khử mùi nổi tiếng của thương hiệu EtiaXil xuất xứ từ Pháp, giúp đặc trị khử mùi hôi cho vùng da dưới cánh tay lên đến 72 giờ, đồng thời ngăn tiết mồ hôi và giữ cho vùng da nhạy cảm luôn khô thoáng. Công thức sản phẩm đặc biệt không màu, không mùi, không bết dính, không gây ố vàng và thâm nách.",
               XuatXu = @"Pháp"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0006,
               TenDMP = @"Dầu gội thảo dược La Beauty dưỡng tóc suôn mượt, phục hồi tóc chuyên sâu (250ml)",
               MaKhuVuc = 1,
               GiaBan = 115000,
               DonViTinh = @"Hộp",
               Hinh = @"Content/images/DuocMyPham/Beauty.png",
               CongDung = @"Dầu gội thảo dược La Beauty 250ml là sản phẩm kết hợp các dưỡng chất tốt lành từ thiên nhiên để nuôi dưỡng da dầu và tóc phát triển khỏe mạnh suôn mượt.",
               XuatXu = @"Việt Nam"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0007,
               TenDMP = @"Gel Qderma hỗ trợ làm phẳng, mềm và mờ tất cả các loại sẹo (20g)",
               MaKhuVuc = 1,
               GiaBan = 275000,
               DonViTinh = @"Tuýp",
               Hinh = @"Content/images/DuocMyPham/Qderma .png",
               CongDung = @"Gel trị sẹo QDerma với thành phần chính Cyclopentasiloxane có khả năng khả năng bảo vệ da, giữ độ ẩm cho da, giúp bình thường hóa sự tổng hợp collagen. Gel trị sẹo QDerma là sản phẩm bôi sẹo cao cấp được nhập khẩu từ Ý giúp làm phẳng, mềm và mờ tất cả các loại sẹo do mụn, vết phỏng, chấn thương và phẫu thuật gây ra.",
               XuatXu = @"Ý"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0008,
               TenDMP = @"Serum Rebirth Cellular B Plavenom Placenta & Bee Venom dưỡng ẩm, se khít lỗ chân lông (10ml)",
               MaKhuVuc = 1,
               GiaBan = 230000,
               DonViTinh = @"Chai",
               Hinh = @"Content/images/DuocMyPham/Serum.png",
               CongDung = @" Serum Rebirth Cellular B Plavenom giúp dưỡng ẩm, se khít lỗ chân lông, giảm dần nếp nhăn trên da, ngăn ngừa lão hóa da và giúp tái tạo làn da, giúp da săn chắc và căng mịn.",
               XuatXu = @"Úc
"
           },
           new Models.DuocMyPham
           {
               MaDMP = 0009,
               TenDMP = @"Mặt nạ Megrhythm Kao xông hơi mắt không hương hỗ trợ thúc đẩy lưu thông máu (5 miếng)",
               MaKhuVuc = 1,
               GiaBan = 112000,
               DonViTinh = @"Hộp",
               Hinh = @"Content/images/DuocMyPham/Megrhythm.png",
               CongDung = @"Mặt nạ xông hơi mắt MegRhythm không hương là sản phẩm chăm sóc vùng da mắt đến từ thương hiệu MegRhythm thuộc tập đoàn Kao nổi tiếng của Nhật Bản. Sản phẩm là giải pháp đơn giản và tiện lợi, kết hợp giữa hơi ấm dễ chịu 40 độ C và mùi hương dịu nhẹ từ tinh dầu thiên nhiên, giúp làm dịu và tan biến đi sự mệt mỏi cho vùng da quanh mắt, đồng thời hỗ trợ thúc đẩy lưu thông mạch máu để giảm quầng thâm quanh mắt, mang lại cho bạn những giây phút thư giãn tuyệt vời và một đôi mắt tươi tỉnh hơn sau khi sử dụng.",
               XuatXu = @"Nhật Bản"
           }
           );
        }
    }
}
