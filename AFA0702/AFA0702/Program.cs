using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AFA0702.AudioPlayer;

namespace AFA0702
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 0x12, 0x2c, 0x34, 0xd3 };

            IAudioPlayer player = new XiaoMiPlayer();
            player.Play(data);
        }
    }
}
