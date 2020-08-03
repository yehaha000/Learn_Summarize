using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFA0702
{
    class AudioPlayer
    {
        // 定义一个接口，接口名要以I开头
        public interface IAudioPlayer
        {
            void Play(int[] data);
        }
    }
}
