# 검사 시뮬레이션 이미지 처리 파트 

**프로그램 작업소스**
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
~~취소선테스트~~



> 마크업 테스트
> > 마마크업 테테스트
> > > 마마마크업 테스트
![Image](https://github.com/user-attachments/assets/b8c6aaa1-b146-4dce-83d6-6d45e8eba066)

