using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHotelApp.Infrastructure.Data.Model;

namespace MyHotelApp.Infrastructure.Data.Profiles
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room
                {
                    Id = 1,
                    ImgUrl = "https://images.unsplash.com/photo-1611892440504-42a792e24d32?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aG90ZWwlMjByb29tfGVufDB8fDB8fHww",
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 2,
                    ImgUrl = "https://t3.ftcdn.net/jpg/02/71/08/28/360_F_271082810_CtbTjpnOU3vx43ngAKqpCPUBx25udBrg.jpg",
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 3,
                    ImgUrl = "https://images.unsplash.com/photo-1578683010236-d716f9a3f461?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 4,
                    ImgUrl = "https://images.unsplash.com/photo-1631049035182-249067d7618e?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 5,
                    ImgUrl = "https://images.unsplash.com/photo-1608198399988-341f712c3711?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 6,
                    ImgUrl = "https://t3.ftcdn.net/jpg/02/71/08/28/360_F_271082810_CtbTjpnOU3vx43ngAKqpCPUBx25udBrg.jpg",
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 7,
                    ImgUrl = "https://images.unsplash.com/photo-1608198399988-341f712c3711?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 8,
                    ImgUrl = "https://images.unsplash.com/photo-1592229505726-ca121723b8ef?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 9,
                    ImgUrl = "https://plus.unsplash.com/premium_photo-1661956080119-71234af803b3?q=80&w=2012&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 10,
                    ImgUrl = "https://images.unsplash.com/photo-1512918728675-ed5a9ecdebfd?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    FloorId = 1,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 11,
                    ImgUrl = "https://www.rd.com/wp-content/uploads/2017/09/28_starwoodhotels_Dreamy-Hotel-Rooms-With-Views-For-Days_starwoodhotels.jpg?resize=640%2C426",
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 12,
                    ImgUrl = "https://www.travelandleisure.com/thmb/BVXwxaCEyKbstCpScLm0tKPxuIE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/1-b76afaa92ebb4386b92ccd18395f5880.jpg",
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 13,
                    ImgUrl = "https://image-tc.galaxy.tf/wijpeg-803x266hfn7ecl37odjx1iys8/usat-terrace-garden-view-2-9ffe77_wide.jpg?crop=0%2C85%2C1620%2C911",
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 14,
                    ImgUrl = "https://images.squarespace-cdn.com/content/v1/52da9677e4b03d314575985a/29d0375b-d25e-4483-b3dc-b7f5666bded1/Amsterdam+Hotels+with+Best+Views+-+Anantara+Grand+Hotel+Krasnapolsky+Amsterdam.jpg",
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 15,
                    ImgUrl = "https://sauntonsands.co.uk/sites/default/files/styles/940x690/public/2023-06/Double%20sea%20facing%20room%202023%201.jpg?h=c6980913&itok=QGO2J_G6",
                    FloorId = 2,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 16,
                    ImgUrl = "https://www.travelrepublic.co.uk/blog///wp-content/uploads/2012/10/Jade-mountaibn.jpg",
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 17,
                    ImgUrl = "https://d2mo2a5fvrklap.cloudfront.net/app/uploads/sites/11/2022/07/13000012/oceanviewsrooms-hero-desktop-1.jpg",
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 18,
                    ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQK0sYqGA6P7ELOT0Q1xIr2mvHP81kBTFjhZg&usqp=CAU",
                    FloorId = 2,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 19,
                    ImgUrl = "https://www.niccolohotels.com/getmedia/cd170107-1f9c-4540-a549-fcfa8da310b8/NINCQ_N3_Deluxe_City_View_King-2_1000-560px.jpg?width=1000&height=560&ext=.jpg",
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 20,
                    ImgUrl = "https://static.travelclick.com/assets/hotel/108321/media/room/detail-image/455x400_enhanced.jpg",
                    FloorId = 2,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 21,
                    ImgUrl = "https://www.valleyviewcasino.com/wp-content/uploads/gallery_deluxe_2.jpg.webp",
                    FloorId = 2,
                    RoomTypeId = 2,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 22,
                    ImgUrl = "https://www.tripsavvy.com/thmb/YkOq94GddksqrDCnMfG8SyDWmSM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Pacific-Rooms-Post-Ranch-Inn-56a4e76a5f9b58b7d0d9d1bc.jpg",
                    FloorId = 2,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 23,
                    ImgUrl = "https://d2f304910ir8yu.cloudfront.net/wp-content/uploads/2023/01/04160614/Oceanview-Guestroom-King-1-The-Boca-Raton-Beach-Club-1920x1080-1.jpg",
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 24,
                    ImgUrl = "https://www.journeyera.com/wp-content/uploads/2023/09/Hotels_San_Francisco_Best_Views-91-1024x683.jpg",
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 25,
                    ImgUrl = "https://images.mirai.com/INFOROOMS/10110403/XLjhBErmnwSSih0RkUg7/XLjhBErmnwSSih0RkUg7_original.jpg",
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 26,
                    ImgUrl = "https://www.royallancaster.com/wp-content/uploads/2018/03/Royal-Suite-Cozy.jpg",
                    FloorId = 3,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 27,
                    ImgUrl = "https://image-tc.galaxy.tf/wijpeg-1ep2143ci3dsvirm90ud0wv8l/rockymountainphotoco-16-opt_standard.jpg?crop=107%2C0%2C1707%2C1280",
                    FloorId = 3,
                    RoomTypeId = 3,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 28,
                    ImgUrl = "https://static.travelclick.com/assets/hotel/108321/media/room/detail-image/664x386_adfvh_deluxe_room1_enhanced.png",
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 29,
                    ImgUrl = "https://www.travelandleisure.com/thmb/JIoqZXurmgjBU-aRjKthU7oKu8A=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/1-71d7208a004a48b7bc1617a7e77183ea.jpg",
                    FloorId = 3,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 30,
                    ImgUrl = "https://image-tc.galaxy.tf/wijpeg-5bf9r2ij6tztosz1vloj6bmzx/lp-06342_standard.jpg?crop=84%2C0%2C1333%2C1000",
                    FloorId = 3,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 31,
                    ImgUrl = "https://www.caesars.com/content/dam/flv/Room/Standard%20Room/Flamingo-Room/flv-flaming-room-2-queens-garden-view-1160px.jpeg.transform/slider-img/image.jpg",
                    FloorId = 3,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 32,
                    ImgUrl = "https://assets-global.website-files.com/656dadf7ca1efe1c3d4a2cfb/659583c546cf30603d4725c8_Frame%2090%20(1).png",
                    FloorId = 3,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 33,
                    ImgUrl = "https://images.squarespace-cdn.com/content/v1/52da9677e4b03d314575985a/9615bcfc-572f-499a-b657-eaf4bd43aa01/Barcelona+Hotels+with+Best+Views+-+Condes+de+Barcelona.jpg",
                    FloorId = 3,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                }, new Room
                {
                    Id = 34,
                    ImgUrl = "https://symphony.cdn.tambourine.com/_pacifica-hotels/media/marina-del-rey-rooms-grand-one-bedroom-marina-suite-02-5f03993dbbf97.jpg",
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 35,
                    ImgUrl = "https://www.jetsetter.com//uploads/sites/7/2018/04/YgAlwLap-1-1380x690.jpeg",
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 36,
                    ImgUrl = "https://www.treehousehotels.com/sites/default/files/styles/card_3_up_xl/public/2019-10/Treehouse-London-2019-%2825%29.jpg?itok=sOi8nz8P",
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 37,
                    ImgUrl = "https://s7d1.scene7.com/is/image/marriotts7prod/rz-melrz-king-room-with-bay-views-38149:Classic-Hor?wid=1215&fit=constrain",
                    FloorId = 4,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 38,
                    ImgUrl = "https://image-tc.galaxy.tf/wijpeg-15mjlf1rrmlwe31v0c75ato6j/ocean-view-room-ccbh-small_wide.jpg?crop=0%2C113%2C1200%2C675",
                    FloorId = 4,
                    RoomTypeId = 3,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 39,
                    ImgUrl = "https://d3tm25asqtyj7x.cloudfront.net/hotel/Twin-Room/_1536x1024_crop_center-center_61_line/Twin-Room-8001.jpg",
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 40,
                    ImgUrl = "https://www.lakedistricthotels.net/explore/wp-content/uploads/2024/01/Lake-View-Feature-2024-6.jpg",
                    FloorId = 4,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 41,
                    ImgUrl = "https://assets.langhamhotels.com/is/image/langhamhotelsstage/tlbos-rooms-parkview-club:Medium?wid=675&hei=380",
                    FloorId = 4,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 42,
                    ImgUrl = "https://image-tc.galaxy.tf/wijpeg-ajs2zf31tbtrqj8agj6w4xhta/alextphoto-com-clinton-hotel-room-346-1-highres_wide.jpg?crop=0%2C100%2C1920%2C1080",
                    FloorId = 4,
                    RoomTypeId = 1,
                    ViewTypeId = 2,
                    Price = 200
                },
                new Room
                {
                    Id = 43,
                    ImgUrl = "https://cdn.dirigible.studio/wp-content/uploads/sites/84/2015/08/22115829/Edgewater_Rooms11447.jpg.webp",
                    FloorId = 4,
                    RoomTypeId = 2,
                    ViewTypeId = 1,
                    Price = 200
                },
                new Room
                {
                    Id = 44,
                    ImgUrl = "https://cdn.kimkim.com/files/a/images/e47400f530f231b194e51129b88e62121df3ce62/original-eaa5e83a80ea995bd2689936e89df8d1.jpg",
                    FloorId = 4,
                    RoomTypeId = 3,
                    ViewTypeId = 2,
                    Price = 200
                }
                );
        }
    }
}
