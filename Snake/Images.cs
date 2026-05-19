using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("empty.png");
        public readonly static ImageSource Body = LoadImage("snakeBody.png");
        public readonly static ImageSource Head = LoadImage("snakeFace.png");
        public readonly static ImageSource Food = LoadImage("food.png");
        public readonly static ImageSource DeadBody = LoadImage("deadSnakeBody.png");
        public readonly static ImageSource DeadHead = LoadImage("deadSnakeFace.png");

        private static ImageSource LoadImage(string filename)
        {
            return new BitmapImage(new Uri($"Assets/{filename}", UriKind.Relative));
        }
    }
}
