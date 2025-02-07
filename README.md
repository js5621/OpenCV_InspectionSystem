# 제목 적는 기능(H1)
## H2
### H3
#### H4
##### H5
###### H6

아무 문장이나 작성해보면 이렇게 나옵니다.


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
