# 검사 시뮬레이션 이미지 처리 파트 

참고 소스
```cs
using OpenCvSharp;

namespace OpenCVProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // 이미지 크기조정
            Mat src = new Mat("Ahhh.jpg");
            Mat dst = new Mat();

            Cv2.Resize(src, dst, new Size(50, 50));

            Cv2.ImShow("src", src);
            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
        }
    }
}
```
