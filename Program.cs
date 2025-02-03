using OpenCvSharp;

namespace OpenCVProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 사진 출력
             Mat image = Cv2.ImRead("BeastEdit.png", ImreadModes.Grayscale);
             Cv2.ImShow("image", image);
             Cv2.WaitKey(0);
             Cv2.DestroyAllWindows();
             */
            /* 웹캠출력
            VideoCapture video = new VideoCapture(0);
            Mat frame = new Mat();

            while (Cv2.WaitKey(33) != 'q')
            {
                video.Read(frame);
                Cv2.ImShow("frame", frame);
            }

            frame.Dispose();
            video.Release();
            Cv2.DestroyAllWindows();
            */
            // 이미지 크기조정
            Mat src = new Mat("BeastEdit.png");
            Mat dst = new Mat();

            Cv2.Resize(src, dst, new Size(50, 50));

            Cv2.ImShow("src", src);
            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
        }
    }
}