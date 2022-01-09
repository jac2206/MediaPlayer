using MediaPlayerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaPlayerDemo.Logic
{
    public class VideoLogic
    {

        public static IEnumerable<Video> ObtenerVideos(string nombreVideos)
        {
            if(nombreVideos == "theStrokes")
            {
                return TheStrokesVideos();
            }
            return TelerikVideos();
        }


        private static IEnumerable<Video> TelerikVideos()
        {
            List<Video> videos = new List<Video>();

            videos.Add(new Video()
            {
                title = "Build HIPAA-Compliant Healthcare Apps Fast",
                poster = "https://img.youtube.com/vi/_S63eCewxRg/1.jpg",
                source = "https://www.youtube.com/watch?v=dyvxivS5EcI"
            });
            videos.Add(new Video()
            {
                title = "ProgressNEXT 2018 Highlights",
                poster = "https://img.youtube.com/vi/DYsiJRmIQZw/1.jpg",
                source = "https://www.youtube.com/watch?v=Gp7tcOcSKAU"
            });
            videos.Add(new Video()
            {
                title = "Kendo UI Testimonial",
                poster = "https://img.youtube.com/vi/gNlya720gbk/1.jpg",
                source = "https://www.youtube.com/watch?v=itoKeywVNBI"
            });
            videos.Add(new Video()
            {
                title = "Introducing Test Studio DevEdition",
                poster = "https://img.youtube.com/vi/rLtTuFbuf1c/1.jpg",
                source = "https://www.youtube.com/watch?v=A2rmIx9rPG0"
            });
            videos.Add(new Video()
            {
                title = "Progress Application Server OpenEdge",
                poster = "https://i.ytimg.com/vi/CpHKm2NruYc/1.jpg",
                source = "https://www.youtube.com/watch?v=3Ce11N9udR4&list=PLC679RvCan2BJ9HCdUyZhnhHKActnrape"
            });
            return videos;
        }

        private static IEnumerable<Video> TheStrokesVideos()
        {
            List<Video> videos = new List<Video>();

            videos.Add(new Video()
            {
                title = "You Only Live Once",
                poster = "	https://i.ytimg.com/vi/pT68FS3YbQ4/hqdefault.jpg?s…AFwAcABBg==&rs=AOn4CLC5kbZSCb1-NpXbrltTQBBQcUWO0g",
                source = "https://www.youtube.com/watch?v=pT68FS3YbQ4"
            });
            videos.Add(new Video()
            {
                title = "Someday",
                poster = "https://i.ytimg.com/vi/knU9gRUWCno/hqdefault.jpg?s…AFwAcABBg==&rs=AOn4CLDwXCUaa5gTSpPDZuLxRZX05NGltA",
                source = "https://www.youtube.com/watch?v=knU9gRUWCno"
            });
            videos.Add(new Video()
            {
                title = "Under Cover of Darkness",
                poster = "https://i.ytimg.com/vi/_l09H-3zzgA/hqdefault.jpg?s…AFwAcABBg==&rs=AOn4CLBrkdi8Wni1biFARgH615fbL3ioFg",
                source = "https://www.youtube.com/watch?v=_l09H-3zzgA"
            });
            videos.Add(new Video()
            {
                title = "The Adults Are Talking",
                poster = "https://i.ytimg.com/vi/ewOPQZZn4SY/hq720.jpg?sqp=-…AFwAcABBg==&rs=AOn4CLAXMOsjxyRsdKON67dz4V6avLoXnQ",
                source = "https://www.youtube.com/watch?v=ewOPQZZn4SY"
            });
            videos.Add(new Video()
            {
                title = "Instant Crush",
                poster = "https://i.ytimg.com/vi/a5uQMwRMHcs/hqdefault.jpg?s…AFwAcABBg==&rs=AOn4CLCTI5GltkNjRvxB2UGwKVs83-PCOA",
                source = "https://www.youtube.com/watch?v=a5uQMwRMHcs"
            });
            return videos;
        }
    }
}